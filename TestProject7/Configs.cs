﻿namespace AppliedSystems.Tam.Ui.Tests
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

        public static string OurHighWayPath
        {
            get
            {
                return Directory.GetCurrentDirectory() + "/" + (string)Reader.GetValue("OurHighwayPath", typeof(string));
            }
        }

        public static string OurMMaReg
        {
            get
            {
                return Directory.GetCurrentDirectory() + "/" + (string)Reader.GetValue("OurMMaPath", typeof(string));
            }
        }

        public static string OfficePath
        {
            get
            {
                return Directory.GetCurrentDirectory() + "/" + (string)Reader.GetValue("OfficePath", typeof(string));
            }
        }
    }
}