using System;
using GenericCloudCommons.Interfaces;
using Microsoft.Extensions.Configuration;

namespace GenericCloudProvider
{
    public class GenericCloudWrapperProvider
    {
        private readonly IIdentification _identification;

        public IIdentification Identification
        {
            get { return _identification; }
        }

        public GenericCloudWrapperProvider(IConfiguration config)
        {
            
        }
    }
}
