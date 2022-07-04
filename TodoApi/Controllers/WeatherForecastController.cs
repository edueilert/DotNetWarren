using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
    [HttpGet]
    public IEnumerable<WeatherForecast> Post()
        {
            return _todoForescast.Add();
        }
    
}
