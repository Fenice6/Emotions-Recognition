using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Recognition.Services.Interfaces
{
    public interface IEmotionsExtractor
    {
        Task<string> EmotinsReport(IFormFile PhotoInput);
    }
}
