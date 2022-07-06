using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TudoApi;

namespace TodoApi.Controllers;

[Produces("application/json")]
[ApiController]
[Route("api/Todo")]
public class WeatherForecastController : ControllerBase
{   WeatherForecast _todoForescast = new WeatherForecast();
    [Route("~/api/GetAllTodos")]
    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
        {
            return _todoForescast.GetAll();
        }

    [Route("~/api/AddTodo")]
    [HttpPost]
    public ActionResult<WeatherForecast> Post([FromBody] WeatherForecast value)
        {
             Console.WriteLine(value?.Id);
             Console.WriteLine(value?.nomeCompleto);
             Console.WriteLine(value?.email);
             Console.WriteLine(value?.emailConfirmation);
             Console.WriteLine(value?.cpf);
             Console.WriteLine(value?.nascimento);
             Console.WriteLine(value?.emailSms);
             Console.WriteLine(value?.whatsapp);
             Console.WriteLine(value?.pais);
             Console.WriteLine(value?.cep);
             Console.WriteLine(value?.endereco);
             Console.WriteLine(value?.numero);

    var item = _todoForescast.Save(value);
    if(item != null)
        return (ActionResult<WeatherForecast>)item;

    return BadRequest();
        }
    
}
