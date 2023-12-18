using Shared;

namespace WeatherForms {
    public partial class Form1 : Form, IWeatherView {
        WeatherService weatherService;
        public Form1() {
            InitializeComponent();
            weatherService = new WeatherService(this);
        }

        public void SetWeatherData(WeatherModel model) {
            lbCity.Text = model.Location.Name;
            lbPrecipitation.Text = $"Precipitation: {model.Current.Precip_mm} mm";
            lbTemperature.Text = $"{model.Current.Temp_c} °C";
            lbWeather.Text = $"{model.Current.Condition.Text}";
            lbWind.Text = $"{model.Current.Wind_dir} {model.Current.Wind_kph} km/h";
        }

        private async void cbCity_SelectedIndexChanged(object sender, EventArgs e) {
            string city = cbCity.SelectedItem.ToString();
            await weatherService.GetWeatherForCityAsync(city);
        }
    }
}