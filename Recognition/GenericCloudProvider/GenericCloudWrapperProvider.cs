using System;
using GenericCloudCommons.Interfaces;
namespace GenericCloudProvider
{
    public class GenericCloudWrapperProvider
    {
        private readonly IIdentification _identification;

        public IIdentification Identification
        {
            get { return _identification; }
        }

    }
}
