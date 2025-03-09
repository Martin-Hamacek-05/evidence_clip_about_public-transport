using evidence_clip_about_public_transport.Win_forms_user_interface.other;

namespace evidence_clip_about_public_transport
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
            Application.Run(new Load_window());
            Application.Run(new Login_popup());
        }
    }
}