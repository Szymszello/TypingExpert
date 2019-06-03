using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class odczyt : Form
    {
       private Form1 formaa1;
        public odczyt(Form1 forma1)
        {
            
            InitializeComponent();
            formaa1 = forma1;
        }

       

        private void odczyt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazadanychDataSet.wyniki' table. You can move, or remove it, as needed.
           
            this.wynikiTableAdapter.FillBy(this.bazadanychDataSet.wyniki);
        }
        

        private void wyczyscbutton_Click(object sender, EventArgs e) //czyszczenie rekordów
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            SqlCeConnection con = new SqlCeConnection("Data Source =" + path + "bazadanych.sdf");
            con.Open();

            string sql = @"DELETE FROM wyniki;";
            SqlCeCommand cmd = new SqlCeCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            odczyt_Load(sender, e);
        }
    }
}
