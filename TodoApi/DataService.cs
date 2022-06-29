using TodoApi;

namespace TudoApi
{
    public class DataService
    {
        public List<WeatherForecast> Data { get; set; } = new List<WeatherForecast>();
        public void Add()
        {
        Data.Add(new WeatherForecast() { Id = 1234, nomeCompleto = "Eduardo Rodrigues", email = "edurodrigues51@gmail.com", emailConfirmation = "edurodrigues51@gmail.com", cpf = "87405873049", cellphone = "51985784290"});
        Data.Add(new WeatherForecast() { PartName = "chain ring", PartId = 1334 });
        Data.Add(new WeatherForecast() { PartName = "regular seat", PartId = 1434 });
        Data.Add(new WeatherForecast() { PartName = "banana seat", PartId = 1444 });
        Data.Add(new WeatherForecast() { PartName = "cassette", PartId = 1534 });
        Data.Add(new WeatherForecast() { PartName = "shift lever", PartId = 1634 });
        }
    }
}