using System.Security.AccessControl;
using System.Security.Principal;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            Audit audit = new Audit("audit_log.txt");
            Auth auth = new Auth(100,10);
            User[] userIndex = new User[100];

            User newUser = new User { Id =2, Name = "User2", Password = "password1" };// the array register in auth class
           // auth.Register(newUser);
           // User user = auth.Login();

            static void Menu()
            {
                Console.WriteLine("1. Register User");
                Console.WriteLine("2. Login User");
                Console.WriteLine("3. Login Admin");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Your Choice: ");

            }

             Console.WriteLine("Welcome To The National Bank, PLease Enter You Choice");
              Menu();
              int option = int.Parse(Console.ReadLine());
              bool exit = true;

              switch (option)
              {

                  case 1:
                      auth.Register(newUser);
                      break;

                  case 2:
                      auth.Login();


                      break;
                  case 3:
                      auth.LoginAdmin();
                      break;

                  case 4:
                          exit = true;
                      break;

                  default:
                      Console.WriteLine("Invalid!PLease Enter Number Between 1 and 5");

                      break ;





              }


            // if login successed

           /* static void UserMenu()
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");

            }
            UserMenu();
            int options = int.Parse(Console.ReadLine());

            bool exits = true;
            switch (options)
            {

                case 1:
                    bankAccount.Deposit();
                    break;

                case 2:
                    bankAccount.Withdraw();


                    break;
                case 3:
                    auth.LoginAdmin();
                    break;

                case 4:
                    exits = true;
                    break;

                default:
                    Console.WriteLine("Invalid!PLease Enter Number Between 1 and 3");

                    break;





            }*/

            /*  if (user != null)
              {
                  Console.WriteLine("Login successful!");


                  BankAccount account = new BankAccount { AccountNumber = "123", Balance = 0 };



                  // Display balance
                  Console.WriteLine($"Balance for account {account.AccountNumber}: {account.Balance}");
                  //Console.WriteLine($"Balance for account {anotherAccount.AccountNumber}: {anotherAccount.Balance}");
              }
              else
              {
                  Console.WriteLine("Login failed!");
              }*/









        }
    }
}
