using System;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace VuurwerkKassa
{
    public class DBConnection
    {
        private OleDbConnection con;

        public void openConnection()
        {
            try
            {
                string source = ".\\Vuurwerk.accdb";
                string str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + source;
                con = new OleDbConnection(str);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kassa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void closeConnection()
        {
            con.Close();
        }

        public Artikel getArtikelByBarCode(string code)
        {
            int artnr = 0;
            String omsch = "", barcode = "";
            float prijs = 0;
            string query = "SELECT * FROM Artikelen WHERE BARcode = '" + code + "'";
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader dreader = cmd.ExecuteReader();
                dreader.Read();
                artnr = int.Parse(dreader["ArtikelNr"].ToString());
                barcode = dreader["BARcode"].ToString();
                omsch = dreader["Omschrijving"].ToString();
                prijs = float.Parse(dreader["Prijs"].ToString());
                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kassa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new Artikel(artnr, 1, barcode, omsch, prijs, prijs);
        }

        public Artikel getArtikelByArtNr(string artNr)
        {
            int artnr = 0;
            String omsch = "", barcode = "";
            float prijs = 0;
            string query = "SELECT * FROM Artikelen WHERE ArtikelNr = " + artNr; 
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader dreader = cmd.ExecuteReader();
                dreader.Read();
                artnr = int.Parse(dreader["ArtikelNr"].ToString());
                barcode = dreader["BARcode"].ToString();
                omsch = dreader["Omschrijving"].ToString();
                prijs = float.Parse(dreader["Prijs"].ToString());
                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kassa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new Artikel(artnr, 1, barcode, omsch, prijs, prijs);
        }

        public Collection<Artikel> getArtikelen(string code)
        { 
            Collection<Artikel> arts = new Collection<Artikel>();
            int artnr = 0;
            String omsch = "", barcode = "";
            float prijs = 0;
            string query = "SELECT * FROM Artikelen WHERE Omschrijving LIKE '%" + code + "%' ORDER BY ArtikelNr";
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader dreader = cmd.ExecuteReader();

                while (dreader.Read())
                {
                    artnr = int.Parse(dreader["ArtikelNr"].ToString());
                    barcode = dreader["BARcode"].ToString();
                    omsch = dreader["Omschrijving"].ToString();
                    prijs = float.Parse(dreader["Prijs"].ToString());
                    arts.Add(new Artikel(artnr, 1, barcode, omsch, prijs, prijs));
                }
                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kassa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return arts;
        }
    }
}
