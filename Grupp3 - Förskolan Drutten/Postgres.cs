using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Grupp3___Förskolan_Drutten
{
    class Postgres
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private NpgsqlDataReader dr;
        private DataTable tabell;
        public Person aktuellPerson;
        List<Person> personlista = new List<Person>();


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
            string sql = "select * from dagis.barn ORDER BY förnamn";

            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Barn> BarnNamn = new List<Barn>();
            Barn barn;

            foreach (DataRow rad in tabell.Rows)
            {
                barn = new Barn();

                barn.Barnid = (int)rad[0];
                barn.Förnamn = rad[1].ToString();
                barn.Efternamn = rad[2].ToString();
                barn.Avdelningsid = (int)rad[3];
                barn.Allergier = rad[4].ToString();
                barn.Annat = rad[5].ToString();

                BarnNamn.Add(barn);

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
            aktuellPerson = new Person();

            aktuellPerson.Användarnamn = användare;
            return aktuellPerson.Användarnamn;
        }

        //Metod för att hämta barn som tillhör en viss förälder
        public List<Barn> HämtaFöräldersBarn()
        {
            string sql = "SELECT barn.barnid, barn.förnamn, barn.efternamn FROM dagis.barn, dagis.person, dagis.person_barn WHERE barn.barnid = person_barn.fk_barnid AND person.personid = person_barn.fk_personid AND personid = 30;";

            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Barn> BarnLista = new List<Barn>();
            Barn barn;

            foreach (DataRow rad in tabell.Rows)
            {
                barn = new Barn();

                barn.Barnid = (int)rad[0];
                barn.Förnamn = rad[1].ToString();
                barn.Efternamn = rad[2].ToString();

                BarnLista.Add(barn);
            }
            return BarnLista;
        }

        public string BarnetsHämtaTid(int barnid, DateTime datum)
        {
            string svar = "";
                  try
            {

                string sql = "select tid_hamtad from dagis.narvaro where barnid = '" + barnid + "' and datum = '" + datum + "';";

                cmd = new NpgsqlCommand(sql, conn); // Kör sql

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                        Närvaro n = new Närvaro();
                        
                            n.TidHämtad = dr["tid_hamtad"].ToString();
                            svar = n.TidHämtad;
                            return svar;
                }
             
               }

            catch (Exception ex)
            {
                
                svar = ex.Message;
                return svar;
                
            } 
            dr.Close();
            return svar;
           
        }
        
        

        // Johan

        // Letar efter användare i DB
        public void HämtaAnvändare(string användarnamn, string lösenord)
        {
            try
            {
                string sql = "SELECT * FROM dagis.person dp WHERE användarnamn = '" + användarnamn + "' AND lösenord = '" + LösenordsEncrypt(lösenord) + "'";

                cmd = new NpgsqlCommand(sql, conn); // Kör sql

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr.HasRows)  // Hittad användare
                    {
                        aktuellPerson = new Person()
                        {
                            Personid = (int)dr["personid"],
                            Förnamn = dr["förnamn"].ToString(),
                            Efternamn = dr["efternamn"].ToString(),
                            Telefonnr = dr["telefonnummer"].ToString(),
                            Användarnamn = dr["användarnamn"].ToString(),
                            Lösenord = dr["lösenord"].ToString(),
                            ÄrPersonal = (bool)dr["personal"],
                            ÄrFörälder = (bool)dr["förälder"]
                        };
                    
                        //personlista.Add(aktuellPerson);

                        KontrolleraAnvändartyp();
                    }
                }
                else // Ingen användare hittad.
                {
                    MessageBox.Show("Felaktigt användarnamn eller lösenord." + "\n" + "\n" + "Om du har glömt ditt användarnamn eller lösenord" + "\n" + "vänligen kontakta systemansvarig.");

                }
                
            }

            catch (Exception ex) // Annat fel
            {
                MessageBox.Show("Ett fel har uppstått: " + ex.Message);

            }
            dr.Close();
        }

        public void HämtaAnvändarensUppgifter(string användarnamn, string lösenord)
        {
            try
            {
                string sql = "SELECT * FROM dagis.person dp WHERE användarnamn = '" + användarnamn + "' AND lösenord = '" + LösenordsEncrypt(lösenord) + "'";

                cmd = new NpgsqlCommand(sql, conn); // Kör sql

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr.HasRows)  // Hittad användare
                    {
                        aktuellPerson = new Person()
                        {
                            Personid = (int)dr["personid"],
                            Förnamn = dr["förnamn"].ToString(),
                            Efternamn = dr["efternamn"].ToString(),
                            Telefonnr = dr["telefonnummer"].ToString(),
                            Användarnamn = dr["användarnamn"].ToString(),
                            Lösenord = dr["lösenord"].ToString(),
                            ÄrPersonal = (bool)dr["personal"],
                            ÄrFörälder = (bool)dr["förälder"]
                        };
                    }
                }
                else
                {
                    MessageBox.Show("Kan inte hämta användarens uppgifter.");

                }

            }

            catch (Exception ex) // Annat fel
            {
                MessageBox.Show("Ett fel har uppstått: " + ex.Message);

            }
            dr.Close();
        }


        // Kontrollerar behörigheten hos användaren och skickar den till rätt Form.
        public void KontrolleraAnvändartyp()
        {
            if (aktuellPerson.ÄrFörälder == true && aktuellPerson.ÄrPersonal == true)  // "Mellan läget"
            {
                
                StartFP fp = new StartFP();
                fp.Show();
            }
            else if (aktuellPerson.ÄrFörälder == true) // Om användaren är förälder
            {
                
                StartForalder f = new StartForalder();
                f.Show();
            }
            else if (aktuellPerson.ÄrPersonal == true) // Om användaren är personal
            {
                
                StartPersonal p = new StartPersonal();
                p.Show();

            }
            else
            {
                MessageBox.Show("Användaren har ingen behörighet, kontakta systemadministratören.");
            }
        }
        // Lätt-krypterar lösenordet. Används i HämtaAnvändare();
        public string LösenordsEncrypt(string lösenord) 
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(lösenord));
                return Convert.ToBase64String(data);
            }
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
        public void ReturneraVärdenAvAktuellperson()
        {
            

            if (aktuellPerson.Förnamn == "James")
            {
                MessageBox.Show("hej");
            }
           
            

        }
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
        //public List<Barn> HämtaBarnochFöräldrar()
        //{

        //    string sql = "SELECT db.barnid, db.förnamn, db.efternamn, db.avdelningsid FROM dagis.barn db";

        //    tabell.Clear();
        //    tabell = sqlFråga(sql);
        //    List<Barn> BarnochFörälderlista = new List<Barn>();
        //    Barn barn;

        //    {
        //        foreach (DataRow rad in tabell.Rows)
        //        {
        //            barn = new Närvaro();

        //            barn.Barnid = (int)rad[0];
        //            barn.Förnamn = rad[1].ToString();
        //            barn.Efternamn = rad[2].ToString();
        //            barn.Avdelningsid = (int)rad[3];

        //            Närvarolista.Add(närvaro);

        //        }
        //    }
        //    return Närvarolista;

        //}


        // Martin

        public void UppdateraBarn(int barnid, string förnamn, string efternamn, string allergier, string annat)
        {

            string meddelande;
            try
            {
                string sql = "insert into barn (barnid, förnamn, efternamn, allergier, annat)"
                   + " values (@barnid, @förnamn, @efternamn, @allergier, @annat)";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@barnid", barnid);
                cmd.Parameters.AddWithValue("@förnamn", förnamn);
                cmd.Parameters.AddWithValue("@efternamn", efternamn);
                cmd.Parameters.AddWithValue("@allergier", allergier);
                cmd.Parameters.AddWithValue("@annat", annat);

                dr = cmd.ExecuteReader();
                dr.Close();
                meddelande = "Uppgifterna är uppdaterade.";

            }
            catch (NpgsqlException ex)
            {
                meddelande = ex.Message;
            }
            System.Windows.Forms.MessageBox.Show(meddelande);


        }

    }

}

