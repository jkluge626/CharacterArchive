using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterArchive.Controllers
{
    class MainMenuController
    {
        public void Start()
        {
            Console.WriteLine( "_________________" );
            Console.WriteLine();
            Console.WriteLine( "CHARACTER ARCHIVE" );
            Console.WriteLine( "_________________" );

            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine( "What would you like to do?" );
            Console.WriteLine( "1) View Characters{0}2) Add Character{0}3) Exit", Environment.NewLine );

            char opt = Console.ReadKey().KeyChar;

            switch ( opt )
            {
                case '1':
                    //PeopleSelect();
                    break;
                case '2':
                    //LibrarySelect();
                    break;
                case '3':
                    //ExitProgram();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine( "Invalid input, please try again." );
                    MainMenu();
                    break;
            }
        }
    }
}
