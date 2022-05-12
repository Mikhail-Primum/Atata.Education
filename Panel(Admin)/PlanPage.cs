using Atata;

namespace AtataDemo.UITests
{
    using _ = PlanPage;

    [Url("Account/Login")]
    public class PlanPage : Page<_>
    {
        public TextInput<_> Логин { get; private set; }

        public PasswordInput<_> Пароль { get; private set; }

        public Button<_> Войти { get; private set; }

    }
}