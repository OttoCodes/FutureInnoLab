using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        Location location;
        CancellationTokenSource cts;

        public MainPage()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            await GetCurrentLocation();
            await DisplayData();
        }
        
        async Task DisplayData()
        {
           var Longitude = location.Longitude;
           var Latitude = location.Latitude;

            var weatherService = new WeatherAppService();
            var weather = await weatherService.GetWeather( Longitude, Latitude);

            Heading.Text = $"The Timezone is {weather.timezone}";

            var icon = weather.current.weather[0].icon;
            Weathericon.Source = $"https://openweathermap.org/img/wn/{icon}@4x.png";

            string weatherteamp;
            Tempp.Text = $"{weather.current.temp}°";

            
            FeelsLike.Text = $"It feels like {weather.current.feels_like}°" ;
   
            weatherteamp = weather.current.weather[0].main.ToString();
            Main.Text = weatherteamp;

            weatherteamp = weather.current.weather[0].description.ToString();
            Descr.Text = weatherteamp;


            Winddegree.Text = $"The wind direction is { weather.current.wind_deg}";

            Clouds.Text = $"Cloud cover is {weather.current.clouds}%";

            Humidity.Text = $"Humidity is {weather.current.humidity}%";

            WindSpeed.Text = $"The wind speed is {weather.current.wind_speed}";

            UVrays.Text = $"Midday UV rays is {weather.current.uvi}%";
        }

        async Task GetCurrentLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                location = await Geolocation.GetLocationAsync(request, cts.Token);

                //if (location != null)
                //{
                //    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                //}
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }

        protected override void OnDisappearing()
        {
            if (cts != null && !cts.IsCancellationRequested)
                cts.Cancel();
            base.OnDisappearing();
        }
    }
}

