using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppUserName_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //problem sttament 1..............5th Assignment
            string username = "john";
            string password = "pass123";
            string validUser;
            string validPassword;
            Console.WriteLine("Enter userName");
            validUser = Console.ReadLine();
            Console.WriteLine("Enter passWord");
            validPassword = Console.ReadLine();
            if (validUser == username && validPassword == password)
            {
                Console.WriteLine("Login Sucessful");
            }
            else if (validUser == username)
            {
                Console.WriteLine("Invalid Password");

            }
            else if (validPassword == password)
            {
                Console.WriteLine("Invalid username");
            }
            else
            {
                Console.WriteLine("Invalid UserName and Password!");
                Console.ReadKey();
            }
        }
    }
}
