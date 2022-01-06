﻿using Kitchen_Mini_Project.Constants;
using Kitchen_Mini_Project.Moduls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kitchen_Mini_Project.Services
{
    public class ShowAllProducts
    {
        public static void ShowProducts()
        { 
            string json = File.ReadAllText(PathConst.ProductDBPath);

            List<Products> products = JsonConvert.DeserializeObject<List<Products>>(json);

            foreach (Products product in products)
            {   
                ForegroundColor = ConsoleColor.Green; 
                WriteLine($"| {product.foodName} | {product.foodType} | {product.correctedTerm} | {product.calories}" +
                    $" | {product.sideItem} | {product.dressingItem} | {product.protein} | {product.ketchupItem} | " +
                    $"{product.breakfastItem} | {product.carbs} | {product.sodium}");
                ForegroundColor = ConsoleColor.White;
            }

        }

        public static void ChooseRestaurant()
        {
            WriteLine("Which restaurant you want to choose? ");
            string choose = ReadLine();



        }


    }
}
