﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank
{
    public class Auth
    {
        private Audit audit;
        private User[] users;
        private Admin[] admins;
        private int userCount = 0;
        private int adminCount = 0;

        public string Name { get; set; }
        public string Password { get; set; }
        public Auth(int maxUsers, int maxAdmins)
        {
            users = new User[maxUsers];
            admins = new Admin[maxAdmins];
        }
        public  User Login()
        {

            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
           
            for (int i = 0; i < userCount; i++)
            {
                if (users[i] != null && users[i].Name == name && users[i].Password == password)
                {
                    Console.WriteLine($"Hi {name}, Hope You Enjoy Our Services ");
                    return users[i];

                }
                   
                
                //another method
                // return users.FirstOrDefault(u => u != null && u.Name == name && u.Password == password);// to check the first thing that matches the condition
            }
            return null;
        }

        public void Register(User newUser)
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
            while (userCount < users.Length)
            {
                users[userCount++] = newUser;
                
            }

        }
        public User LoginAdmin()
        {
            Console.WriteLine("Hi Admin!");
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            for (int i = 0; i < adminCount; i++)
            {
                if (admins[i] != null && admins[i].Name == name && admins[i].Password == password)

                    return users[i];

                //another method
                // return users.FirstOrDefault(u => u != null && u.Name == name && u.Password == password);// to check the first thing that matches the condition
            }
            return null;
        }

    }

    

   // public void RegisterAdmin(Admin newAdmin)
    //{
      //  while (adminCount < admins.Length)
      //  {
      //      admins[adminCount++] = newAdmin;
          
      //  }
        
   // }



}
