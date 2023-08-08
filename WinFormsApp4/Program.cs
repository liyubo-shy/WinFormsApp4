namespace WinFormsApp3 {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            // 把form2设置为主窗口
            //Ponder.WinUI.Portal.FrmLogin frmLogin = new Ponder.WinUI.Portal.FrmLogin();
            //if (DialogResult.OK == frmLogin.ShowDialog()) {
            //    Application.Run(new Ponder.WinUI.Portal.FrmPortal());
            //}

        }
    }
}