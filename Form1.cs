using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WeatherApp.Models;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "b3c858bd1174157ec154e307227ee958";
        double lon;
        double lat;


        double convertToCelcius(double kelvin)
        {
            var celcius = (kelvin - 273.15);
            return celcius;
        }

        DateTime dateTimeConverter(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();
            return day;

        }

        async void getWeather()
        {
            try
            {
                HttpClient web = new HttpClient();
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", cityTB.Text, APIKey);
                var json = await web.GetStringAsync(url);
                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                picIcon.ImageLocation = "https://openweathermap.org/img/w/04d.png";
                labelCondition.Text = info.weather[0].main;
                labelDetails.Text = info.weather[0].description;
                sunriseInfo.Text = dateTimeConverter(info.sys.sunrise).ToShortTimeString();
                sunsetInfo.Text = dateTimeConverter(info.sys.sunset).ToShortTimeString();
                tempInfo.Text = convertToCelcius(info.main.temp).ToString() + "°";

                lon = info.coord.lon;
                lat = info.coord.lat;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Caught Exception");
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
            }
        }


        async void getForecast()
        {
            try
            {
                HttpClient web = new HttpClient();
                string url = string.Format("api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid={2}", lat, lon, APIKey);
                var json = await web.GetStringAsync(url);
                ForecastInfo.ForecastInf info = JsonConvert.DeserializeObject<ForecastInfo.ForecastInf>(json);

                ForecastForm FUC = new ForecastForm();
                for (int i = 0; i < 40; i += 8)
                {
                    
                    FUC.pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + info.list[i].weather[0].icon + ".png";
                    FUC.DTLab.Text = dateTimeConverter(info.list[i].dt).DayOfWeek.ToString();
                    FUC.condLabel.Text = info.list[i].weather[0].main;
                    FUC.descLabel.Text = info.list[i].weather[0].description;
                    FUC.tempLabel.Text = convertToCelcius(info.list[i].main.temp).ToString();
                    FUC.minLabel.Text = convertToCelcius(info.list[i].main.temp_min).ToString();
                    FUC.maxLabel.Text = convertToCelcius(info.list[i].main.temp_max).ToString();

                    FLP.Controls.Add(FUC);


                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cityTB_TextChanged(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}