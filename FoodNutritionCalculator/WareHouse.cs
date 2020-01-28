using System;
using System.Collections.Generic;

namespace FoodNutritionCalculator
{
    class Warehouse
    {
        List<Food> InStock;

        public Warehouse()
        {
            InStock = new List<Food>(); //kutsume siin välja, et mälu j aega säästa
            Food milk = new Food("milk", 1, Category.DAIRY, 149, 11.7, 12.3, 8, 7.7, 0, 0); //pole faili kust võta, seega loome käsitsi
            InStock.Add(milk);
            Food cheese = new Food("cheese", 2, Category.DAIRY, 416, 0.1, 0.1, 34.9, 25.4, 0, 1.8);
            InStock.Add(cheese);
            Food butter = new Food("butter", 3, Category.DAIRY, 736, 0, 0, 82, 0, 0, 0);
            InStock.Add(butter);
            Food yogurt = new Food("yogurt", 4, Category.DAIRY, 61, 4.7, 4.7, 3.3, 3.5, 0, 0);
            InStock.Add(yogurt);
            Food eggs = new Food("eggs", 5, Category.DAIRY, 143, 0.7, 0, 9.5, 13,0, 0.142);
            InStock.Add(eggs);
            Food beef = new Food("beef", 6, Category.MEAT, 217, 0, 0, 11.8, 26.1, 0, 0);
            InStock.Add(beef);
            Food chicken = new Food("chicken", 7, Category.MEAT, 106, 0, 0, 1.1, 24, 0, 0.2);
            InStock.Add(chicken);
            Food lamb = new Food("lamb", 8, Category.MEAT, 200, 0, 0, 14.1, 18.5, 0, 0.07);
            InStock.Add(lamb);
            Food pork = new Food("pork", 9, Category.MEAT, 136, 0, 0, 5.41, 20.54, 0, 0);
            InStock.Add(pork);
            Food veal = new Food("veal", 10, Category.MEAT, 177, 0.1, 0, 10, 20, 0, 0.098);
            InStock.Add(veal);
            Food duck = new Food("duck", 11, Category.MEAT, 404, 0, 0, 39, 11, 0, 0.063);
            InStock.Add(duck);
            Food salmon = new Food("salmon", 12, Category.FISH, 206, 0, 0, 12, 22, 0, 0.061);
            InStock.Add(salmon);
            Food cod = new Food("atlantic cod",13, Category.FISH, 82, 0, 0, 0.7, 18, 0, 0.054);
            InStock.Add(cod);
            Food pikePerch = new Food("pike perch", 14, Category.FISH, 148, 0, 0, 1.9, 30, 0, 0.081);
            InStock.Add(pikePerch);
            Food pangasius = new Food("pangasius", 15, Category.FISH, 92, 0, 0, 3.5, 15, 0, 0.08);
            InStock.Add(pangasius);
            Food prawns = new Food("prawns", 16, Category.SEAFOOD, 105, 0.9, 0, 1.72, 20.14, 0, 0.047);
            InStock.Add(prawns);
            Food mussels = new Food("mussels", 17, Category.SEAFOOD, 86, 3.69, 0, 2.24, 11.9, 0, 0.286);
            InStock.Add(mussels);
            Food scallops = new Food("scallops", 18, Category.SEAFOOD, 111, 5.4, 0, 0.8, 21, 0, 0.667);
            InStock.Add(scallops);
            Food squid = new Food("squid", 19, Category.SEAFOOD, 92, 3.1, 0, 1.4, 15.6, 0, 0.044);
            InStock.Add(squid);
            Food pasta = new Food("pasta", 20, Category.GRAINS, 355, 73, 0, 1, 7, 2, 0);
            InStock.Add(pasta);
            Food whiteRice = new Food("white rice", 21, Category.GRAINS, 125, 27, 0, 0, 2, 0, 0.365);
            InStock.Add(whiteRice);
            Food buckwheat = new Food("buckwheat", 22, Category.GRAINS, 343, 71.5, 0, 3.4, 13.25, 10, 0.001);
            InStock.Add(buckwheat);
            Food oats = new Food("oats", 23, Category.GRAINS, 374, 60, 1, 8, 11, 9, 0);
            InStock.Add(oats);
            Food whiteBread = new Food("white bread", 24, Category.GRAINS, 265, 49, 5, 3, 9, 2, 0.491);
            InStock.Add(whiteBread);
            Food banana = new Food("banana", 25, Category.FRUITS, 89, 23, 12, 0.3, 1.1, 2.6, 0.001);
            InStock.Add(banana);


        }

        public void PrinInStock() //selle klassi meetod
        {
            foreach (Food food in InStock)
            {
                Console.WriteLine("Nutritiens per 100g");
                Console.WriteLine($"ID: {food.Id}");
                Console.WriteLine($"Product: {food.Name}");
                Console.WriteLine($"Category: {food.Category}");
                Console.WriteLine();
            }
        }

        public Food GetFromStock(int id) //tagastab selle objekti listist id koodi järgi
        {
            return InStock[id - 1]; //kui kasutaja tahab piima, siis ta paneb id 1 aga arvuti jaoks ta on 0 kohal.
        }

    } 
}
