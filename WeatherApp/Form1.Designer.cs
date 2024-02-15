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
            labDetails = new Label();
            labSunrise = new Label();
            labSunset = new Label();
            labSunriseValue = new Label();
            labSunsetValue = new Label();
            labCondition = new Label();
            picIcon = new PictureBox();
            labCountry = new Label();
            labMaxTempValue = new Label();
            labMinTempValue = new Label();
            labMaxTemp = new Label();
            labMinTemp = new Label();
            labPressureValue = new Label();
            labPressure = new Label();
            labWindSpeedValue = new Label();
            labWindSpeed = new Label();
            labTempValue = new Label();
            labFeelsLikeValue = new Label();
            labFeelsLike = new Label();
            labTemp = new Label();
            labDateTime = new Label();
            labTempFahr = new Label();
            labFeelsLikeFahr = new Label();
            labMaxTempFahr = new Label();
            labMinTempFahr = new Label();
            labLocalTime = new Label();
            labErrorWeather = new Label();
            timerErrorWeather = new System.Windows.Forms.Timer(components);
            labErrorForecast = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl2 = new TabControl();
            tabPageMonday = new TabPage();
            labMonTempValF = new Label();
            labMonTempVal = new Label();
            labTempMonday = new Label();
            tabPageTuesday = new TabPage();
            labTueTempValF = new Label();
            labTueTempVal = new Label();
            labTempTuesday = new Label();
            tabPageWednesday = new TabPage();
            labWedTempValF = new Label();
            labWedTempVal = new Label();
            labTempWednesday = new Label();
            tabPageThursday = new TabPage();
            labThuTempValF = new Label();
            labThuTempVal = new Label();
            labTempThursday = new Label();
            tabPageFriday = new TabPage();
            labFriTempValF = new Label();
            labFriTempVal = new Label();
            labTempFriday = new Label();
            tabPageSaturday = new TabPage();
            labSatTempValF = new Label();
            labSatTempVal = new Label();
            labTempSaturday = new Label();
            tabPageSunday = new TabPage();
            labSunTempValF = new Label();
            labSunTempVal = new Label();
            labTempSunday = new Label();
            tabPage3 = new TabPage();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPageMonday.SuspendLayout();
            tabPageTuesday.SuspendLayout();
            tabPageWednesday.SuspendLayout();
            tabPageThursday.SuspendLayout();
            tabPageFriday.SuspendLayout();
            tabPageSaturday.SuspendLayout();
            tabPageSunday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            labWindSpeedValue.Click += labWindSpeedValue_Click;
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
            labTempFahr.Click += labTempFahr_Click;
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
            labFeelsLikeFahr.Click += labFeelsLikeFahr_Click;
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
            labMaxTempFahr.Click += labMaxTempFahr_Click;
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
            labMinTempFahr.Click += labMinTempFahr_Click;
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
            // labErrorForecast
            // 
            labErrorForecast.AutoSize = true;
            labErrorForecast.BackColor = Color.Transparent;
            labErrorForecast.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labErrorForecast.ForeColor = Color.Red;
            labErrorForecast.Location = new Point(36, 692);
            labErrorForecast.Margin = new Padding(4, 0, 4, 0);
            labErrorForecast.Name = "labErrorForecast";
            labErrorForecast.Size = new Size(0, 27);
            labErrorForecast.TabIndex = 46;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(93, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(901, 531);
            tabControl1.TabIndex = 47;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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
            tabPage1.Size = new Size(893, 490);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сегашно време";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(tabControl2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(893, 490);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Дневна прогноза";
            tabPage2.UseVisualStyleBackColor = true;
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
            tabControl2.Size = new Size(640, 403);
            tabControl2.TabIndex = 0;
            // 
            // tabPageMonday
            // 
            tabPageMonday.Controls.Add(pictureBox1);
            tabPageMonday.Controls.Add(labMonTempValF);
            tabPageMonday.Controls.Add(labMonTempVal);
            tabPageMonday.Controls.Add(labTempMonday);
            tabPageMonday.Location = new Point(4, 37);
            tabPageMonday.Name = "tabPageMonday";
            tabPageMonday.Padding = new Padding(3);
            tabPageMonday.Size = new Size(632, 362);
            tabPageMonday.TabIndex = 0;
            tabPageMonday.Text = "Понеделник";
            tabPageMonday.UseVisualStyleBackColor = true;
            // 
            // labMonTempValF
            // 
            labMonTempValF.AutoSize = true;
            labMonTempValF.BackColor = Color.Transparent;
            labMonTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labMonTempValF.ForeColor = Color.Black;
            labMonTempValF.Location = new Point(405, 163);
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
            labMonTempVal.Location = new Point(344, 172);
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
            labTempMonday.Location = new Point(193, 172);
            labTempMonday.Margin = new Padding(4, 0, 4, 0);
            labTempMonday.Name = "labTempMonday";
            labTempMonday.Size = new Size(143, 28);
            labTempMonday.TabIndex = 43;
            labTempMonday.Text = "Температура:";
            // 
            // tabPageTuesday
            // 
            tabPageTuesday.Controls.Add(labTueTempValF);
            tabPageTuesday.Controls.Add(labTueTempVal);
            tabPageTuesday.Controls.Add(labTempTuesday);
            tabPageTuesday.Location = new Point(4, 29);
            tabPageTuesday.Name = "tabPageTuesday";
            tabPageTuesday.Padding = new Padding(3);
            tabPageTuesday.Size = new Size(632, 370);
            tabPageTuesday.TabIndex = 1;
            tabPageTuesday.Text = "Вторник";
            tabPageTuesday.UseVisualStyleBackColor = true;
            // 
            // labTueTempValF
            // 
            labTueTempValF.AutoSize = true;
            labTueTempValF.BackColor = Color.Transparent;
            labTueTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labTueTempValF.ForeColor = Color.Black;
            labTueTempValF.Location = new Point(405, 163);
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
            labTueTempVal.Location = new Point(344, 172);
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
            labTempTuesday.Location = new Point(193, 172);
            labTempTuesday.Margin = new Padding(4, 0, 4, 0);
            labTempTuesday.Name = "labTempTuesday";
            labTempTuesday.Size = new Size(143, 28);
            labTempTuesday.TabIndex = 43;
            labTempTuesday.Text = "Температура:";
            // 
            // tabPageWednesday
            // 
            tabPageWednesday.Controls.Add(labWedTempValF);
            tabPageWednesday.Controls.Add(labWedTempVal);
            tabPageWednesday.Controls.Add(labTempWednesday);
            tabPageWednesday.Location = new Point(4, 29);
            tabPageWednesday.Name = "tabPageWednesday";
            tabPageWednesday.Size = new Size(632, 370);
            tabPageWednesday.TabIndex = 2;
            tabPageWednesday.Text = "Сряда";
            tabPageWednesday.UseVisualStyleBackColor = true;
            // 
            // labWedTempValF
            // 
            labWedTempValF.AutoSize = true;
            labWedTempValF.BackColor = Color.Transparent;
            labWedTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labWedTempValF.ForeColor = Color.Black;
            labWedTempValF.Location = new Point(405, 163);
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
            labWedTempVal.Location = new Point(344, 172);
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
            labTempWednesday.Location = new Point(193, 172);
            labTempWednesday.Margin = new Padding(4, 0, 4, 0);
            labTempWednesday.Name = "labTempWednesday";
            labTempWednesday.Size = new Size(143, 28);
            labTempWednesday.TabIndex = 43;
            labTempWednesday.Text = "Температура:";
            // 
            // tabPageThursday
            // 
            tabPageThursday.Controls.Add(labThuTempValF);
            tabPageThursday.Controls.Add(labThuTempVal);
            tabPageThursday.Controls.Add(labTempThursday);
            tabPageThursday.Location = new Point(4, 29);
            tabPageThursday.Name = "tabPageThursday";
            tabPageThursday.Size = new Size(632, 370);
            tabPageThursday.TabIndex = 3;
            tabPageThursday.Text = "Четвъртък";
            tabPageThursday.UseVisualStyleBackColor = true;
            // 
            // labThuTempValF
            // 
            labThuTempValF.AutoSize = true;
            labThuTempValF.BackColor = Color.Transparent;
            labThuTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labThuTempValF.ForeColor = Color.Black;
            labThuTempValF.Location = new Point(405, 163);
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
            labThuTempVal.Location = new Point(344, 172);
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
            labTempThursday.Location = new Point(193, 172);
            labTempThursday.Margin = new Padding(4, 0, 4, 0);
            labTempThursday.Name = "labTempThursday";
            labTempThursday.Size = new Size(143, 28);
            labTempThursday.TabIndex = 43;
            labTempThursday.Text = "Температура:";
            // 
            // tabPageFriday
            // 
            tabPageFriday.Controls.Add(labFriTempValF);
            tabPageFriday.Controls.Add(labFriTempVal);
            tabPageFriday.Controls.Add(labTempFriday);
            tabPageFriday.Location = new Point(4, 29);
            tabPageFriday.Name = "tabPageFriday";
            tabPageFriday.Size = new Size(632, 370);
            tabPageFriday.TabIndex = 4;
            tabPageFriday.Text = "Петък";
            tabPageFriday.UseVisualStyleBackColor = true;
            // 
            // labFriTempValF
            // 
            labFriTempValF.AutoSize = true;
            labFriTempValF.BackColor = Color.Transparent;
            labFriTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labFriTempValF.ForeColor = Color.Black;
            labFriTempValF.Location = new Point(405, 163);
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
            labFriTempVal.Location = new Point(344, 172);
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
            labTempFriday.Location = new Point(193, 172);
            labTempFriday.Margin = new Padding(4, 0, 4, 0);
            labTempFriday.Name = "labTempFriday";
            labTempFriday.Size = new Size(143, 28);
            labTempFriday.TabIndex = 43;
            labTempFriday.Text = "Температура:";
            // 
            // tabPageSaturday
            // 
            tabPageSaturday.Controls.Add(labSatTempValF);
            tabPageSaturday.Controls.Add(labSatTempVal);
            tabPageSaturday.Controls.Add(labTempSaturday);
            tabPageSaturday.Location = new Point(4, 29);
            tabPageSaturday.Name = "tabPageSaturday";
            tabPageSaturday.Size = new Size(632, 370);
            tabPageSaturday.TabIndex = 5;
            tabPageSaturday.Text = "Събота";
            tabPageSaturday.UseVisualStyleBackColor = true;
            // 
            // labSatTempValF
            // 
            labSatTempValF.AutoSize = true;
            labSatTempValF.BackColor = Color.Transparent;
            labSatTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSatTempValF.ForeColor = Color.Black;
            labSatTempValF.Location = new Point(405, 163);
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
            labSatTempVal.Location = new Point(344, 172);
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
            labTempSaturday.Location = new Point(193, 172);
            labTempSaturday.Margin = new Padding(4, 0, 4, 0);
            labTempSaturday.Name = "labTempSaturday";
            labTempSaturday.Size = new Size(143, 28);
            labTempSaturday.TabIndex = 43;
            labTempSaturday.Text = "Температура:";
            // 
            // tabPageSunday
            // 
            tabPageSunday.Controls.Add(labSunTempValF);
            tabPageSunday.Controls.Add(labSunTempVal);
            tabPageSunday.Controls.Add(labTempSunday);
            tabPageSunday.Location = new Point(4, 29);
            tabPageSunday.Name = "tabPageSunday";
            tabPageSunday.Size = new Size(632, 370);
            tabPageSunday.TabIndex = 6;
            tabPageSunday.Text = "Неделя";
            tabPageSunday.UseVisualStyleBackColor = true;
            // 
            // labSunTempValF
            // 
            labSunTempValF.AutoSize = true;
            labSunTempValF.BackColor = Color.Transparent;
            labSunTempValF.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labSunTempValF.ForeColor = Color.Black;
            labSunTempValF.Location = new Point(405, 163);
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
            labSunTempVal.Location = new Point(344, 172);
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
            labTempSunday.Location = new Point(193, 172);
            labTempSunday.Margin = new Padding(4, 0, 4, 0);
            labTempSunday.Name = "labTempSunday";
            labTempSunday.Size = new Size(143, 28);
            labTempSunday.TabIndex = 43;
            labTempSunday.Text = "Температура:";
            // 
            // tabPage3
            // 
            tabPage3.AutoScroll = true;
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(893, 498);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Часова прогноза";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
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
            Controls.Add(labErrorForecast);
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
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label labCity;
        private TextBox City;
        private Button btnSearch;
        private Label labDetails;
        private Label labSunrise;
        private Label labSunset;
        private Label labSunriseValue;
        private Label labSunsetValue;
        private Label labCondition;
        private PictureBox picIcon;
        private Label labCountry;
        private Label labMaxTempValue;
        private Label labMinTempValue;
        private Label labMaxTemp;
        private Label labMinTemp;
        private Label labPressureValue;
        private Label labPressure;
        private Label labWindSpeedValue;
        private Label labWindSpeed;
        private Label labTempValue;
        private Label labFeelsLikeValue;
        private Label labFeelsLike;
        private Label labTemp;
        private Label labDateTime;
        private Label labTempFahr;
        private Label labFeelsLikeFahr;
        private Label labMaxTempFahr;
        private Label labMinTempFahr;
        private Label labLocalTime;
        private Label labErrorWeather;
        private System.Windows.Forms.Timer timerErrorWeather;
        private Label labErrorForecast;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPageMonday;
        private TabControl tabControl2;
        private TabPage tabPageTuesday;
        private TabPage tabPageWednesday;
        private TabPage tabPageThursday;
        private TabPage tabPageFriday;
        private TabPage tabPageSaturday;
        private TabPage tabPageSunday;
        private TabPage tabPage5;
        private TabPage tabPage4;
        private Label labMonTempValF;
        private Label labMonTempVal;
        private Label labTempMonday;
        private Label labTueTempValF;
        private Label labTueTempVal;
        private Label labTempTuesday;
        private Label labWedTempValF;
        private Label labWedTempVal;
        private Label labTempWednesday;
        private Label labThuTempValF;
        private Label labThuTempVal;
        private Label labTempThursday;
        private Label labFriTempValF;
        private Label labFriTempVal;
        private Label labTempFriday;
        private Label labSatTempValF;
        private Label labSatTempVal;
        private Label labTempSaturday;
        private Label labSunTempValF;
        private Label labSunTempVal;
        private Label labTempSunday;
        private PictureBox pictureBox1;
    }
}