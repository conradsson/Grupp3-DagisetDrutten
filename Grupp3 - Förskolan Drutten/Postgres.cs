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
        //public List<Information> inläggslista;
        //StartForalder f = new StartForalder();


        //Kontaktar databasen.
        public Postgres()
        {
            conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=pgmvaru_g3;User Id=pgmvaru_g3;Password=gunga;Database=pgmvaru_g3;SslMode=Require;trustServerCertificate=true;Pooling=false");
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

        /// <summary>
        /// Metod för att hämta barn till en lista
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Lägger in information i databasen om barnet är sjuk eller ledig
        /// </summary>
        /// <param name="datum"></param>
        /// <param name="barnid"></param>
        /// <param name="sjuk"></param>
        /// <param name="ledig"></param>
        public void LäggTillFånvaro(DateTime datum, int barnid, bool sjuk, bool ledig)
        {
            string meddelande;
            try
            {
                string sql = "insert into dagis.franvaro (datum, barnid, sjuk, ledig) values (@datum, @barnid, @sjuk, @ledig);";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@datum", datum);
                cmd.Parameters.AddWithValue("@barnid", barnid);
                cmd.Parameters.AddWithValue("@sjuk", sjuk);
                cmd.Parameters.AddWithValue("@ledig", ledig);


                dr = cmd.ExecuteReader();
                dr.Close();
                meddelande = "Frånvaron är registrerad.";

            }
            catch (NpgsqlException ex)
            {
                meddelande = ex.Message;
            }
            System.Windows.Forms.MessageBox.Show(meddelande);
            conn.Close();
        }

        /// <summary>
        ///  Metod för att lägga till tider till ett barn
        /// </summary>
        /// <param name="datum"></param>
        /// <param name="barnid"></param>
        /// <param name="lamnas"></param>
        /// <param name="hamtas"></param>
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
            conn.Close();
        }

        /// <summary>
        /// Metod för att uppdatera tider barnet lämnas och hämtas
        /// </summary>
        /// <param name="datum"></param>
        /// <param name="barnid"></param>
        /// <param name="lamnas"></param>
        /// <param name="hamtas"></param>
        public void UppdateraTider(DateTime datum, int barnid, string lamnas, string hamtas)
        {
            string meddelande;
            try
            {
                string sql = "update dagis.narvaro SET tid_lamnad = '" + lamnas + "', tid_hamtad ='" + hamtas + "' where barnid = '" + barnid +"' and datum = '" + datum + "';";
                   
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@datum", datum);
                cmd.Parameters.AddWithValue("@barnid", barnid);
                cmd.Parameters.AddWithValue("@tid_lamnad", lamnas);
                cmd.Parameters.AddWithValue("@tid_hamtad", hamtas);

                dr = cmd.ExecuteReader();
                dr.Close();
                meddelande = "Tiden är uppdaterad.";

            }
            catch (NpgsqlException ex)
            {
                meddelande = ex.Message;
            }
            System.Windows.Forms.MessageBox.Show(meddelande);
            conn.Close();
        }

        /// <summary>
        /// Metod för att hämta barn som tillhör en viss förälder
        /// </summary>
        /// <returns></returns>
        public List<Barn> HämtaFöräldersBarn(int aktuellpersonid)
        {
            string sql = "SELECT barn.barnid, barn.förnamn, barn.efternamn FROM dagis.barn, dagis.person, dagis.person_barn WHERE barn.barnid = person_barn.fk_barnid AND person.personid = person_barn.fk_personid AND personid = '" + aktuellpersonid + "';";

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

        /// <summary>
        /// Metod som hämtar barnets tid när det ska lämnas på dagis
        /// </summary>
        /// <param name="barnid"></param>
        /// <param name="datum"></param>
        /// <returns></returns>
        public string BarnetsLämnaTid(int barnid, DateTime datum)
        {
            string svar1 = "";
            try
            {
                string sql = "select tid_lamnad from dagis.narvaro where barnid = '" + barnid + "' and datum = '" + datum + "';";

                cmd = new NpgsqlCommand(sql, conn); // Kör sql
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Närvaro n = new Närvaro();

                    n.TidHämtad = dr["tid_lamnad"].ToString();
                    svar1 = n.TidHämtad;
                    return svar1;
                }
            }

            catch (Exception ex)
            {

                svar1 = ex.Message;
                return svar1;
            }

            dr.Close();
            conn.Close();
            return svar1;
            
        }

        /// <summary>
        /// Metod som hämtar ut barnets tid när det ska hämtas från dagis
        /// </summary>
        /// <param name="barnid"></param>
        /// <param name="datum"></param>
        /// <returns></returns>
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
                conn.Close();
                return svar;
        }

        /// <summary>
        /// Hämtar ut information om vem som hämtar barnet
        /// </summary>
        /// <param name="barnid"></param>
        /// <param name="datum"></param>
        /// <returns></returns>
        public string BarnetHämtasAv(int barnid, DateTime datum)
        {
            string svar = "";
            try
            {
                string sql = "select hamtas_av from dagis.narvaro where barnid = '" + barnid + "' and datum = '" + datum + "';";

                cmd = new NpgsqlCommand(sql, conn); // Kör sql
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Närvaro n = new Närvaro();

                    n.TidHämtad = dr["hamtas_av"].ToString();
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
            conn.Close();
            return svar;
        }

        /// <summary>
        /// Meddelar vem som hämtar barnet
        /// </summary>
        /// <param name="barnid"></param>
        /// <param name="hamtas"></param>
        /// <param name="datum"></param>
        public void MeddelaHämtning(int barnid, string hamtas, DateTime datum)
        {
            string meddelande;
            try
            {
                string sql = "UPDATE dagis.narvaro SET hamtas_av = @hamtas_av"
                   + " WHERE narvaro.barnid = @barnid AND datum = @datum;";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@hamtas_av", hamtas);
                cmd.Parameters.AddWithValue("@barnid", barnid);
                cmd.Parameters.AddWithValue("@datum", datum);
                
                dr = cmd.ExecuteReader();
                dr.Close();
                meddelande = "Hämtningen är meddelad.";

            }
            catch (NpgsqlException ex)
            {
                meddelande = ex.Message;
            }
            System.Windows.Forms.MessageBox.Show(meddelande);
            conn.Close();
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


        // Kontrollerar behörigheten hos användaren och skickar den till rätt Form.
        public void KontrolleraAnvändartyp()
        {
            if (aktuellPerson.ÄrFörälder == true && aktuellPerson.ÄrPersonal == true)  // "Mellan läget"
            {
                
                StartFP fp = new StartFP(aktuellPerson);
                fp.Show();
            }
            else if (aktuellPerson.ÄrFörälder == true) // Om användaren är förälder
            {
                
                StartForalder f = new StartForalder(aktuellPerson);
                f.Show();
            }
            else if (aktuellPerson.ÄrPersonal == true) // Om användaren är personal
            {
                
                StartPersonal p = new StartPersonal(aktuellPerson);
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

        // Hämtar informationsinlägg från db
        public List<Information> HämtaInlägg()
        {
            string sql = "SELECT * FROM dagis.information ORDER BY  datum DESC";

            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Information> Inlägg = new List<Information>();
            Information i;

            foreach (DataRow rad in tabell.Rows)
            {
                i = new Information();

                i.InläggsId = (int)rad[0];
                i.Datum = rad[1].ToString();
                i.InläggsRubrik = rad[2].ToString();
                i.InläggsText = rad[3].ToString();
                i.SkrivetAv = rad[4].ToString();

                Inlägg.Add(i);

            }
            return Inlägg;
        }

        public void NyttInlägg(string datum,string inläggsrubrik,string inläggstext,string skrivetav)
        {
            Random random = new Random();

            try
            {
                string sql = "insert into dagis.information (inläggsid, datum, inläggsrubrik, inläggstext, skrivet_av)"
                   + " values (@inläggsid, @datum, @inläggsrubrik, @inläggstext, @skrivet_av)";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@inläggsid", random.Next(1000));
                cmd.Parameters.AddWithValue("@datum", datum);
                cmd.Parameters.AddWithValue("@inläggsrubrik", inläggsrubrik);
                cmd.Parameters.AddWithValue("@inläggstext", inläggstext);
                cmd.Parameters.AddWithValue("@skrivet_av", skrivetav);


                dr = cmd.ExecuteReader();
                dr.Close();

                MessageBox.Show("Inlägget har publicerats!");

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ett fel har uppstått: " + ex.Message);
            }
            //conn.Close();
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
        //public void ReturneraVärdenAvAktuellperson()
        //{


        //    if (aktuellPerson.Förnamn == "James")
        //    {
        //        MessageBox.Show("hej");
        //    }



        //}
        public List<Närvaro> HämtaNärvaro(DateTime AktuelltDatum)
        {

            string sql = "select dp.datum, db.förnamn, db.efternamn, dp.tid_lamnad, dp.tid_hamtad, dp.hamtas_av from dagis.narvaro dp, dagis.barn db where datum = ('" + AktuelltDatum + "') AND dp.barnid = db.barnid ORDER BY tid_lamnad";



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
                    frånvaro.Sjuk = Convert.ToBoolean(rad[3]);
                    frånvaro.Ledig = (bool)rad[4];


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
        /// <summary>
        /// Uppdaterar barn på inloggad förälder.
        /// </summary>
        public void UppdateraBarn(int barnid, string förnamn, string efternamn, string allergier, string annat)
        {
            
            string meddelande;
            try
            {
                string sql = "UPDATE dagis.barn SET förnamn = '" + förnamn + "', efternamn = '" + efternamn + "', allergier = '" + allergier + "', annat = '" + annat + "' where barnid = '" + barnid + "';";

                cmd = new NpgsqlCommand(sql, conn);
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

            //conn.Close();

            
        }
        /// <summary>
        /// Hämtar aktuella barn på inloggad förälder
        /// </summary>
        public List<Barn> HämtaAktuellaBarn(int aktuellpersonid)
        {
            string sql = "SELECT barn.barnid, barn.förnamn, barn.efternamn, barn.allergier, barn.annat FROM dagis.barn, dagis.person, dagis.person_barn WHERE barn.barnid = person_barn.fk_barnid AND person.personid = person_barn.fk_personid AND personid = '" + aktuellpersonid + "';;";

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
                barn.Allergier = rad[3].ToString();
                barn.Annat = rad[4].ToString();
                BarnLista.Add(barn);
            }
            return BarnLista;
            
        }
        public Int64 HämtaDagensTider(DateTime AktuelltDatum, int tid)
        {
            Int64 svar = 0;

            try
            {
                string sql = "SELECT COUNT(narvaro.datum) as antal FROM dagis.narvaro WHERE datum = ('" + AktuelltDatum + "') AND tid_lamnad  LIKE '%" + tid + "_%'";

                cmd = new NpgsqlCommand(sql, conn); // Kör sql
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {


                    svar = (Int64)dr["antal"];

                    return svar;
                }
            }

            catch (Exception ex)
            {

                svar = Convert.ToInt32(ex.Message);
                return svar;
            }

            dr.Close();
            conn.Close();
            return svar;
        }
        public Int64 HämtaDagensTiderHämtas(DateTime AktuelltDatum, int tid)
        {
            Int64 svar = 0;

            try
            {
                string sql = "SELECT COUNT(narvaro.datum) as antal FROM dagis.narvaro WHERE datum = ('" + AktuelltDatum + "') AND tid_hamtad  LIKE '" + tid + "%_'";

                cmd = new NpgsqlCommand(sql, conn); // Kör sql
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {


                    svar = (Int64)dr["antal"];

                    return svar;
                }
            }

            catch (Exception ex)
            {

                svar = Convert.ToInt32(ex.Message);
                return svar;
            }

            dr.Close();
            conn.Close();
            return svar;
        }

        public List<Person> HämtaBarnsFörälder(int aktuellbarnid)
        {
            string sql = "SELECT person.förnamn, person.efternamn, person.telefonnummer FROM dagis.person, dagis.person_barn, dagis.barn WHERE person.personid = person_barn.fk_personid AND barn.barnid = person_barn.fk_barnid AND barnid = '" + aktuellbarnid + "';";
            
            tabell.Clear();
            tabell = sqlFråga(sql);
            List<Person> PersonLista = new List<Person>();
            Person person;

            foreach (DataRow rad in tabell.Rows)
            {
                person = new Person();

                person.Förnamn = rad[0].ToString();
                person.Efternamn= rad[1].ToString();
                person.Telefonnr = rad[2].ToString();

                PersonLista.Add(person);
            }
            return PersonLista;
        }
        //public List<Person> HämtaBarnsFörälderAvdelning1(int aktuellbarnid)
        //{
        //    string sql = "SELECT person.förnamn, person.efternamn, person.telefonnummer FROM dagis.person, dagis.person_barn, dagis.barn WHERE person.personid = person_barn.fk_personid AND barn.barnid = person_barn.fk_barnid AND barnid = ('" + aktuellbarnid + "') AND avdelningsid = 1";

        //    tabell.Clear();
        //    tabell = sqlFråga(sql);
        //    List<Person> PersonLista = new List<Person>();
        //    Person person;

        //    foreach (DataRow rad in tabell.Rows)
        //    {
        //        person = new Person();

        //        person.Förnamn = rad[0].ToString();
        //        person.Efternamn = rad[1].ToString();
        //        person.Telefonnr = rad[2].ToString();

        //        PersonLista.Add(person);
        //    }
        //    return PersonLista;
        //}
        //public List<Person> HämtaBarnsFörälderAvdelning2(int aktuellbarnid)
        //{
        //    string sql = "SELECT person.förnamn, person.efternamn, person.telefonnummer FROM dagis.person, dagis.person_barn, dagis.barn WHERE person.personid = person_barn.fk_personid AND barn.barnid = person_barn.fk_barnid AND barnid = ('" + aktuellbarnid + "') AND barn.avdelningsid = 2";

        //    tabell.Clear();
        //    tabell = sqlFråga(sql);
        //    List<Person> PersonLista = new List<Person>();
        //    Person person;

        //    foreach (DataRow rad in tabell.Rows)
        //    {
        //        person = new Person();

        //        person.Förnamn = rad[0].ToString();
        //        person.Efternamn = rad[1].ToString();
        //        person.Telefonnr = rad[2].ToString();

        //        PersonLista.Add(person);
        //    }
        //    return PersonLista;
        //}
        public List<Barn> HämtaBarnAvdelning1()
        {
            string sql = "select * from dagis.barn WHERE avdelningsid = 1 ORDER BY förnamn";

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
        public List<Barn> HämtaBarnAvdelning2()
        {
            string sql = "select * from dagis.barn WHERE avdelningsid = 2 ORDER BY förnamn";

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
        public List<Barn> HämtaBarnEfterSök(string söktext)
        {
            string sql = "select * from dagis.barn WHERE barn.förnamn LIKE '%" + LowercaseFirst(söktext) + "%' OR barn.förnamn LIKE '%" + UppercaseFirst(söktext) + "%' ORDER BY förnamn";

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
        public List<Barn> HämtaBarnEfterSök1(string söktext)
        {
            string sql = "select * from dagis.barn WHERE avdelningsid = 1 AND (barn.förnamn LIKE '%" + LowercaseFirst(söktext) + "%' OR barn.förnamn LIKE '%" + UppercaseFirst(söktext) + "%') ORDER BY förnamn";

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
        public List<Barn> HämtaBarnEfterSök2(string söktext)
        {
            string sql = "select * from dagis.barn WHERE avdelningsid = 2 AND (barn.förnamn LIKE '%" + LowercaseFirst(söktext) + "%' OR barn.förnamn LIKE '%" + UppercaseFirst(söktext) + "%') ORDER BY förnamn";

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
        /// <summary>
        /// Uppdaterar barn på inloggad förälder.
        /// </summary>
        public void UppdateraFörälder(int id, string förnamn, string efternamn, string telefonnummer)
        {

            string meddelande;
            try
            {
                string sql = "UPDATE dagis.person SET förnamn = '" + förnamn + "', efternamn = '" + efternamn + "', telefonnummer = '" + telefonnummer + "' where personid = '" + id + "';";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@förnamn", förnamn);
                cmd.Parameters.AddWithValue("@efternamn", efternamn);
                cmd.Parameters.AddWithValue("@telefonnummer", telefonnummer);


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

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        static string LowercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToLower(s[0]) + s.Substring(1);
        }
    }

}

