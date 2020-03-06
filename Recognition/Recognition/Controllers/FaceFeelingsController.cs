using GenericCloudProvider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Recognition.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FaceFeelingsController : ControllerBase
    {
        private readonly GenericCloudWrapperProvider _genericCloudWrapperProvider;
        private readonly IConfiguration _config;
        public FaceFeelingsController(IConfiguration config)
        {
            _genericCloudWrapperProvider = new GenericCloudWrapperProvider(config);
            _config = config;
        }
    }
}
