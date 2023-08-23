using FurnitureWinApp;

namespace PRN211_Project_Group1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmLogin());
            Application.Run(new frmProductManagement(new DataAccess.Account()
            {
                Email = "abc",
                FullName = "abc",
                Id = 1,
                Password = "1230",
                Phone = "1230",
                Role = "Manager",
                Username = "abc"
            }, new frmLogin()));
        }
    }
}