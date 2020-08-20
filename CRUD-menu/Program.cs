using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CRUD_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();
           
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
                        for (int i = 0; i < videos.Count; i++)
                        {
                            //Console.WriteLine((i +1) + ":" + menuItems[i]);
                            Console.WriteLine($"{(i + 1)}:{videos[i]}");

                        }

                        Console.ReadLine();
                        break;
                    case 2:
                        // TODO: add input validation
                        Console.WriteLine("Add video");
                        Console.WriteLine("Enter title");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter release date");
                        Console.ReadLine();
                        Console.WriteLine("Enter year");
                        int year = int.Parse(Console.ReadLine());
                        Console.ReadLine();
                        Console.WriteLine("Enter month");
                        int month = int.Parse(Console.ReadLine());

                        Console.ReadLine();
                        Console.WriteLine("Enter day");
                        int day = int.Parse(Console.ReadLine());

                        DateTime date = new DateTime(year,month,day);

                        Console.ReadLine();
                        Console.WriteLine("Enter storyline");
                        string storyline = Console.ReadLine();

                        Console.ReadLine();
                        Console.WriteLine("Enter genre");
                        string action = Console.ReadLine();

                        videos.Add(new Video(title, date, storyline, action));

                        Console.ReadLine();
                        break;
                    case 3:
                        // TODO: finish creating deletion. 
                        Console.WriteLine("Delete video");
                        Console.ReadLine();
                        Console.Write("write the id of the video you wish to delete:");
                        int id = int.Parse(Console.ReadLine());

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
