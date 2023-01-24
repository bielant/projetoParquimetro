using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkimeterFunchal_1
{
    internal class Menu
    {
        Random rdn= new Random();
        public void runStartMainMenu()
        {
            string prompt = @"
_____ __ __ ____     __ __ __  ____ _          ____   ____ ____  __  _ ____ ___ ___   ___ ______   ___ ____      
|     |  |  |    \   /  ]  |  |/    | |        |    \ /    |    \|  |/ ]    |   |   | /  _]      | /  _]    \     
|   __|  |  |  _  | /  /|  |  |  o  | |        |  o  )  o  |  D  )  ' / |  || _   _ |/  [_|      |/  [_|  D  )    
|  |_ |  |  |  |  |/  / |  _  |     | |___     |   _/|     |    /|    \ |  ||  \_/  |    _]_|  |_|    _]    /     
|   _]|  :  |  |  /   \_|  |  |  _  |     |    |  |  |  _  |    \|     \|  ||   |   |   [_  |  | |   [_|    \     
|  |  |     |  |  \     |  |  |  |  |     |    |  |  |  |  |  .  \  .  ||  ||   |   |     | |  | |     |  .  \    
|__|   \__,_|__|__|\____|__|__|__|__|_____|    |__|  |__|__|__|\_|__|\_|____|___|___|_____| |__| |_____|__|\__|    
                                       Welcome to the Funchal Parkimeter   

                     (Use the arrow Keys to cycle through options and press enter to select) ";
            string[] mainOptions = { "1. Administrador", "2. Customer", "3. Exit" };
            ReadToMenus menu = new ReadToMenus(prompt, mainOptions);
            int selectedIndex = menu.Run();
            
            switch (selectedIndex)
            {
                case 0: startMenuAdministrator(); break;
                case 1: runMenuCustomer(); break;
                case 2: runExit(); break;
            }
        }

        public void startMenuAdministrator()
        {
            Console.Clear();
            Console.WriteLine("If you are an administrator, please enter your username and password");
            //Controlo do acesso do administrador
            bool dataCorrect = false;
            while (!dataCorrect)
            {
                Console.Write("Username:");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Password:");
                string passWord = Console.ReadLine();
                string userNameKey = "admin";
                string passWordKey = "1234";


                if (passWord == passWordKey && userName == userNameKey)
                {
                    dataCorrect = true;
                    string prompt = @"
                  ____ ___   ___ ___ ____ ____  ____ ___________ ____   ____ ______  ___  ____  
                 /    |   \ |   |   |    |    \|    / ___/      |    \ /    |      |/   \|    \ 
                |  o  |    \| _   _ ||  ||  _  ||  (   \_|      |  D  )  o  |      |     |  D  )
                |     |  D  |  \_/  ||  ||  |  ||  |\__  |_|  |_|    /|     |_|  |_|  O  |    / 
                |  _  |     |   |   ||  ||  |  ||  |/  \ | |  | |    \|  _  | |  | |     |    \ 
                |  |  |     |   |   ||  ||  |  ||  |\    | |  | |  .  \  |  | |  | |     |  .  \
                |__|__|_____|___|___|____|__|__|____|\___| |__| |__|\_|__|__| |__|  \___/|__|\__|
                                                    _______
                                                   //  ||\ \
                                             _____//___||_\ \___
                                             )  _          _    \
                                             |_/ \________/ \___|
                                            ___\_/________\_/______ 
                                                                                   
                                       Welcome to the Funchal Parkimeter   

                     (Use the arrow Keys to cycle through options and press enter to select) ";
                    string[] mainOptions = { "1. See Zones", "2. See History", "3. See Machines", "4. Return", "5. Exit" };
                    ReadToMenus menu = new ReadToMenus(prompt, mainOptions);
                    int selectedIndex = menu.Run();

                    switch (selectedIndex)
                    {
                        case 0: runSeeZones();break;
                        case 1: runSeeHistóry(); break;
                        case 2: runSeeMachines();break;
                        case 3: runReturn(); break;
                        case 4: runExit(); break;
                    }

                    Console.ReadKey(true);

                    runStartMainMenu();

                }
                else
                {
                    Console.WriteLine("Entered incorrect data, try again");

                }
            }
        }


        public void runMenuCustomer()
        {
            Console.Clear();

            string prompt = @"
                           _____          _                            
                          / ____|        | |                           
                         | |    _   _ ___| |_ ___  _ __ ___   ___ _ __ 
                         | |   | | | / __| __/ _ \| '_ ` _ \ / _ \ '__|
                         | |____ |_| \__ \ |_ (_) | | | | | |  __/ |   
                          \_____\__,_|___/\__\___/|_| |_| |_|\___|_|                                              
                                            _______
                                           //  ||\ \
                                     _____//___||_\ \___
                                     )  _          _    \
                                     |_/ \________/ \___|
                                    ___\_/________\_/______                         
                           
                                               
           (Use the arrow Keys to cycle through options and press enter to select) ";
            string[] mainOptions = { "1. Park", "2. Information prices and schedules ", "3. Return", "4. Exit" };
            ReadToMenus SecondMenu = new ReadToMenus(prompt, mainOptions);
            int selectedIndex = SecondMenu.Run();
            Console.ReadKey(true);
            switch (selectedIndex)
            {
                case 0: runPark(); break;
                case 1: runPricesByArea(); break;
                case 2: runReturn(); break;
                case 3: runExit(); break;
            }


        }
        private void runPark()
        {
                Console.Clear();

                string prompt = @"
                         
                 _____  ___  ____   ____  _____
                |     |/   \|    \ /    |/ ___/
                |__/  |     |  _  |  o  (   \_ 
                |   __|  O  |  |  |     |\__  |
                |  /  |     |  |  |  _  |/  \ |
                |     |     |  |  |  |  |\    |
                |_____|\___/|__|__|__|__| \___|   
                                               
           (Use the arrow Keys to cycle through options and press enter to select) ";
                string[] mainOptions = { "1. Zone 1", "2. Zone 2 ", "3. Zone 3", "4. Retur"};
                ReadToMenus SecondMenu = new ReadToMenus(prompt, mainOptions);
                int selectedIndex = SecondMenu.Run();
                Console.ReadKey(true);
                switch (selectedIndex)
                {
                    case 0: runZone1(); break;
                    case 1: runZone2(); break;
                    case 2: runZone3(); break;
                    case 3: runMenuCustomer(); break;
                }


        }
        private void runPricesByArea()
        {
            string prompt = @"Information Prices Schedules
      ______________________________________________________
     |                 Days                    |   Hours    |
     |_________________________________________|____________|
     |Monday Tuesday Wednesday Thursday Friday |  9h to 20h |
     |-----------------------------------------|------------|
     |               Saturday                  |  9h to 14h |
      ------------------------------------------------------
(Use the arrow Keys to cycle through options and press enter to select) ";
            string[] mainOptions = { "1. Return"," 2. Exit" };
            ReadToMenus SecondMenu = new ReadToMenus(prompt, mainOptions);
            int selectedIndex = SecondMenu.Run();
            Console.ReadKey(true);
            switch (selectedIndex)
            {
                case 0: runMenuCustomer(); break;
                case 1: runExit(); break;
            }

        }
        private void runSeeZones()
        {


        }
        private void runSeeHistóry()
        {

        }
        private void runSeeMachines()
        {

        }

        public void runExit()
        {
            Console.Clear();
            Console.WriteLine("\nPress any key to exit.......");
            Console.ReadKey(true);
            Environment.Exit(0);

        }
        public void runReturn()
        {
            Console.Clear();
            runStartMainMenu();

        }
        public void runZone1()
        {
            Zona zona1 = new Zona(1.45, 45, rdn.Next(10, 51));

        }
        public void runZone2()
        {

        }
        public void runZone3()
        {

        }
    }
}
