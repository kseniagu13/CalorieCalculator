using System;
namespace FoodNutritionCalculator
{
    class Item
    {
        Food food;
        int quantity;

        public Item (Food _food, int _quantity)
        {
            food = _food;
            quantity = _quantity;
        }

        public Food Food
        {
            get { return food; }
        }

        public void PrintItem()
        {
            Console.WriteLine($" Nutritiens per 100g \n Food Id: {food.Id} \n Name: {food.Name} \n Category: {food.Category} \n Calories: {CalculateItemTotalCalories()} \n Carbohydrates: {CalculateItemTotalCarbs()} \n Sugar: {CalculateItemTotalSugar()} \n Fat: {CalculateItemTotalFat()} \n Protein: {CalculateItemTotalProtein()} \n Fibre: {CalculateItemTotalFibre()} \n Salt: {CalculateItemTotalSalt()} \n ");
             
        }

        public double CalculateItemTotalCalories() //tagastab double tüüpi vastuse
        {
            return food.Calories * quantity/100;
        }
        public double CalculateItemTotalCarbs() 
        {
            return food.Carbohydrates * quantity/100;
        }
        public double CalculateItemTotalSugar() 
        {
            return food.Sugar * quantity/100;
        }
        public double CalculateItemTotalFat() 
        {
            return food.Fat * quantity/100;
        }
        public double CalculateItemTotalProtein() 
        {
            return food.Protein * quantity/100;
        }
        public double CalculateItemTotalFibre() 
        {
            return food.Fibre * quantity/100;
        }
        public double CalculateItemTotalSalt() 
        {
            return food.Salt * quantity/100;
        }



    }

}
