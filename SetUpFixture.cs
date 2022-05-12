using Atata;
using NUnit.Framework;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace AtataDemo.UITests
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            // Find information about AtataContext set-up on https://atata.io/getting-started/#set-up
            AtataContext.GlobalConfiguration
                .UseChrome().WithArguments("ignore-certificate-errors", "start-maximized")
                .UseBaseUrl("https://10.1.0.189:195/")
                .UseCulture("en-US")
                .UseAllNUnitFeatures()
                .AddScreenshotFileSaving()
                .WithArtifactsFolderPath();

         
            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }
    }
}
