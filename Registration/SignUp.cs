﻿using Kitchen_Mini_Project.IRepositories;
using Kitchen_Mini_Project.Moduls;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Mini_Project.Enums;

namespace Kitchen_Mini_Project.Registration
{
    public class SignUp
    {
        public static User SignUpUser()
        {
            while (true)
            {
                try
                {
                    var user = new User()
                    {
                        FirstName = "Muhammadabdulloh",
                        LastName = "Komilov",
                        Login = "Komilov1",
                        Password = "190675"
                    };
                    return user;
                }
                catch
                {
                    WriteLine("Qandaydur hatolik ketdi boshqatdan kiriting: ");
                    continue;
                }
            }
        }
        
    }
}
