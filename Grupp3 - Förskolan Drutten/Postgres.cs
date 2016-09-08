﻿using Npgsql;
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

        //Kontaktar databasen.
        public Postgres()
        {
            conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g3;User Id=pgmvaru_g3;Password=gunga;Database=pgmvaru_g3;SslMode=Require;trustServerCertificate=true;");
            conn.Open();
            tabell = new DataTable();
        }

        //Test av fråga.
        public DataTable sqlFråga(string sql)
        {
            try
            {

                cmd = new NpgsqlCommand(sql, conn);
                dr = cmd.ExecuteReader();

                tabell.Load(dr);
                return tabell;

            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                DataColumn c1 = new DataColumn("Error");
                DataColumn c2 = new DataColumn("ErrorMeddelande");

                c1.DataType = System.Type.GetType("System.Boolean");
                c2.DataType = System.Type.GetType("System.String");

                tabell.Columns.Add(c1);
                tabell.Columns.Add(c2);



                DataRow rad = tabell.NewRow();
                rad[c1] = true;
                rad[c2] = ex.Message;
                tabell.Rows.Add(rad);


                return tabell;
            }
            finally
            {
                conn.Close();
            }
        }

        //Metod att utgå ifrån vid SQLfrågor
        //public List<Barn> HämtanBarn()
        //{
        //    string sql = "select * from dagis.barn";

        //    tabell.Clear();
        //    tabell = sqlFråga(sql);
        //    List<Barn> BarnNamn = new List<Barn>();
        //    Barn barn;


        //    if (tabell.Columns[0].ColumnName.Equals("Error"))
        //    {
        //        Barn b = new Barn();
        //        b.Error = true;
        //        b.ErrorMeddelande = tabell.Rows[0][1].ToString();

        //        BarnNamn.Add(b);
        //    }
        //    else
        //    {
        //        foreach (DataRow rad in tabell.Rows)
        //        {
        //            barn = new Barn();

        //            barn.Barnid = (int)rad[0];
        //            barn.Förnamn = rad[1].ToString();
        //            barn.Efternamn = rad[2].ToString();
        //            barn.Avdelningsid = (int)rad[3];

        //            BarnNamn.Add(barn);
        //        }
        //    }
        //    return BarnNamn;

        //}


        //Mathilda






        // Johan

        

        public void HämtaAnvändare()
        {
            string sql = "SELECT * FROM dagis.person dp";

            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Person> InloggUppgifterList = new List<Person>();
            Person person;


            if (tabell.Columns[0].ColumnName.Equals("Error"))
            {
                Person i = new Person();
                i.Error = true;
                i.ErrorMeddelande = tabell.Rows[0][1].ToString();

                InloggUppgifterList.Add(i);
            }
            else
            {
                foreach (DataRow rad in tabell.Rows)
                {
                    person = new Person();

                    person.Personid = (int)rad[0];
                    person.Förnamn = rad[1].ToString();
                    person.Efternamn = rad[2].ToString();
                    person.Telefonnr = rad[3].ToString();
                    person.Användarnamn = rad[4].ToString();
                    person.Lösenord = rad[5].ToString();
                    person.ÄrPersonal = rad[6].ToString();
                    person.ÄrFörälder = rad[7].ToString();

                    InloggUppgifterList.Add(person);
                }
            }
            //return BarnNamn;

        }




        //Hischam




        // Martin


    }
}
