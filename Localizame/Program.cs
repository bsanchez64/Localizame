using Localizame.vista;

namespace Localizame
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmSplash());
        }
    }
}