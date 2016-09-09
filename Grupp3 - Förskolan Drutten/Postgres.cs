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
        public Person aktuellPerson;


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
                MessageBox.Show(ex.Message);
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

        //Metod för att hämta barn till en lista
        public List<Barn> HämtanBarn()
        {
            string sql = "select * from dagis.barn";

            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Barn> BarnNamn = new List<Barn>();
            Barn barn;


            if (tabell.Columns[0].ColumnName.Equals("Error"))
            {
                Barn b = new Barn();
                b.Error = true;
                b.ErrorMeddelande = tabell.Rows[0][1].ToString();

                BarnNamn.Add(b);
            }
            else
            {
                foreach (DataRow rad in tabell.Rows)
                {
                    barn = new Barn();

                    barn.Barnid = (int)rad[0];
                    barn.Förnamn = rad[1].ToString();
                    barn.Efternamn = rad[2].ToString();
                    barn.Avdelningsid = (int)rad[3];

                    BarnNamn.Add(barn);
                }
            }
            return BarnNamn;

        }

        // Metod för att lägga till tider till ett barn
        public void LäggTillTid(DateTime datum, int barnid, string lamnas, string hamtas)
        {

            string meddelande;
            try
            {
                string sql = "insert into dagis.narvaro (datum, barnid, tid_lamnad, tid_hamtad)"
                   + " values (@datum, @barnid, @tid_lamnad, @tid_hamtad)";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@datum", datum);
                cmd.Parameters.AddWithValue("@barnid", barnid);
                cmd.Parameters.AddWithValue("@tid_lamnad", lamnas);
                cmd.Parameters.AddWithValue("@tid_hamtad", hamtas);
               

                dr = cmd.ExecuteReader();
                dr.Close();
                meddelande = "Tiden är tillagd ";

            }
            catch (NpgsqlException ex)
            {
                meddelande = ex.Message;
            }
            System.Windows.Forms.MessageBox.Show(meddelande);


        }

        //Metod för att kunna hämta användarnamnet som kan användas till att hämta rätt barn till rätt förälder
        public string HämtaAnvändare(string användare)
        {
            Person p = new Person();
            p.Användarnamn = användare;
            return användare;
        }


        // Johan

        // Inloggningskontrollerare.
        public void KontrolleraAnvändare(string användarnamn, string lösenord)  
        {
                try
                {
                    string sql1 = "SELECT *  FROM dagis.person dp WHERE användarnamn = '" + användarnamn + "' AND lösenord = '" + lösenord + "' AND personal = TRUE";
                    string sql2 = "SELECT * FROM dagis.person dp WHERE användarnamn = '" + användarnamn + "' AND lösenord = '" + lösenord + "' AND förälder = TRUE";

                cmd = new NpgsqlCommand(sql1, conn); // Kör sql1

                dr = cmd.ExecuteReader();

                
                
                int count = 0;
                while (dr.Read())
                 {
                   count += 1;
                  }
                
                if (count == 1)  // Lyckad inlogging med personalbehörighet
                   {

                    StartPersonal p = new StartPersonal();
                            
                            p.Show();
                    
                            dr.Close();

                }

                else // Testar om kontot är förälder istället, annars misslyckad inloggning.
                   {
                    dr.Close();

                    cmd = new NpgsqlCommand(sql2, conn); // Kör sql2

                          dr = cmd.ExecuteReader();

                        
                        while (dr.Read())
                        {
                          count += 1;
                        }
                    if (count == 1) // Lyckad inloggning med förälderinloggning
                         {

                        StartForalder f = new StartForalder();

                        f.Show();
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Felaktigt användarnamn eller lösenord.");
                    }
                        
                   }
    
                  }
            catch (Exception ex)
               {
                          MessageBox.Show("Ett fel har uppstått: " + ex.Message);
                         
            }
            dr.Close();
        }
     
        public List<Person> HämtaAnvändare()
        {
            string sql = "SELECT * FROM dagis.person dp";

            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Person> AnvändarList = new List<Person>();
            Person person;


            if (tabell.Columns[0].ColumnName.Equals("Error"))
            {
                Person i = new Person();
                i.Error = true;
                i.ErrorMeddelande = tabell.Rows[0][1].ToString();

                AnvändarList.Add(i);
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

                    AnvändarList.Add(person);
                }
            }
            return AnvändarList;

        }

        //Hischam

        //public List<Närvaro> HämtaNärvaro()
        //{
        //    string sql = "select * from dagis.narvaro";
         
        //    tabell.Clear();
        //    tabell = sqlFråga(sql);
        //    List<Närvaro> Närvarolista = new List<Närvaro>();
        //    Närvaro närvaro;

        //    if (tabell.Columns[0].ColumnName.Equals("Error"))
        //    {
        //        Närvaro n = new Närvaro();
        //        n.Error = true;
        //        n.ErrorMeddelande = tabell.Rows[0][1].ToString();
 
        //        Närvarolista.Add(n);
        //    }
        //    else
        //    {
        //        foreach (DataRow rad in tabell.Rows)
        //        {
        //            närvaro = new Närvaro();

        //            närvaro.Närvaroid = (int)rad[0];
        //            närvaro.Datum = (DateTime)rad[1];
        //            närvaro.Barnid = (int)rad[2];
        //            närvaro.TidLämnad = rad[4].ToString();
        //            närvaro.TidHämtad = rad[5].ToString();
        //            närvaro.HämtasAv = rad[3].ToString();

        //            Närvarolista.Add(närvaro);  
        //        }
        //}
        //    return Närvarolista;
        //}
        public List<Närvaro> HämtaNärvaro(DateTime AktuelltDatum)
        {

            string sql = "select dp.datum, db.förnamn, db.efternamn, dp.tid_lamnad, dp.tid_hamtad, dp.hamtas_av from dagis.narvaro dp, dagis.barn db where datum = ('" + AktuelltDatum + "') AND dp.barnid = db.barnid";



            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Närvaro> Närvarolista = new List<Närvaro>();
            Närvaro närvaro;

            {
                foreach (DataRow rad in tabell.Rows)
                {
                    närvaro = new Närvaro();

                    närvaro.Datum = (DateTime)rad[0];
                    närvaro.Förnamn = rad[1].ToString();
                    närvaro.Efternamn = rad[2].ToString();
                    närvaro.TidLämnad = rad[3].ToString();
                    närvaro.TidHämtad = rad[4].ToString();
                    närvaro.HämtasAv = rad[5].ToString();

                    Närvarolista.Add(närvaro);

            }
        }
            return Närvarolista;
            
        }
        public List<Frånvaro> HämtaFrånvaro(DateTime AktuelltDatum)
        {

            string sql = "select df.datum, db.förnamn, db.efternamn, df.sjuk, df.ledig from dagis.franvaro df, dagis.barn db where datum = ('" + AktuelltDatum + "') AND df.barnid = db.barnid";



            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Frånvaro> Frånvarolista = new List<Frånvaro>();
            Frånvaro frånvaro;

            {
                foreach (DataRow rad in tabell.Rows)
                {
                    frånvaro = new Frånvaro();

                    frånvaro.Datum = (DateTime)rad[0];
                    frånvaro.Förnamn = rad[1].ToString();
                    frånvaro.Efternamn = rad[2].ToString();
                    frånvaro.Sjuk = Convert.ToBoolean(rad[4]);
                    frånvaro.Ledig = (bool)rad[3];


                    Frånvarolista.Add(frånvaro);

                }
            }
            return Frånvarolista;

        }



        // Martin


    }
}

