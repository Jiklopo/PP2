using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBaza
{
    public class Dosje
    {
        DataSet ds;
        SQLiteConnection con;
        SQLiteCommand prikaz;
        public Dosje()
        {
            string path = @"..\..\..\Bratki.db";
            con = new SQLiteConnection("Data Source =" + path);
        }

        public void Vypolnyaj(string ukaz)
        {
            con.Open();
            prikaz = new SQLiteCommand(ukaz, con);
            prikaz.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DaiInfu()
        {
            con.Open();
            string ukaz = "select * from Bratki";
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(ukaz, con);
            adapter.Fill(ds);
            con.Close();
            return ds.Tables[0];
        } 
    }
}
