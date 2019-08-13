using CharacterArchive.Controllers;

namespace CharacterArchive
{
    class Program
    {
        static void Main( string[] args )
        {
            var mm = new MainMenuController();
            mm.Start();
        }
    }
}
