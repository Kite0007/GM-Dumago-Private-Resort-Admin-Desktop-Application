namespace GM_Dumago_Private_Resort_Admin_Desktop_Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // --- Configuration should happen BEFORE the application runs ---

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // The lines below are usually handled by ApplicationConfiguration.Initialize() in modern .NET
            // Application.SetHighDpiMode(HighDpiMode.SystemAware);
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);


            // --- Initialize our database connection ---
            // This MUST be done BEFORE Application.Run()
            MongoDbService.Initialize();


            // --- Run the application's first form ---
            // This line should only be called ONCE and it should be the LAST line.
            Application.Run(new LoginForm());
        }
    }
}