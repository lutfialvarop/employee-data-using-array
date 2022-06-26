using System;

namespace ConsoleAppPT
{
    class Program
    {
        public static int[] ids = {1,2,3,4,5}; // Modifiable
        public static string[] names = new string[5];
        
        static void Main(string[] args)
        {
            int a;
            bool repeat = true;

            Console.WriteLine("===================");
            Console.WriteLine("===== Welcome =====");
            Console.WriteLine("===================");
            while (repeat == true)
            {
                Console.WriteLine("\n===================");
                Console.WriteLine("===== Employee ====");
                Console.WriteLine("= ID =    Name    =");
                Console.WriteLine("===================");
                for (int i = 0; i < ids.Length; i++)
                {
                    Console.WriteLine($"=  {ids[i]} = {names[i]}");
                }
                
                Console.WriteLine("\nSelect :");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                Console.WriteLine("0. Exit");
                Console.Write("\nChoose : ");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 0:
                        Console.WriteLine("\n===================");
                        Console.WriteLine("==== Thank You ====");
                        Console.WriteLine("===================");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nMore Than 3 / Not Numbers");
                        break;
                }
            }
        }

        static void Add()
        {
            Console.WriteLine("\n===================");
            Console.WriteLine("======= Add =======");
            Console.WriteLine("===================");
            Console.Write("\nID : ");
            int id = int.Parse(Console.ReadLine());
            if (id < 1 || id > 5 )
            {
                Console.WriteLine($"\nID More Than {ids.Length} / Less Than 0");
                Console.WriteLine("Add Failed");
                return;
            } else if (names[id - 1] != null)
            {
                Console.WriteLine($"\nThere Is A Name On ID {id}. You Can Choose Update");
                Console.WriteLine("Add Failed");
                return;
            }
            Console.Write("Name : ");
            string name = Console.ReadLine();
            ids[id-1] = id;
            names[id - 1] = name;
        }

        static void Delete()
        {
            Console.WriteLine("\n===================");
            Console.WriteLine("====== Delete =====");
            Console.WriteLine("===================");
            Console.Write("\nID : ");
            int id = int.Parse(Console.ReadLine());
            if (id < 1 || id > 5)
            {
                Console.WriteLine($"\nID More Than {ids.Length} / Less Than 0");
                Console.WriteLine("Delete Failed");
                return;
            } else if (names[id - 1] == null)
            {
                Console.WriteLine($"\nID Not Found");
                Console.WriteLine("Delete Failed");
                return;
            }
            names[id - 1] = null;
        }
        
        static void Update()
        {
            Console.WriteLine("\n===================");
            Console.WriteLine("====== Update =====");
            Console.WriteLine("===================");
            Console.Write("\nID : ");
            int id = int.Parse(Console.ReadLine());
            if (id < 1 || id > 5)
            {
                Console.WriteLine($"\nID More Than {ids.Length} / Less Than 0");
                return;
            }
            else if (names[id - 1] == null)
            {
                Console.WriteLine("\nName Doesn't Exist");
                Console.WriteLine("Update Failed");
                return;
            }
            Console.Write("Name : ");
            string name = Console.ReadLine();
            if (names[id-1] == name)
            {
                Console.WriteLine($"\nName Can't Be The Same {names[id-1]}");
                Console.WriteLine("Update Failed");
                return;
            }
            ids[id - 1] = id;
            names[id - 1] = name;
        }
    }
}
