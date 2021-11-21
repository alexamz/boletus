using DataReader.Interface;

namespace DataReader.Http
{
    public class HttpReader : IDataReader
    {
        //public HttpReader(AppSettingsConfiguration settings)
        //{

        //}

        public WeatherData GetData()
        {
            //string uri = $@"https://api.openweathermap.org/data/2.5/onecall?lat=41.609935&lon=2.029882&exclude=minutely,hourly,daily,alerts&lang=es&units=metric&appid={settings.OpenWeatherMap.ApiKey}";
            throw new NotImplementedException();
        }
    }
}