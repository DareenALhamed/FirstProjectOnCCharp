using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Info
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }

        

       

        public static void ReadInfo(string name, string email, string phone)
        {
            string read = $"Account Name: {name}, Email:{email},Phone Num: {phone}";
            //Audit.WriteToFile(read);
            Console.WriteLine(read);



        }

       /* public static void CreateAccount()
        {
             Console.WriteLine("Please enter your name");
           string name = Console.ReadLine();
            Console.WriteLine("Please enter your email");
           string email = Console.ReadLine();
            Console.WriteLine("Please enter your phone");
           string phone = Console.ReadLine();
            string Create = $"Your Account Deatils is:\nName:{name}\nEmail:{email}\nPhone:{phone}\n" +
                $"It created at {DateTime.Now}";
           // Audit.WriteToFile(Create);
            Console.WriteLine(Create);
            
            
        }*/
    }
}
