using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace GenericCloudCommons.Interfaces
{
    public interface IIdentification
    {
        Task GenerateNewCollectionAsync(string collectionId);

        Task<string> FaceAnalyzerAsync(IFormFile facePhoto, string collectionID);
    }
}
