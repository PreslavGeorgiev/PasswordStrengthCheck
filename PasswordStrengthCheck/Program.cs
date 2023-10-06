namespace PasswordStrengthCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Enter a password:");
                string password = Console.ReadLine();
    
                if(password.Length >= 8) 
                {
                    if (containsUpper(password))
                    {
                        if (containsNum(password))
                        {
                            if (containsSymbol(password))
                            {
                                Console.WriteLine("Your password is very strong!");
                                loop = false;
                            }
                            else
                                Console.WriteLine("Your password should contain at least one symbol!");
                        }
                        else
                            Console.WriteLine("Your password should contain at least one number!");
                    }
                    else
                        Console.WriteLine("Your password should contain at least one capital letter!");
                }
                else
                {
                    Console.WriteLine("Your password is should be at least 8 characters long!");
                }
            }
        }

        public static bool containsNum(string pass)
        {
            return pass.Any(char.IsDigit);
        }

        public static bool containsUpper(string pass)
        {
            return pass.Any(char.IsUpper);
        }

        public static bool containsSymbol(string pass)
        {
            //return (pass.Any(char.IsSymbol) && pass.Any(char.IsPunctuation));

            foreach (char c in pass)
            {
                if (!char.IsLetterOrDigit(c))
                    return true;
            }

            return false;
        }
    }
}