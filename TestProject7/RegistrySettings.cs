namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.Win32;

    internal class RegistrySettings
    {
        public static void WriteToRegistry(string path, string key, string value)
        {
            RegistryKey myKey = Registry.CurrentUser.OpenSubKey(path, true);
            if (myKey != null)
            {
                myKey.SetValue(key, value, RegistryValueKind.String);
            }
        }
    }
}