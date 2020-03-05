using System;
using System.IO;
using System.Reflection;
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
            var dllName = config.GetSection("GenericCloudProvider:DllName");
            if (dllName.Value is null)
                throw new MissingFieldException("GenericCloudProvider: dll name miss");
            var parentFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            var absolutePath = Path.Combine(parentFolder, dllName.Value);
            var dllFile = new FileInfo(absolutePath);
            if (!dllFile.Exists)
                throw new FileNotFoundException("GenericCloudProvider dll miss");
            var provider = Assembly.LoadFile(dllFile.FullName);

            var identificationClass = config.GetSection("GenericCloudProvider:IdentificationClass");
            if (identificationClass.Value is null)
                throw new MissingFieldException("GenericCloudProvider:IdentificationClass miss");
            var identificationType = provider.GetType(identificationClass.Value);
            _identification = (IIdentification)Activator.CreateInstance(identificationType, config);
        }
    }
}
