using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataDemo.UITests
{
    using _ = SomePage;

    public class SomePage : Page<_>
    {
        [FindById("leftMenu", Visibility = Visibility.Visible)]
        public Control<_> VisibleElement { get; private set; }
    }
}
