using System.Configuration;
using System.Data;
using System.Windows;
using DotNetEnv;

namespace ugyfel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string ConnectionString { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DotNetEnv.Env.Load();
            ConnectionString = $"Server={Env.GetString("DB_HOST")};user={Env.GetString("DB_USERNAME")};password={Env.GetString("DB_PASSWORD")};database={Env.GetString("DB_NAME")};";
            //ablak
            Regisztracio ablak = new Regisztracio();
            MainWindow= ablak;
            ablak.Show();

        }
    }

}
