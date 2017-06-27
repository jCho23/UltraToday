using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UltraToday
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            app.Screenshot("App Launched");
        }

        [Test]
        public void Repl()
        {
            app.Repl();
        }

        [Test]
        public void FirstTest()
        {
			app.Tap("MyEntry");
			app.ClearText();
			app.EnterText("ILoveXamarin");
			app.DismissKeyboard();
        }
    }
}
