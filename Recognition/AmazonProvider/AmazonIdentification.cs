using System;
using Amazon.Rekognition;
namespace AmazonProvider
{
    public class AmazonIdentification
    {
        private readonly IAmazonRekognition _amazonRekognition;
        public AmazonIdentification(IAmazonRekognition amazonRekognition)
        {
            _amazonRekognition = amazonRekognition;
        }
    }
}
