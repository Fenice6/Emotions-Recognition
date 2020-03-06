using System;
using System.Threading.Tasks;
using GenericCloudProvider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Recognition.Services.Interfaces;
using RecognitionCommons.DataModels;

namespace Recognition.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FaceEmotionsController : ControllerBase
    {
        private readonly IEmotionsExtractor _emotionsExtractor;
        public FaceEmotionsController(IEmotionsExtractor emotionsExtractor)
        {
            _emotionsExtractor = emotionsExtractor;
        }

        [HttpPost]
        public async Task<EmotionsReport> GetEmotionsReport([FromForm] EmotionsRecognitionInputDatas emotionsRecognitionInputDatas)
        {
            return new EmotionsReport()
            {
                Report = await this._emotionsExtractor.EmotinsReport(
                    emotionsRecognitionInputDatas.PhotoInput
                )
            };
        }
    }
}
