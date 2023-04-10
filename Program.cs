using System;
using System.IO;
using System.Media;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace С__firstapp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.Beep(200, 200);
            Console.Beep(300, 200);

            string consoles = "start console";
            string cas = File.ReadAllText("commands.txt");
            File.WriteAllText("commands.txt", $"{cas}\n{consoles}");
            while (true)
            {
            
                string command;
                Console.Write(">>");
                Console.ForegroundColor = ConsoleColor.Blue;
                command = Console.ReadLine();
                Console.ResetColor();

                if (command == "clear")
                { Console.Clear(); consoles = "clear"; }
                else if (command == "help")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Список доступных команд:");
                    Console.WriteLine("delete - удаление файлов");
                    Console.WriteLine("clear - очистка консоли");
                    Console.WriteLine("dir create - создание папки");
                    Console.WriteLine("about - информация о системе");
                    Console.WriteLine("exit - выход");
                    Console.WriteLine("create - создание файла");
                    Console.WriteLine("download - скачивание файла");
                    Console.WriteLine("DateTime - выводит дату и время");
                    Console.WriteLine("workpath - вывод пути расположения программы");
                    Console.WriteLine("play - проигрывает музыку");
                    Console.WriteLine("game,game2 - миниигры");
                    Console.WriteLine("history - история команд(всё в файле)");
                    Console.WriteLine("history clear - удаляет историю команд(всё в файле)");
                    Console.ResetColor();
                    Console.Beep(500, 200);
                    Console.Beep(400, 200);
                    consoles = "help";
                }

                else if (command == "history")
                {
                    string casu = File.ReadAllText("commands.txt");
                    Console.WriteLine(casu);

                }



                

                else if (command == "about")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.WriteLine("о програме:");
                    Console.WriteLine("Version - 0.2.1.cv");
                    Console.WriteLine("02.04.2023");
                    Console.WriteLine();
                    Console.WriteLine("о системе:");
                    Console.WriteLine("версия системы: " + Environment.OSVersion);
                    Console.WriteLine("число процессоров: " + Environment.ProcessorCount);
                    Console.WriteLine("имя пк: " + Environment.MachineName);
                    Console.WriteLine("Модель процессора:" + Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"));
                    Console.WriteLine("Имя текущего пользователя:" + Environment.UserName);
                    Console.Beep(500, 200);
                    Console.Beep(400, 200);
                    Console.Beep(600, 200);
                    consoles = "about";
                    Console.ResetColor();
                }

                else if (command == "delete")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("введите путь");
                    Console.Write(">>");
                    string FileName = Console.ReadLine();
                    File.Delete(FileName);
                    Console.ResetColor();
                    consoles = "delete";
                }

                else if (command == "dir create")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("введите путь к папке и название");
                    string dir = Console.ReadLine();
                    Console.ResetColor();
                    Directory.CreateDirectory(dir);
                    consoles = "dir create";
                }

                else if (command == "create")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("введите расположение и название файла");
                    Console.Write(">>");
                    string file = Console.ReadLine();
                    Console.ResetColor();
                    File.Create(file);
                    consoles = "create";
                }

                else if (command == "exit")
                {
                    Console.Beep(500, 200);
                    Console.Beep(900, 200);
                    consoles = "exit";
                    break;
                }

                else if (command == "download")
                {
                    WebClient webcl = new WebClient();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("ссылка на файл \n>>");
                    string web = Console.ReadLine();
                    Console.Write("как и куда сохранить файл \n>>");
                    string filename = Console.ReadLine();
                    Console.ResetColor();
                    webcl.DownloadFile(web, filename);
                    consoles = "download";
                }

                else if (command == "workpath")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("вы работаете по пути " + Environment.CurrentDirectory);
                    Console.ResetColor();
                    consoles = "workpath";
                }

                else if (command == "DateTime")
                {
                    DateTime dateTime = DateTime.Now;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Текущее время и число: " + dateTime);
                    Console.ResetColor();
                    consoles = "DateTime";
                }

                else if (command == "play")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    SoundPlayer player = new SoundPlayer();
                    Console.WriteLine("укажите путь до музыки в формате wav");
                    Console.Write(">>");
                    string music = Console.ReadLine();
                    player.SoundLocation = music;
                    player.Play();
                    Console.ResetColor();
                    consoles = "play";
                }

                else if (command == "game2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    int a, b, c, o;
                    Random a1 = new Random();
                    Random b1 = new Random();
                    Random c1 = new Random();

                    a = a1.Next(2, 100);
                    b = b1.Next(51, 100);
                    c = c1.Next(77, 200);
                    int o2 = a + b + c;
                    Console.WriteLine($"сложите {a} {b} {c}");
                    Console.Write(">>");
                    o = Convert.ToInt32(Console.ReadLine());

                    if (o == o2)
                    {
                        Console.WriteLine("поздравляем вы выиграли");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();

                    }

                    else
                    {
                        Console.WriteLine("вы проигали");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                    Console.ResetColor();
                    consoles = "game2";

                }

                else if (command == "game")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.WriteLine("В этой игре вы должны угадать загадонное число от 1 до 5");

                    consoles = "game";

                    for (int i = 5; i >= 0; i--)
                    {
                        Random sus = new Random();
                        string game = Convert.ToString(sus.Next(1, 6));
                        Console.Write(">>");
                        string game2 = Console.ReadLine();

                        if (i == 0)
                        {
                            Console.WriteLine("game over");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }

                        else if (game == game2)
                        {
                            Console.WriteLine("you win");
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }


                        else
                        {
                            Console.WriteLine("неверно осталось попыток:" + i);
                        }
                    }
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Неизвестная команда '" + command + "' введите help чтобы увидеть список команд");
                    Console.ResetColor();
                    consoles = "error command";
                }
                cas = File.ReadAllText("commands.txt");
                File.WriteAllText("commands.txt",$"{cas}\n{consoles}");
            }
        }
    }
}

