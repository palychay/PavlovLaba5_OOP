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
    public class PavlovAttacker: PavlovPlayer
    {
        public int power { get; set; }
        public double jump {  get; set; }
        public override void InputPlayer()
        {
            base.InputPlayer();
            Console.WriteLine("Введите мощность удара(км/ч):");
            power = GetCorrect.ValidityEnterInteractive<int>(50, 150);

            Console.WriteLine("Введите прыжок(см):");
            jump = GetCorrect.ValidityEnterInteractive<double>(45.0, 150.0);
        }

        public override void OutputPlayer()
        {
            base.OutputPlayer();
            Console.WriteLine($"Power: {power}");
            Console.WriteLine($"Jump: {jump}");
        }
    }
}
