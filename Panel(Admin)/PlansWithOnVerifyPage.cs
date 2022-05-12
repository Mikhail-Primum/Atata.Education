using Atata;
using System;

namespace AtataDemo.UITests
{
    using _ = PlansWithOnVerifyPage;

    [Url("#/home")]
    public class PlansWithOnVerifyPage : Page<_>
    {
        public H1<_> Header { get; private set; }

        protected override void OnVerify()
        {
            base.OnVerify();

            PageUrl.Should.Equal("https://10.1.0.189:195/#/home");
            Content.Should.Contain("Администрирование"); 
        }
    }
}