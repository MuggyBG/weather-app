namespace WeatherApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            labCity = new Label();
            City = new TextBox();
            btnSearch = new Button();
            labCountry = new Label();
            labLocalTime = new Label();
            labErrorWeather = new Label();
            timerErrorWeather = new System.Windows.Forms.Timer(components);
            tabPage2 = new TabPage();
            labForecastError = new Label();
            tabControl2 = new TabControl();
            tabPageMonday = new TabPage();
            monFLP = new FlowLayoutPanel();
            labMonPrecipitation = new Label();
            labMonPrecipitationVal = new Label();
            labMonSpeed = new Label();
            labMonSpeedVal = new Label();
            labMonSunrise = new Label();
            labMonSunset = new Label();
            labMonSunriseVal = new Label();
            labMonSunsetVal = new Label();
            labMonMinTemp = new Label();
            labMonMinTempValF = new Label();
            labMonMaxTemp = new Label();
            labMonMaxTempValF = new Label();
            labMonMinTempVal = new Label();
            labMonMaxTempVal = new Label();
            labMonTempValF = new Label();
            labMonTempVal = new Label();
            labTempMonday = new Label();
            tabPageTuesday = new TabPage();
            tueFLP = new FlowLayoutPanel();
            labTuePrecipitation = new Label();
            labTuePrecipitationVal = new Label();
            labTueSpeed = new Label();
            labTueSpeedVal = new Label();
            labTueSunrise = new Label();
            labTueSunset = new Label();
            labTueSunriseVal = new Label();
            labTueSunsetVal = new Label();
            labTueMinTemp = new Label();
            labTueMinTempValF = new Label();
            labTueMaxTemp = new Label();
            labTueMaxTempValF = new Label();
            labTueMinTempVal = new Label();
            labTueMaxTempVal = new Label();
            labTueTempValF = new Label();
            labTueTempVal = new Label();
            labTempTuesday = new Label();
            tabPageWednesday = new TabPage();
            wedFLP = new FlowLayoutPanel();
            labWedPrecipitation = new Label();
            labWedPrecipitationVal = new Label();
            labWedSpeed = new Label();
            labWedSpeedVal = new Label();
            labWedSunrise = new Label();
            labWedSunset = new Label();
            labWedSunriseVal = new Label();
            labWedSunsetVal = new Label();
            labWedMinTemp = new Label();
            labWedMinTempValF = new Label();
            labWedMaxTemp = new Label();
            labWedMaxTempValF = new Label();
            labWedMinTempVal = new Label();
            labWedMaxTempVal = new Label();
            labWedTempValF = new Label();
            labWedTempVal = new Label();
            labTempWednesday = new Label();
            tabPageThursday = new TabPage();
            thuFLP = new FlowLayoutPanel();
            labThuPrecipitation = new Label();
            labThuPrecipitationVal = new Label();
            labThuSpeed = new Label();
            labThuSpeedVal = new Label();
            labThuSunrise = new Label();
            labThuSunset = new Label();
            labThuSunriseVal = new Label();
            labThuSunsetVal = new Label();
            labThuMinTemp = new Label();
            labThuMinTempValF = new Label();
            labThuMaxTemp = new Label();
            labThuMaxTempValF = new Label();
            labThuMinTempVal = new Label();
            labThuMaxTempVal = new Label();
            labThuTempValF = new Label();
            labThuTempVal = new Label();
            labTempThursday = new Label();
            tabPageFriday = new TabPage();
            friFLP = new FlowLayoutPanel();
            labFriPrecipitation = new Label();
            labFriPrecipitationVal = new Label();
            labFriSpeed = new Label();
            labFriSpeedVal = new Label();
            labFriSunrise = new Label();
            labFriSunset = new Label();
            labFriSunriseVal = new Label();
            labFriSunsetVal = new Label();
            labFriMinTemp = new Label();
            labFriMinTempValF = new Label();
            labFriMaxTemp = new Label();
            labFriMaxTempValF = new Label();
            labFriMinTempVal = new Label();
            labFriMaxTempVal = new Label();
            labFriTempValF = new Label();
            labFriTempVal = new Label();
            labTempFriday = new Label();
            tabPageSaturday = new TabPage();
            satFLP = new FlowLayoutPanel();
            labSatPrecipitation = new Label();
            labSatPrecipitationVal = new Label();
            labSatSpeed = new Label();
            labSatSpeedVal = new Label();
            labSatSunrise = new Label();
            labSatSunset = new Label();
            labSatSunriseVal = new Label();
            labSatSunsetVal = new Label();
            labSatMinTemp = new Label();
            labSatMinTempValF = new Label();
            labSatMaxTemp = new Label();
            labSatMaxTempValF = new Label();
            labSatMinTempVal = new Label();
            labSatMaxTempVal = new Label();
            labSatTempValF = new Label();
            labSatTempVal = new Label();
            labTempSaturday = new Label();
            tabPageSunday = new TabPage();
            sunFLP = new FlowLayoutPanel();
            labSunPrecipitation = new Label();
            labSunPrecipitationVal = new Label();
            labSunSpeed = new Label();
            labSunSpeedVal = new Label();
            labSunSunrise = new Label();
            labSunSunset = new Label();
            labSunSunriseVal = new Label();
            labSunSunsetVal = new Label();
            labSunMinTemp = new Label();
            labSunMinTempValF = new Label();
            labSunMaxTemp = new Label();
            labSunMaxTempValF = new Label();
            labSunMinTempVal = new Label();
            labSunMaxTempVal = new Label();
            labSunTempValF = new Label();
            labSunTempVal = new Label();
            labTempSunday = new Label();
            tabPage1 = new TabPage();
            labWindSpeed = new Label();
            labWindSpeedValue = new Label();
            labPressure = new Label();
            labPressureValue = new Label();
            labMinTemp = new Label();
            labFeelsLikeFahr = new Label();
            labMinTempFahr = new Label();
            labTempFahr = new Label();
            labTempValue = new Label();
            labMaxTemp = new Label();
            labFeelsLikeValue = new Label();
            labDateTime = new Label();
            labMaxTempFahr = new Label();
            labFeelsLike = new Label();
            labMinTempValue = new Label();
            labTemp = new Label();
            labMaxTempValue = new Label();
            labCondition = new Label();
            picIcon = new PictureBox();
            labDetails = new Label();
            labSunrise = new Label();
            labSunset = new Label();
            labSunriseValue = new Label();
            labSunsetValue = new Label();
            tabControl1 = new TabControl();
            timerForecastError = new System.Windows.Forms.Timer(components);
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPageMonday.SuspendLayout();
            tabPageTuesday.SuspendLayout();
            tabPageWednesday.SuspendLayout();
            tabPageThursday.SuspendLayout();
            tabPageFriday.SuspendLayout();
            tabPageSaturday.SuspendLayout();
            tabPageSunday.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // labCity
            // 
            labCity.AutoSize = true;
            labCity.BackColor = Color.Transparent;
            labCity.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labCity.ForeColor = Color.Black;
            labCity.Location = new Point(29, 21);
            labCity.Margin = new Padding(4, 0, 4, 0);
            labCity.Name = "labCity";
            labCity.Size = new Size(69, 28);
            labCity.TabIndex = 0;
            labCity.Text = "Град: ";
            labCity.Click += label1_Click;
            // 
            // City
            // 
            City.BackColor = Color.White;
            City.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            City.Location = new Point(93, 21);
            City.Margin = new Padding(4, 6, 4, 6);
            City.Name = "City";
            City.PlaceholderText = "Въведете град/място";
            City.Size = new Size(342, 35);
            City.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(460, 21);
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(192, 35);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Намери";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // labCountry
            // 
            labCountry.AutoSize = true;
            labCountry.BackColor = Color.Transparent;
            labCountry.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labCountry.ForeColor = Color.Black;
            labCountry.Location = new Point(4, 62);
            labCountry.Margin = new Padding(4, 0, 4, 0);
            labCountry.Name = "labCountry";
            labCountry.Size = new Size(94, 28);
            labCountry.TabIndex = 25;
            labCountry.Text = "Държава";
            // 
            // labLocalTime
            // 
            labLocalTime.AutoSize = true;
            labLocalTime.BackColor = Color.Transparent;
            labLocalTime.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labLocalTime.ForeColor = Color.Black;
            labLocalTime.Location = new Point(828, 24);
            labLocalTime.Margin = new Padding(4, 0, 4, 0);
            labLocalTime.Name = "labLocalTime";
            labLocalTime.Size = new Size(0, 28);
            labLocalTime.TabIndex = 43;
            // 
            // labErrorWeather
            // 
            labErrorWeather.AutoSize = true;
            labErrorWeather.BackColor = Color.Transparent;
            labErrorWeather.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labErrorWeather.ForeColor = Color.Red;
            labErrorWeather.Location = new Point(673, 21);
            labErrorWeather.Margin = new Padding(4, 0, 4, 0);
            labErrorWeather.Name = "labErrorWeather";
            labErrorWeather.Size = new Size(0, 27);
            labErrorWeather.TabIndex = 44;
            // 
            // timerErrorWeather
            // 
            timerErrorWeather.Interval = 5000;
            timerErrorWeather.Tick += timerErrorWeather_Tick;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(labForecastError);
            tabPage2.Controls.Add(tabControl2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(888, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Прогноза";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labForecastError
            // 
            labForecastError.AutoSize = true;
            labForecastError.ForeColor = Color.Red;
            labForecastError.Location = new Point(62, 5);
            labForecastError.Name = "labForecastError";
            labForecastError.Size = new Size(0, 28);
            labForecastError.TabIndex = 94;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPageMonday);
            tabControl2.Controls.Add(tabPageTuesday);
            tabControl2.Controls.Add(tabPageWednesday);
            tabControl2.Controls.Add(tabPageThursday);
            tabControl2.Controls.Add(tabPageFriday);
            tabControl2.Controls.Add(tabPageSaturday);
            tabControl2.Controls.Add(tabPageSunday);
            tabControl2.Location = new Point(62, 36);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(697, 481);
            tabControl2.TabIndex = 0;
            // 
            // tabPageMonday
            // 
            tabPageMonday.Controls.Add(monFLP);
            tabPageMonday.Controls.Add(labMonPrecipitation);
            tabPageMonday.Controls.Add(labMonPrecipitationVal);
            tabPageMonday.Controls.Add(labMonSpeed);
            tabPageMonday.Controls.Add(labMonSpeedVal);
            tabPageMonday.Controls.Add(labMonSunrise);
            tabPageMonday.Controls.Add(labMonSunset);
            tabPageMonday.Controls.Add(labMonSunriseVal);
            tabPageMonday.Controls.Add(labMonSunsetVal);
            tabPageMonday.Controls.Add(labMonMinTemp);
            tabPageMonday.Controls.Add(labMonMinTempValF);
            tabPageMonday.Controls.Add(labMonMaxTemp);
            tabPageMonday.Controls.Add(labMonMaxTempValF);
            tabPageMonday.Controls.Add(labMonMinTempVal);
            tabPageMonday.Controls.Add(labMonMaxTempVal);
            tabPageMonday.Controls.Add(labMonTempValF);
            tabPageMonday.Controls.Add(labMonTempVal);
            tabPageMonday.Controls.Add(labTempMonday);
            tabPageMonday.Location = new Point(4, 37);
            tabPageMonday.Name = "tabPageMonday";
            tabPageMonday.Padding = new Padding(3);
            tabPageMonday.Size = new Size(689, 440);
            tabPageMonday.TabIndex = 0;
            tabPageMonday.Text = "Понеделник";
            tabPageMonday.UseVisualStyleBackColor = true;
            // 
            // monFLP
            // 
            monFLP.AutoScroll = true;
            monFLP.Location = new Point(8, 237);
            monFLP.Name = "monFLP";
            monFLP.Size = new Size(624, 186);
            monFLP.TabIndex = 1;
            monFLP.WrapContents = false;
            // 
            // labMonPrecipitation
            // 
            labMonPrecipitation.AutoSize = true;
            labMonPrecipitation.BackColor = Color.Transparent;
            labMonPrecipitation.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonPrecipitation.ForeColor = Color.Black;
            labMonPrecipitation.Location = new Point(8, 58);
            labMonPrecipitation.Margin = new Padding(4, 0, 4, 0);
            labMonPrecipitation.Name = "labMonPrecipitation";
            labMonPrecipitation.Size = new Size(86, 28);
            labMonPrecipitation.TabIndex = 92;
            labMonPrecipitation.Text = "Валежи";
            // 
            // labMonPrecipitationVal
            // 
            labMonPrecipitationVal.AutoSize = true;
            labMonPrecipitationVal.BackColor = Color.Transparent;
            labMonPrecipitationVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonPrecipitationVal.ForeColor = Color.Black;
            labMonPrecipitationVal.Location = new Point(155, 58);
            labMonPrecipitationVal.Margin = new Padding(4, 0, 4, 0);
            labMonPrecipitationVal.Name = "labMonPrecipitationVal";
            labMonPrecipitationVal.Size = new Size(53, 28);
            labMonPrecipitationVal.TabIndex = 93;
            labMonPrecipitationVal.Text = "N/A";
            // 
            // labMonSpeed
            // 
            labMonSpeed.AutoSize = true;
            labMonSpeed.BackColor = Color.Transparent;
            labMonSpeed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonSpeed.ForeColor = Color.Black;
            labMonSpeed.Location = new Point(8, 189);
            labMonSpeed.Margin = new Padding(4, 0, 4, 0);
            labMonSpeed.Name = "labMonSpeed";
            labMonSpeed.Size = new Size(168, 28);
            labMonSpeed.TabIndex = 88;
            labMonSpeed.Text = "Вятърна скорост";
            // 
            // labMonSpeedVal
            // 
            labMonSpeedVal.AutoSize = true;
            labMonSpeedVal.BackColor = Color.Transparent;
            labMonSpeedVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonSpeedVal.ForeColor = Color.Black;
            labMonSpeedVal.Location = new Point(302, 189);
            labMonSpeedVal.Margin = new Padding(4, 0, 4, 0);
            labMonSpeedVal.Name = "labMonSpeedVal";
            labMonSpeedVal.Size = new Size(53, 28);
            labMonSpeedVal.TabIndex = 89;
            labMonSpeedVal.Text = "N/A";
            // 
            // labMonSunrise
            // 
            labMonSunrise.AutoSize = true;
            labMonSunrise.BackColor = Color.Transparent;
            labMonSunrise.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonSunrise.ForeColor = Color.Black;
            labMonSunrise.Location = new Point(8, 101);
            labMonSunrise.Margin = new Padding(4, 0, 4, 0);
            labMonSunrise.Name = "labMonSunrise";
            labMonSunrise.Size = new Size(77, 28);
            labMonSunrise.TabIndex = 84;
            labMonSunrise.Text = "Изгрев";
            // 
            // labMonSunset
            // 
            labMonSunset.AutoSize = true;
            labMonSunset.BackColor = Color.Transparent;
            labMonSunset.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonSunset.ForeColor = Color.Black;
            labMonSunset.Location = new Point(8, 146);
            labMonSunset.Margin = new Padding(4, 0, 4, 0);
            labMonSunset.Name = "labMonSunset";
            labMonSunset.Size = new Size(67, 28);
            labMonSunset.TabIndex = 85;
            labMonSunset.Text = "Залез";
            // 
            // labMonSunriseVal
            // 
            labMonSunriseVal.AutoSize = true;
            labMonSunriseVal.BackColor = Color.Transparent;
            labMonSunriseVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonSunriseVal.ForeColor = Color.Black;
            labMonSunriseVal.Location = new Point(155, 101);
            labMonSunriseVal.Margin = new Padding(4, 0, 4, 0);
            labMonSunriseVal.Name = "labMonSunriseVal";
            labMonSunriseVal.Size = new Size(53, 28);
            labMonSunriseVal.TabIndex = 86;
            labMonSunriseVal.Text = "N/A";
            // 
            // labMonSunsetVal
            // 
            labMonSunsetVal.AutoSize = true;
            labMonSunsetVal.BackColor = Color.Transparent;
            labMonSunsetVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonSunsetVal.ForeColor = Color.Black;
            labMonSunsetVal.Location = new Point(155, 146);
            labMonSunsetVal.Margin = new Padding(4, 0, 4, 0);
            labMonSunsetVal.Name = "labMonSunsetVal";
            labMonSunsetVal.Size = new Size(53, 28);
            labMonSunsetVal.TabIndex = 87;
            labMonSunsetVal.Text = "N/A";
            // 
            // labMonMinTemp
            // 
            labMonMinTemp.AutoSize = true;
            labMonMinTemp.BackColor = Color.Transparent;
            labMonMinTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonMinTemp.ForeColor = Color.Black;
            labMonMinTemp.Location = new Point(302, 14);
            labMonMinTemp.Margin = new Padding(4, 0, 4, 0);
            labMonMinTemp.Name = "labMonMinTemp";
            labMonMinTemp.Size = new Size(186, 28);
            labMonMinTemp.TabIndex = 78;
            labMonMinTemp.Text = "Минимална темп:";
            // 
            // labMonMinTempValF
            // 
            labMonMinTempValF.AutoSize = true;
            labMonMinTempValF.BackColor = Color.Transparent;
            labMonMinTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labMonMinTempValF.ForeColor = Color.Black;
            labMonMinTempValF.Location = new Point(557, 5);
            labMonMinTempValF.Margin = new Padding(4, 0, 4, 0);
            labMonMinTempValF.Name = "labMonMinTempValF";
            labMonMinTempValF.Size = new Size(34, 18);
            labMonMinTempValF.TabIndex = 83;
            labMonMinTempValF.Text = "N/A";
            // 
            // labMonMaxTemp
            // 
            labMonMaxTemp.AutoSize = true;
            labMonMaxTemp.BackColor = Color.Transparent;
            labMonMaxTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonMaxTemp.ForeColor = Color.Black;
            labMonMaxTemp.Location = new Point(302, 67);
            labMonMaxTemp.Margin = new Padding(4, 0, 4, 0);
            labMonMaxTemp.Name = "labMonMaxTemp";
            labMonMaxTemp.Size = new Size(192, 28);
            labMonMaxTemp.TabIndex = 79;
            labMonMaxTemp.Text = "Максимална темп:";
            // 
            // labMonMaxTempValF
            // 
            labMonMaxTempValF.AutoSize = true;
            labMonMaxTempValF.BackColor = Color.Transparent;
            labMonMaxTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labMonMaxTempValF.ForeColor = Color.Black;
            labMonMaxTempValF.Location = new Point(557, 58);
            labMonMaxTempValF.Margin = new Padding(4, 0, 4, 0);
            labMonMaxTempValF.Name = "labMonMaxTempValF";
            labMonMaxTempValF.Size = new Size(34, 18);
            labMonMaxTempValF.TabIndex = 82;
            labMonMaxTempValF.Text = "N/A";
            // 
            // labMonMinTempVal
            // 
            labMonMinTempVal.AutoSize = true;
            labMonMinTempVal.BackColor = Color.Transparent;
            labMonMinTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonMinTempVal.ForeColor = Color.Black;
            labMonMinTempVal.Location = new Point(496, 14);
            labMonMinTempVal.Margin = new Padding(4, 0, 4, 0);
            labMonMinTempVal.Name = "labMonMinTempVal";
            labMonMinTempVal.Size = new Size(53, 28);
            labMonMinTempVal.TabIndex = 80;
            labMonMinTempVal.Text = "N/A";
            // 
            // labMonMaxTempVal
            // 
            labMonMaxTempVal.AutoSize = true;
            labMonMaxTempVal.BackColor = Color.Transparent;
            labMonMaxTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonMaxTempVal.ForeColor = Color.Black;
            labMonMaxTempVal.Location = new Point(496, 67);
            labMonMaxTempVal.Margin = new Padding(4, 0, 4, 0);
            labMonMaxTempVal.Name = "labMonMaxTempVal";
            labMonMaxTempVal.Size = new Size(53, 28);
            labMonMaxTempVal.TabIndex = 81;
            labMonMaxTempVal.Text = "N/A";
            // 
            // labMonTempValF
            // 
            labMonTempValF.AutoSize = true;
            labMonTempValF.BackColor = Color.Transparent;
            labMonTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labMonTempValF.ForeColor = Color.Black;
            labMonTempValF.Location = new Point(216, 11);
            labMonTempValF.Margin = new Padding(4, 0, 4, 0);
            labMonTempValF.Name = "labMonTempValF";
            labMonTempValF.Size = new Size(34, 18);
            labMonTempValF.TabIndex = 45;
            labMonTempValF.Text = "N/A";
            // 
            // labMonTempVal
            // 
            labMonTempVal.AutoSize = true;
            labMonTempVal.BackColor = Color.Transparent;
            labMonTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMonTempVal.ForeColor = Color.Black;
            labMonTempVal.Location = new Point(155, 20);
            labMonTempVal.Margin = new Padding(4, 0, 4, 0);
            labMonTempVal.Name = "labMonTempVal";
            labMonTempVal.Size = new Size(53, 28);
            labMonTempVal.TabIndex = 44;
            labMonTempVal.Text = "N/A";
            // 
            // labTempMonday
            // 
            labTempMonday.AutoSize = true;
            labTempMonday.BackColor = Color.Transparent;
            labTempMonday.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTempMonday.ForeColor = Color.Black;
            labTempMonday.Location = new Point(4, 20);
            labTempMonday.Margin = new Padding(4, 0, 4, 0);
            labTempMonday.Name = "labTempMonday";
            labTempMonday.Size = new Size(143, 28);
            labTempMonday.TabIndex = 43;
            labTempMonday.Text = "Температура:";
            // 
            // tabPageTuesday
            // 
            tabPageTuesday.Controls.Add(tueFLP);
            tabPageTuesday.Controls.Add(labTuePrecipitation);
            tabPageTuesday.Controls.Add(labTuePrecipitationVal);
            tabPageTuesday.Controls.Add(labTueSpeed);
            tabPageTuesday.Controls.Add(labTueSpeedVal);
            tabPageTuesday.Controls.Add(labTueSunrise);
            tabPageTuesday.Controls.Add(labTueSunset);
            tabPageTuesday.Controls.Add(labTueSunriseVal);
            tabPageTuesday.Controls.Add(labTueSunsetVal);
            tabPageTuesday.Controls.Add(labTueMinTemp);
            tabPageTuesday.Controls.Add(labTueMinTempValF);
            tabPageTuesday.Controls.Add(labTueMaxTemp);
            tabPageTuesday.Controls.Add(labTueMaxTempValF);
            tabPageTuesday.Controls.Add(labTueMinTempVal);
            tabPageTuesday.Controls.Add(labTueMaxTempVal);
            tabPageTuesday.Controls.Add(labTueTempValF);
            tabPageTuesday.Controls.Add(labTueTempVal);
            tabPageTuesday.Controls.Add(labTempTuesday);
            tabPageTuesday.Location = new Point(4, 29);
            tabPageTuesday.Name = "tabPageTuesday";
            tabPageTuesday.Padding = new Padding(3);
            tabPageTuesday.Size = new Size(689, 448);
            tabPageTuesday.TabIndex = 1;
            tabPageTuesday.Text = "Вторник";
            tabPageTuesday.UseVisualStyleBackColor = true;
            // 
            // tueFLP
            // 
            tueFLP.AutoScroll = true;
            tueFLP.Location = new Point(8, 237);
            tueFLP.Name = "tueFLP";
            tueFLP.Size = new Size(624, 186);
            tueFLP.TabIndex = 94;
            tueFLP.WrapContents = false;
            // 
            // labTuePrecipitation
            // 
            labTuePrecipitation.AutoSize = true;
            labTuePrecipitation.BackColor = Color.Transparent;
            labTuePrecipitation.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTuePrecipitation.ForeColor = Color.Black;
            labTuePrecipitation.Location = new Point(8, 58);
            labTuePrecipitation.Margin = new Padding(4, 0, 4, 0);
            labTuePrecipitation.Name = "labTuePrecipitation";
            labTuePrecipitation.Size = new Size(86, 28);
            labTuePrecipitation.TabIndex = 92;
            labTuePrecipitation.Text = "Валежи";
            // 
            // labTuePrecipitationVal
            // 
            labTuePrecipitationVal.AutoSize = true;
            labTuePrecipitationVal.BackColor = Color.Transparent;
            labTuePrecipitationVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTuePrecipitationVal.ForeColor = Color.Black;
            labTuePrecipitationVal.Location = new Point(155, 58);
            labTuePrecipitationVal.Margin = new Padding(4, 0, 4, 0);
            labTuePrecipitationVal.Name = "labTuePrecipitationVal";
            labTuePrecipitationVal.Size = new Size(53, 28);
            labTuePrecipitationVal.TabIndex = 93;
            labTuePrecipitationVal.Text = "N/A";
            // 
            // labTueSpeed
            // 
            labTueSpeed.AutoSize = true;
            labTueSpeed.BackColor = Color.Transparent;
            labTueSpeed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueSpeed.ForeColor = Color.Black;
            labTueSpeed.Location = new Point(8, 189);
            labTueSpeed.Margin = new Padding(4, 0, 4, 0);
            labTueSpeed.Name = "labTueSpeed";
            labTueSpeed.Size = new Size(168, 28);
            labTueSpeed.TabIndex = 88;
            labTueSpeed.Text = "Вятърна скорост";
            // 
            // labTueSpeedVal
            // 
            labTueSpeedVal.AutoSize = true;
            labTueSpeedVal.BackColor = Color.Transparent;
            labTueSpeedVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueSpeedVal.ForeColor = Color.Black;
            labTueSpeedVal.Location = new Point(302, 189);
            labTueSpeedVal.Margin = new Padding(4, 0, 4, 0);
            labTueSpeedVal.Name = "labTueSpeedVal";
            labTueSpeedVal.Size = new Size(53, 28);
            labTueSpeedVal.TabIndex = 89;
            labTueSpeedVal.Text = "N/A";
            // 
            // labTueSunrise
            // 
            labTueSunrise.AutoSize = true;
            labTueSunrise.BackColor = Color.Transparent;
            labTueSunrise.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueSunrise.ForeColor = Color.Black;
            labTueSunrise.Location = new Point(8, 101);
            labTueSunrise.Margin = new Padding(4, 0, 4, 0);
            labTueSunrise.Name = "labTueSunrise";
            labTueSunrise.Size = new Size(77, 28);
            labTueSunrise.TabIndex = 84;
            labTueSunrise.Text = "Изгрев";
            // 
            // labTueSunset
            // 
            labTueSunset.AutoSize = true;
            labTueSunset.BackColor = Color.Transparent;
            labTueSunset.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueSunset.ForeColor = Color.Black;
            labTueSunset.Location = new Point(8, 146);
            labTueSunset.Margin = new Padding(4, 0, 4, 0);
            labTueSunset.Name = "labTueSunset";
            labTueSunset.Size = new Size(67, 28);
            labTueSunset.TabIndex = 85;
            labTueSunset.Text = "Залез";
            // 
            // labTueSunriseVal
            // 
            labTueSunriseVal.AutoSize = true;
            labTueSunriseVal.BackColor = Color.Transparent;
            labTueSunriseVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueSunriseVal.ForeColor = Color.Black;
            labTueSunriseVal.Location = new Point(155, 101);
            labTueSunriseVal.Margin = new Padding(4, 0, 4, 0);
            labTueSunriseVal.Name = "labTueSunriseVal";
            labTueSunriseVal.Size = new Size(53, 28);
            labTueSunriseVal.TabIndex = 86;
            labTueSunriseVal.Text = "N/A";
            // 
            // labTueSunsetVal
            // 
            labTueSunsetVal.AutoSize = true;
            labTueSunsetVal.BackColor = Color.Transparent;
            labTueSunsetVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueSunsetVal.ForeColor = Color.Black;
            labTueSunsetVal.Location = new Point(155, 146);
            labTueSunsetVal.Margin = new Padding(4, 0, 4, 0);
            labTueSunsetVal.Name = "labTueSunsetVal";
            labTueSunsetVal.Size = new Size(53, 28);
            labTueSunsetVal.TabIndex = 87;
            labTueSunsetVal.Text = "N/A";
            // 
            // labTueMinTemp
            // 
            labTueMinTemp.AutoSize = true;
            labTueMinTemp.BackColor = Color.Transparent;
            labTueMinTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueMinTemp.ForeColor = Color.Black;
            labTueMinTemp.Location = new Point(302, 14);
            labTueMinTemp.Margin = new Padding(4, 0, 4, 0);
            labTueMinTemp.Name = "labTueMinTemp";
            labTueMinTemp.Size = new Size(186, 28);
            labTueMinTemp.TabIndex = 78;
            labTueMinTemp.Text = "Минимална темп:";
            // 
            // labTueMinTempValF
            // 
            labTueMinTempValF.AutoSize = true;
            labTueMinTempValF.BackColor = Color.Transparent;
            labTueMinTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labTueMinTempValF.ForeColor = Color.Black;
            labTueMinTempValF.Location = new Point(557, 5);
            labTueMinTempValF.Margin = new Padding(4, 0, 4, 0);
            labTueMinTempValF.Name = "labTueMinTempValF";
            labTueMinTempValF.Size = new Size(34, 18);
            labTueMinTempValF.TabIndex = 83;
            labTueMinTempValF.Text = "N/A";
            // 
            // labTueMaxTemp
            // 
            labTueMaxTemp.AutoSize = true;
            labTueMaxTemp.BackColor = Color.Transparent;
            labTueMaxTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueMaxTemp.ForeColor = Color.Black;
            labTueMaxTemp.Location = new Point(302, 67);
            labTueMaxTemp.Margin = new Padding(4, 0, 4, 0);
            labTueMaxTemp.Name = "labTueMaxTemp";
            labTueMaxTemp.Size = new Size(192, 28);
            labTueMaxTemp.TabIndex = 79;
            labTueMaxTemp.Text = "Максимална темп:";
            // 
            // labTueMaxTempValF
            // 
            labTueMaxTempValF.AutoSize = true;
            labTueMaxTempValF.BackColor = Color.Transparent;
            labTueMaxTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labTueMaxTempValF.ForeColor = Color.Black;
            labTueMaxTempValF.Location = new Point(557, 58);
            labTueMaxTempValF.Margin = new Padding(4, 0, 4, 0);
            labTueMaxTempValF.Name = "labTueMaxTempValF";
            labTueMaxTempValF.Size = new Size(34, 18);
            labTueMaxTempValF.TabIndex = 82;
            labTueMaxTempValF.Text = "N/A";
            // 
            // labTueMinTempVal
            // 
            labTueMinTempVal.AutoSize = true;
            labTueMinTempVal.BackColor = Color.Transparent;
            labTueMinTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueMinTempVal.ForeColor = Color.Black;
            labTueMinTempVal.Location = new Point(496, 14);
            labTueMinTempVal.Margin = new Padding(4, 0, 4, 0);
            labTueMinTempVal.Name = "labTueMinTempVal";
            labTueMinTempVal.Size = new Size(53, 28);
            labTueMinTempVal.TabIndex = 80;
            labTueMinTempVal.Text = "N/A";
            // 
            // labTueMaxTempVal
            // 
            labTueMaxTempVal.AutoSize = true;
            labTueMaxTempVal.BackColor = Color.Transparent;
            labTueMaxTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueMaxTempVal.ForeColor = Color.Black;
            labTueMaxTempVal.Location = new Point(496, 67);
            labTueMaxTempVal.Margin = new Padding(4, 0, 4, 0);
            labTueMaxTempVal.Name = "labTueMaxTempVal";
            labTueMaxTempVal.Size = new Size(53, 28);
            labTueMaxTempVal.TabIndex = 81;
            labTueMaxTempVal.Text = "N/A";
            // 
            // labTueTempValF
            // 
            labTueTempValF.AutoSize = true;
            labTueTempValF.BackColor = Color.Transparent;
            labTueTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labTueTempValF.ForeColor = Color.Black;
            labTueTempValF.Location = new Point(216, 11);
            labTueTempValF.Margin = new Padding(4, 0, 4, 0);
            labTueTempValF.Name = "labTueTempValF";
            labTueTempValF.Size = new Size(34, 18);
            labTueTempValF.TabIndex = 45;
            labTueTempValF.Text = "N/A";
            // 
            // labTueTempVal
            // 
            labTueTempVal.AutoSize = true;
            labTueTempVal.BackColor = Color.Transparent;
            labTueTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTueTempVal.ForeColor = Color.Black;
            labTueTempVal.Location = new Point(155, 20);
            labTueTempVal.Margin = new Padding(4, 0, 4, 0);
            labTueTempVal.Name = "labTueTempVal";
            labTueTempVal.Size = new Size(53, 28);
            labTueTempVal.TabIndex = 44;
            labTueTempVal.Text = "N/A";
            // 
            // labTempTuesday
            // 
            labTempTuesday.AutoSize = true;
            labTempTuesday.BackColor = Color.Transparent;
            labTempTuesday.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTempTuesday.ForeColor = Color.Black;
            labTempTuesday.Location = new Point(4, 20);
            labTempTuesday.Margin = new Padding(4, 0, 4, 0);
            labTempTuesday.Name = "labTempTuesday";
            labTempTuesday.Size = new Size(143, 28);
            labTempTuesday.TabIndex = 43;
            labTempTuesday.Text = "Температура:";
            // 
            // tabPageWednesday
            // 
            tabPageWednesday.Controls.Add(wedFLP);
            tabPageWednesday.Controls.Add(labWedPrecipitation);
            tabPageWednesday.Controls.Add(labWedPrecipitationVal);
            tabPageWednesday.Controls.Add(labWedSpeed);
            tabPageWednesday.Controls.Add(labWedSpeedVal);
            tabPageWednesday.Controls.Add(labWedSunrise);
            tabPageWednesday.Controls.Add(labWedSunset);
            tabPageWednesday.Controls.Add(labWedSunriseVal);
            tabPageWednesday.Controls.Add(labWedSunsetVal);
            tabPageWednesday.Controls.Add(labWedMinTemp);
            tabPageWednesday.Controls.Add(labWedMinTempValF);
            tabPageWednesday.Controls.Add(labWedMaxTemp);
            tabPageWednesday.Controls.Add(labWedMaxTempValF);
            tabPageWednesday.Controls.Add(labWedMinTempVal);
            tabPageWednesday.Controls.Add(labWedMaxTempVal);
            tabPageWednesday.Controls.Add(labWedTempValF);
            tabPageWednesday.Controls.Add(labWedTempVal);
            tabPageWednesday.Controls.Add(labTempWednesday);
            tabPageWednesday.Location = new Point(4, 29);
            tabPageWednesday.Name = "tabPageWednesday";
            tabPageWednesday.Size = new Size(689, 448);
            tabPageWednesday.TabIndex = 2;
            tabPageWednesday.Text = "Сряда";
            tabPageWednesday.UseVisualStyleBackColor = true;
            // 
            // wedFLP
            // 
            wedFLP.AutoScroll = true;
            wedFLP.Location = new Point(8, 237);
            wedFLP.Name = "wedFLP";
            wedFLP.Size = new Size(624, 186);
            wedFLP.TabIndex = 94;
            wedFLP.WrapContents = false;
            // 
            // labWedPrecipitation
            // 
            labWedPrecipitation.AutoSize = true;
            labWedPrecipitation.BackColor = Color.Transparent;
            labWedPrecipitation.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedPrecipitation.ForeColor = Color.Black;
            labWedPrecipitation.Location = new Point(8, 58);
            labWedPrecipitation.Margin = new Padding(4, 0, 4, 0);
            labWedPrecipitation.Name = "labWedPrecipitation";
            labWedPrecipitation.Size = new Size(86, 28);
            labWedPrecipitation.TabIndex = 92;
            labWedPrecipitation.Text = "Валежи";
            // 
            // labWedPrecipitationVal
            // 
            labWedPrecipitationVal.AutoSize = true;
            labWedPrecipitationVal.BackColor = Color.Transparent;
            labWedPrecipitationVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedPrecipitationVal.ForeColor = Color.Black;
            labWedPrecipitationVal.Location = new Point(155, 58);
            labWedPrecipitationVal.Margin = new Padding(4, 0, 4, 0);
            labWedPrecipitationVal.Name = "labWedPrecipitationVal";
            labWedPrecipitationVal.Size = new Size(53, 28);
            labWedPrecipitationVal.TabIndex = 93;
            labWedPrecipitationVal.Text = "N/A";
            // 
            // labWedSpeed
            // 
            labWedSpeed.AutoSize = true;
            labWedSpeed.BackColor = Color.Transparent;
            labWedSpeed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedSpeed.ForeColor = Color.Black;
            labWedSpeed.Location = new Point(8, 189);
            labWedSpeed.Margin = new Padding(4, 0, 4, 0);
            labWedSpeed.Name = "labWedSpeed";
            labWedSpeed.Size = new Size(168, 28);
            labWedSpeed.TabIndex = 88;
            labWedSpeed.Text = "Вятърна скорост";
            // 
            // labWedSpeedVal
            // 
            labWedSpeedVal.AutoSize = true;
            labWedSpeedVal.BackColor = Color.Transparent;
            labWedSpeedVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedSpeedVal.ForeColor = Color.Black;
            labWedSpeedVal.Location = new Point(302, 189);
            labWedSpeedVal.Margin = new Padding(4, 0, 4, 0);
            labWedSpeedVal.Name = "labWedSpeedVal";
            labWedSpeedVal.Size = new Size(53, 28);
            labWedSpeedVal.TabIndex = 89;
            labWedSpeedVal.Text = "N/A";
            // 
            // labWedSunrise
            // 
            labWedSunrise.AutoSize = true;
            labWedSunrise.BackColor = Color.Transparent;
            labWedSunrise.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedSunrise.ForeColor = Color.Black;
            labWedSunrise.Location = new Point(8, 101);
            labWedSunrise.Margin = new Padding(4, 0, 4, 0);
            labWedSunrise.Name = "labWedSunrise";
            labWedSunrise.Size = new Size(77, 28);
            labWedSunrise.TabIndex = 84;
            labWedSunrise.Text = "Изгрев";
            // 
            // labWedSunset
            // 
            labWedSunset.AutoSize = true;
            labWedSunset.BackColor = Color.Transparent;
            labWedSunset.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedSunset.ForeColor = Color.Black;
            labWedSunset.Location = new Point(8, 146);
            labWedSunset.Margin = new Padding(4, 0, 4, 0);
            labWedSunset.Name = "labWedSunset";
            labWedSunset.Size = new Size(67, 28);
            labWedSunset.TabIndex = 85;
            labWedSunset.Text = "Залез";
            // 
            // labWedSunriseVal
            // 
            labWedSunriseVal.AutoSize = true;
            labWedSunriseVal.BackColor = Color.Transparent;
            labWedSunriseVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedSunriseVal.ForeColor = Color.Black;
            labWedSunriseVal.Location = new Point(155, 101);
            labWedSunriseVal.Margin = new Padding(4, 0, 4, 0);
            labWedSunriseVal.Name = "labWedSunriseVal";
            labWedSunriseVal.Size = new Size(53, 28);
            labWedSunriseVal.TabIndex = 86;
            labWedSunriseVal.Text = "N/A";
            // 
            // labWedSunsetVal
            // 
            labWedSunsetVal.AutoSize = true;
            labWedSunsetVal.BackColor = Color.Transparent;
            labWedSunsetVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedSunsetVal.ForeColor = Color.Black;
            labWedSunsetVal.Location = new Point(155, 146);
            labWedSunsetVal.Margin = new Padding(4, 0, 4, 0);
            labWedSunsetVal.Name = "labWedSunsetVal";
            labWedSunsetVal.Size = new Size(53, 28);
            labWedSunsetVal.TabIndex = 87;
            labWedSunsetVal.Text = "N/A";
            // 
            // labWedMinTemp
            // 
            labWedMinTemp.AutoSize = true;
            labWedMinTemp.BackColor = Color.Transparent;
            labWedMinTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedMinTemp.ForeColor = Color.Black;
            labWedMinTemp.Location = new Point(302, 14);
            labWedMinTemp.Margin = new Padding(4, 0, 4, 0);
            labWedMinTemp.Name = "labWedMinTemp";
            labWedMinTemp.Size = new Size(186, 28);
            labWedMinTemp.TabIndex = 78;
            labWedMinTemp.Text = "Минимална темп:";
            // 
            // labWedMinTempValF
            // 
            labWedMinTempValF.AutoSize = true;
            labWedMinTempValF.BackColor = Color.Transparent;
            labWedMinTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labWedMinTempValF.ForeColor = Color.Black;
            labWedMinTempValF.Location = new Point(557, 5);
            labWedMinTempValF.Margin = new Padding(4, 0, 4, 0);
            labWedMinTempValF.Name = "labWedMinTempValF";
            labWedMinTempValF.Size = new Size(34, 18);
            labWedMinTempValF.TabIndex = 83;
            labWedMinTempValF.Text = "N/A";
            // 
            // labWedMaxTemp
            // 
            labWedMaxTemp.AutoSize = true;
            labWedMaxTemp.BackColor = Color.Transparent;
            labWedMaxTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedMaxTemp.ForeColor = Color.Black;
            labWedMaxTemp.Location = new Point(302, 67);
            labWedMaxTemp.Margin = new Padding(4, 0, 4, 0);
            labWedMaxTemp.Name = "labWedMaxTemp";
            labWedMaxTemp.Size = new Size(192, 28);
            labWedMaxTemp.TabIndex = 79;
            labWedMaxTemp.Text = "Максимална темп:";
            // 
            // labWedMaxTempValF
            // 
            labWedMaxTempValF.AutoSize = true;
            labWedMaxTempValF.BackColor = Color.Transparent;
            labWedMaxTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labWedMaxTempValF.ForeColor = Color.Black;
            labWedMaxTempValF.Location = new Point(557, 58);
            labWedMaxTempValF.Margin = new Padding(4, 0, 4, 0);
            labWedMaxTempValF.Name = "labWedMaxTempValF";
            labWedMaxTempValF.Size = new Size(34, 18);
            labWedMaxTempValF.TabIndex = 82;
            labWedMaxTempValF.Text = "N/A";
            // 
            // labWedMinTempVal
            // 
            labWedMinTempVal.AutoSize = true;
            labWedMinTempVal.BackColor = Color.Transparent;
            labWedMinTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedMinTempVal.ForeColor = Color.Black;
            labWedMinTempVal.Location = new Point(496, 14);
            labWedMinTempVal.Margin = new Padding(4, 0, 4, 0);
            labWedMinTempVal.Name = "labWedMinTempVal";
            labWedMinTempVal.Size = new Size(53, 28);
            labWedMinTempVal.TabIndex = 80;
            labWedMinTempVal.Text = "N/A";
            // 
            // labWedMaxTempVal
            // 
            labWedMaxTempVal.AutoSize = true;
            labWedMaxTempVal.BackColor = Color.Transparent;
            labWedMaxTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedMaxTempVal.ForeColor = Color.Black;
            labWedMaxTempVal.Location = new Point(496, 67);
            labWedMaxTempVal.Margin = new Padding(4, 0, 4, 0);
            labWedMaxTempVal.Name = "labWedMaxTempVal";
            labWedMaxTempVal.Size = new Size(53, 28);
            labWedMaxTempVal.TabIndex = 81;
            labWedMaxTempVal.Text = "N/A";
            // 
            // labWedTempValF
            // 
            labWedTempValF.AutoSize = true;
            labWedTempValF.BackColor = Color.Transparent;
            labWedTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labWedTempValF.ForeColor = Color.Black;
            labWedTempValF.Location = new Point(216, 11);
            labWedTempValF.Margin = new Padding(4, 0, 4, 0);
            labWedTempValF.Name = "labWedTempValF";
            labWedTempValF.Size = new Size(34, 18);
            labWedTempValF.TabIndex = 45;
            labWedTempValF.Text = "N/A";
            // 
            // labWedTempVal
            // 
            labWedTempVal.AutoSize = true;
            labWedTempVal.BackColor = Color.Transparent;
            labWedTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWedTempVal.ForeColor = Color.Black;
            labWedTempVal.Location = new Point(155, 20);
            labWedTempVal.Margin = new Padding(4, 0, 4, 0);
            labWedTempVal.Name = "labWedTempVal";
            labWedTempVal.Size = new Size(53, 28);
            labWedTempVal.TabIndex = 44;
            labWedTempVal.Text = "N/A";
            // 
            // labTempWednesday
            // 
            labTempWednesday.AutoSize = true;
            labTempWednesday.BackColor = Color.Transparent;
            labTempWednesday.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTempWednesday.ForeColor = Color.Black;
            labTempWednesday.Location = new Point(4, 20);
            labTempWednesday.Margin = new Padding(4, 0, 4, 0);
            labTempWednesday.Name = "labTempWednesday";
            labTempWednesday.Size = new Size(143, 28);
            labTempWednesday.TabIndex = 43;
            labTempWednesday.Text = "Температура:";
            // 
            // tabPageThursday
            // 
            tabPageThursday.Controls.Add(thuFLP);
            tabPageThursday.Controls.Add(labThuPrecipitation);
            tabPageThursday.Controls.Add(labThuPrecipitationVal);
            tabPageThursday.Controls.Add(labThuSpeed);
            tabPageThursday.Controls.Add(labThuSpeedVal);
            tabPageThursday.Controls.Add(labThuSunrise);
            tabPageThursday.Controls.Add(labThuSunset);
            tabPageThursday.Controls.Add(labThuSunriseVal);
            tabPageThursday.Controls.Add(labThuSunsetVal);
            tabPageThursday.Controls.Add(labThuMinTemp);
            tabPageThursday.Controls.Add(labThuMinTempValF);
            tabPageThursday.Controls.Add(labThuMaxTemp);
            tabPageThursday.Controls.Add(labThuMaxTempValF);
            tabPageThursday.Controls.Add(labThuMinTempVal);
            tabPageThursday.Controls.Add(labThuMaxTempVal);
            tabPageThursday.Controls.Add(labThuTempValF);
            tabPageThursday.Controls.Add(labThuTempVal);
            tabPageThursday.Controls.Add(labTempThursday);
            tabPageThursday.Location = new Point(4, 29);
            tabPageThursday.Name = "tabPageThursday";
            tabPageThursday.Size = new Size(689, 448);
            tabPageThursday.TabIndex = 3;
            tabPageThursday.Text = "Четвъртък";
            tabPageThursday.UseVisualStyleBackColor = true;
            // 
            // thuFLP
            // 
            thuFLP.AutoScroll = true;
            thuFLP.Location = new Point(8, 237);
            thuFLP.Name = "thuFLP";
            thuFLP.Size = new Size(624, 186);
            thuFLP.TabIndex = 78;
            thuFLP.WrapContents = false;
            // 
            // labThuPrecipitation
            // 
            labThuPrecipitation.AutoSize = true;
            labThuPrecipitation.BackColor = Color.Transparent;
            labThuPrecipitation.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuPrecipitation.ForeColor = Color.Black;
            labThuPrecipitation.Location = new Point(8, 58);
            labThuPrecipitation.Margin = new Padding(4, 0, 4, 0);
            labThuPrecipitation.Name = "labThuPrecipitation";
            labThuPrecipitation.Size = new Size(86, 28);
            labThuPrecipitation.TabIndex = 76;
            labThuPrecipitation.Text = "Валежи";
            // 
            // labThuPrecipitationVal
            // 
            labThuPrecipitationVal.AutoSize = true;
            labThuPrecipitationVal.BackColor = Color.Transparent;
            labThuPrecipitationVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuPrecipitationVal.ForeColor = Color.Black;
            labThuPrecipitationVal.Location = new Point(155, 58);
            labThuPrecipitationVal.Margin = new Padding(4, 0, 4, 0);
            labThuPrecipitationVal.Name = "labThuPrecipitationVal";
            labThuPrecipitationVal.Size = new Size(53, 28);
            labThuPrecipitationVal.TabIndex = 77;
            labThuPrecipitationVal.Text = "N/A";
            // 
            // labThuSpeed
            // 
            labThuSpeed.AutoSize = true;
            labThuSpeed.BackColor = Color.Transparent;
            labThuSpeed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuSpeed.ForeColor = Color.Black;
            labThuSpeed.Location = new Point(8, 189);
            labThuSpeed.Margin = new Padding(4, 0, 4, 0);
            labThuSpeed.Name = "labThuSpeed";
            labThuSpeed.Size = new Size(168, 28);
            labThuSpeed.TabIndex = 72;
            labThuSpeed.Text = "Вятърна скорост";
            // 
            // labThuSpeedVal
            // 
            labThuSpeedVal.AutoSize = true;
            labThuSpeedVal.BackColor = Color.Transparent;
            labThuSpeedVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuSpeedVal.ForeColor = Color.Black;
            labThuSpeedVal.Location = new Point(302, 189);
            labThuSpeedVal.Margin = new Padding(4, 0, 4, 0);
            labThuSpeedVal.Name = "labThuSpeedVal";
            labThuSpeedVal.Size = new Size(53, 28);
            labThuSpeedVal.TabIndex = 73;
            labThuSpeedVal.Text = "N/A";
            // 
            // labThuSunrise
            // 
            labThuSunrise.AutoSize = true;
            labThuSunrise.BackColor = Color.Transparent;
            labThuSunrise.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuSunrise.ForeColor = Color.Black;
            labThuSunrise.Location = new Point(8, 101);
            labThuSunrise.Margin = new Padding(4, 0, 4, 0);
            labThuSunrise.Name = "labThuSunrise";
            labThuSunrise.Size = new Size(77, 28);
            labThuSunrise.TabIndex = 68;
            labThuSunrise.Text = "Изгрев";
            // 
            // labThuSunset
            // 
            labThuSunset.AutoSize = true;
            labThuSunset.BackColor = Color.Transparent;
            labThuSunset.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuSunset.ForeColor = Color.Black;
            labThuSunset.Location = new Point(8, 146);
            labThuSunset.Margin = new Padding(4, 0, 4, 0);
            labThuSunset.Name = "labThuSunset";
            labThuSunset.Size = new Size(67, 28);
            labThuSunset.TabIndex = 69;
            labThuSunset.Text = "Залез";
            // 
            // labThuSunriseVal
            // 
            labThuSunriseVal.AutoSize = true;
            labThuSunriseVal.BackColor = Color.Transparent;
            labThuSunriseVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuSunriseVal.ForeColor = Color.Black;
            labThuSunriseVal.Location = new Point(155, 101);
            labThuSunriseVal.Margin = new Padding(4, 0, 4, 0);
            labThuSunriseVal.Name = "labThuSunriseVal";
            labThuSunriseVal.Size = new Size(53, 28);
            labThuSunriseVal.TabIndex = 70;
            labThuSunriseVal.Text = "N/A";
            // 
            // labThuSunsetVal
            // 
            labThuSunsetVal.AutoSize = true;
            labThuSunsetVal.BackColor = Color.Transparent;
            labThuSunsetVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuSunsetVal.ForeColor = Color.Black;
            labThuSunsetVal.Location = new Point(155, 146);
            labThuSunsetVal.Margin = new Padding(4, 0, 4, 0);
            labThuSunsetVal.Name = "labThuSunsetVal";
            labThuSunsetVal.Size = new Size(53, 28);
            labThuSunsetVal.TabIndex = 71;
            labThuSunsetVal.Text = "N/A";
            // 
            // labThuMinTemp
            // 
            labThuMinTemp.AutoSize = true;
            labThuMinTemp.BackColor = Color.Transparent;
            labThuMinTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuMinTemp.ForeColor = Color.Black;
            labThuMinTemp.Location = new Point(302, 14);
            labThuMinTemp.Margin = new Padding(4, 0, 4, 0);
            labThuMinTemp.Name = "labThuMinTemp";
            labThuMinTemp.Size = new Size(186, 28);
            labThuMinTemp.TabIndex = 62;
            labThuMinTemp.Text = "Минимална темп:";
            // 
            // labThuMinTempValF
            // 
            labThuMinTempValF.AutoSize = true;
            labThuMinTempValF.BackColor = Color.Transparent;
            labThuMinTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labThuMinTempValF.ForeColor = Color.Black;
            labThuMinTempValF.Location = new Point(557, 5);
            labThuMinTempValF.Margin = new Padding(4, 0, 4, 0);
            labThuMinTempValF.Name = "labThuMinTempValF";
            labThuMinTempValF.Size = new Size(34, 18);
            labThuMinTempValF.TabIndex = 67;
            labThuMinTempValF.Text = "N/A";
            // 
            // labThuMaxTemp
            // 
            labThuMaxTemp.AutoSize = true;
            labThuMaxTemp.BackColor = Color.Transparent;
            labThuMaxTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuMaxTemp.ForeColor = Color.Black;
            labThuMaxTemp.Location = new Point(302, 67);
            labThuMaxTemp.Margin = new Padding(4, 0, 4, 0);
            labThuMaxTemp.Name = "labThuMaxTemp";
            labThuMaxTemp.Size = new Size(192, 28);
            labThuMaxTemp.TabIndex = 63;
            labThuMaxTemp.Text = "Максимална темп:";
            // 
            // labThuMaxTempValF
            // 
            labThuMaxTempValF.AutoSize = true;
            labThuMaxTempValF.BackColor = Color.Transparent;
            labThuMaxTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labThuMaxTempValF.ForeColor = Color.Black;
            labThuMaxTempValF.Location = new Point(557, 58);
            labThuMaxTempValF.Margin = new Padding(4, 0, 4, 0);
            labThuMaxTempValF.Name = "labThuMaxTempValF";
            labThuMaxTempValF.Size = new Size(34, 18);
            labThuMaxTempValF.TabIndex = 66;
            labThuMaxTempValF.Text = "N/A";
            // 
            // labThuMinTempVal
            // 
            labThuMinTempVal.AutoSize = true;
            labThuMinTempVal.BackColor = Color.Transparent;
            labThuMinTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuMinTempVal.ForeColor = Color.Black;
            labThuMinTempVal.Location = new Point(496, 14);
            labThuMinTempVal.Margin = new Padding(4, 0, 4, 0);
            labThuMinTempVal.Name = "labThuMinTempVal";
            labThuMinTempVal.Size = new Size(53, 28);
            labThuMinTempVal.TabIndex = 64;
            labThuMinTempVal.Text = "N/A";
            // 
            // labThuMaxTempVal
            // 
            labThuMaxTempVal.AutoSize = true;
            labThuMaxTempVal.BackColor = Color.Transparent;
            labThuMaxTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuMaxTempVal.ForeColor = Color.Black;
            labThuMaxTempVal.Location = new Point(496, 67);
            labThuMaxTempVal.Margin = new Padding(4, 0, 4, 0);
            labThuMaxTempVal.Name = "labThuMaxTempVal";
            labThuMaxTempVal.Size = new Size(53, 28);
            labThuMaxTempVal.TabIndex = 65;
            labThuMaxTempVal.Text = "N/A";
            // 
            // labThuTempValF
            // 
            labThuTempValF.AutoSize = true;
            labThuTempValF.BackColor = Color.Transparent;
            labThuTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labThuTempValF.ForeColor = Color.Black;
            labThuTempValF.Location = new Point(216, 11);
            labThuTempValF.Margin = new Padding(4, 0, 4, 0);
            labThuTempValF.Name = "labThuTempValF";
            labThuTempValF.Size = new Size(34, 18);
            labThuTempValF.TabIndex = 45;
            labThuTempValF.Text = "N/A";
            // 
            // labThuTempVal
            // 
            labThuTempVal.AutoSize = true;
            labThuTempVal.BackColor = Color.Transparent;
            labThuTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labThuTempVal.ForeColor = Color.Black;
            labThuTempVal.Location = new Point(155, 20);
            labThuTempVal.Margin = new Padding(4, 0, 4, 0);
            labThuTempVal.Name = "labThuTempVal";
            labThuTempVal.Size = new Size(53, 28);
            labThuTempVal.TabIndex = 44;
            labThuTempVal.Text = "N/A";
            // 
            // labTempThursday
            // 
            labTempThursday.AutoSize = true;
            labTempThursday.BackColor = Color.Transparent;
            labTempThursday.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTempThursday.ForeColor = Color.Black;
            labTempThursday.Location = new Point(4, 20);
            labTempThursday.Margin = new Padding(4, 0, 4, 0);
            labTempThursday.Name = "labTempThursday";
            labTempThursday.Size = new Size(143, 28);
            labTempThursday.TabIndex = 43;
            labTempThursday.Text = "Температура:";
            // 
            // tabPageFriday
            // 
            tabPageFriday.Controls.Add(friFLP);
            tabPageFriday.Controls.Add(labFriPrecipitation);
            tabPageFriday.Controls.Add(labFriPrecipitationVal);
            tabPageFriday.Controls.Add(labFriSpeed);
            tabPageFriday.Controls.Add(labFriSpeedVal);
            tabPageFriday.Controls.Add(labFriSunrise);
            tabPageFriday.Controls.Add(labFriSunset);
            tabPageFriday.Controls.Add(labFriSunriseVal);
            tabPageFriday.Controls.Add(labFriSunsetVal);
            tabPageFriday.Controls.Add(labFriMinTemp);
            tabPageFriday.Controls.Add(labFriMinTempValF);
            tabPageFriday.Controls.Add(labFriMaxTemp);
            tabPageFriday.Controls.Add(labFriMaxTempValF);
            tabPageFriday.Controls.Add(labFriMinTempVal);
            tabPageFriday.Controls.Add(labFriMaxTempVal);
            tabPageFriday.Controls.Add(labFriTempValF);
            tabPageFriday.Controls.Add(labFriTempVal);
            tabPageFriday.Controls.Add(labTempFriday);
            tabPageFriday.Location = new Point(4, 29);
            tabPageFriday.Name = "tabPageFriday";
            tabPageFriday.Size = new Size(689, 448);
            tabPageFriday.TabIndex = 4;
            tabPageFriday.Text = "Петък";
            tabPageFriday.UseVisualStyleBackColor = true;
            // 
            // friFLP
            // 
            friFLP.AutoScroll = true;
            friFLP.Location = new Point(8, 237);
            friFLP.Name = "friFLP";
            friFLP.Size = new Size(624, 186);
            friFLP.TabIndex = 78;
            friFLP.TabStop = true;
            friFLP.WrapContents = false;
            // 
            // labFriPrecipitation
            // 
            labFriPrecipitation.AutoSize = true;
            labFriPrecipitation.BackColor = Color.Transparent;
            labFriPrecipitation.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriPrecipitation.ForeColor = Color.Black;
            labFriPrecipitation.Location = new Point(8, 58);
            labFriPrecipitation.Margin = new Padding(4, 0, 4, 0);
            labFriPrecipitation.Name = "labFriPrecipitation";
            labFriPrecipitation.Size = new Size(86, 28);
            labFriPrecipitation.TabIndex = 76;
            labFriPrecipitation.Text = "Валежи";
            // 
            // labFriPrecipitationVal
            // 
            labFriPrecipitationVal.AutoSize = true;
            labFriPrecipitationVal.BackColor = Color.Transparent;
            labFriPrecipitationVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriPrecipitationVal.ForeColor = Color.Black;
            labFriPrecipitationVal.Location = new Point(155, 58);
            labFriPrecipitationVal.Margin = new Padding(4, 0, 4, 0);
            labFriPrecipitationVal.Name = "labFriPrecipitationVal";
            labFriPrecipitationVal.Size = new Size(53, 28);
            labFriPrecipitationVal.TabIndex = 77;
            labFriPrecipitationVal.Text = "N/A";
            // 
            // labFriSpeed
            // 
            labFriSpeed.AutoSize = true;
            labFriSpeed.BackColor = Color.Transparent;
            labFriSpeed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriSpeed.ForeColor = Color.Black;
            labFriSpeed.Location = new Point(8, 189);
            labFriSpeed.Margin = new Padding(4, 0, 4, 0);
            labFriSpeed.Name = "labFriSpeed";
            labFriSpeed.Size = new Size(168, 28);
            labFriSpeed.TabIndex = 72;
            labFriSpeed.Text = "Вятърна скорост";
            // 
            // labFriSpeedVal
            // 
            labFriSpeedVal.AutoSize = true;
            labFriSpeedVal.BackColor = Color.Transparent;
            labFriSpeedVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriSpeedVal.ForeColor = Color.Black;
            labFriSpeedVal.Location = new Point(302, 189);
            labFriSpeedVal.Margin = new Padding(4, 0, 4, 0);
            labFriSpeedVal.Name = "labFriSpeedVal";
            labFriSpeedVal.Size = new Size(53, 28);
            labFriSpeedVal.TabIndex = 73;
            labFriSpeedVal.Text = "N/A";
            // 
            // labFriSunrise
            // 
            labFriSunrise.AutoSize = true;
            labFriSunrise.BackColor = Color.Transparent;
            labFriSunrise.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriSunrise.ForeColor = Color.Black;
            labFriSunrise.Location = new Point(8, 101);
            labFriSunrise.Margin = new Padding(4, 0, 4, 0);
            labFriSunrise.Name = "labFriSunrise";
            labFriSunrise.Size = new Size(77, 28);
            labFriSunrise.TabIndex = 68;
            labFriSunrise.Text = "Изгрев";
            // 
            // labFriSunset
            // 
            labFriSunset.AutoSize = true;
            labFriSunset.BackColor = Color.Transparent;
            labFriSunset.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriSunset.ForeColor = Color.Black;
            labFriSunset.Location = new Point(8, 146);
            labFriSunset.Margin = new Padding(4, 0, 4, 0);
            labFriSunset.Name = "labFriSunset";
            labFriSunset.Size = new Size(67, 28);
            labFriSunset.TabIndex = 69;
            labFriSunset.Text = "Залез";
            // 
            // labFriSunriseVal
            // 
            labFriSunriseVal.AutoSize = true;
            labFriSunriseVal.BackColor = Color.Transparent;
            labFriSunriseVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriSunriseVal.ForeColor = Color.Black;
            labFriSunriseVal.Location = new Point(155, 101);
            labFriSunriseVal.Margin = new Padding(4, 0, 4, 0);
            labFriSunriseVal.Name = "labFriSunriseVal";
            labFriSunriseVal.Size = new Size(53, 28);
            labFriSunriseVal.TabIndex = 70;
            labFriSunriseVal.Text = "N/A";
            // 
            // labFriSunsetVal
            // 
            labFriSunsetVal.AutoSize = true;
            labFriSunsetVal.BackColor = Color.Transparent;
            labFriSunsetVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriSunsetVal.ForeColor = Color.Black;
            labFriSunsetVal.Location = new Point(155, 146);
            labFriSunsetVal.Margin = new Padding(4, 0, 4, 0);
            labFriSunsetVal.Name = "labFriSunsetVal";
            labFriSunsetVal.Size = new Size(53, 28);
            labFriSunsetVal.TabIndex = 71;
            labFriSunsetVal.Text = "N/A";
            // 
            // labFriMinTemp
            // 
            labFriMinTemp.AutoSize = true;
            labFriMinTemp.BackColor = Color.Transparent;
            labFriMinTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriMinTemp.ForeColor = Color.Black;
            labFriMinTemp.Location = new Point(302, 14);
            labFriMinTemp.Margin = new Padding(4, 0, 4, 0);
            labFriMinTemp.Name = "labFriMinTemp";
            labFriMinTemp.Size = new Size(186, 28);
            labFriMinTemp.TabIndex = 62;
            labFriMinTemp.Text = "Минимална темп:";
            // 
            // labFriMinTempValF
            // 
            labFriMinTempValF.AutoSize = true;
            labFriMinTempValF.BackColor = Color.Transparent;
            labFriMinTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labFriMinTempValF.ForeColor = Color.Black;
            labFriMinTempValF.Location = new Point(557, 5);
            labFriMinTempValF.Margin = new Padding(4, 0, 4, 0);
            labFriMinTempValF.Name = "labFriMinTempValF";
            labFriMinTempValF.Size = new Size(34, 18);
            labFriMinTempValF.TabIndex = 67;
            labFriMinTempValF.Text = "N/A";
            // 
            // labFriMaxTemp
            // 
            labFriMaxTemp.AutoSize = true;
            labFriMaxTemp.BackColor = Color.Transparent;
            labFriMaxTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriMaxTemp.ForeColor = Color.Black;
            labFriMaxTemp.Location = new Point(302, 67);
            labFriMaxTemp.Margin = new Padding(4, 0, 4, 0);
            labFriMaxTemp.Name = "labFriMaxTemp";
            labFriMaxTemp.Size = new Size(192, 28);
            labFriMaxTemp.TabIndex = 63;
            labFriMaxTemp.Text = "Максимална темп:";
            // 
            // labFriMaxTempValF
            // 
            labFriMaxTempValF.AutoSize = true;
            labFriMaxTempValF.BackColor = Color.Transparent;
            labFriMaxTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labFriMaxTempValF.ForeColor = Color.Black;
            labFriMaxTempValF.Location = new Point(557, 58);
            labFriMaxTempValF.Margin = new Padding(4, 0, 4, 0);
            labFriMaxTempValF.Name = "labFriMaxTempValF";
            labFriMaxTempValF.Size = new Size(34, 18);
            labFriMaxTempValF.TabIndex = 66;
            labFriMaxTempValF.Text = "N/A";
            // 
            // labFriMinTempVal
            // 
            labFriMinTempVal.AutoSize = true;
            labFriMinTempVal.BackColor = Color.Transparent;
            labFriMinTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriMinTempVal.ForeColor = Color.Black;
            labFriMinTempVal.Location = new Point(496, 14);
            labFriMinTempVal.Margin = new Padding(4, 0, 4, 0);
            labFriMinTempVal.Name = "labFriMinTempVal";
            labFriMinTempVal.Size = new Size(53, 28);
            labFriMinTempVal.TabIndex = 64;
            labFriMinTempVal.Text = "N/A";
            // 
            // labFriMaxTempVal
            // 
            labFriMaxTempVal.AutoSize = true;
            labFriMaxTempVal.BackColor = Color.Transparent;
            labFriMaxTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriMaxTempVal.ForeColor = Color.Black;
            labFriMaxTempVal.Location = new Point(496, 67);
            labFriMaxTempVal.Margin = new Padding(4, 0, 4, 0);
            labFriMaxTempVal.Name = "labFriMaxTempVal";
            labFriMaxTempVal.Size = new Size(53, 28);
            labFriMaxTempVal.TabIndex = 65;
            labFriMaxTempVal.Text = "N/A";
            // 
            // labFriTempValF
            // 
            labFriTempValF.AutoSize = true;
            labFriTempValF.BackColor = Color.Transparent;
            labFriTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labFriTempValF.ForeColor = Color.Black;
            labFriTempValF.Location = new Point(216, 11);
            labFriTempValF.Margin = new Padding(4, 0, 4, 0);
            labFriTempValF.Name = "labFriTempValF";
            labFriTempValF.Size = new Size(34, 18);
            labFriTempValF.TabIndex = 45;
            labFriTempValF.Text = "N/A";
            // 
            // labFriTempVal
            // 
            labFriTempVal.AutoSize = true;
            labFriTempVal.BackColor = Color.Transparent;
            labFriTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFriTempVal.ForeColor = Color.Black;
            labFriTempVal.Location = new Point(155, 20);
            labFriTempVal.Margin = new Padding(4, 0, 4, 0);
            labFriTempVal.Name = "labFriTempVal";
            labFriTempVal.Size = new Size(53, 28);
            labFriTempVal.TabIndex = 44;
            labFriTempVal.Text = "N/A";
            // 
            // labTempFriday
            // 
            labTempFriday.AutoSize = true;
            labTempFriday.BackColor = Color.Transparent;
            labTempFriday.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTempFriday.ForeColor = Color.Black;
            labTempFriday.Location = new Point(4, 20);
            labTempFriday.Margin = new Padding(4, 0, 4, 0);
            labTempFriday.Name = "labTempFriday";
            labTempFriday.Size = new Size(143, 28);
            labTempFriday.TabIndex = 43;
            labTempFriday.Text = "Температура:";
            // 
            // tabPageSaturday
            // 
            tabPageSaturday.Controls.Add(satFLP);
            tabPageSaturday.Controls.Add(labSatPrecipitation);
            tabPageSaturday.Controls.Add(labSatPrecipitationVal);
            tabPageSaturday.Controls.Add(labSatSpeed);
            tabPageSaturday.Controls.Add(labSatSpeedVal);
            tabPageSaturday.Controls.Add(labSatSunrise);
            tabPageSaturday.Controls.Add(labSatSunset);
            tabPageSaturday.Controls.Add(labSatSunriseVal);
            tabPageSaturday.Controls.Add(labSatSunsetVal);
            tabPageSaturday.Controls.Add(labSatMinTemp);
            tabPageSaturday.Controls.Add(labSatMinTempValF);
            tabPageSaturday.Controls.Add(labSatMaxTemp);
            tabPageSaturday.Controls.Add(labSatMaxTempValF);
            tabPageSaturday.Controls.Add(labSatMinTempVal);
            tabPageSaturday.Controls.Add(labSatMaxTempVal);
            tabPageSaturday.Controls.Add(labSatTempValF);
            tabPageSaturday.Controls.Add(labSatTempVal);
            tabPageSaturday.Controls.Add(labTempSaturday);
            tabPageSaturday.Location = new Point(4, 29);
            tabPageSaturday.Name = "tabPageSaturday";
            tabPageSaturday.Size = new Size(689, 448);
            tabPageSaturday.TabIndex = 5;
            tabPageSaturday.Text = "Събота";
            tabPageSaturday.UseVisualStyleBackColor = true;
            // 
            // satFLP
            // 
            satFLP.AutoScroll = true;
            satFLP.Location = new Point(8, 237);
            satFLP.Name = "satFLP";
            satFLP.Size = new Size(624, 186);
            satFLP.TabIndex = 78;
            satFLP.WrapContents = false;
            // 
            // labSatPrecipitation
            // 
            labSatPrecipitation.AutoSize = true;
            labSatPrecipitation.BackColor = Color.Transparent;
            labSatPrecipitation.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatPrecipitation.ForeColor = Color.Black;
            labSatPrecipitation.Location = new Point(8, 58);
            labSatPrecipitation.Margin = new Padding(4, 0, 4, 0);
            labSatPrecipitation.Name = "labSatPrecipitation";
            labSatPrecipitation.Size = new Size(86, 28);
            labSatPrecipitation.TabIndex = 76;
            labSatPrecipitation.Text = "Валежи";
            // 
            // labSatPrecipitationVal
            // 
            labSatPrecipitationVal.AutoSize = true;
            labSatPrecipitationVal.BackColor = Color.Transparent;
            labSatPrecipitationVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatPrecipitationVal.ForeColor = Color.Black;
            labSatPrecipitationVal.Location = new Point(155, 58);
            labSatPrecipitationVal.Margin = new Padding(4, 0, 4, 0);
            labSatPrecipitationVal.Name = "labSatPrecipitationVal";
            labSatPrecipitationVal.Size = new Size(53, 28);
            labSatPrecipitationVal.TabIndex = 77;
            labSatPrecipitationVal.Text = "N/A";
            // 
            // labSatSpeed
            // 
            labSatSpeed.AutoSize = true;
            labSatSpeed.BackColor = Color.Transparent;
            labSatSpeed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatSpeed.ForeColor = Color.Black;
            labSatSpeed.Location = new Point(8, 189);
            labSatSpeed.Margin = new Padding(4, 0, 4, 0);
            labSatSpeed.Name = "labSatSpeed";
            labSatSpeed.Size = new Size(168, 28);
            labSatSpeed.TabIndex = 72;
            labSatSpeed.Text = "Вятърна скорост";
            // 
            // labSatSpeedVal
            // 
            labSatSpeedVal.AutoSize = true;
            labSatSpeedVal.BackColor = Color.Transparent;
            labSatSpeedVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatSpeedVal.ForeColor = Color.Black;
            labSatSpeedVal.Location = new Point(302, 189);
            labSatSpeedVal.Margin = new Padding(4, 0, 4, 0);
            labSatSpeedVal.Name = "labSatSpeedVal";
            labSatSpeedVal.Size = new Size(53, 28);
            labSatSpeedVal.TabIndex = 73;
            labSatSpeedVal.Text = "N/A";
            // 
            // labSatSunrise
            // 
            labSatSunrise.AutoSize = true;
            labSatSunrise.BackColor = Color.Transparent;
            labSatSunrise.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatSunrise.ForeColor = Color.Black;
            labSatSunrise.Location = new Point(8, 101);
            labSatSunrise.Margin = new Padding(4, 0, 4, 0);
            labSatSunrise.Name = "labSatSunrise";
            labSatSunrise.Size = new Size(77, 28);
            labSatSunrise.TabIndex = 68;
            labSatSunrise.Text = "Изгрев";
            // 
            // labSatSunset
            // 
            labSatSunset.AutoSize = true;
            labSatSunset.BackColor = Color.Transparent;
            labSatSunset.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatSunset.ForeColor = Color.Black;
            labSatSunset.Location = new Point(8, 146);
            labSatSunset.Margin = new Padding(4, 0, 4, 0);
            labSatSunset.Name = "labSatSunset";
            labSatSunset.Size = new Size(67, 28);
            labSatSunset.TabIndex = 69;
            labSatSunset.Text = "Залез";
            // 
            // labSatSunriseVal
            // 
            labSatSunriseVal.AutoSize = true;
            labSatSunriseVal.BackColor = Color.Transparent;
            labSatSunriseVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatSunriseVal.ForeColor = Color.Black;
            labSatSunriseVal.Location = new Point(155, 101);
            labSatSunriseVal.Margin = new Padding(4, 0, 4, 0);
            labSatSunriseVal.Name = "labSatSunriseVal";
            labSatSunriseVal.Size = new Size(53, 28);
            labSatSunriseVal.TabIndex = 70;
            labSatSunriseVal.Text = "N/A";
            // 
            // labSatSunsetVal
            // 
            labSatSunsetVal.AutoSize = true;
            labSatSunsetVal.BackColor = Color.Transparent;
            labSatSunsetVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatSunsetVal.ForeColor = Color.Black;
            labSatSunsetVal.Location = new Point(155, 146);
            labSatSunsetVal.Margin = new Padding(4, 0, 4, 0);
            labSatSunsetVal.Name = "labSatSunsetVal";
            labSatSunsetVal.Size = new Size(53, 28);
            labSatSunsetVal.TabIndex = 71;
            labSatSunsetVal.Text = "N/A";
            // 
            // labSatMinTemp
            // 
            labSatMinTemp.AutoSize = true;
            labSatMinTemp.BackColor = Color.Transparent;
            labSatMinTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatMinTemp.ForeColor = Color.Black;
            labSatMinTemp.Location = new Point(302, 14);
            labSatMinTemp.Margin = new Padding(4, 0, 4, 0);
            labSatMinTemp.Name = "labSatMinTemp";
            labSatMinTemp.Size = new Size(186, 28);
            labSatMinTemp.TabIndex = 62;
            labSatMinTemp.Text = "Минимална темп:";
            // 
            // labSatMinTempValF
            // 
            labSatMinTempValF.AutoSize = true;
            labSatMinTempValF.BackColor = Color.Transparent;
            labSatMinTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSatMinTempValF.ForeColor = Color.Black;
            labSatMinTempValF.Location = new Point(557, 5);
            labSatMinTempValF.Margin = new Padding(4, 0, 4, 0);
            labSatMinTempValF.Name = "labSatMinTempValF";
            labSatMinTempValF.Size = new Size(34, 18);
            labSatMinTempValF.TabIndex = 67;
            labSatMinTempValF.Text = "N/A";
            // 
            // labSatMaxTemp
            // 
            labSatMaxTemp.AutoSize = true;
            labSatMaxTemp.BackColor = Color.Transparent;
            labSatMaxTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatMaxTemp.ForeColor = Color.Black;
            labSatMaxTemp.Location = new Point(302, 67);
            labSatMaxTemp.Margin = new Padding(4, 0, 4, 0);
            labSatMaxTemp.Name = "labSatMaxTemp";
            labSatMaxTemp.Size = new Size(192, 28);
            labSatMaxTemp.TabIndex = 63;
            labSatMaxTemp.Text = "Максимална темп:";
            // 
            // labSatMaxTempValF
            // 
            labSatMaxTempValF.AutoSize = true;
            labSatMaxTempValF.BackColor = Color.Transparent;
            labSatMaxTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSatMaxTempValF.ForeColor = Color.Black;
            labSatMaxTempValF.Location = new Point(557, 58);
            labSatMaxTempValF.Margin = new Padding(4, 0, 4, 0);
            labSatMaxTempValF.Name = "labSatMaxTempValF";
            labSatMaxTempValF.Size = new Size(34, 18);
            labSatMaxTempValF.TabIndex = 66;
            labSatMaxTempValF.Text = "N/A";
            // 
            // labSatMinTempVal
            // 
            labSatMinTempVal.AutoSize = true;
            labSatMinTempVal.BackColor = Color.Transparent;
            labSatMinTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatMinTempVal.ForeColor = Color.Black;
            labSatMinTempVal.Location = new Point(496, 14);
            labSatMinTempVal.Margin = new Padding(4, 0, 4, 0);
            labSatMinTempVal.Name = "labSatMinTempVal";
            labSatMinTempVal.Size = new Size(53, 28);
            labSatMinTempVal.TabIndex = 64;
            labSatMinTempVal.Text = "N/A";
            // 
            // labSatMaxTempVal
            // 
            labSatMaxTempVal.AutoSize = true;
            labSatMaxTempVal.BackColor = Color.Transparent;
            labSatMaxTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatMaxTempVal.ForeColor = Color.Black;
            labSatMaxTempVal.Location = new Point(496, 67);
            labSatMaxTempVal.Margin = new Padding(4, 0, 4, 0);
            labSatMaxTempVal.Name = "labSatMaxTempVal";
            labSatMaxTempVal.Size = new Size(53, 28);
            labSatMaxTempVal.TabIndex = 65;
            labSatMaxTempVal.Text = "N/A";
            // 
            // labSatTempValF
            // 
            labSatTempValF.AutoSize = true;
            labSatTempValF.BackColor = Color.Transparent;
            labSatTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSatTempValF.ForeColor = Color.Black;
            labSatTempValF.Location = new Point(216, 11);
            labSatTempValF.Margin = new Padding(4, 0, 4, 0);
            labSatTempValF.Name = "labSatTempValF";
            labSatTempValF.Size = new Size(34, 18);
            labSatTempValF.TabIndex = 45;
            labSatTempValF.Text = "N/A";
            // 
            // labSatTempVal
            // 
            labSatTempVal.AutoSize = true;
            labSatTempVal.BackColor = Color.Transparent;
            labSatTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSatTempVal.ForeColor = Color.Black;
            labSatTempVal.Location = new Point(155, 20);
            labSatTempVal.Margin = new Padding(4, 0, 4, 0);
            labSatTempVal.Name = "labSatTempVal";
            labSatTempVal.Size = new Size(53, 28);
            labSatTempVal.TabIndex = 44;
            labSatTempVal.Text = "N/A";
            // 
            // labTempSaturday
            // 
            labTempSaturday.AutoSize = true;
            labTempSaturday.BackColor = Color.Transparent;
            labTempSaturday.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTempSaturday.ForeColor = Color.Black;
            labTempSaturday.Location = new Point(4, 20);
            labTempSaturday.Margin = new Padding(4, 0, 4, 0);
            labTempSaturday.Name = "labTempSaturday";
            labTempSaturday.Size = new Size(143, 28);
            labTempSaturday.TabIndex = 43;
            labTempSaturday.Text = "Температура:";
            // 
            // tabPageSunday
            // 
            tabPageSunday.Controls.Add(sunFLP);
            tabPageSunday.Controls.Add(labSunPrecipitation);
            tabPageSunday.Controls.Add(labSunPrecipitationVal);
            tabPageSunday.Controls.Add(labSunSpeed);
            tabPageSunday.Controls.Add(labSunSpeedVal);
            tabPageSunday.Controls.Add(labSunSunrise);
            tabPageSunday.Controls.Add(labSunSunset);
            tabPageSunday.Controls.Add(labSunSunriseVal);
            tabPageSunday.Controls.Add(labSunSunsetVal);
            tabPageSunday.Controls.Add(labSunMinTemp);
            tabPageSunday.Controls.Add(labSunMinTempValF);
            tabPageSunday.Controls.Add(labSunMaxTemp);
            tabPageSunday.Controls.Add(labSunMaxTempValF);
            tabPageSunday.Controls.Add(labSunMinTempVal);
            tabPageSunday.Controls.Add(labSunMaxTempVal);
            tabPageSunday.Controls.Add(labSunTempValF);
            tabPageSunday.Controls.Add(labSunTempVal);
            tabPageSunday.Controls.Add(labTempSunday);
            tabPageSunday.Location = new Point(4, 29);
            tabPageSunday.Name = "tabPageSunday";
            tabPageSunday.Size = new Size(689, 448);
            tabPageSunday.TabIndex = 6;
            tabPageSunday.Text = "Неделя";
            tabPageSunday.UseVisualStyleBackColor = true;
            // 
            // sunFLP
            // 
            sunFLP.AutoScroll = true;
            sunFLP.Location = new Point(8, 237);
            sunFLP.Name = "sunFLP";
            sunFLP.Size = new Size(624, 186);
            sunFLP.TabIndex = 62;
            sunFLP.WrapContents = false;
            // 
            // labSunPrecipitation
            // 
            labSunPrecipitation.AutoSize = true;
            labSunPrecipitation.BackColor = Color.Transparent;
            labSunPrecipitation.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunPrecipitation.ForeColor = Color.Black;
            labSunPrecipitation.Location = new Point(8, 58);
            labSunPrecipitation.Margin = new Padding(4, 0, 4, 0);
            labSunPrecipitation.Name = "labSunPrecipitation";
            labSunPrecipitation.Size = new Size(86, 28);
            labSunPrecipitation.TabIndex = 60;
            labSunPrecipitation.Text = "Валежи";
            // 
            // labSunPrecipitationVal
            // 
            labSunPrecipitationVal.AutoSize = true;
            labSunPrecipitationVal.BackColor = Color.Transparent;
            labSunPrecipitationVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunPrecipitationVal.ForeColor = Color.Black;
            labSunPrecipitationVal.Location = new Point(155, 58);
            labSunPrecipitationVal.Margin = new Padding(4, 0, 4, 0);
            labSunPrecipitationVal.Name = "labSunPrecipitationVal";
            labSunPrecipitationVal.Size = new Size(53, 28);
            labSunPrecipitationVal.TabIndex = 61;
            labSunPrecipitationVal.Text = "N/A";
            // 
            // labSunSpeed
            // 
            labSunSpeed.AutoSize = true;
            labSunSpeed.BackColor = Color.Transparent;
            labSunSpeed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunSpeed.ForeColor = Color.Black;
            labSunSpeed.Location = new Point(8, 189);
            labSunSpeed.Margin = new Padding(4, 0, 4, 0);
            labSunSpeed.Name = "labSunSpeed";
            labSunSpeed.Size = new Size(168, 28);
            labSunSpeed.TabIndex = 56;
            labSunSpeed.Text = "Вятърна скорост";
            // 
            // labSunSpeedVal
            // 
            labSunSpeedVal.AutoSize = true;
            labSunSpeedVal.BackColor = Color.Transparent;
            labSunSpeedVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunSpeedVal.ForeColor = Color.Black;
            labSunSpeedVal.Location = new Point(302, 189);
            labSunSpeedVal.Margin = new Padding(4, 0, 4, 0);
            labSunSpeedVal.Name = "labSunSpeedVal";
            labSunSpeedVal.Size = new Size(53, 28);
            labSunSpeedVal.TabIndex = 57;
            labSunSpeedVal.Text = "N/A";
            // 
            // labSunSunrise
            // 
            labSunSunrise.AutoSize = true;
            labSunSunrise.BackColor = Color.Transparent;
            labSunSunrise.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunSunrise.ForeColor = Color.Black;
            labSunSunrise.Location = new Point(8, 101);
            labSunSunrise.Margin = new Padding(4, 0, 4, 0);
            labSunSunrise.Name = "labSunSunrise";
            labSunSunrise.Size = new Size(77, 28);
            labSunSunrise.TabIndex = 52;
            labSunSunrise.Text = "Изгрев";
            // 
            // labSunSunset
            // 
            labSunSunset.AutoSize = true;
            labSunSunset.BackColor = Color.Transparent;
            labSunSunset.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunSunset.ForeColor = Color.Black;
            labSunSunset.Location = new Point(8, 146);
            labSunSunset.Margin = new Padding(4, 0, 4, 0);
            labSunSunset.Name = "labSunSunset";
            labSunSunset.Size = new Size(67, 28);
            labSunSunset.TabIndex = 53;
            labSunSunset.Text = "Залез";
            // 
            // labSunSunriseVal
            // 
            labSunSunriseVal.AutoSize = true;
            labSunSunriseVal.BackColor = Color.Transparent;
            labSunSunriseVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunSunriseVal.ForeColor = Color.Black;
            labSunSunriseVal.Location = new Point(155, 101);
            labSunSunriseVal.Margin = new Padding(4, 0, 4, 0);
            labSunSunriseVal.Name = "labSunSunriseVal";
            labSunSunriseVal.Size = new Size(53, 28);
            labSunSunriseVal.TabIndex = 54;
            labSunSunriseVal.Text = "N/A";
            // 
            // labSunSunsetVal
            // 
            labSunSunsetVal.AutoSize = true;
            labSunSunsetVal.BackColor = Color.Transparent;
            labSunSunsetVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunSunsetVal.ForeColor = Color.Black;
            labSunSunsetVal.Location = new Point(155, 146);
            labSunSunsetVal.Margin = new Padding(4, 0, 4, 0);
            labSunSunsetVal.Name = "labSunSunsetVal";
            labSunSunsetVal.Size = new Size(53, 28);
            labSunSunsetVal.TabIndex = 55;
            labSunSunsetVal.Text = "N/A";
            // 
            // labSunMinTemp
            // 
            labSunMinTemp.AutoSize = true;
            labSunMinTemp.BackColor = Color.Transparent;
            labSunMinTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunMinTemp.ForeColor = Color.Black;
            labSunMinTemp.Location = new Point(302, 14);
            labSunMinTemp.Margin = new Padding(4, 0, 4, 0);
            labSunMinTemp.Name = "labSunMinTemp";
            labSunMinTemp.Size = new Size(186, 28);
            labSunMinTemp.TabIndex = 46;
            labSunMinTemp.Text = "Минимална темп:";
            // 
            // labSunMinTempValF
            // 
            labSunMinTempValF.AutoSize = true;
            labSunMinTempValF.BackColor = Color.Transparent;
            labSunMinTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSunMinTempValF.ForeColor = Color.Black;
            labSunMinTempValF.Location = new Point(557, 5);
            labSunMinTempValF.Margin = new Padding(4, 0, 4, 0);
            labSunMinTempValF.Name = "labSunMinTempValF";
            labSunMinTempValF.Size = new Size(34, 18);
            labSunMinTempValF.TabIndex = 51;
            labSunMinTempValF.Text = "N/A";
            // 
            // labSunMaxTemp
            // 
            labSunMaxTemp.AutoSize = true;
            labSunMaxTemp.BackColor = Color.Transparent;
            labSunMaxTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunMaxTemp.ForeColor = Color.Black;
            labSunMaxTemp.Location = new Point(302, 67);
            labSunMaxTemp.Margin = new Padding(4, 0, 4, 0);
            labSunMaxTemp.Name = "labSunMaxTemp";
            labSunMaxTemp.Size = new Size(192, 28);
            labSunMaxTemp.TabIndex = 47;
            labSunMaxTemp.Text = "Максимална темп:";
            // 
            // labSunMaxTempValF
            // 
            labSunMaxTempValF.AutoSize = true;
            labSunMaxTempValF.BackColor = Color.Transparent;
            labSunMaxTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSunMaxTempValF.ForeColor = Color.Black;
            labSunMaxTempValF.Location = new Point(557, 58);
            labSunMaxTempValF.Margin = new Padding(4, 0, 4, 0);
            labSunMaxTempValF.Name = "labSunMaxTempValF";
            labSunMaxTempValF.Size = new Size(34, 18);
            labSunMaxTempValF.TabIndex = 50;
            labSunMaxTempValF.Text = "N/A";
            // 
            // labSunMinTempVal
            // 
            labSunMinTempVal.AutoSize = true;
            labSunMinTempVal.BackColor = Color.Transparent;
            labSunMinTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunMinTempVal.ForeColor = Color.Black;
            labSunMinTempVal.Location = new Point(496, 14);
            labSunMinTempVal.Margin = new Padding(4, 0, 4, 0);
            labSunMinTempVal.Name = "labSunMinTempVal";
            labSunMinTempVal.Size = new Size(53, 28);
            labSunMinTempVal.TabIndex = 48;
            labSunMinTempVal.Text = "N/A";
            // 
            // labSunMaxTempVal
            // 
            labSunMaxTempVal.AutoSize = true;
            labSunMaxTempVal.BackColor = Color.Transparent;
            labSunMaxTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunMaxTempVal.ForeColor = Color.Black;
            labSunMaxTempVal.Location = new Point(496, 67);
            labSunMaxTempVal.Margin = new Padding(4, 0, 4, 0);
            labSunMaxTempVal.Name = "labSunMaxTempVal";
            labSunMaxTempVal.Size = new Size(53, 28);
            labSunMaxTempVal.TabIndex = 49;
            labSunMaxTempVal.Text = "N/A";
            // 
            // labSunTempValF
            // 
            labSunTempValF.AutoSize = true;
            labSunTempValF.BackColor = Color.Transparent;
            labSunTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSunTempValF.ForeColor = Color.Black;
            labSunTempValF.Location = new Point(216, 11);
            labSunTempValF.Margin = new Padding(4, 0, 4, 0);
            labSunTempValF.Name = "labSunTempValF";
            labSunTempValF.Size = new Size(34, 18);
            labSunTempValF.TabIndex = 45;
            labSunTempValF.Text = "N/A";
            // 
            // labSunTempVal
            // 
            labSunTempVal.AutoSize = true;
            labSunTempVal.BackColor = Color.Transparent;
            labSunTempVal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunTempVal.ForeColor = Color.Black;
            labSunTempVal.Location = new Point(155, 20);
            labSunTempVal.Margin = new Padding(4, 0, 4, 0);
            labSunTempVal.Name = "labSunTempVal";
            labSunTempVal.Size = new Size(53, 28);
            labSunTempVal.TabIndex = 44;
            labSunTempVal.Text = "N/A";
            // 
            // labTempSunday
            // 
            labTempSunday.AutoSize = true;
            labTempSunday.BackColor = Color.Transparent;
            labTempSunday.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTempSunday.ForeColor = Color.Black;
            labTempSunday.Location = new Point(4, 20);
            labTempSunday.Margin = new Padding(4, 0, 4, 0);
            labTempSunday.Name = "labTempSunday";
            labTempSunday.Size = new Size(143, 28);
            labTempSunday.TabIndex = 43;
            labTempSunday.Text = "Температура:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labWindSpeed);
            tabPage1.Controls.Add(labWindSpeedValue);
            tabPage1.Controls.Add(labPressure);
            tabPage1.Controls.Add(labPressureValue);
            tabPage1.Controls.Add(labMinTemp);
            tabPage1.Controls.Add(labFeelsLikeFahr);
            tabPage1.Controls.Add(labMinTempFahr);
            tabPage1.Controls.Add(labTempFahr);
            tabPage1.Controls.Add(labTempValue);
            tabPage1.Controls.Add(labMaxTemp);
            tabPage1.Controls.Add(labFeelsLikeValue);
            tabPage1.Controls.Add(labDateTime);
            tabPage1.Controls.Add(labMaxTempFahr);
            tabPage1.Controls.Add(labFeelsLike);
            tabPage1.Controls.Add(labMinTempValue);
            tabPage1.Controls.Add(labTemp);
            tabPage1.Controls.Add(labMaxTempValue);
            tabPage1.Controls.Add(labCondition);
            tabPage1.Controls.Add(picIcon);
            tabPage1.Controls.Add(labDetails);
            tabPage1.Controls.Add(labSunrise);
            tabPage1.Controls.Add(labSunset);
            tabPage1.Controls.Add(labSunriseValue);
            tabPage1.Controls.Add(labSunsetValue);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(888, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сегашно време";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labWindSpeed
            // 
            labWindSpeed.AutoSize = true;
            labWindSpeed.BackColor = Color.Transparent;
            labWindSpeed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWindSpeed.ForeColor = Color.Black;
            labWindSpeed.Location = new Point(26, 378);
            labWindSpeed.Margin = new Padding(4, 0, 4, 0);
            labWindSpeed.Name = "labWindSpeed";
            labWindSpeed.Size = new Size(168, 28);
            labWindSpeed.TabIndex = 26;
            labWindSpeed.Text = "Вятърна скорост";
            // 
            // labWindSpeedValue
            // 
            labWindSpeedValue.AutoSize = true;
            labWindSpeedValue.BackColor = Color.Transparent;
            labWindSpeedValue.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labWindSpeedValue.ForeColor = Color.Black;
            labWindSpeedValue.Location = new Point(383, 378);
            labWindSpeedValue.Margin = new Padding(4, 0, 4, 0);
            labWindSpeedValue.Name = "labWindSpeedValue";
            labWindSpeedValue.Size = new Size(53, 28);
            labWindSpeedValue.TabIndex = 27;
            labWindSpeedValue.Text = "N/A";
            // 
            // labPressure
            // 
            labPressure.AutoSize = true;
            labPressure.BackColor = Color.Transparent;
            labPressure.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labPressure.ForeColor = Color.Black;
            labPressure.Location = new Point(26, 438);
            labPressure.Margin = new Padding(4, 0, 4, 0);
            labPressure.Name = "labPressure";
            labPressure.Size = new Size(224, 28);
            labPressure.TabIndex = 28;
            labPressure.Text = "Атмосферно налягане";
            // 
            // labPressureValue
            // 
            labPressureValue.AutoSize = true;
            labPressureValue.BackColor = Color.Transparent;
            labPressureValue.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labPressureValue.ForeColor = Color.Black;
            labPressureValue.Location = new Point(383, 438);
            labPressureValue.Margin = new Padding(4, 0, 4, 0);
            labPressureValue.Name = "labPressureValue";
            labPressureValue.Size = new Size(53, 28);
            labPressureValue.TabIndex = 29;
            labPressureValue.Text = "N/A";
            // 
            // labMinTemp
            // 
            labMinTemp.AutoSize = true;
            labMinTemp.BackColor = Color.Transparent;
            labMinTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMinTemp.ForeColor = Color.Black;
            labMinTemp.Location = new Point(524, 23);
            labMinTemp.Margin = new Padding(4, 0, 4, 0);
            labMinTemp.Name = "labMinTemp";
            labMinTemp.Size = new Size(186, 28);
            labMinTemp.TabIndex = 30;
            labMinTemp.Text = "Минимална темп:";
            // 
            // labFeelsLikeFahr
            // 
            labFeelsLikeFahr.AutoSize = true;
            labFeelsLikeFahr.BackColor = Color.Transparent;
            labFeelsLikeFahr.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labFeelsLikeFahr.ForeColor = Color.Black;
            labFeelsLikeFahr.Location = new Point(363, 67);
            labFeelsLikeFahr.Margin = new Padding(4, 0, 4, 0);
            labFeelsLikeFahr.Name = "labFeelsLikeFahr";
            labFeelsLikeFahr.Size = new Size(34, 18);
            labFeelsLikeFahr.TabIndex = 40;
            labFeelsLikeFahr.Text = "N/A";
            // 
            // labMinTempFahr
            // 
            labMinTempFahr.AutoSize = true;
            labMinTempFahr.BackColor = Color.Transparent;
            labMinTempFahr.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labMinTempFahr.ForeColor = Color.Black;
            labMinTempFahr.Location = new Point(779, 14);
            labMinTempFahr.Margin = new Padding(4, 0, 4, 0);
            labMinTempFahr.Name = "labMinTempFahr";
            labMinTempFahr.Size = new Size(34, 18);
            labMinTempFahr.TabIndex = 42;
            labMinTempFahr.Text = "N/A";
            // 
            // labTempFahr
            // 
            labTempFahr.AutoSize = true;
            labTempFahr.BackColor = Color.Transparent;
            labTempFahr.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labTempFahr.ForeColor = Color.Black;
            labTempFahr.Location = new Point(363, 14);
            labTempFahr.Margin = new Padding(4, 0, 4, 0);
            labTempFahr.Name = "labTempFahr";
            labTempFahr.Size = new Size(34, 18);
            labTempFahr.TabIndex = 39;
            labTempFahr.Text = "N/A";
            // 
            // labTempValue
            // 
            labTempValue.AutoSize = true;
            labTempValue.BackColor = Color.Transparent;
            labTempValue.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTempValue.ForeColor = Color.Black;
            labTempValue.Location = new Point(302, 23);
            labTempValue.Margin = new Padding(4, 0, 4, 0);
            labTempValue.Name = "labTempValue";
            labTempValue.Size = new Size(53, 28);
            labTempValue.TabIndex = 37;
            labTempValue.Text = "N/A";
            // 
            // labMaxTemp
            // 
            labMaxTemp.AutoSize = true;
            labMaxTemp.BackColor = Color.Transparent;
            labMaxTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMaxTemp.ForeColor = Color.Black;
            labMaxTemp.Location = new Point(524, 76);
            labMaxTemp.Margin = new Padding(4, 0, 4, 0);
            labMaxTemp.Name = "labMaxTemp";
            labMaxTemp.Size = new Size(192, 28);
            labMaxTemp.TabIndex = 31;
            labMaxTemp.Text = "Максимална темп:";
            // 
            // labFeelsLikeValue
            // 
            labFeelsLikeValue.AutoSize = true;
            labFeelsLikeValue.BackColor = Color.Transparent;
            labFeelsLikeValue.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFeelsLikeValue.ForeColor = Color.Black;
            labFeelsLikeValue.Location = new Point(302, 76);
            labFeelsLikeValue.Margin = new Padding(4, 0, 4, 0);
            labFeelsLikeValue.Name = "labFeelsLikeValue";
            labFeelsLikeValue.Size = new Size(53, 28);
            labFeelsLikeValue.TabIndex = 36;
            labFeelsLikeValue.Text = "N/A";
            // 
            // labDateTime
            // 
            labDateTime.AutoSize = true;
            labDateTime.BackColor = Color.Transparent;
            labDateTime.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labDateTime.ForeColor = Color.Black;
            labDateTime.Location = new Point(524, 116);
            labDateTime.Margin = new Padding(4, 0, 4, 0);
            labDateTime.Name = "labDateTime";
            labDateTime.Size = new Size(0, 28);
            labDateTime.TabIndex = 38;
            // 
            // labMaxTempFahr
            // 
            labMaxTempFahr.AutoSize = true;
            labMaxTempFahr.BackColor = Color.Transparent;
            labMaxTempFahr.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labMaxTempFahr.ForeColor = Color.Black;
            labMaxTempFahr.Location = new Point(779, 67);
            labMaxTempFahr.Margin = new Padding(4, 0, 4, 0);
            labMaxTempFahr.Name = "labMaxTempFahr";
            labMaxTempFahr.Size = new Size(34, 18);
            labMaxTempFahr.TabIndex = 41;
            labMaxTempFahr.Text = "N/A";
            // 
            // labFeelsLike
            // 
            labFeelsLike.AutoSize = true;
            labFeelsLike.BackColor = Color.Transparent;
            labFeelsLike.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labFeelsLike.ForeColor = Color.Black;
            labFeelsLike.Location = new Point(151, 76);
            labFeelsLike.Margin = new Padding(4, 0, 4, 0);
            labFeelsLike.Name = "labFeelsLike";
            labFeelsLike.Size = new Size(106, 28);
            labFeelsLike.TabIndex = 35;
            labFeelsLike.Text = "Feels like ";
            // 
            // labMinTempValue
            // 
            labMinTempValue.AutoSize = true;
            labMinTempValue.BackColor = Color.Transparent;
            labMinTempValue.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMinTempValue.ForeColor = Color.Black;
            labMinTempValue.Location = new Point(718, 23);
            labMinTempValue.Margin = new Padding(4, 0, 4, 0);
            labMinTempValue.Name = "labMinTempValue";
            labMinTempValue.Size = new Size(53, 28);
            labMinTempValue.TabIndex = 32;
            labMinTempValue.Text = "N/A";
            // 
            // labTemp
            // 
            labTemp.AutoSize = true;
            labTemp.BackColor = Color.Transparent;
            labTemp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTemp.ForeColor = Color.Black;
            labTemp.Location = new Point(151, 23);
            labTemp.Margin = new Padding(4, 0, 4, 0);
            labTemp.Name = "labTemp";
            labTemp.Size = new Size(143, 28);
            labTemp.TabIndex = 34;
            labTemp.Text = "Температура:";
            // 
            // labMaxTempValue
            // 
            labMaxTempValue.AutoSize = true;
            labMaxTempValue.BackColor = Color.Transparent;
            labMaxTempValue.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labMaxTempValue.ForeColor = Color.Black;
            labMaxTempValue.Location = new Point(718, 76);
            labMaxTempValue.Margin = new Padding(4, 0, 4, 0);
            labMaxTempValue.Name = "labMaxTempValue";
            labMaxTempValue.Size = new Size(53, 28);
            labMaxTempValue.TabIndex = 33;
            labMaxTempValue.Text = "N/A";
            // 
            // labCondition
            // 
            labCondition.AutoSize = true;
            labCondition.BackColor = Color.Transparent;
            labCondition.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labCondition.ForeColor = Color.Black;
            labCondition.Location = new Point(26, 139);
            labCondition.Margin = new Padding(4, 0, 4, 0);
            labCondition.Name = "labCondition";
            labCondition.Size = new Size(85, 28);
            labCondition.TabIndex = 12;
            labCondition.Text = "Време: ";
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.Transparent;
            picIcon.BorderStyle = BorderStyle.FixedSingle;
            picIcon.Location = new Point(26, 23);
            picIcon.Margin = new Padding(4, 6, 4, 6);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(67, 60);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 13;
            picIcon.TabStop = false;
            // 
            // labDetails
            // 
            labDetails.AutoSize = true;
            labDetails.BackColor = Color.Transparent;
            labDetails.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labDetails.ForeColor = Color.Black;
            labDetails.Location = new Point(26, 199);
            labDetails.Margin = new Padding(4, 0, 4, 0);
            labDetails.Name = "labDetails";
            labDetails.Size = new Size(67, 28);
            labDetails.TabIndex = 3;
            labDetails.Text = "Още: ";
            labDetails.Click += labDetails_Click;
            // 
            // labSunrise
            // 
            labSunrise.AutoSize = true;
            labSunrise.BackColor = Color.Transparent;
            labSunrise.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunrise.ForeColor = Color.Black;
            labSunrise.Location = new Point(26, 258);
            labSunrise.Margin = new Padding(4, 0, 4, 0);
            labSunrise.Name = "labSunrise";
            labSunrise.Size = new Size(77, 28);
            labSunrise.TabIndex = 4;
            labSunrise.Text = "Изгрев";
            labSunrise.Click += labSunrise_Click;
            // 
            // labSunset
            // 
            labSunset.AutoSize = true;
            labSunset.BackColor = Color.Transparent;
            labSunset.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunset.ForeColor = Color.Black;
            labSunset.Location = new Point(26, 322);
            labSunset.Margin = new Padding(4, 0, 4, 0);
            labSunset.Name = "labSunset";
            labSunset.Size = new Size(67, 28);
            labSunset.TabIndex = 5;
            labSunset.Text = "Залез";
            // 
            // labSunriseValue
            // 
            labSunriseValue.AutoSize = true;
            labSunriseValue.BackColor = Color.Transparent;
            labSunriseValue.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunriseValue.ForeColor = Color.Black;
            labSunriseValue.Location = new Point(151, 258);
            labSunriseValue.Margin = new Padding(4, 0, 4, 0);
            labSunriseValue.Name = "labSunriseValue";
            labSunriseValue.Size = new Size(53, 28);
            labSunriseValue.TabIndex = 6;
            labSunriseValue.Text = "N/A";
            // 
            // labSunsetValue
            // 
            labSunsetValue.AutoSize = true;
            labSunsetValue.BackColor = Color.Transparent;
            labSunsetValue.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labSunsetValue.ForeColor = Color.Black;
            labSunsetValue.Location = new Point(151, 322);
            labSunsetValue.Margin = new Padding(4, 0, 4, 0);
            labSunsetValue.Name = "labSunsetValue";
            labSunsetValue.Size = new Size(53, 28);
            labSunsetValue.TabIndex = 7;
            labSunsetValue.Text = "N/A";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(93, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(896, 564);
            tabControl1.TabIndex = 47;
            // 
            // timerForecastError
            // 
            timerForecastError.Interval = 5000;
            timerForecastError.Tick += timerForecastError_Tick;
            // 
            // Form1
            // 
            AcceptButton = btnSearch;
            AccessibleName = "WeatherApp";
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1271, 639);
            Controls.Add(tabControl1);
            Controls.Add(labErrorWeather);
            Controls.Add(labLocalTime);
            Controls.Add(labCountry);
            Controls.Add(btnSearch);
            Controls.Add(City);
            Controls.Add(labCity);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            Name = "Form1";
            Text = "Weather App";
            Load += Form1_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPageMonday.ResumeLayout(false);
            tabPageMonday.PerformLayout();
            tabPageTuesday.ResumeLayout(false);
            tabPageTuesday.PerformLayout();
            tabPageWednesday.ResumeLayout(false);
            tabPageWednesday.PerformLayout();
            tabPageThursday.ResumeLayout(false);
            tabPageThursday.PerformLayout();
            tabPageFriday.ResumeLayout(false);
            tabPageFriday.PerformLayout();
            tabPageSaturday.ResumeLayout(false);
            tabPageSaturday.PerformLayout();
            tabPageSunday.ResumeLayout(false);
            tabPageSunday.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label labCity;
        private TextBox City;
        private Button btnSearch;
        private Label labCountry;
        private Label labLocalTime;
        private Label labErrorWeather;
        private System.Windows.Forms.Timer timerErrorWeather;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPageMonday;
        private Label labMonPrecipitation;
        private Label labMonPrecipitationVal;
        private Label labMonSpeed;
        private Label labMonSpeedVal;
        private Label labMonSunrise;
        private Label labMonSunset;
        private Label labMonSunriseVal;
        private Label labMonSunsetVal;
        private Label labMonMinTemp;
        private Label labMonMinTempValF;
        private Label labMonMaxTemp;
        private Label labMonMaxTempValF;
        private Label labMonMinTempVal;
        private Label labMonMaxTempVal;
        private Label labMonTempValF;
        private Label labMonTempVal;
        private Label labTempMonday;
        private TabPage tabPageTuesday;
        private Label labTuePrecipitation;
        private Label labTuePrecipitationVal;
        private Label labTueSpeed;
        private Label labTueSpeedVal;
        private Label labTueSunrise;
        private Label labTueSunset;
        private Label labTueSunriseVal;
        private Label labTueSunsetVal;
        private Label labTueMinTemp;
        private Label labTueMinTempValF;
        private Label labTueMaxTemp;
        private Label labTueMaxTempValF;
        private Label labTueMinTempVal;
        private Label labTueMaxTempVal;
        private Label labTueTempValF;
        private Label labTueTempVal;
        private Label labTempTuesday;
        private TabPage tabPageWednesday;
        private Label labWedPrecipitation;
        private Label labWedPrecipitationVal;
        private Label labWedSpeed;
        private Label labWedSpeedVal;
        private Label labWedSunrise;
        private Label labWedSunset;
        private Label labWedSunriseVal;
        private Label labWedSunsetVal;
        private Label labWedMinTemp;
        private Label labWedMinTempValF;
        private Label labWedMaxTemp;
        private Label labWedMaxTempValF;
        private Label labWedMinTempVal;
        private Label labWedMaxTempVal;
        private Label labWedTempValF;
        private Label labWedTempVal;
        private Label labTempWednesday;
        private TabPage tabPageThursday;
        private Label labThuPrecipitation;
        private Label labThuPrecipitationVal;
        private Label labThuSpeed;
        private Label labThuSpeedVal;
        private Label labThuSunrise;
        private Label labThuSunset;
        private Label labThuSunriseVal;
        private Label labThuSunsetVal;
        private Label labThuMinTemp;
        private Label labThuMinTempValF;
        private Label labThuMaxTemp;
        private Label labThuMaxTempValF;
        private Label labThuMinTempVal;
        private Label labThuMaxTempVal;
        private Label labThuTempValF;
        private Label labThuTempVal;
        private Label labTempThursday;
        private TabPage tabPageFriday;
        private Label labFriPrecipitation;
        private Label labFriPrecipitationVal;
        private Label labFriSpeed;
        private Label labFriSpeedVal;
        private Label labFriSunrise;
        private Label labFriSunset;
        private Label labFriSunriseVal;
        private Label labFriSunsetVal;
        private Label labFriMinTemp;
        private Label labFriMinTempValF;
        private Label labFriMaxTemp;
        private Label labFriMaxTempValF;
        private Label labFriMinTempVal;
        private Label labFriMaxTempVal;
        private Label labFriTempValF;
        private Label labFriTempVal;
        private Label labTempFriday;
        private TabPage tabPageSaturday;
        private Label labSatPrecipitation;
        private Label labSatPrecipitationVal;
        private Label labSatSpeed;
        private Label labSatSpeedVal;
        private Label labSatSunrise;
        private Label labSatSunset;
        private Label labSatSunriseVal;
        private Label labSatSunsetVal;
        private Label labSatMinTemp;
        private Label labSatMinTempValF;
        private Label labSatMaxTemp;
        private Label labSatMaxTempValF;
        private Label labSatMinTempVal;
        private Label labSatMaxTempVal;
        private Label labSatTempValF;
        private Label labSatTempVal;
        private Label labTempSaturday;
        private TabPage tabPageSunday;
        private Label labSunPrecipitation;
        private Label labSunPrecipitationVal;
        private Label labSunSpeed;
        private Label labSunSpeedVal;
        private Label labSunSunrise;
        private Label labSunSunset;
        private Label labSunSunriseVal;
        private Label labSunSunsetVal;
        private Label labSunMinTemp;
        private Label labSunMinTempValF;
        private Label labSunMaxTemp;
        private Label labSunMaxTempValF;
        private Label labSunMinTempVal;
        private Label labSunMaxTempVal;
        private Label labSunTempValF;
        private Label labSunTempVal;
        private Label labTempSunday;
        private TabPage tabPage1;
        private Label labWindSpeed;
        private Label labWindSpeedValue;
        private Label labPressure;
        private Label labPressureValue;
        private Label labMinTemp;
        private Label labFeelsLikeFahr;
        private Label labMinTempFahr;
        private Label labTempFahr;
        private Label labTempValue;
        private Label labMaxTemp;
        private Label labFeelsLikeValue;
        private Label labDateTime;
        private Label labMaxTempFahr;
        private Label labFeelsLike;
        private Label labMinTempValue;
        private Label labTemp;
        private Label labMaxTempValue;
        private Label labCondition;
        private PictureBox picIcon;
        private Label labDetails;
        private Label labSunrise;
        private Label labSunset;
        private Label labSunriseValue;
        private Label labSunsetValue;
        private TabControl tabControl1;
        private FlowLayoutPanel monFLP;
        private FlowLayoutPanel tueFLP;
        private FlowLayoutPanel wedFLP;
        private FlowLayoutPanel thuFLP;
        private FlowLayoutPanel friFLP;
        private FlowLayoutPanel satFLP;
        private FlowLayoutPanel sunFLP;
        private Label labForecastError;
        private System.Windows.Forms.Timer timerForecastError;
    }
}