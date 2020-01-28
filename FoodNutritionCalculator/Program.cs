using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FoodNutritionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse nutritionStock = new Warehouse(); //objekti sees list nimekirjaga
            NutritionList nutritionListObject = new NutritionList();

            Console.WriteLine("Hello, enter your Daily Calorie Target:");
            double userCalorieTarget = double.Parse(Console.ReadLine());

            nutritionStock.PrinInStock(); //kutsuse Warehouse klassi meetodi välja
            AddItemsToNutritionList(nutritionStock, nutritionListObject); //kutsume funktsiooni välja, et lisada tooted
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Add/Remove/Confirm");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "add")
                {
                    Console.Clear();
                    nutritionStock.PrinInStock();
                    AddItemsToNutritionList(nutritionStock, nutritionListObject);
                }
                else if (userInput == "remove")
                {
                    Console.Clear();
                    nutritionListObject.PrintNutritionList();
                    Console.WriteLine("Enter the id of product to remove from your list:");
                    int itemIdRemove = int.Parse(Console.ReadLine());
                    nutritionListObject.RemoveFromNutritionList(itemIdRemove);
                }
                else if (userInput == "confirm") //kui lisame confirm, siis nöitab meie ostukorvi Total
                {
                    Console.Clear();
                    ConfirmNutritionList(nutritionListObject);
                    break; //lähme programmist välja kui inimene confirmib
                }
             }

            if (userCalorieTarget < nutritionListObject.TotalCalories)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Daily Calorie Intake is over your target! Eat less!");
            }
            else if (userCalorieTarget >= nutritionListObject.TotalCalories)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your Daily Calorie Intake is under your target!");
            }

            
            Console.ReadLine();


        }

            public static void AddItemsToNutritionList(Warehouse currentlyInStock, NutritionList nutritionList) //see ei ole meetod, sest ei ole seotud objektiga
            {
                Console.WriteLine("What did you eat/drink today?");
                int productID = int.Parse(Console.ReadLine());
                Console.WriteLine("How many grams of products did you eat? ");
                int quantityOfProduct = int.Parse(Console.ReadLine());

                Food foodToAdd = currentlyInStock.GetFromStock(productID);
                nutritionList.AddToNutritionList(foodToAdd, quantityOfProduct);
                nutritionList.PrintNutritionList();
            }

           public static void ConfirmNutritionList(NutritionList nutritionList)
        {
            Console.WriteLine("You daily Nutrition List is:");
            nutritionList.PrintTotalCalories();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Calories: {nutritionList.TotalCalories}");
            Console.ResetColor();
            nutritionList.PrintTotalCarbs();
            Console.WriteLine($"Carbohydrates: {nutritionList.TotalCarbs}");
            nutritionList.PrintTotalSugar();
            Console.WriteLine($"Sugar: {nutritionList.TotalSugar}");
            nutritionList.PrintTotalFat();
            Console.WriteLine($"Fat: {nutritionList.TotalFat}");
            nutritionList.PrintTotalProtein();
            Console.WriteLine($"Protein: {nutritionList.TotalProtein}");
            nutritionList.PrintTotalFibre();
            Console.WriteLine($"Fibre: {nutritionList.TotalFibre}");
            nutritionList.PrintTotalSalt();
            Console.WriteLine($"Salt: {nutritionList.TotalSalt}");
        }

       

    }
}
