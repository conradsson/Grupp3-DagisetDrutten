using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;


namespace Grupp3___Förskolan_Drutten
{
    class Postgres
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private NpgsqlDataReader dr;
        private DataTable tabell;
        public string Förnamn { get; set; }
        

        public Postgres()
        {
            conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g3;User Id=pgmvaru_g3;Password=gunga;Database=pgmvaru_g3;SslMode=Require;trustServerCertificate=true;");
            conn.Open();
            tabell = new DataTable();
        }

        public void VisaNamn()
        {
            try
            {
                string sql = "SELECT förnamn FROM dagis.barn";
                
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    {
                        Förnamn = dr["förnamn"].ToString();
                    };
                    
                    MessageBox.Show(Förnamn);
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.ErrorCode.Equals("28P01"))
                {
                    MessageBox.Show("Fel lösenord.");
                }
                if (ex.ErrorCode.Equals("42501"))
                {
                    MessageBox.Show("Användaren saknar nödvändiga rättigheter.");
                }
                else
                {
                    MessageBox.Show(ex.ErrorCode.ToString());
                }
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
