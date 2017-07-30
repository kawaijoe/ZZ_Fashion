using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace ZZ_Fashion {
    public class Database {

        public static Database INSTANCE = new Database(ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString());


        private string url;


        private Database(string url) {
            this.url = url;
        }


        public int RetrieveSerialNumber() {
            var cache = 0;
            Try(connection => {
                using (var table = new DataTable()) {
                    table.Load(new SqlCommand("SELECT MAX(IssuingID) FROM CashVoucher", connection).ExecuteReader());
                    if (table.Rows.Count == 1) {
                        cache = Convert.ToInt32(table.Rows[0][0]);

                    } else {
                        cache = 0;
                    }
                }

            }, ex => cache = 0);

            return cache;
        }



        public void Bind(GridView view, string query, Action<SqlException> handle) {
            Try (connection => {
                using (var table = new DataTable()) {
                    table.Load(new SqlCommand(query, connection).ExecuteReader());
                    view.DataSource = table;
                    view.DataBind();
                }

            }, handle);
        }

        public void Execute(string statement, Action<SqlCommand> execute, Action<SqlException> handle) {
            Try (connection => execute(new SqlCommand(statement, connection)), handle);
        }


        private void Try(Action<SqlConnection> execute, Action<SqlException> handle) {
            try {
                using (var connection = new SqlConnection(url)) {
                    connection.Open();
                    execute(connection);
                }

            } catch (SqlException e) {
                handle(e);
            }
        }

    }
}