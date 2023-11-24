using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        //copy past, cmt dong Van lai, kh xoa
        protected SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-FDN5AM5O\\SQLEXPRESS;Initial Catalog=DUAN1_QUANLYKHO;Integrated Security=True");

    }
}
