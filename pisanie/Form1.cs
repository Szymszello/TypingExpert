using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using WMPLib;



namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public Form1() //To jest początek XD
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
             t.Start();
            Thread.Sleep(2500);
            InitializeComponent();
            t.Abort();
         }

        #region Dane

        string path = AppDomain.CurrentDomain.BaseDirectory; //ścieżka do Debug
        Zapis forma2;
        odczyt odczyt1;
        AboutBox1 oapce;

       string[] wyrazy;
       int index = 0;                                           //który wyraz       
       int t = 60;                                              //czas domyślny
       /* Wyniki */
       public float wynik = 0;
       public float czas = 0;
       public double wps;
       
       
        public float wynik1(float w)
        {
            return wynik;
        }
        public float czas1(float c)
        {
            return czas;
        }
        public int wps1(int wps)
        {
            return wps;
        }
        #endregion

        public void textBox2_TextChanged(object sender, EventArgs e)                //PISANIE! 
        {
            DialogResult result;
            try
            {             
                    
                if (index <= wyrazy.Length)
                {
                    if (labelWyrazy.Text == textBox2.Text)
                    {
                        wynik++;
                        index++;
                        labelWyrazy.Text = wyrazy[index];                        
                        textBox2.Text = "";
                        labelwynik.Text = wynik.ToString();
                    }

                 }             
                            
            }

            catch                                         //jeżeli przed czasem
                {
                    timer1.Enabled = false;                             //stop timera
                    labelwynik.Text = wynik.ToString();
                    czas = Convert.ToInt32(numericUpDown1.Value) - Convert.ToInt32(labelczas.Text);                    
                    wps = wynik / czas;
                    result = MessageBox.Show("Gratulacje ukończyłeś przed czasem!" + Environment.NewLine  
                        + "Twój wynik to: " + wynik + " (wyrazów)" + Environment.NewLine + "Czas: " + czas + "(s)" 
                        + Environment.NewLine + "Wyrazów na sekundę: " + wps.ToString("N2") + Environment.NewLine 
                        + "Czy chcesz zapisać wynik?", "Koniec Gry!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        zapis_Click(sender, e);
                    }
                    else
                    {
                        labelWyrazy.Text = "Wczytaj tekst (F2)";
                    
                    }
                    button1.Enabled = true; 
                    button1.Text = "Od nowa!";
                    textBox2.ReadOnly = true;                                   //blokada klawiatury
                    
                    
                }
        }

        #region wczytywanie
        public void wczytajToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            openFileDialog1.InitialDirectory = path+@"\teksty" ;
            DialogResult result;
        wczytaj:                                                 //wczytywanie goto
            if (wyrazyBox.Text == "")
            {
                labelczas.Text = numericUpDown1.Value.ToString();
                t = Convert.ToInt32(numericUpDown1.Value);
                string tekst = null;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Encoding enc = Encoding.GetEncoding("Windows-1250");
                    StreamReader sr = new StreamReader(openFileDialog1.FileName, enc); //wczytuje tekst
                    tekst = sr.ReadToEnd();
                    sr.Close();
                    if (panel2.Visible == true) panel2.Visible = false;
                    char[] separatory = { ' ', ',', '.', ':','-', '\n', '\r' };                         //separatory

                    wyrazy = tekst.Split(separatory);                                   //dzielę na wyrazy
                    wyrazy = wyrazy.Where(x => !string.IsNullOrEmpty(x)).ToArray();  //usuwa puste znaki
                    if (wyrazy.Length > 15)
                    {
                        button1.Enabled = true;                                             //aktywuję przycisk start
                        labelWyrazy.Text = "Naciśnij Start lub Enter";
                        foreach (string s in wyrazy)
                        {
                            if (s.Trim() != "")
                                wyrazyBox.Text += s + " ";
                        }

                        switch (wyrazy.Length)                                              //wypisuję ile wyrazów do przepisania
                        {
                            case 1:
                                textBox2.Text = "Masz do przepisania " + wyrazy.Length + " wyraz.";
                                break;

                            case 2:
                            case 3:
                            case 4:
                                textBox2.Text = "Masz do przepisania " + wyrazy.Length + " wyrazy.";
                                break;
                            default:
                                textBox2.Text = "Masz do przepisania " + wyrazy.Length + " wyrazów.";
                                break;
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Za krótki tekst!", "Tekst powinien być nie krótszy niż 15 wyrazów!");
                        ustawienia_początkowe();
                        goto wczytaj;
                    }

                }
                else
                {
                    ustawienia_początkowe();   

                }
            }
            else
            {
                result = MessageBox.Show("Czy chcesz wczytać inny tekst?", "Tekst już jest wczytany",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    wyrazyBox.Text = "";
                    goto wczytaj;
                }



            }
        

        }
        #endregion
        public void ustawienia_początkowe()                                         //przywracam początkowe dane 
        {
            index = 0;                                                                         
            wynik = 0;
            t = Convert.ToInt32(numericUpDown1.Value);
            button1.Text = "Start";
            labelczas.Text = "--";
            button1.Enabled = false;
            textBox2.ReadOnly = true;
            textBox2.Text = "Wpisz tekst..";
            labelWyrazy.Text = "Wczytaj tekst (F2)";
            comboBox1.Enabled = true;
        }

        public void SplashScreen()                                                  //ekran powitalny uruchomienie
        {
            Application.Run(new SplashScreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlayFile();
            panel2.BackColor = Color.FromArgb(150, 0, 0, 0);
            panel2.Visible = true;
            this.TopLevel = true;
        }
       
        private void timer1_Tick(object sender, EventArgs e)                        //Timer odliczanie czasu, koniec gry.
        {
            DialogResult result;
            t--;
            labelczas.Text = t.ToString();
            if(labelczas.Text == "0")            // Po czasie
            {
                timer1.Enabled = false;                             
                czas = Convert.ToInt32(numericUpDown1.Value);

                wps = wynik / czas;
                result = MessageBox.Show("Koniec gry!" + Environment.NewLine                                    //Wyświetla wynik i pyta czy zapisać
                        + "Twój wynik to: " + wynik + " (wyrazów)" + Environment.NewLine + "Czas: " + czas + "(s)"
                        + Environment.NewLine + "Wyrazów na sekundę: " + wps.ToString("N2") + Environment.NewLine
                        + "Czy chcesz zapisać wynik?", "Koniec Gry!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    zapis_Click(sender, e);
                }
                else
                {
                    labelWyrazy.Text = "Wczytaj tekst (F2)";

                }
                button1.Enabled = true;
                button1.Text = "Od nowa!";
                  
                textBox2.ReadOnly = true;                                   //blokada klawiatury
                
            }

        }

        #region muzyka
        WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
        private void PlayFile()
        {                       
            Player.URL = path +@"\Armada.mp3";
            Player.controls.play();
        }
        private void StopFile()
        {
            Player.controls.stop();
        }
        #endregion

        public void button1_Click(object sender, EventArgs e)                       //przycisk start
        {
            ustawienia_początkowe();
            try
            {                
                textBox2.Enabled = true;
                timer1.Enabled = true;
                textBox2.Text = null;
                textBox2.ReadOnly = false;
                textBox2.Focus();
                labelWyrazy.Text = wyrazy[index];
                comboBox1.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show("Błąd:"+Environment.NewLine+ ex,"Zły ruch!"); }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)             //Enter skrót od start 
        {
            if (labelczas.Text == numericUpDown1.Value.ToString())
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    button1_Click(sender, e);
                }
            }
            if (button1.Enabled == true)
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    button1_Click(sender, e);
                }
            }
            
            
        }
    
        private void button2_Click(object sender, EventArgs e)                      //przycisk - ranking
        {
            odczyt1 = new odczyt(this);
            odczyt1.Visible = true;
            
        }

        private void zapis_Click(object sender, EventArgs e)                        //przycisk - zapis
        {
            forma2 = new Zapis(this);
            forma2.Visible = true;
            
        }

        #region muzyka włącz/wyłącz
        bool x = true; //stan muzyki
        private void pictureBox1_Click(object sender, EventArgs e) //muzyka start-stop
        {
            if (x == true)
            {
                StopFile();
                x = !x;
            }
            else
            {
                PlayFile();
                x = !x;
            }
        }
        #endregion

        private void zobaczWynikiToolStripMenuItem_Click(object sender, EventArgs e) //ranking
        {
            button2_Click(sender, e);
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)    //o autorze
        {     

            oapce = new AboutBox1();
            oapce.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)           //otworzenie panela instrukcji
        {
            panel2.Visible = true;
            
        }
   
        private void label7_Click(object sender, EventArgs e)                       //zamknięcie panela instrukcji
        {
            panel2.Visible = false;
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)        //zmiana czasu stopera
        {
            t = Convert.ToInt32(numericUpDown1.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     //wybór tekstu
        {
            Cursor.Current = Cursors.WaitCursor;
            wyrazyBox.Text = null;
            
            string tekst = null;
            int i = comboBox1.SelectedIndex;
            
            
                Encoding enc = Encoding.GetEncoding("Windows-1250");
                i++;
                string sciezka = path+"\\teksty\\tekst"+i.ToString()+".txt";                
                StreamReader sr1 = new StreamReader(sciezka, enc); //wczytuje do textboxa
                tekst = sr1.ReadToEnd();
                sr1.Close();
                if (panel2.Visible == true) panel2.Visible = false;
                char[] separatory = { ' ', ',', '.', ':','-', '\n', '\r' };                         //separatory

                wyrazy = tekst.Split(separatory);                                   //dzielę na wyrazy
                wyrazy = wyrazy.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                button1.Enabled = true;                                             //aktywuję przycisk start
                labelWyrazy.Text = "Naciśnij Start lub Enter";
                foreach (string s in wyrazy)
                {
                    if (s.Trim() != "")
                        wyrazyBox.Text += s + " ";
                }

                switch (wyrazy.Length)                                              //wypisuję ile wyrazów do przepisania
                {
                    case 1:
                        textBox2.Text = "Masz do przepisania " + wyrazy.Length + " wyraz.";
                        break;

                    case 2:
                    case 3:
                    case 4:
                        textBox2.Text = "Masz do przepisania " + wyrazy.Length + " wyrazy.";
                        break;
                    default:
                        textBox2.Text = "Masz do przepisania " + wyrazy.Length + " wyrazów.";
                        break;
                }
                Cursor.Current = Cursors.Default;
                Application.DoEvents();

        }

    }
}
