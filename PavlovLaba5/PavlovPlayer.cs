using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PavlovLaba5
{
    [Serializable]
    public class PavlovPlayer
    {
        public string? name { get; set; }

        public int height { get; set; }

        public double weight { get; set; }

        public int age { get; set; }

        public virtual void InputPlayer()
        {
            Console.WriteLine("Введите имя:");
            while (string.IsNullOrWhiteSpace(name))
            {
                name = Console.ReadLine();
            }

            Console.WriteLine("Введите рост(см):");
            height = GetCorrect.ValidityEnterInteractive<int>(170, 220);

            Console.WriteLine("Введите вес(кг):");
            weight = GetCorrect.ValidityEnterInteractive<double>(45.0, 120.0);

            Console.WriteLine("Введите возраст(лет):");
            age = GetCorrect.ValidityEnterInteractive<int>(14, 65);

        }

        public virtual void OutputPlayer()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
