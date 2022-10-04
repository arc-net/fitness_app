using System;

namespace fitness_app.BL.model
{
    public class Food
    {
        public string Name { get; }
        
        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; }

        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get; }

        /// <summary>
        /// Калории
        /// </summary>
        public double Calories { get; }

        public Food(string name)
        {
            // TODO: проверка

            Name = name;
        }
        public Food(string name, double proteins, double fats, double carbohydrates, double calories)
        {
            Name = name;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates  / 100.0;
            Calories = calories / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
