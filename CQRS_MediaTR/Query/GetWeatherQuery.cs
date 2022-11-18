using MediatR;
using System.Security.Principal;

namespace CQRS_MediaTR.Query
{
    public class GetWeatherQuery : IRequest<List<WeatherForecast>>
    {
        //query parameters 

        public int DayOfTheMonth { get; set; }
    }
}
