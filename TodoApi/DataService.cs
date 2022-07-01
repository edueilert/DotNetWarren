using TodoApi;

namespace TudoApi
{
    public class DataService
    {
        public List<WeatherForecast> Data { get; set; } = new List<WeatherForecast>();
        public void Add()
        {
        Data.Add(new WeatherForecast() { Id = 1, nomeCompleto = "Eduardo Rodrigues", email = "eduardo.rodrigues@warren.com", emailConfirmation = "eduardo.rodrigues@warren.com", cpf = "87405863049", cellphone = "51985784290", nascimento = DateTime.FromOADate(26-01-2002), emailSms = true, whatsapp = false, pais = "Brasil", cep = "91340370", endereco = "Rua Ramis Galvão", numero = 222}); 

        Data.Add(new WeatherForecast() { Id = 2, nomeCompleto = "Nia Mello", email = "nia.melo@warren.com", emailConfirmation = "nia.mello@warren.com", cpf = "85409853076", cellphone = "51946836290", nascimento = DateTime.FromOADate(24-11-1999), emailSms = false, whatsapp = true, pais = "Brasil", cep = "91440330", endereco = "Rua Santo Amaro", numero = 57});

        Data.Add(new WeatherForecast() { Id = 3, nomeCompleto = "Lucca Chalmes", email = "lucas.chalmes@warren.com", emailConfirmation = "lucas.chalmes@warren.com", cpf = "89465773840", cellphone = "51982042900", nascimento = DateTime.FromOADate(27-01-2005), emailSms = true, whatsapp = false, pais = "Brasil", cep = "81220200", endereco = "Rua Pão de Açucar", numero = 73});

        Data.Add(new WeatherForecast() { Id = 4, nomeCompleto = "Agnes Vargas", email = "agnes.vitoria@warren.com", emailConfirmation = "agnes.vitoria@warren.com", cpf = "85995873544", cellphone = "51986784570", nascimento = DateTime.FromOADate(13-04-2004), emailSms = true, whatsapp = false, pais = "Chile", cep = "71043380", endereco = "Rua Aguacate", numero = 373});

        Data.Add(new WeatherForecast() { Id = 5, nomeCompleto = "Juliana Kolmar", email = "juliana.kolmar@warren.com", emailConfirmation = "juliana.kolmar@warren.com", cpf = "95409874055", cellphone = "51995744280", nascimento = DateTime.FromOADate(09-12-2002), emailSms = true, whatsapp = true, pais = "Brasil", cep = "81540200", endereco = "Avenida Tosse de Getulio", numero = 2});

        Data.Add(new WeatherForecast() { Id = 6, nomeCompleto = "Yasmin Ferreira", email = "yasmin.ferreira@warren.com", emailConfirmation = "yasmin.ferreira@warren.com", cpf = "99005577074", cellphone = "51995784393", nascimento = DateTime.FromOADate(25-03-2002), emailSms = false, whatsapp = true, pais = "Brasil", cep = "91550380", endereco = "Alameda Twitter dos Santos", numero = 36});
    }
}
}