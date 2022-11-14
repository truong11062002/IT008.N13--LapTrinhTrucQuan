using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bai09
{
    class Connection
    {
        private static string StringConnection = "Data Source=DESKTOP-IUEIHA4;Initial Catalog=NhapLieuSinhVien;Integrated Security=True";

        public static SqlConnection getConnection()
        {
            return new SqlConnection(StringConnection);
        }
    }
}
