namespace WeatherApp
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labUCTime = new Label();
            labUCTemp = new Label();
            labUCPrecipitation = new Label();
            labUCTempF = new Label();
            SuspendLayout();
            // 
            // labUCTime
            // 
            labUCTime.AutoSize = true;
            labUCTime.Location = new Point(62, 28);
            labUCTime.Name = "labUCTime";
            labUCTime.Size = new Size(58, 28);
            labUCTime.TabIndex = 0;
            labUCTime.Text = "Time";
            // 
            // labUCTemp
            // 
            labUCTemp.AutoSize = true;
            labUCTemp.Location = new Point(62, 75);
            labUCTemp.Name = "labUCTemp";
            labUCTemp.Size = new Size(122, 28);
            labUCTemp.TabIndex = 1;
            labUCTemp.Text = "Temprature";
            // 
            // labUCPrecipitation
            // 
            labUCPrecipitation.AutoSize = true;
            labUCPrecipitation.Location = new Point(62, 120);
            labUCPrecipitation.Name = "labUCPrecipitation";
            labUCPrecipitation.Size = new Size(129, 28);
            labUCPrecipitation.TabIndex = 2;
            labUCPrecipitation.Text = "Precipitation";
            // 
            // labUCTempF
            // 
            labUCTempF.AutoSize = true;
            labUCTempF.BackColor = Color.Transparent;
            labUCTempF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labUCTempF.ForeColor = Color.Black;
            labUCTempF.Location = new Point(157, 75);
            labUCTempF.Margin = new Padding(4, 0, 4, 0);
            labUCTempF.Name = "labUCTempF";
            labUCTempF.Size = new Size(34, 18);
            labUCTempF.TabIndex = 46;
            labUCTempF.Text = "N/A";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labUCTempF);
            Controls.Add(labUCPrecipitation);
            Controls.Add(labUCTemp);
            Controls.Add(labUCTime);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UserControl1";
            Size = new Size(225, 210);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labUCTime;
        public Label labUCTemp;
        public Label labUCPrecipitation;
        public Label labUCTempF;
    }
}
