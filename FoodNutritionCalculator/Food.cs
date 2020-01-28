using System;
using System.Collections.Generic;

namespace FoodNutritionCalculator
{
    
        enum Category
        {
            DAIRY,
            MEAT,
            VEGETABLES,
            FRUITS,
            GRAINS,
            NUTS,
            FISH,
            SEAFOOD,
            CONFECTIONARY,
            BEVERAGES,
            PASTRY
        }

    class Food
    {
        string name;
        int id;
        Category category;
        int calories;
        double carbohydrates;
        double sugar;
        double fat;
        double protein;
        double fibre;
        double salt;
      


        public Food(string _name, int _id, Category _category, int _calories, double _carbohydrates, double _sugar, double _fat, double _protein, double _fibre, double _salt)
        {
            name = _name;
            id = _id;
            category = _category;
            calories = _calories;
            carbohydrates = _carbohydrates;
            sugar = _sugar;
            fat = _fat;
            protein = _protein;
            fibre = _fibre;
            salt = _salt;
            
        }

        public string Name
        {
            get { return name; }
        }

        public int Id
        {
            get { return id; }
        }

        public int Calories
        {
            get { return calories; }
        }

        public double Carbohydrates
        {
            get { return carbohydrates; }
        }

        public double Fat
        {
            get { return fat; }
        }

        public double Sugar
        {
            get { return sugar; }
        }

        public double Protein
        {
            get { return protein; }
        }

        public double Fibre
        {
            get { return fibre; }
        }

        public double Salt
        {
            get { return salt; }
        }

        public string Category
        {
            get { return category.ToString(); } //koverteerime sõnaks
        }
    }


}
