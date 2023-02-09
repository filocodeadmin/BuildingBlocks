using System.Data.SqlClient;

namespace block_res.Code_Files.Data {

    internal static class DataLib {       

        private const string MSSQLConnStr = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WMS;Data Source=DESKTOP-PJ4CBH3\\SQLEXPRESS";

        private static SqlDataReader MSSQLDataReader;
        private static SqlConnection MSSQLConnection;
        private static SqlCommand MSSQLCommand;

        

    }

}
