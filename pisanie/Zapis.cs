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
    public partial class Zapis : Form
    {
        private Form1 formaa1;
        public Zapis(Form1 forma1)
        {
            
            InitializeComponent();
            formaa1 = forma1;
        }
                
        
        
    
        
        private void Zapis_Load(object sender, EventArgs e)
        {
            
            
        }
        #region pobieranie danych
        public float wynik()
        {
            return formaa1.wynik;
        }
        public float czas()
        {
           return formaa1.czas;
        }
        public double wps()
        {
            return formaa1.wps;
        }
        #endregion
        #region zapis do bazy danych
        private SqlCeConnection connection;
        private SqlCeDataAdapter adapter;
        private SqlCeCommandBuilder builder;
        private DataSet data;

        private void button1_Click(object sender, EventArgs e) //dodawanie do bazy danych 
        {
            Cursor.Current = Cursors.WaitCursor;
            string path = AppDomain.CurrentDomain.BaseDirectory;
           

            connection = new SqlCeConnection("Data Source ="+path+"bazadanych.sdf");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM wyniki";
            adapter = new SqlCeDataAdapter(cmd);
            builder = new SqlCeCommandBuilder();
            builder.DataAdapter = adapter;
            data = new DataSet();
            adapter.Fill(data);


            MemoryStream ms = new MemoryStream();
            byte[] im = ms.ToArray();
            DataRow newRow = data.Tables[0].NewRow();
            newRow["Nick"] = textBox1.Text;
            newRow["Wynik"] = wynik();
            newRow["Czas"] = czas();
            newRow["WPS"] = wps().ToString("N2");
          
            data.Tables[0].Rows.Add(newRow);
            adapter.Update(data);
            connection.Close();

            this.Close();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
            MessageBox.Show("Twój wynik został poprawnie zapisany!", "Zapis");
        }
        #endregion

        private void Zapis_KeyPress(object sender, KeyPressEventArgs e) //Skrót enter 
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button1_Click(sender, e);
            }
        }
    }
}
