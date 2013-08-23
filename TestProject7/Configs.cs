namespace Applied.TAM.Ui.Tests
{
    using System.Configuration;

    public class Configs
    {
        private static readonly AppSettingsReader Reader = new AppSettingsReader();

        public static string Username
        {
            get
            {
                return (string)Reader.GetValue("Username", typeof(string));
            }
        }

        public static string Password
        {
            get
            {
                return (string)Reader.GetValue("Password", typeof(string));
            }
        }

        public static string ExePath
        {
            get
            {
                return (string)Reader.GetValue("ExePath", typeof(string));
            }
        }
    }
}