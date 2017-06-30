using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages {
    public class Database {

        public static Database INSTANCE { get; } = new Database(ConfigurationManager.ConnectionStrings["ZZFashionConnection"].ToString());


        private string url;

        private Database(string url) {
            this.url = url;
        }


        public void Load(GridView grid, string query, Action<SqlException> handle) {
            Try(connection => {
                var adapter = new SqlDataAdapter(new SqlCommand(query, connection));
                var results = new DataSet();
                adapter.Fill(results, "table");
                grid.DataSource = results;
                grid.DataBind();
            }, handle);
        }

        public void Insert(string statement, Action<SqlCommand> execute, Action<SqlException> handle) {
            Try(connection => execute(new SqlCommand(statement, connection)), handle);      
        }


        protected void Try(Action<SqlConnection> execute, Action<SqlException> handle) {
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