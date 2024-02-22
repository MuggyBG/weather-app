using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Runtime.CompilerServices;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //променливи за API ключ, език и мярка
        string APIKey = "3c0be927681b790ee0c45c665d362e83";
        string language = "bg";
        string units = "metric";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labSunrise_Click(object sender, EventArgs e)
        {

        }

        private void labDetails_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await currentWeather();

        }
        float lon;
        float lat;

        async Task currentWeather()
        {
            //създаваме нов HttpClient, за вземане на данни от API
            using (var client = new HttpClient())
            {



                //даваме url за API Call
                string url = string.Format($"https://api.openweathermap.org/data/2.5/weather?q={City.Text}&units={units}&lang={language}&appid={APIKey}");
                //изпращаме резултата към променлива json
                try
                {
                    var json = await client.GetStringAsync(url);

                    WeatherInfo.Rootobject Info = JsonConvert.DeserializeObject<WeatherInfo.Rootobject>(json);
                    //правим стринг за място на снимката
                    string imgUrl = "http://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    picIcon.ImageLocation = imgUrl;
                    //променлива за температура и температура фаренхайт конверсия
                    double temprature = Info.main.temp;
                    double tempratureFahrenheit = temprature * 1.8 + 32;
                    //показване на температура, температура фаренхайт, време, детайли, време на изгрев и залез, вятърна скорост и налягане
                    labTempValue.Text = $"{Math.Round(temprature)}°C";
                    labTempFahr.Text = $"{Math.Round(tempratureFahrenheit)}°F";
                    labCondition.Text = Info.weather[0].main;
                    labDetails.Text = Info.weather[0].description.ToUpper();
                    labSunsetValue.Text = $"{convertDateTime(Info.sys.sunset)} UTC+2";
                    labSunriseValue.Text = $"{convertDateTime(Info.sys.sunrise)} UTC+2";
                    labWindSpeedValue.Text = $"{Info.wind.speed} m/s";
                    labPressureValue.Text = $"{Info.main.pressure} hPa";
                    //променлива за мин и макс темп, за да можем да я превърнем в фаренхайт
                    double minTempC = Info.main.temp_min;
                    double maxTempC = Info.main.temp_max;
                    double minTempFahr = minTempC * 1.8 + 32;
                    double maxTempFahr = maxTempC * 1.8 + 32;
                    //показване на мин макс темп
                    labMinTempValue.Text = $"{Math.Round(minTempC)}°C";
                    labMaxTempValue.Text = $"{Math.Round(maxTempC)}°C";
                    labMinTempFahr.Text = $"{Math.Round(minTempFahr)}°F";
                    labMaxTempFahr.Text = $"{Math.Round(maxTempFahr)}°F";
                    double feelsLikeC = Info.main.feels_like;
                    labFeelsLikeValue.Text = $"{Math.Round(feelsLikeC)}°C";
                    double feelsLikeFahr = feelsLikeC * 1.8 + 32;
                    labFeelsLikeFahr.Text = $"{Math.Round(feelsLikeFahr)}°F";
                    //код на държавата, за която гледаме времето
                    labCountry.Text = Info.sys.country.ToString();
                    lon = Info.coord.lon;
                    lat = Info.coord.lat;
                    labErrorWeather.Hide();
                    labDateTime.Text = $"{convertDateTime(Info.dt)} UTC+2";
                    labLocalTime.Text = $"Сегашно време: {DateTime.Now}";
                    await getForecast();
                }
                catch (Exception ex)
                {
                    labDateTime.Hide();
                    labErrorWeather.Show();
                    labErrorWeather.Text = String.Format("Грешка, моля проверете написаното и опитайте отново.");
                    timerErrorWeather.Start();
                }

            }

        }

        async Task getForecast()
        {
            //създаваме нов HttpClient, за вземане на данни от друг API за прогноза
            using (var client = new HttpClient())
            {


                {
                    //даваме url за API Call
                    string url = string.Format($"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&hourly=temperature_2m,precipitation_probability,precipitation,weather_code&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_sum,precipitation_hours,sunrise,sunset,wind_speed_10m_max,precipitation_probability_max&timeformat=unixtime&timezone=Europe%2FMoscow");
                    //изпращаме резултата към променлива json
                    try
                    {
                        var json = await client.GetStringAsync(url);
                        ForecastInfo.Rootobject Info = JsonConvert.DeserializeObject<ForecastInfo.Rootobject>(json);
                        // Дневна прогноза
                        double monTemp = Math.Round(Info.hourly.temperature_2m[0], 2);
                        double monTempFahr = Math.Round(Info.hourly.temperature_2m[0] * 1.8 + 32, 1);
                        double monMinTemp = Math.Round(Info.daily.temperature_2m_min[0], 2);
                        double monMinTempFahr = Math.Round(Info.daily.temperature_2m_min[0] * 1.8 + 32, 1);
                        double monMaxTemp = Math.Round(Info.daily.temperature_2m_max[0], 2);
                        double monMaxTempFahr = Math.Round(Info.daily.temperature_2m_max[0] * 1.8 + 32, 1);
                        labMonSunriseVal.Text = $"{convertDateTime(Info.daily.sunrise[0])}";
                        labMonSunsetVal.Text = $"{convertDateTime(Info.daily.sunset[0])}";
                        labMonTempVal.Text = $"{monTemp}{Info.hourly_units.temperature_2m}";
                        labMonTempValF.Text = $"{monTempFahr}°F";
                        labMonMinTempVal.Text = $"{monMinTemp}{Info.hourly_units.temperature_2m}";
                        labMonMaxTempVal.Text = $"{monMaxTemp}{Info.hourly_units.temperature_2m}";
                        labMonMinTempValF.Text = $"{monMinTempFahr}°F";
                        labMonMaxTempValF.Text = $"{monMaxTempFahr}°F";
                        labMonSpeedVal.Text = $"{Info.daily.wind_speed_10m_max[0]}{Info.daily_units.wind_speed_10m_max}";
                        labMonPrecipitationVal.Text = $"{Info.daily.precipitation_sum[0]}{Info.daily_units.precipitation_sum}, {Info.daily.precipitation_probability_max[0]}{Info.daily_units.precipitation_probability_max}";
                        double tueTemp = Math.Round(Info.hourly.temperature_2m[25], 2);
                        double tueTempFahr = Math.Round(Info.hourly.temperature_2m[25] * 1.8 + 32, 1);
                        double tueMinTemp = Math.Round(Info.daily.temperature_2m_min[1], 2);
                        double tueMinTempFahr = Math.Round(Info.daily.temperature_2m_min[1] * 1.8 + 32, 1);
                        double tueMaxTemp = Math.Round(Info.daily.temperature_2m_max[1], 2);
                        double tueMaxTempFahr = Math.Round(Info.daily.temperature_2m_max[1] * 1.8 + 32, 1);
                        labTueSunriseVal.Text = $"{convertDateTime(Info.daily.sunrise[1])}";
                        labTueSunsetVal.Text = $"{convertDateTime(Info.daily.sunset[1])}";
                        labTueTempVal.Text = $"{tueTemp}{Info.hourly_units.temperature_2m}";
                        labTueTempValF.Text = $"{tueTempFahr}°F";
                        labTueMinTempVal.Text = $"{tueMinTemp}{Info.hourly_units.temperature_2m}";
                        labTueMaxTempVal.Text = $"{tueMaxTemp}{Info.hourly_units.temperature_2m}";
                        labTueMinTempValF.Text = $"{tueMinTempFahr}°F";
                        labTueMaxTempValF.Text = $"{tueMaxTempFahr}°F";
                        labTueSpeedVal.Text = $"{Info.daily.wind_speed_10m_max[1]}{Info.daily_units.wind_speed_10m_max}";
                        labTuePrecipitationVal.Text = $"{Info.daily.precipitation_sum[1]}{Info.daily_units.precipitation_sum}, {Info.daily.precipitation_probability_max[1]}{Info.daily_units.precipitation_probability_max}";
                        double wedTemp = Math.Round(Info.hourly.temperature_2m[49], 2);
                        double wedTempFahr = Math.Round(Info.hourly.temperature_2m[49] * 1.8 + 32, 1);
                        double wedMinTemp = Math.Round(Info.daily.temperature_2m_min[2], 2);
                        double wedMinTempFahr = Math.Round(Info.daily.temperature_2m_min[2] * 1.8 + 32, 1);
                        double wedMaxTemp = Math.Round(Info.daily.temperature_2m_max[2], 2);
                        double wedMaxTempFahr = Math.Round(Info.daily.temperature_2m_max[2] * 1.8 + 32, 1);
                        labWedSunriseVal.Text = $"{convertDateTime(Info.daily.sunrise[2])}";
                        labWedSunsetVal.Text = $"{convertDateTime(Info.daily.sunset[2])}";
                        labWedTempVal.Text = $"{wedTemp}{Info.hourly_units.temperature_2m}";
                        labWedTempValF.Text = $"{wedTempFahr}°F";
                        labWedMinTempVal.Text = $"{wedMinTemp}{Info.hourly_units.temperature_2m}";
                        labWedMaxTempVal.Text = $"{wedMaxTemp}{Info.hourly_units.temperature_2m}";
                        labWedMinTempValF.Text = $"{wedMinTempFahr}°F";
                        labWedMaxTempValF.Text = $"{wedMaxTempFahr}°F";
                        labWedSpeedVal.Text = $"{Info.daily.wind_speed_10m_max[2]}{Info.daily_units.wind_speed_10m_max}";
                        labWedPrecipitationVal.Text = $"{Info.daily.precipitation_sum[2]}{Info.daily_units.precipitation_sum}, {Info.daily.precipitation_probability_max[2]}{Info.daily_units.precipitation_probability_max}";
                        double thuTemp = Math.Round(Info.hourly.temperature_2m[74], 2);
                        double thuTempFahr = Math.Round(Info.hourly.temperature_2m[74] * 1.8 + 32, 1);
                        double thuMinTemp = Math.Round(Info.daily.temperature_2m_min[3], 2);
                        double thuMinTempFahr = Math.Round(Info.daily.temperature_2m_min[3] * 1.8 + 32, 1);
                        double thuMaxTemp = Math.Round(Info.daily.temperature_2m_max[3], 2);
                        double thuMaxTempFahr = Math.Round(Info.daily.temperature_2m_max[3] * 1.8 + 32, 1);
                        labThuSunriseVal.Text = $"{convertDateTime(Info.daily.sunrise[3])}";
                        labThuSunsetVal.Text = $"{convertDateTime(Info.daily.sunset[3])}";
                        labThuTempVal.Text = $"{thuTemp}{Info.hourly_units.temperature_2m}";
                        labThuTempValF.Text = $"{thuTempFahr}°F";
                        labThuMinTempVal.Text = $"{thuMinTemp}{Info.hourly_units.temperature_2m}";
                        labThuMaxTempVal.Text = $"{thuMaxTemp}{Info.hourly_units.temperature_2m}";
                        labThuMinTempValF.Text = $"{thuMinTempFahr}°F";
                        labThuMaxTempValF.Text = $"{thuMaxTempFahr}°F";
                        labThuSpeedVal.Text = $"{Info.daily.wind_speed_10m_max[3]}{Info.daily_units.wind_speed_10m_max}";
                        labThuPrecipitationVal.Text = $"{Info.daily.precipitation_sum[3]}{Info.daily_units.precipitation_sum}, {Info.daily.precipitation_probability_max[3]}{Info.daily_units.precipitation_probability_max}";
                        double friTemp = Math.Round(Info.hourly.temperature_2m[99], 2);
                        double friTempFahr = Math.Round(Info.hourly.temperature_2m[99] * 1.8 + 32, 1);
                        double friMinTemp = Math.Round(Info.daily.temperature_2m_min[4], 2);
                        double friMinTempFahr = Math.Round(Info.daily.temperature_2m_min[4] * 1.8 + 32, 1);
                        double friMaxTemp = Math.Round(Info.daily.temperature_2m_max[4], 2);
                        double friMaxTempFahr = Math.Round(Info.daily.temperature_2m_max[4] * 1.8 + 32, 1);
                        labFriSunriseVal.Text = $"{convertDateTime(Info.daily.sunrise[4])}";
                        labFriSunsetVal.Text = $"{convertDateTime(Info.daily.sunset[4])}";
                        labFriTempVal.Text = $"{friTemp}{Info.hourly_units.temperature_2m}";
                        labFriTempValF.Text = $"{friTempFahr}°F";
                        labFriMinTempVal.Text = $"{friMinTemp}{Info.hourly_units.temperature_2m}";
                        labFriMaxTempVal.Text = $"{friMaxTemp}{Info.hourly_units.temperature_2m}";
                        labFriMinTempValF.Text = $"{friMinTempFahr}°F";
                        labFriMaxTempValF.Text = $"{friMaxTempFahr}°F";
                        labFriSpeedVal.Text = $"{Info.daily.wind_speed_10m_max[4]}{Info.daily_units.wind_speed_10m_max}";
                        labFriPrecipitationVal.Text = $"{Info.daily.precipitation_sum[4]}{Info.daily_units.precipitation_sum}, {Info.daily.precipitation_probability_max[4]}{Info.daily_units.precipitation_probability_max}";
                        double satTemp = Math.Round(Info.hourly.temperature_2m[124], 2);
                        double satTempFahr = Math.Round(Info.hourly.temperature_2m[124] * 1.8 + 32, 1);
                        double satMinTemp = Math.Round(Info.daily.temperature_2m_min[5], 2);
                        double satMinTempFahr = Math.Round(Info.daily.temperature_2m_min[5] * 1.8 + 32, 1);
                        double satMaxTemp = Math.Round(Info.daily.temperature_2m_max[5], 2);
                        double satMaxTempFahr = Math.Round(Info.daily.temperature_2m_max[5] * 1.8 + 32, 1);
                        labSatSunriseVal.Text = $"{convertDateTime(Info.daily.sunrise[5])}";
                        labSatSunsetVal.Text = $"{convertDateTime(Info.daily.sunset[5])}";
                        labSatTempVal.Text = $"{satTemp}{Info.hourly_units.temperature_2m}";
                        labSatTempValF.Text = $"{satTempFahr}°F";
                        labSatMinTempVal.Text = $"{satMinTemp}{Info.hourly_units.temperature_2m}";
                        labSatMaxTempVal.Text = $"{satMaxTemp}{Info.hourly_units.temperature_2m}";
                        labSatMinTempValF.Text = $"{satMinTempFahr}°F";
                        labSatMaxTempValF.Text = $"{satMaxTempFahr}°F";
                        labSatSpeedVal.Text = $"{Info.daily.wind_speed_10m_max[5]}{Info.daily_units.wind_speed_10m_max}";
                        labSatPrecipitationVal.Text = $"{Info.daily.precipitation_sum[5]}{Info.daily_units.precipitation_sum}, {Info.daily.precipitation_probability_max[5]}{Info.daily_units.precipitation_probability_max}";
                        double sunTemp = Math.Round(Info.hourly.temperature_2m[149], 2);
                        double sunTempFahr = Math.Round(Info.hourly.temperature_2m[149] * 1.8 + 32, 1);
                        double sunMinTemp = Math.Round(Info.daily.temperature_2m_min[6], 2);
                        double sunMinTempFahr = Math.Round(Info.daily.temperature_2m_min[6] * 1.8 + 32, 1);
                        double sunMaxTemp = Math.Round(Info.daily.temperature_2m_max[6], 2);
                        double sunMaxTempFahr = Math.Round(Info.daily.temperature_2m_max[6] * 1.8 + 32, 1);
                        labSunSunriseVal.Text = $"{convertDateTime(Info.daily.sunrise[6])}";
                        labSunSunsetVal.Text = $"{convertDateTime(Info.daily.sunset[6])}";
                        labSunTempVal.Text = $"{sunTemp}{Info.hourly_units.temperature_2m}";
                        labSunTempValF.Text = $"{sunTempFahr}°F";
                        labSunMinTempVal.Text = $"{sunMinTemp}{Info.hourly_units.temperature_2m}";
                        labSunMaxTempVal.Text = $"{sunMaxTemp}{Info.hourly_units.temperature_2m}";
                        labSunMinTempValF.Text = $"{sunMinTempFahr}°F";
                        labSunMaxTempValF.Text = $"{sunMaxTempFahr}°F";
                        labSunSpeedVal.Text = $"{Info.daily.wind_speed_10m_max[6]}{Info.daily_units.wind_speed_10m_max}";
                        labSunPrecipitationVal.Text = $"{Info.daily.precipitation_sum[6]}{Info.daily_units.precipitation_sum}, {Info.daily.precipitation_probability_max[6]}{Info.daily_units.precipitation_probability_max}";


                        //показваме седмица с начало днешен ден
                        tabPageMonday.Text = convertDateTime(Info.daily.time[0] + 86400).DayOfWeek.ToString();
                        tabPageTuesday.Text = convertDateTime(Info.daily.time[1] + 86400).DayOfWeek.ToString();
                        tabPageWednesday.Text = convertDateTime(Info.daily.time[2] + 86400).DayOfWeek.ToString();
                        tabPageThursday.Text = convertDateTime(Info.daily.time[3] + 86400).DayOfWeek.ToString();
                        tabPageFriday.Text = convertDateTime(Info.daily.time[4] + 86400).DayOfWeek.ToString();
                        tabPageSaturday.Text = convertDateTime(Info.daily.time[5] + 86400).DayOfWeek.ToString();
                        tabPageSunday.Text = convertDateTime(Info.daily.time[6] + 86400).DayOfWeek.ToString();



                        UserControl1 FUK;
                        for (int i = 1; i < 25; i++)
                        {
                            FUK = new UserControl1();
                            string theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                            string theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                            FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                            double UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                            double UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                            FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                            FUK.labUCTempF.Text = $"{UCTimeF}°F";
                            FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                            monFLP.Controls.Add(FUK);
                        }
                        for (int i = 25; i < 49; i++)
                        {
                            FUK = new UserControl1();
                            string theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                            string theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                            FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                            double UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                            double UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                            FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                            FUK.labUCTempF.Text = $"{UCTimeF}°F";
                            FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                            tueFLP.Controls.Add(FUK);
                        }
                        for (int i = 49; i < 73; i++)
                        {
                            FUK = new UserControl1();
                            string theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                            string theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                            FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                            double UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                            double UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                            FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                            FUK.labUCTempF.Text = $"{UCTimeF}°F";
                            FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                            wedFLP.Controls.Add(FUK);
                        }
                        for (int i = 73; i < 97; i++)
                        {
                            FUK = new UserControl1();
                            string theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                            string theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                            FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                            double UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                            double UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                            FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                            FUK.labUCTempF.Text = $"{UCTimeF}°F";
                            FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                            thuFLP.Controls.Add(FUK);
                        }

                        for (int i = 97; i < 121; i++)
                        {
                            FUK = new UserControl1();
                            string theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                            string theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                            FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                            double UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                            double UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                            FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                            FUK.labUCTempF.Text = $"{UCTimeF}°F";
                            FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                            friFLP.Controls.Add(FUK);
                        }

                        for (int i = 121; i < 145; i++)
                        {
                            FUK = new UserControl1();
                            string theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                            string theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                            FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                            double UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                            double UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                            FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                            FUK.labUCTempF.Text = $"{UCTimeF}°F";
                            FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                            satFLP.Controls.Add(FUK);
                        }

                        for (int i = 145; i < 167; i++)
                        {
                            FUK = new UserControl1();
                            string theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                            string theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                            FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                            double UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                            double UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                            FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                            FUK.labUCTempF.Text = $"{UCTimeF}°F";
                            FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                            sunFLP.Controls.Add(FUK);
                        }


                    }
                    catch (Exception ex)
                    {
                        labForecastError.Text = "Имаше проблем при вземането на данни за прогноза.";

                    }
                }
            }
        }
        DateTime convertDateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime().AddHours(2);
            return day;
        }

        private void labMaxTempFahr_Click(object sender, EventArgs e)
        {

        }

        private void labMinTempFahr_Click(object sender, EventArgs e)
        {
        }

        private void labFeelsLikeFahr_Click(object sender, EventArgs e)
        {
        }

        private void labTempFahr_Click(object sender, EventArgs e)
        {
        }

        private void timerErrorWeather_Tick(object sender, EventArgs e)
        {
            labErrorWeather.Hide();
            labDateTime.Show();
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            getForecast();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void labWindSpeedValue_Click(object sender, EventArgs e)
        {

        }

        private void tabPageTuesday_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labTempTuesday_Click(object sender, EventArgs e)
        {

        }

        private void tabPageThursday_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerForecastError_Tick(object sender, EventArgs e)
        {
            labForecastError.Hide();
        }

       
    }

}

