/// <summary>
/// Fluent Builder focuses on providing Method Chaining capability to an Object
/// In this example, we will demonstrate the pattern by chaining UI commands, i.e. fill username and password to login.
/// </summary>
namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginPage pageObject = new LoginPage();

            // A usage/application of Fluent Builder
            pageObject
                .EnterUsername("Tester")
                .EnterPassword("Tester Password")
                .ClickLoginButton();
        }
    }
}
