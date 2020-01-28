using System;
using System.Collections.Generic;

namespace FoodNutritionCalculator
{
    class NutritionList
    {
        List<Item> nutritionList;
        double totalCalories;
        double totalCarbs;
        double totalSugar;
        double totalFat;
        double totalProtein;
        double totalFibre;
        double totalSalt;

        public NutritionList()
        {
            nutritionList = new List<Item>();
            totalCalories=0;
            totalCarbs=0;
            totalSugar=0;
            totalFat=0;
            totalProtein=0;
            totalFibre=0;
            totalSalt=0; //esialgu total on 0
        }

        public double TotalCalories //paneme getter, et keegi ei saaks muuta esialgse total
        {
            get { return totalCalories; }
        }
        public double TotalCarbs 
        {
            get { return totalCarbs; }
        }
        public double TotalSugar 
        {
            get { return totalSugar; }
        }
        public double TotalFat 
        {
            get { return totalFat; }
        }
        public double TotalProtein
        {
            get { return totalProtein; }
        }
        public double TotalFibre 
        {
            get { return totalFibre; }
        }
        public double TotalSalt 
        {
            get { return totalSalt; }
        }

        public void AddToNutritionList(Food food, int quantity)
        {
            Item newItem = new Item(food, quantity); //kasutaja valib toodet ja kogust, see on uus objekt
            nutritionList.Add(newItem); //lisame valitud tooted listi
        }

        public void PrintNutritionList()
        {
            if (nutritionList.Count == 0) //vaatame kas on tühi või mtite
            {
                Console.WriteLine("Your List is empty.");
            }
            else
            {
                foreach (Item item in nutritionList)
                {
                    item.PrintItem();
                }
            }
        }

        public void RemoveFromNutritionList(int id)
        {
            for (int i = 0; i < nutritionList.Count; i++)
            {
                if (nutritionList[i].Food.Id == id)
                {
                    Console.WriteLine($"{nutritionList[i].Food.Name} has been removed");
                    nutritionList.Remove(nutritionList[i]);
                }
            }
            PrintNutritionList();
        }


        public void PrintTotalCalories()
        {
            foreach (Item item in nutritionList)
            {
                totalCalories += item.CalculateItemTotalCalories();
            }
        }
        public void PrintTotalCarbs()
        {
            foreach (Item item in nutritionList)
            {
                totalCarbs += item.CalculateItemTotalCarbs();
            }
        }
        public void PrintTotalSugar()
        {
            foreach (Item item in nutritionList)
            {
                totalSugar += item.CalculateItemTotalSugar();
            }
        }
        public void PrintTotalFat()
        {
            foreach (Item item in nutritionList)
            {
                totalFat += item.CalculateItemTotalFat();
            }
        }
        public void PrintTotalProtein()
        {
            foreach (Item item in nutritionList)
            {
                totalProtein += item.CalculateItemTotalProtein();
            }
        }
        public void PrintTotalFibre()
        {
            foreach (Item item in nutritionList)
            {
                totalFibre += item.CalculateItemTotalFibre();
            }
        }
        public void PrintTotalSalt()
        {
            foreach (Item item in nutritionList)
            {
                totalSalt += item.CalculateItemTotalSalt();
            }
        }


    }
}
