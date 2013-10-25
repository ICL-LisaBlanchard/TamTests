namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Configuration;
    using System.IO;

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

        public static string ScreenshotPath
        {
            get
            {
                return (string)Reader.GetValue("ScreenshotPath", typeof(string));
            }
        }

        public static string LocalDocsPath
        {
            get
            {
                return (string)Reader.GetValue("LocalDocsPath", typeof(string));
            }
        }

        public static int SearchTimeout
        {
            get
            {
                return ((int)Reader.GetValue("SearchTimeoutInSeconds", typeof(int))) * 1000;
            }
        }

        public static int PlatformId
        {
             get
             {
                 return (int)Reader.GetValue("PlatformId", typeof(int));
             }
        }

        public static string BuildName
        {
            get
            {
                return (string)Reader.GetValue("BuildName", typeof(string));
            }
        }

        public static string PlanName
        {
            get
            {
                return (string)Reader.GetValue("PlanName", typeof(string));
            }
        }

        public static int DelayBetweenActions
        {
            get
            {
                return (int)Reader.GetValue("DelayBetweenActions", typeof(int));
            }
        }

        public static string ProjectName
        {
            get
            {
                return (string)Reader.GetValue("ProjectName", typeof(string));
            }
        }

        public static string OledbConnection
        {
            get
            {
                return (string)Reader.GetValue("OLEDBConnection", typeof(string));
            }
        }
    }
}