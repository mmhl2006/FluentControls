using System.Windows;

namespace MMHLco.FluentEssentials
{
    internal class FluentEssentials
    {
        public static void ExitApp(Window targetwindow)
        {
            targetwindow.Close();
        }
        public static string ReadFileContents(string pathname)
        {
            string txt = System.IO.File.ReadAllText(pathname);
            return txt;
        }
        public static void MaximizeApp(Window targetwindow)
        {
            targetwindow.WindowState = WindowState.Maximized;
        }
        public static void MinimizeApp(Window targetwindow)
        {
            targetwindow.WindowState = WindowState.Minimized;
        }
        /*   public static void
           public static void*/
    }
}
