using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TomShirley.EFCore.Sample.Endpoint.Configuration;

namespace TomShirley.EFCore.Sample.Endpoint.Controllers
{
    [Route("status")]
    public class StatusController : ControllerBase
    {
        private readonly StatusSetting _statusSettings;

        public StatusController(IOptions<StatusSetting> statusSettings)
        {
            _statusSettings = statusSettings.Value;
        }

        [HttpGet]
        public string Get()
        {
            return $"TomShirley.EFCore.Sample.Endpoint.Controllers is running at version {_statusSettings.ApiVersion}";
        }
    }
}
