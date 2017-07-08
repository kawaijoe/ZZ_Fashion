using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace ZZ_Fashion {
    public class Database {

        public static readonly Database INSTANCE = new Database(ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString());


        private string url;


        protected Database(string url) {
            this.url = url;
        }


        public void Bind(GridView view, string query, Action<SqlException> handle) {
            Try((connection) => {

            }, handle);
        }


        protected void Try(Action<SqlConnection> execute, Action<SqlException> handle) {
            Task.Run(() => {
                try {
                    using (var connection = new SqlConnection()) {
                        connection.Open();
                        execute(connection);
                    }

                } catch (SqlException e) {
                    handle(e);
                }
            });
        }

    }
}