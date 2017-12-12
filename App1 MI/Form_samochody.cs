using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace App1_MI
{
    public partial class Form_samochody : MaterialSkin.Controls.MaterialForm
    {
        public Form_samochody()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wyp_sam_lok_v1DataSet.SAMOCHODY' table. You can move, or remove it, as needed.
            this.sAMOCHODYTableAdapter.Fill(this.wyp_sam_lok_v1DataSet.SAMOCHODY);

        }

        private void button_dodaj_samochod_Click(object sender, EventArgs e)
        {
            string Connectthestring = null;
            string sql = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataReader dataReader;
            Connectthestring = "Server= mibrom; Database= Wyp_sam_lok_v1; User ID=sa; Password=andrzej";

            string marka = textBox_marka.Text;
            string typ = textBox_typ.Text;
            int rok_produkcji = int.Parse(textBox_rok_produkcji.Text);
            string kolor = textBox_kolor.Text;
            //konwersja stringa to float, zeby go dodac pozniej do bazy
            float num = float.Parse(textBox_pojemnosc.Text);
            string pojemnosc_silnika = num.ToString().Replace(',', '.');
            int przebieg = int.Parse(textBox_przebieg.Text);


            //sql = "INSERT INTO Samochody (IDsamochodu , Marka, Model ,Typ ,Rok_produkcji ,Kolor ,Pojemnosc_silnika) VALUES (17, '" + marka + "', '" + model + "', '" + typ + "', '" + rok_produkcji + "', '" + kolor + "', '" + pojemnosc_silnika + "');"; /*+ model + "', '" + typ + "', '1999', '" + kolor + ", '15';"; */
            sql = "INSERT INTO Samochody (Marka, Typ, Rok_produkcji, Kolor, Pojemnosc_silnika, Przebieg) VALUES('" + marka + "', '" + typ + "', '" + rok_produkcji + "', '" + kolor + "', '" + pojemnosc_silnika + "', '" + przebieg + "');";
            connection = new SqlConnection(Connectthestring);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {

                }
                dataReader.Close();
                command.Dispose();
                MessageBox.Show("Dodano nowy samochód !");
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Niestety nie udało się wykonać zadania!");
            }
        }

        private void textBox_marka_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            Form_main openForm = new Form_main();
            openForm.Show();
            Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
