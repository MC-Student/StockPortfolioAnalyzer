using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PortfolioAnalyzer
{
    public partial class PortfolioAnalyzer : Form
    {
        private SqlConnection sqlCon;
        private DataSet dataSet;
        public PortfolioAnalyzer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CreateConnection())
            {
                dataSet = new DataSet();
                LoadPositions();
                GetTickers();
                SetICGrid();
            }
        }

        private Boolean CreateConnection()
        {
            try
            {
                string strServer = Environment.GetEnvironmentVariable("SQL_Server_Name", EnvironmentVariableTarget.User);
                string strDatabase = Environment.GetEnvironmentVariable("SQL_DB_Name", EnvironmentVariableTarget.User);

                string strConnect = $"Server={strServer};Database={strDatabase};Trusted_Connection=True;";
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + DateTime.Now.ToLongTimeString() + "  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void LoadPositions()
        {
            SqlCommand sqlCmd = new SqlCommand("spGetPositions", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dataSet, "Positions");
            P_Grid.AutoGenerateColumns = true;
            P_Grid.DataSource = dataSet.Tables["Positions"];
            P_Grid.Columns["Value"].DefaultCellStyle.Format = "c";
        }

        private void GetTickers()
        {
            SqlCommand sqlCmd = new SqlCommand("spGetTickers", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();
            DataTable List = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(List);

            foreach (DataRow Row in List.Rows)
            {
                comboBox.Items.Add(Row.ItemArray.GetValue(0).ToString());
            }

            comboBox.SelectedText = List.Rows[0].ItemArray.GetValue(0).ToString();
        }

        private void SetICGrid()
        {
            IC_Grid.ColumnCount = 3;
            IC_Grid.ColumnHeadersVisible = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Segoe UI Semibold", 13);
            IC_Grid.ColumnHeadersDefaultCellStyle = style;
            IC_Grid.Columns[0].Name = "Tickers";
            IC_Grid.Columns[1].Name = "Values";
            IC_Grid.Columns[2].Name = "PL";
        }

        private void ComboBoxChange(object sender, EventArgs e)
        {
            string ticker = comboBox.Text;
            string price = GetLatestPrice(ticker);
            InputPrice.Text = price;
        }

        private void InputPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void InputPriceEnter(object sender, KeyEventArgs e)
        {
            IC_Grid.Rows.Clear();

            if (e.KeyCode == Keys.Enter)
            {
                string ChosenTicker = comboBox.Text;

                Double NewPrice = Double.Parse(InputPrice.Text);

                Double LatestPrice = Double.Parse(GetLatestPrice(ChosenTicker));

                Double DeltaPrice = NewPrice - LatestPrice;

                Double PercentChange = DeltaPrice / LatestPrice;

                foreach (String Ticker in comboBox.Items)
                {
                    Double Beta = Double.Parse(GetBeta(ChosenTicker, Ticker));

                    Double PriceChange = PercentChange * Beta;

                    Double LatestTickerPrice = Double.Parse(GetLatestPrice(Ticker));

                    Double ExpectedPrice = (1 + PriceChange) * LatestTickerPrice;

                    Double SharePL = ExpectedPrice - LatestTickerPrice;

                    int NumShares = GetNumShares(Ticker);

                    Double TotalPL = NumShares * SharePL;

                    IC_Grid.Rows.Add(Ticker, (LatestTickerPrice + SharePL) * NumShares, TotalPL);
                }
            }
        }

        private string GetLatestPrice(string ticker)
        {
            SqlCommand sqlCmd = new SqlCommand("spGetLatestPrice", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Ticker", SqlDbType.VarChar).Value = ticker;
            sqlCmd.ExecuteNonQuery();
            DataTable close = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(close);
            string price = close.Rows[0].ItemArray.GetValue(0).ToString();
            return price;
        }

        private string GetBeta(string chosen, string ticker)
        {
            string beta;
            SqlCommand sqlCmd = new SqlCommand("spGetBeta", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Chosen", SqlDbType.VarChar).Value = chosen;
            sqlCmd.Parameters.Add("@Ticker", SqlDbType.VarChar).Value = ticker;
            sqlCmd.Parameters.Add("@Beta", SqlDbType.VarChar, 10);
            sqlCmd.Parameters["@Beta"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            DataTable close = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(close);
            beta = close.Rows[0].ItemArray.GetValue(0).ToString();
            return beta;
        }

        private int GetNumShares(string ticker)
        {
            SqlCommand sqlCmd = new SqlCommand("spGetNumShares", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Ticker", SqlDbType.VarChar).Value = ticker;
            sqlCmd.Parameters.Add("@NumShares", SqlDbType.Int);
            sqlCmd.Parameters["@NumShares"].Direction = ParameterDirection.Output;
            sqlCmd.ExecuteNonQuery();
            DataTable shares = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(shares);
            int NumShares = Int32.Parse(shares.Rows[0].ItemArray.GetValue(0).ToString());
            return NumShares;
        }

        private void ResetForecast(object sender, EventArgs e)
        {
            comboBox.Text = string.Empty;
            comboBox.SelectedIndex = 0;
            InputPrice.Text = string.Empty;
            IC_Grid.Rows.Clear();
        }
    }
}