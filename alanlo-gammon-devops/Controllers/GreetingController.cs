using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore.Mvc;

namespace alanlo_gammon_devops.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        public string Get(int id)
        {
            TelemetryConfiguration configuration = TelemetryConfiguration.CreateDefault();
            configuration.InstrumentationKey = "61b7fb78-d207-411d-b7c5-59df48e5703f";
            var telemetryClient = new TelemetryClient(configuration);
            telemetryClient.TrackTrace($@"4.0 Greeting Controller Get Id: {id}");
            return "Hello World 4.0!";
        }
    }
}