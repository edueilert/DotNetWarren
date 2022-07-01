using System;
namespace TodoApi;

public class WeatherForecast
{
    public long Id { get; set; }
    public string? nomeCompleto { get; set; }
    public string? email { get; set; }
    public string? emailConfirmation { get; set; }
    public string? cpf { get; set; }
    public string? cellphone { get; set; }
    public DateTime nascimento { get; set; }
    public bool emailSms { get; set; }
    public bool whatsapp { get; set; }
    public string? pais { get; set; }
    public string? cep { get; set; }
    public string? endereco { get; set; }
    public int numero { get; set; }
}