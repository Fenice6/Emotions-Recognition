using System;
using System.Threading.Tasks;
using GenericCloudProvider;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Recognition.Services.Interfaces;

namespace Recognition.Services
{
    public class EmotionsExtractor : IEmotionsExtractor
    {
        private readonly GenericCloudWrapperProvider _genericCloudWrapperProvider;
        private readonly IConfiguration _config;
        public EmotionsExtractor(IConfiguration config)
        {
            _genericCloudWrapperProvider = new GenericCloudWrapperProvider(config);
            _config = config;
        }
        public async Task<string> EmotinsReport(IFormFile PhotoInput)
        {
            string collectionID = Guid.NewGuid().ToString();
            await this._genericCloudWrapperProvider.Identification.GenerateNewCollectionAsync(collectionID);
            return await this._genericCloudWrapperProvider.Identification.FaceAnalyzerAsync(
                    PhotoInput,
                    collectionID
                );
        }
    }
}
