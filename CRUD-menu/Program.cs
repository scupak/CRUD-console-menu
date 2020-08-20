using System;
using System.ComponentModel;

namespace CRUD_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems =
            {
                "List all videos",
                "Add video",
                "Delete video",
                "Edit video",
                "Exit"


            }; 

            var selection = 0;
            while (selection != 5)
            {
                
            
                selection = ShowMenu(menuItems); 
                Console.ReadLine();

                switch (selection)
                {

                    case 1:
                        Console.WriteLine("List all videos");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Add video");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Delete video");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Edit video");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        Console.ReadLine();
                        break;

                }






            }

        }

        private static int ShowMenu(string[] menuItems)
        {
           Console.Clear();


           Console.WriteLine("Select what you want to  do");
           Console.WriteLine("");
           /*
           foreach (var menuItem in menuItems)
           {
               Console.WriteLine(menuItem);
               
           }
           */

           for (int i = 0; i < menuItems.Length; i++)
           {
               //Console.WriteLine((i +1) + ":" + menuItems[i]);
               Console.WriteLine($"{(i + 1)}:{menuItems[i]}");

            }

           int selection;
           while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
           {
               Console.WriteLine("You need to select a menu item");

           }
           Console.WriteLine("Selection " + selection);
           return selection;
        }
    }
}
