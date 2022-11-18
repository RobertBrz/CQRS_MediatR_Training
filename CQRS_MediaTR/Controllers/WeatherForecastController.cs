using CQRS_MediaTR.Notification;
using CQRS_MediaTR.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_MediaTR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IMediator _mediator;


        private readonly ILogger<WeatherForecastController> _logger;


        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            await _mediator.Publish(new AddInfoNotification() { Message = "testmessage" });

            var request = new GetWeatherQuery { DayOfTheMonth = 20 };
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}