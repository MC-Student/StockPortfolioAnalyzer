namespace PortfolioAnalyzer
{
    partial class PortfolioAnalyzer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P_Grid = new System.Windows.Forms.DataGridView();
            this.IC_Grid = new System.Windows.Forms.DataGridView();
            this.Positions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tickers_pos = new System.Windows.Forms.Label();
            this.Shares = new System.Windows.Forms.Label();
            this.values_pos = new System.Windows.Forms.Label();
            this.PL = new System.Windows.Forms.Label();
            this.Values_change = new System.Windows.Forms.Label();
            this.Tickers_change = new System.Windows.Forms.Label();
            this.Ticker_Hedge = new System.Windows.Forms.Label();
            this.Price_Hedge = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.InputPrice = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.P_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IC_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Grid
            // 
            this.P_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_Grid.Location = new System.Drawing.Point(12, 78);
            this.P_Grid.Name = "P_Grid";
            this.P_Grid.RowHeadersWidth = 51;
            this.P_Grid.RowTemplate.Height = 29;
            this.P_Grid.Size = new System.Drawing.Size(250, 360);
            this.P_Grid.TabIndex = 0;
            this.P_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IC_Grid
            // 
            this.IC_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IC_Grid.Location = new System.Drawing.Point(527, 78);
            this.IC_Grid.Name = "IC_Grid";
            this.IC_Grid.RowHeadersWidth = 51;
            this.IC_Grid.RowTemplate.Height = 29;
            this.IC_Grid.Size = new System.Drawing.Size(255, 360);
            this.IC_Grid.TabIndex = 1;
            // 
            // Positions
            // 
            this.Positions.AutoSize = true;
            this.Positions.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Positions.Location = new System.Drawing.Point(79, 9);
            this.Positions.Name = "Positions";
            this.Positions.Size = new System.Drawing.Size(125, 30);
            this.Positions.TabIndex = 2;
            this.Positions.Text = "POSITIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(542, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "IMPLIED CHANGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(346, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "HEDGE";
            // 
            // Tickers_pos
            // 
            this.Tickers_pos.AutoSize = true;
            this.Tickers_pos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tickers_pos.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tickers_pos.Location = new System.Drawing.Point(12, 40);
            this.Tickers_pos.Name = "Tickers_pos";
            this.Tickers_pos.Size = new System.Drawing.Size(84, 32);
            this.Tickers_pos.TabIndex = 5;
            this.Tickers_pos.Text = "Tickers";
            // 
            // Shares
            // 
            this.Shares.AutoSize = true;
            this.Shares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Shares.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Shares.Location = new System.Drawing.Point(98, 40);
            this.Shares.Name = "Shares";
            this.Shares.Size = new System.Drawing.Size(80, 32);
            this.Shares.TabIndex = 6;
            this.Shares.Text = "Shares";
            // 
            // values_pos
            // 
            this.values_pos.AutoSize = true;
            this.values_pos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.values_pos.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.values_pos.Location = new System.Drawing.Point(180, 40);
            this.values_pos.Name = "values_pos";
            this.values_pos.Size = new System.Drawing.Size(78, 32);
            this.values_pos.TabIndex = 7;
            this.values_pos.Text = "Values";
            // 
            // PL
            // 
            this.PL.AutoSize = true;
            this.PL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PL.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PL.Location = new System.Drawing.Point(690, 40);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(90, 32);
            this.PL.TabIndex = 10;
            this.PL.Text = "  P/L     ";
            // 
            // Values_change
            // 
            this.Values_change.AutoSize = true;
            this.Values_change.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Values_change.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Values_change.Location = new System.Drawing.Point(612, 40);
            this.Values_change.Name = "Values_change";
            this.Values_change.Size = new System.Drawing.Size(78, 32);
            this.Values_change.TabIndex = 9;
            this.Values_change.Text = "Values";
            // 
            // Tickers_change
            // 
            this.Tickers_change.AutoSize = true;
            this.Tickers_change.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tickers_change.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tickers_change.Location = new System.Drawing.Point(527, 40);
            this.Tickers_change.Name = "Tickers_change";
            this.Tickers_change.Size = new System.Drawing.Size(84, 32);
            this.Tickers_change.TabIndex = 8;
            this.Tickers_change.Text = "Tickers";
            // 
            // Ticker_Hedge
            // 
            this.Ticker_Hedge.AutoSize = true;
            this.Ticker_Hedge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ticker_Hedge.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ticker_Hedge.Location = new System.Drawing.Point(305, 60);
            this.Ticker_Hedge.Name = "Ticker_Hedge";
            this.Ticker_Hedge.Size = new System.Drawing.Size(75, 32);
            this.Ticker_Hedge.TabIndex = 11;
            this.Ticker_Hedge.Text = "Ticker";
            // 
            // Price_Hedge
            // 
            this.Price_Hedge.AutoSize = true;
            this.Price_Hedge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price_Hedge.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price_Hedge.Location = new System.Drawing.Point(402, 60);
            this.Price_Hedge.Name = "Price_Hedge";
            this.Price_Hedge.Size = new System.Drawing.Size(64, 32);
            this.Price_Hedge.TabIndex = 12;
            this.Price_Hedge.Text = "Price";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(305, 111);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(75, 28);
            this.comboBox.TabIndex = 13;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChange);
            // 
            // InputPrice
            // 
            this.InputPrice.BackColor = System.Drawing.Color.LightCyan;
            this.InputPrice.Location = new System.Drawing.Point(402, 111);
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.Size = new System.Drawing.Size(67, 27);
            this.InputPrice.TabIndex = 14;
            this.InputPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputPriceEnter);
            this.InputPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputPrice_KeyPress);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.LightCyan;
            this.RefreshButton.Location = new System.Drawing.Point(343, 180);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(94, 29);
            this.RefreshButton.TabIndex = 15;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.ResetForecast);
            // 
            // PortfolioAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.InputPrice);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.Price_Hedge);
            this.Controls.Add(this.Ticker_Hedge);
            this.Controls.Add(this.PL);
            this.Controls.Add(this.Values_change);
            this.Controls.Add(this.Tickers_change);
            this.Controls.Add(this.values_pos);
            this.Controls.Add(this.Shares);
            this.Controls.Add(this.Tickers_pos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Positions);
            this.Controls.Add(this.IC_Grid);
            this.Controls.Add(this.P_Grid);
            this.Name = "PortfolioAnalyzer";
            this.Text = "Portfolio Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IC_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView P_Grid;
        private DataGridView IC_Grid;
        private Label Positions;
        private Label label2;
        private Label label3;
        private Label Tickers_pos;
        private Label Shares;
        private Label values_pos;
        private Label PL;
        private Label Values_change;
        private Label Tickers_change;
        private Label Ticker_Hedge;
        private Label Price_Hedge;
        private ComboBox comboBox;
        private TextBox InputPrice;
        private Button RefreshButton;
    }
}