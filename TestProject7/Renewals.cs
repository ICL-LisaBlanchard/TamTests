namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Data.OleDb;

    public class Renewals
    {
        public static void CleanRenewals()
        {
            const string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=J:\APPS\IEOFFICE\DATA\TamRenewals.mdb;";
            var con = new OleDbConnection(ConnStr);
            var com = new OleDbCommand("Delete from MotorRenewals", con);
            var com2 = new OleDbCommand("Delete from HouseholdRenewals", con);
            con.Open();    
            com.ExecuteNonQuery();
            com2.ExecuteNonQuery();
            con.Close();
        }
    }
}
