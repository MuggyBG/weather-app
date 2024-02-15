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
                    string url = string.Format($"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&hourly=temperature_2m,precipitation_probability,precipitation,weather_code&daily=temperature_2m_max,temperature_2m_min,precipitation_sum,precipitation_hours,precipitation_probability_max&timeformat=unixtime&timezone=Europe%2FMoscow");
                    //изпращаме резултата към променлива json
                    try
                    {
                        var json = await client.GetStringAsync(url);
                        ForecastInfo.Rootobject Info = JsonConvert.DeserializeObject<ForecastInfo.Rootobject>(json);
                        // Дневна прогноза
                        double monTemp = Math.Round(Info.hourly.temperature_2m[1], 2);
                        double monTempFahr = monTemp * 1.8 + 32;
                        labMonTempVal.Text = $"{monTemp}{Info.hourly_units.temperature_2m}";
                        labMonTempValF.Text = $"{monTempFahr}°F";
                        double tueTemp = Math.Round(Info.hourly.temperature_2m[25], 2);
                        double tueTempFahr = tueTemp * 1.8 + 32;
                        labTueTempVal.Text = $"{tueTemp}{Info.hourly_units.temperature_2m}";
                        labTueTempValF.Text = $"{tueTempFahr}°F";
                        double wedTemp = Math.Round(Info.hourly.temperature_2m[49], 2);
                        double wedTempFahr = wedTemp * 1.8 + 32;
                        labWedTempVal.Text = $"{wedTemp}{Info.hourly_units.temperature_2m}";
                        labWedTempValF.Text = $"{wedTempFahr}°F";
                        double thuTemp = Math.Round(Info.hourly.temperature_2m[74], 2);
                        double thuTempFahr = thuTemp * 1.8 + 32;
                        labThuTempVal.Text = $"{thuTemp}{Info.hourly_units.temperature_2m}";
                        labThuTempValF.Text = $"{thuTempFahr}°F";
                        double friTemp = Math.Round(Info.hourly.temperature_2m[99], 2);
                        double friTempFahr = friTemp * 1.8 + 32;
                        labFriTempVal.Text = $"{friTemp}{Info.hourly_units.temperature_2m}";
                        labFriTempValF.Text = $"{friTempFahr}°F";
                        double satTemp = Math.Round(Info.hourly.temperature_2m[124], 2);
                        double satTempFahr = satTemp * 1.8 + 32;
                        labSatTempVal.Text = $"{satTemp}{Info.hourly_units.temperature_2m}";
                        labSatTempValF.Text = $"{satTempFahr}°F";
                        double sunTemp = Math.Round(Info.hourly.temperature_2m[149], 2);
                        double sunTempFahr = sunTemp * 1.8 + 32;
                        labSunTempVal.Text = $"{sunTemp}{Info.hourly_units.temperature_2m}";
                        labSunTempValF.Text = $"{sunTempFahr}°F";
                        tabPageMonday.Text = convertDateTime(Info.daily.time[1]).DayOfWeek.ToString();
                        tabPageTuesday.Text = convertDateTime(Info.daily.time[2]).DayOfWeek.ToString();
                        tabPageWednesday.Text = convertDateTime(Info.daily.time[3]).DayOfWeek.ToString();
                        tabPageThursday.Text = convertDateTime(Info.daily.time[4]).DayOfWeek.ToString();
                        tabPageFriday.Text = convertDateTime(Info.daily.time[5]).DayOfWeek.ToString();
                        tabPageSaturday.Text = convertDateTime(Info.daily.time[6]).DayOfWeek.ToString();
                        tabPageSunday.Text = convertDateTime(Info.daily.time[0]).DayOfWeek.ToString();

                    }
                    catch (Exception ex)
                    {


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
    }

}

