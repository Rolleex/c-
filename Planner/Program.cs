using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;

            int p, rem;
            List<string> note = new List<string>();
            do
            {
                try
                {

                    Console.WriteLine("Что вы хотите сделать? " + "\n 1 - Добавить задачу. " + "\n 2-Удалить задачу. " + "\n 3-Редактировать задачу." + "\n Для выхода из программы, нажмите комбинацию клавиш ALT+F4");
                    p = Convert.ToInt32(Console.ReadLine());
                    switch (p)
                    {
                        case 1:
                            Console.WriteLine("Введите новую заметку");
                            string newElement = "";
                            newElement = Console.ReadLine();
                            note.Add(newElement);

                            for (int i = 0; i < note.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + note[i]);

                            }
                            break;
                        case 2:
                            Console.WriteLine("Какой пункт удалить?");
                            rem = Convert.ToInt32(Console.ReadLine());
                            if (rem > note.Count)
                            {
                                Console.WriteLine("Такого элемента не существует");
                                continue;
                            }
                            note.RemoveAt(rem - 1);
                            for (int i = 0; i < note.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + note[i]);
                            }

                            break;
                        case 3:
                            string newitem;
                            int red;
                            Console.WriteLine("Какой элемент хотите редактировать?");
                            red = Convert.ToInt32(Console.ReadLine());
                            if (red > note.Count)
                            {
                                Console.WriteLine("Такого элемента не существует");
                                continue;
                            }
                            Console.WriteLine("Введите пометку");
                            newitem = Convert.ToString(Console.ReadLine());
                            note.RemoveAt(red - 1);
                            note.Insert((red - 1), newitem);
                            for (int i = 0; i < note.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + note[i]);
                            }
                            break;
                        default:
                            Console.WriteLine("Такой функции не существует");
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат ввода");
                }

                try
                {
                    Console.WriteLine("Для выхода из программы нажмите n \nДля продожения работы нажмите любую клавишу");
                    Char answer;
                    answer = Convert.ToChar(Console.ReadLine());
                    if (answer == 'y')
                    {
                        continue;
                    }
                    else if (answer == 'n')
                    {
                        result = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Неверный формат ввода");
                    continue;
                }
            } while (result == false);
            Console.WriteLine("Нажмите любую клавишу для выхода из программы.");
            Console.ReadKey();
        }
    }

}


