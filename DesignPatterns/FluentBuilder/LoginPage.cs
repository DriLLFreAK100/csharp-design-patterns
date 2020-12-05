using System;

namespace FluentBuilder
{
    public class LoginPage
    {
        public LoginPage EnterUsername(string username)
        {
            // Get username input element, fill it up, etc.
            Console.WriteLine($"Entered username: {username}");
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            // Get password input element, fill it up, etc.
            Console.WriteLine($"Entered password: {password}");
            return this;
        }

        public void ClickLoginButton()
        {
            // Get login button element, invoke a click
            Console.WriteLine("Clicked Login Button");
        }
    }
}
