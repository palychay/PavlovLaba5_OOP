namespace PavlovLaba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintMenu()
            {
                Console.WriteLine("1. Добавить волейбольного игрока");
                Console.WriteLine("2. Добавить атакующего");
                Console.WriteLine("3. Просмотр всех");
                Console.WriteLine("4. Сохранить данные");
                Console.WriteLine("5. Загрузить данные");
                Console.WriteLine("6. Очистить");
                Console.WriteLine("0. Выход\n");
            }

            Team team = new();

                do
                {
                    PrintMenu();
                    switch (GetCorrect.ValidityEnterInteractive<int>(0, 6))
                    {
                        case 0:
                            {
                                return;
                            }
                        case 1:
                            {
                                PavlovPlayer player = new();
                                player.InputPlayer();
                                team.AddPlayer(player);
                                Console.WriteLine("Игрок добавлен");
                                break;
                            };
                        case 2:
                            {
                                PavlovAttacker attacker = new();
                                attacker.InputPlayer();
                                team.AddPlayer(attacker);
                                Console.WriteLine("Нападающий добавлен");
                                break;
                            };
                        case 3:
                            {
                                if (team.Players.Count != 0)
                                {
                                    foreach (var pl in team.Players)
                                    {
                                        pl.OutputPlayer();
                                        Console.WriteLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Пусто");
                                }
                                break;
                            };
                        case 4:
                            {
                                team.Save();
                                break;
                            };
                        case 5:
                            {
                                team.Load();
                                break;
                            };
                        case 6:
                            {
                                team.ClearData();
                                break;
                            };

                    }
                } while (true);
            
        }
    }
}
