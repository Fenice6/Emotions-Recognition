using System;
using System.Threading.Tasks;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;

namespace AmazonProvider
{
    public class AmazonIdentification
    {
        private readonly IAmazonRekognition _amazonRekognition;
        public AmazonIdentification(IAmazonRekognition amazonRekognition)
        {
            _amazonRekognition = amazonRekognition;
        }

        public async Task GenerateNewCollectionAsync(string collectionId)
        {
            CreateCollectionResponse createCollectionResponse = await this._amazonRekognition.CreateCollectionAsync(
                new CreateCollectionRequest
                {
                    CollectionId = collectionId
                }
            );
            if (createCollectionResponse.HttpStatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception(createCollectionResponse.HttpStatusCode.ToString());
        }
    }
}
