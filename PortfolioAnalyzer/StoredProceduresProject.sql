CREATE PROCEDURE spGetPositions AS

WITH Tickers

AS
(SELECT DISTINCT Ticker FROM Transaction_Data)

SELECT	t.Ticker,	 
		Quantity = (SELECT SUM(Quantity) AS TotalShares FROM Transaction_Data WHERE Ticker = t.Ticker),
		Value = Quantity * 
						(SELECT [Close] AS MostRecentPrice 
							FROM Historical_Data
							WHERE [Date] = 
								(SELECT MAX([Date]) AS [Date] FROM Historical_Data WHERE Ticker = t.Ticker)
							AND Ticker = t.Ticker)

FROM Tickers t
JOIN Historical_Data hist ON hist.Ticker = t.Ticker
JOIN Net_Price net ON net.Historical_ID = hist.Historical_ID
JOIN  Transaction_Data tra ON tra.Transaction_ID = net.Transaction_ID

GO
-------------------------------------------------------------


CREATE PROCEDURE spGetTickers AS
SELECT DISTINCT Ticker FROM Transaction_Data
GO
-------------------------------------------------------------
CREATE PROCEDURE spGetLatestPrice
@Ticker varchar(10)
AS

BEGIN
	WITH MaxDate
	AS
	(
	SELECT [Date] = MAX([Date]) FROM Historical_Data WHERE Ticker = @Ticker
	)

	SELECT [Close] FROM Historical_Data WHERE Ticker = @Ticker AND [Date] = (SELECT [Date] FROM MaxDate)
END
GO
-------------------------------------------------------------

CREATE PROCEDURE spGetNumShares

@Ticker varchar(10),
@NumShares int OUTPUT

AS

SELECT SUM(Quantity) AS NumShares FROM Transaction_Data WHERE Ticker = @Ticker
-------------------------------------------------------------

CREATE PROCEDURE spGetBeta

@Chosen varchar(10),
@Ticker varchar(10),
@Beta FLOAT OUTPUT

AS

	DROP TABLE IF EXISTS #HedgeReturns
	DROP TABLE IF EXISTS #SpecReturns

	SELECT	[Date],
			[Daily TReturn] = ([Close]/LAG ([Close], 1) OVER (ORDER BY DATE )) - 1
	INTO #SpecReturns
	FROM Historical_Data
	WHERE Ticker = @Ticker
	GROUP BY [Date], [Close]

	SELECT	[Date],
			[Daily HReturn] = ([Close]/LAG ([Close], 1) OVER (ORDER BY DATE )) - 1 
	INTO #HedgeReturns
	FROM Historical_Data
	WHERE Ticker = @Chosen
	GROUP BY [Date], [Close]

	SELECT	[Beta] = ((SUM([Daily TReturn] * [Daily HReturn]) * COUNT(s.[Date])) 
					- (SUM([Daily TReturn]) * SUM([Daily HReturn])))
					/
					(((SUM([Daily HReturn]*[Daily HReturn])) * COUNT(s.[Date]))
					- (SUM([Daily HReturn]) * SUM([Daily HReturn])))
		FROM #SpecReturns s
		FULL JOIN #HedgeReturns h ON h.[Date] = s.[Date]