using System;
using CodeBase.Utilities;
using CodeBase.Elements;
using CodeBase.Moves;
using CodeBase.GameProcess;


namespace PacmanGUI
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Game game = new Game(new CurrentLevel(), 0, 0);
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuForm(game));
            Application.Exit();
            //Console.CursorVisible = false;
        }
    }
}