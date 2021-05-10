using System;
using var16zad6;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            contain Contain = new contain();
            int menu = 0;
            int sum;
            string name;
            while (menu < 10)
            {
                Console.WriteLine("1: add");
                Console.WriteLine("2: del");
                Console.WriteLine("3: print");
                Console.WriteLine("4: all print");
                Console.WriteLine();
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("какой тариф добавить? безлемит/поминут");
                        menu = Convert.ToInt32(Console.ReadLine());
                        sum = Convert.ToInt32(Console.ReadLine());
                        name = Console.ReadLine(); 
                        if(menu == 1)
                        {
                            Contain.add(new bezlemith(name, sum));
                        }
                        else
                        {
                            Contain.add(new MinuteTariff(name, sum));
                        }
                        break;
                    case 2:
                        Console.WriteLine("какой тариф del?");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Contain.Delete(menu);
                        break;
                    case 3:
                        Console.WriteLine("про какой тариф вывести информацию?");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Contain.Print(menu));
                        break;
                    case 4:
                        Console.WriteLine(Contain.printAll());
                        break;
                }
            }
        }
    }
}
