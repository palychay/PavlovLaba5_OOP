using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PavlovLaba5
{
    internal class Team
    {
        public List<PavlovPlayer> Players { get; set; }

        public Team() { Players = []; }

        public void AddPlayer(PavlovPlayer player)
        {
            Players.Add(player);
        }

        public void AddBird(PavlovAttacker attacker)
        {
            Players.Add(attacker);
        }

        public void Save()
        {
            if (Players.Count > 0)
            {
                Console.WriteLine("Введите имя файла: ");
                try
                {
                    string? filename = Console.ReadLine();
                    var xmls = new XmlSerializer(typeof(List<PavlovPlayer>), new[] { typeof(PavlovPlayer), typeof(PavlovAttacker) });
                    using Stream fs = new FileStream($"{filename}.xml", FileMode.OpenOrCreate);
                    xmls.Serialize(fs, Players);
                    Console.WriteLine("Сохранено");
                }
                catch
                {
                    Console.WriteLine("Ошибка сохранения");
                }
            }
            else { Console.WriteLine("Пусто чтобы сохранять"); }
        }

        public void Load()
        {
            Console.WriteLine("Введите название файла:");
            try
            {
                string? fileName = Console.ReadLine();
                var xmls = new XmlSerializer(typeof(List<PavlovPlayer>), new[] { typeof(PavlovPlayer), typeof(PavlovAttacker) });
                using (Stream fs = new FileStream($"{fileName}.xml", FileMode.Open))
                Players = xmls.Deserialize(fs) as List<PavlovPlayer>;
                Console.WriteLine("Данные загружены");
            }
            catch
            {
                Console.WriteLine("Загрузка не удалась");
            }

        }
        public void ClearData()
        {
            Players.Clear();
        }
    }
}
