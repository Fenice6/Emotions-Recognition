# Emotion Recognition
This is a .Net Core backend with goal of create an emotions report of a picture with one face. It's necessary use a cloud service like Amazon Rekognition, implemented in this solution. 

## Framework
This solution is made using .Net Core framework so if you haven't already done download latest version from this link [.Net Core Download](https://dotnet.microsoft.com/download/dotnet-core/3.1).

To update and run solution I sudgest to use [Visual Studio](https://visualstudio.microsoft.com/it/downloads/).

## Solution
This is an API solution with [FaceEmotions](https://github.com/Fenice6/Emotions-Recognition/blob/master/Recognition/Recognition/Controllers/FaceEmotionsController.cs) as a main controller. It use [EmotionExtractor](https://github.com/Fenice6/Emotions-Recognition/blob/master/Recognition/Recognition/Services/EmotionsExtractor.cs) to extract emotions reports. This reports are created with cloud services, like AWS, with *GenericCloudWrapperProvider* class.

### Extend Solution
The solution use a cloud service. It's possible create a new cloud provider just implement [IIdentification](https://github.com/Fenice6/Emotions-Recognition/blob/master/Recognition/GenericCloudCommons/Interfaces/IIdentification.cs). Correct implementation is automatically loaded by *GenericCloudProvider* after configuration.

### Configuration
It's necessary configure solution to work correclty. [Appsettings](https://github.com/Fenice6/Emotions-Recognition/blob/master/Recognition/Recognition/appsettings.json) contains "GenericCloudProvider" section with "DllName" and "IdentificationClass". So it's necessary select correct dll to load with reflection (only at first call of api) and class name that implements *IIdentification*.
If you use AWS services (altready implemented) you have to configure "Profile" and "Region" in "AWS" section in *appsettings*.

### How to use?
If you are running this soluction locally you can call backend with [Postman](https://www.postman.com) using a post to following url `http://localhost:5000/FaceEmotions` with *PhotoInput* inside the Body.

