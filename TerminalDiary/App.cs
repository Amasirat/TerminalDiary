namespace TerminalDiary;
using Lib;
    static class App
    {
        public static void Main()
        {
            try
            {
                mainMenu = new MainMenu(
                );
                mainMenu.DisplaySelections();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static List<Diary>? diaries;
        private static MainMenu mainMenu;
    }