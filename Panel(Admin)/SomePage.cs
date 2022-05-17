using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataDemo.UITests
{
    using _ = SomePage;

    public class SomePage : Page<_>
    {
        [FindByContent("Администрирование", Visibility = Visibility.Visible)]
        public Control<_> Администрирование { get; private set; }

        [FindByContent("Отчёты", Visibility = Visibility.Visible)]
        public Control<_> Отчёты { get; private set; }
    }

}
