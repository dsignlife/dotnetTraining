using System;

namespace Kattis1
{
    class Program
    {
        public class Ingredient
        {
            public string name { set; get; }
            public double weight { set; get; }
            public double percent { set; get; }

            public Ingredient(string _name, double _weight, double _percent)
            {
                name = _name;
                weight = _weight;
                percent = _percent / 100; ;
            }
        }

        public static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());

            for (int recipeNum = 1; recipeNum <= cases; recipeNum++)
            {
                string[] recipeData = Console.ReadLine().Split(" ");
                int totalIngredient = Convert.ToInt32(recipeData[0]);
                double scaleWeight = Convert.ToDouble(recipeData[2]) / Convert.ToDouble(recipeData[1]);
                double main = 0;

                var i = new Ingredient[totalIngredient];

                for (int x = 0; x < totalIngredient; x++)
                {
                    var ingredientInfo = Console.ReadLine().Split(" ");
                    string name = ingredientInfo[0];
                    double weight = Convert.ToDouble(ingredientInfo[1]);
                    double percent = Convert.ToDouble(ingredientInfo[2]);

                    i[x] = new Ingredient(name, weight, percent);

                    if (i[x].percent == 1)
                        main = scaleWeight * i[x].weight;
                }
                Console.WriteLine($"Recipe # {recipeNum}");

                foreach (var e in i)
                {
                    Console.WriteLine($"{e.name} {e.percent * main:0.0}");
                }
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}