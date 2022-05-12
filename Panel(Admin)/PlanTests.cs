using Atata;
using FakeItEasy;
using NUnit.Framework;

namespace AtataDemo.UITests
{
    [TestFixture]
    public class PlanTest
    {

        [Test]
        public void PlanPage()
        {
            Go.To<PlanPage>()

                .Логин.Set("kandksdc@gmail.com")
                .Пароль.Set("777777")
                .Войти.Click();
        }

        [Test]
        public void PrimaryPageDataVerification_OnVerify()
        {
            Go.To<PlansWithOnVerifyPage>();
        }

        [Test]
        public void SomePage()
        {
            Go.To<SomePage>()
                .VisibleElement.Should.Exist();
        }
    }
}
