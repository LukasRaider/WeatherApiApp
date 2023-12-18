using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Shared {
    public class WeatherService {
        //https://api.weatherapi.com/v1/current.json?key=2f3d5a0c8d0a4dd7986132149232003&q=London&aqi=no
        string apiKey = "8e8fa98598464f778a395930231312";
        IWeatherView weatherView;

        public WeatherService(IWeatherView weatherView) {
            this.weatherView = weatherView;
        }

        public async Task GetWeatherForCityAsync(string city) {
            var client = new HttpClient();
            var response= await client.GetAsync($"https://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}&aqi=no");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                var weatherModel= JsonConvert.DeserializeObject<WeatherModel>(content);
                System.Diagnostics.Debug.WriteLine($"{weatherModel.Location.Name}: temperature: {weatherModel.Current.Temp_c}");
                weatherView.SetWeatherData(weatherModel);
            }
        }
    }
}
