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
        //променливи за API ключ, език и мярка към OpenWeatherMap, зададени като Read Only  
        readonly string APIKey = "3c0be927681b790ee0c45c665d362e83";
        readonly string language = "bg";
        readonly string units = "metric";

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //пускане на метода за вземане на актуални метеорологични данни при натискане на бутона. 
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await currentWeather();
        }
        float lon;
        float lat;
        //метода за вземане на актуални метеорологични данни от OpenWeatherMap
        async Task currentWeather()
        {
            //създаваме нов HttpClient, за вземане на данни от API
            using var client = new HttpClient();
            //даваме стринг url за API Call
            string url = string.Format($"https://api.openweathermap.org/data/2.5/weather?q={City.Text}&units={units}&lang={language}&appid={APIKey}");
            //изпращаме резултата към променлива json
            //използваме try, за да можем да хванем проблеми при изпълнението
            try
            {
                var json = await client.GetStringAsync(url);
                //Десериализираме JSON-форматираната информация и резултата се задава към класа WeatherInfo
                var Info = JsonConvert.DeserializeObject<WeatherInfo.Rootobject>(json);
                //правим стринг за място на снимката
                string imgUrl = $"http://openweathermap.org/img/w/{Info.weather[0].icon}.png";
                picIcon.ImageLocation = imgUrl;
                //променлива за температура и температура фаренхайт конверсия
                double temprature = Info.main.temp;
                double tempratureFahrenheit = temprature * 1.8 + 32;
                //показване на температура, температура фаренхайт, време, детайли, време на изгрев и залез, вятърна скорост и налягане
                labTempValue.Text = $"{Math.Round(temprature, 2)}°C";
                labTempFahr.Text = $"{Math.Round(tempratureFahrenheit, 2)}°F";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description.ToUpper();
                labSunsetValue.Text = $"{convertDateTime(Info.sys.sunset)}";
                labSunriseValue.Text = $"{convertDateTime(Info.sys.sunrise)}";
                labWindSpeedValue.Text = $"{Info.wind.speed} m/s";
                labPressureValue.Text = $"{Info.main.pressure} hPa";
                //променлива за мин и макс темп, за да можем да я превърнем в фаренхайт
                double minTempC = Info.main.temp_min;
                double maxTempC = Info.main.temp_max;
                double minTempFahr = minTempC * 1.8 + 32;
                double maxTempFahr = maxTempC * 1.8 + 32;
                //показване на мин макс темп и усещането на времето
                labMinTempValue.Text = $"{Math.Round(minTempC, 2)}°C";
                labMaxTempValue.Text = $"{Math.Round(maxTempC, 2)}°C";
                labMinTempFahr.Text = $"{Math.Round(minTempFahr, 2)}°F";
                labMaxTempFahr.Text = $"{Math.Round(maxTempFahr, 2)}°F";
                double feelsLikeC = Info.main.feels_like;
                labFeelsLikeValue.Text = $"{Math.Round(feelsLikeC, 2)}°C";
                double feelsLikeFahr = feelsLikeC * 1.8 + 32;
                labFeelsLikeFahr.Text = $"{Math.Round(feelsLikeFahr, 2)}°F";
                //код на държавата, за която гледаме времето
                //след това, изшращаме longtitude и latitude стойности към променливите lon и lat, за да можем да изпратим тази информация към друг API Open-Meteo
                labCountry.Text = Info.sys.country.ToString();
                lon = Info.coord.lon;
                lat = Info.coord.lat;
                //скриваме label-а за грешка, защото иначе седи върху друг label за сегашното време
                labErrorWeather.Hide();
                //показваме сегашното време и време на последна актуализация на информацията от API. 
                labDateTime.Text = $"{convertDateTime(Info.dt)}";
                labLocalTime.Text = $"Сегашно време: {DateTime.Now}";
                //стартираме функция за вземане на прогнозните данни 
                await getForecast();
            }
            //хващаме грешки и при такива, показваме label за грешка и започваме таймер да скрием лейбъла след 5 секунди.
            catch (Exception)
            {
                labDateTime.Hide();
                labErrorWeather.Show();
                labErrorWeather.Text = "Грешка, моля проверете написаното и опитайте отново.";
                timerErrorWeather.Start();
            }

        }
        //метод за прогнозни данни
        async Task getForecast()
        {
            //създаваме нов HttpClient, за вземане на данни от друг API за прогноза
            using var client = new HttpClient();
            {
                //даваме url за API Call, в който използваме променливите за географска дължина и географска ширина lon и lat. 
                string url = string.Format($"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&hourly=temperature_2m,precipitation_probability" +
                    $",precipitation,weather_code&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_sum,precipitation_hours,sunrise,sunset" +
                    $",wind_speed_10m_max,precipitation_probability_max&timeformat=unixtime&timezone=Europe%2FMoscow");
                //изпращаме резултата към променлива json
                //пак използваме try, за да можем да хванем грешки
                try
                {
                    
                    var json = await client.GetStringAsync(url);
                    //пак използваме десериализираните данни към променлива Info
                    var Info = JsonConvert.DeserializeObject<ForecastInfo.Rootobject>(json);
                    // Информацията на сегашния ден 1 - температура, изгрев/залез, скорост на вятъра и атмосферно налягане.
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
                    labMonPrecipitationVal.Text = $"{Info.daily.precipitation_sum[0]}{Info.daily_units.precipitation_sum}, " +
                        $"{Info.daily.precipitation_probability_max[0]}{Info.daily_units.precipitation_probability_max}";
                    // Информация за ден 2 
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
                    //информация за ден3 
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
                    //информация за ден4
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
                    //информация за ден5
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
                    //информация за ден 6
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
                    //информация за ден 7
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


                    //сменяме името от placeholder дни към актуални за сегашния ден в седмицата имена.
                    tabPageMonday.Text = convertDateTime(Info.daily.time[0] + 86400).DayOfWeek.ToString();
                    tabPageTuesday.Text = convertDateTime(Info.daily.time[1] + 86400).DayOfWeek.ToString();
                    tabPageWednesday.Text = convertDateTime(Info.daily.time[2] + 86400).DayOfWeek.ToString();
                    tabPageThursday.Text = convertDateTime(Info.daily.time[3] + 86400).DayOfWeek.ToString();
                    tabPageFriday.Text = convertDateTime(Info.daily.time[4] + 86400).DayOfWeek.ToString();
                    tabPageSaturday.Text = convertDateTime(Info.daily.time[5] + 86400).DayOfWeek.ToString();
                    tabPageSunday.Text = convertDateTime(Info.daily.time[6] + 86400).DayOfWeek.ToString();


                    //правим usercontrol за 24-часова 7-дневна прогноза, заедно с променливи за UserControl класа.
                    UserControl1 FUK;
                    //изчистваме ако има предишни данни
                    monFLP.Controls.Clear();
                    tueFLP.Controls.Clear();
                    wedFLP.Controls.Clear();
                    thuFLP.Controls.Clear();
                    friFLP.Controls.Clear();
                    satFLP.Controls.Clear();
                    sunFLP.Controls.Clear();
                    string theTimeIsNow;
                    string theDayIsNow;
                    double UCTime;
                    double UCTimeF;
                    
                    //for цикъл за първият ден
                    for (int i = 1; i < 25; i++)
                    {
                        FUK = new UserControl1();
                        //показваме ден и час за показаната информация, деня е във формат (дата, месец с букви), а часа е във формат (час:минута)
                        theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                        theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                        FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                        //температура
                        UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                        UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                        FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                        FUK.labUCTempF.Text = $"{UCTimeF}°F";
                        //час за валежи
                        FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";
                        //добавяме нов usercontrol в flowlayout панела за всеки час от деня 24часа
                        monFLP.Controls.Add(FUK);
                    }
                    //втори ден, където информацията е на място 25-49 в API Call
                    for (int i = 25; i < 49; i++)
                    {
                        FUK = new UserControl1();
                        theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                        theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                        FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                        UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                        UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                        FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                        FUK.labUCTempF.Text = $"{UCTimeF}°F";
                        FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                        tueFLP.Controls.Add(FUK);
                    }
                    //трети ден, където информацията е на място 49-73 в API Call
                    for (int i = 49; i < 73; i++)
                    {
                        FUK = new UserControl1();
                        theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                        theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                        FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                        UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                        UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                        FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                        FUK.labUCTempF.Text = $"{UCTimeF}°F";
                        FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                        wedFLP.Controls.Add(FUK);
                    }
                    //четвърти ден, където информацията е на място 73-97 в API Call
                    for (int i = 73; i < 97; i++)
                    {
                        FUK = new UserControl1();
                        theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                        theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                        FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                        UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                        UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                        FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                        FUK.labUCTempF.Text = $"{UCTimeF}°F";
                        FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                        thuFLP.Controls.Add(FUK);
                    }
                    //пети ден, където информацията е на място 97-121 в API Call
                    for (int i = 97; i < 121; i++)
                    {
                        FUK = new UserControl1();
                        theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                        theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                        FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                        UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                        UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                        FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                        FUK.labUCTempF.Text = $"{UCTimeF}°F";
                        FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                        friFLP.Controls.Add(FUK);
                    }
                    //шести ден, където информацията е на място 121-145 в API Call
                    for (int i = 121; i < 145; i++)
                    {
                        FUK = new UserControl1();
                        theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                        theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                        FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                        UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                        UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                        FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                        FUK.labUCTempF.Text = $"{UCTimeF}°F";
                        FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                        satFLP.Controls.Add(FUK);
                    }
                    //седми ден, където информацията е на място 145-167 в API Call
                    for (int i = 145; i < 167; i++)
                    {
                        FUK = new UserControl1();
                        theTimeIsNow = convertDateTime(Info.hourly.time[i]).ToString("HH:mm");
                        theDayIsNow = convertDateTime(Info.hourly.time[i]).ToString("dd MMM");
                        FUK.labUCTime.Text = $"{theDayIsNow} {theTimeIsNow}ч.";
                        UCTime = Math.Round(Info.hourly.temperature_2m[i], 2);
                        UCTimeF = Math.Round(Info.hourly.temperature_2m[i] * 1.8 + 32, 1);
                        FUK.labUCTemp.Text = $"{UCTime}{Info.hourly_units.temperature_2m}";
                        FUK.labUCTempF.Text = $"{UCTimeF}°F";
                        FUK.labUCPrecipitation.Text = $"{Info.hourly.precipitation_probability[i]}{Info.hourly_units.precipitation_probability}";

                        sunFLP.Controls.Add(FUK);
                    }
                }
                //хващаме грешка при правенето на API Call-а към сайта. 
                catch (Exception)
                {
                    labForecastError.Text = "Имаше проблем при вземането на данни за прогноза.";

                }
            }
        }
        //методът, който използваме за да превърнем стойностите от универсален unixtime към разбираем формат 
        static DateTime convertDateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local).ToLocalTime();
            DateTime thisTime = DateTime.Now;
            bool isDaylight = TimeZoneInfo.Local.IsDaylightSavingTime(thisTime);
            if (isDaylight)
            {
                day = day.AddSeconds(seconds).ToLocalTime().AddHours(3);
            }
            else
            {
                day = day.AddSeconds(seconds).ToLocalTime().AddHours(2);
            }
            return day;
        }
        //таймер за скриване на съобщението за грешка след изминали 5 секунди от показване 
        private void timerErrorWeather_Tick(object sender, EventArgs e)
        {
            labErrorWeather.Hide();
            labDateTime.Show();
        }
        //таймер за скриване на съобщението за грешка след изминали 5 секунди от показване 
        private void timerForecastError_Tick(object sender, EventArgs e)
        {
            labForecastError.Hide();
        }  
    }
}

