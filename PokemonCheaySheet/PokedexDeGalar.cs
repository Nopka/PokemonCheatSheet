using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PokemonCheaySheet
{
    public partial class PokedexDeGalar : Form
    {
        #region Variables globales pour SQLite
        SQLiteConnection db = new SQLiteConnection("Data Source =PokemonBDD.db");
        SQLiteDataAdapter dataAdapter;
        SQLiteCommandBuilder cmdb1;
        DataSet ds;
        #endregion

        public PokedexDeGalar()
        {
            InitializeComponent();
            refreshData(PokedexGridView);
        }
        void refreshData(DataGridView dgv)
        {
            db.Open();

            // Requête SQL
            dataAdapter = new SQLiteDataAdapter("SELECT field1 as 'Numéros', field2 as 'Image', field3 as 'Nom', field4 as 'Type', field5 as 'Talent', field6 as 'Localisations', field7 as 'Capturé'  FROM PokedexGalar", db);
            ds = new DataSet();

            dataAdapter.Fill(ds, "PokedexGalar");
            dgv.DataSource = ds.Tables[0];

            dgv.Columns[1].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Visible = false;
            
            foreach(DataGridViewRow row in dgv.Rows)
            {
                //MessageBox.Show(row.Cells[6].Value.ToString());
                string captured = row.Cells[6].Value.ToString();
                if (captured == "NON")
                {
                    row.Cells[6].Style.BackColor = Color.Red;
                    //MessageBox.Show("PD C PO BON");
                }
                else if (captured == "OUI")
                {
                    row.Cells[6].Style.BackColor = Color.Green;
                    //MessageBox.Show("FUCK LOIC");
                }
            }

            db.Close();
        }

        private void PokedexDeGalar_Load(object sender, EventArgs e)
        {
            refreshData(PokedexGridView);
        }
        string IDCurrentPoke; // variable pour recup l'ID du pokemon selectionné
        string EtatCurrentPoke; // variable pour recup l'état de capture du pokemon
        private void PokedexGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PokedexGridView.Rows[e.RowIndex];
                string temp1 = row.Cells[0].Value.ToString();
                string[] NumInSWDex = temp1.Split(',');
                NumPoke_Textbox.Text = NumInSWDex[0];
                NomPoke_Textbox.Text = row.Cells[2].Value.ToString();
                TypePoke_Textbox.Text = row.Cells[3].Value.ToString();
                string temp = row.Cells[1].Value.ToString();
                string[] NumInNationalDex = temp.Split('#');
                ImagePoke_Picturebox.BackgroundImage = Image.FromFile("images/Pokemon_bdd/"+NumInNationalDex[1]+".png");
                TalentPoke_Richtextbox.Text = row.Cells[4].Value.ToString();
                LocalisationPoke_RichTextBox.Text = row.Cells[5].Value.ToString();
                NationalDex_Textbox.Text = row.Cells[1].Value.ToString();
                string Captured = row.Cells[6].Value.ToString();
                IDCurrentPoke = temp1;
                EtatCurrentPoke = Captured;
                if (Captured == "OUI")
                {
                    button1.BackgroundImage = Image.FromFile("images/iconePokeballBleu.png");
                }
                else if (Captured == "NON")
                {
                    button1.BackgroundImage = Image.FromFile("images/iconePokeball.png");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e) // Boutton réinitialiser Pokedex
        {
            db.Open();
            dataAdapter = new SQLiteDataAdapter("UPDATE PokedexGalar SET field7 = 'NON';", db);
            ds = new DataSet();
            dataAdapter.Fill(ds, "PokedexGalar");
            db.Close();
            refreshData(PokedexGridView);
        }

        private void Button1_Click(object sender, EventArgs e) // Boutton Capturé
        {
            if(EtatCurrentPoke == "OUI")
            {
                db.Open();
                dataAdapter = new SQLiteDataAdapter("UPDATE PokedexGalar SET field7 = 'NON' WHERE field1 = '" + IDCurrentPoke + "';", db);
                ds = new DataSet();
                dataAdapter.Fill(ds, "PokedexGalar");
                db.Close();
                refreshData(PokedexGridView);
            }
            else if(EtatCurrentPoke == "NON")
            {
                db.Open();
                dataAdapter = new SQLiteDataAdapter("UPDATE PokedexGalar SET field7 = 'OUI' WHERE field1 = '" + IDCurrentPoke + "';", db);
                ds = new DataSet();
                dataAdapter.Fill(ds, "PokedexGalar");
                db.Close();
                refreshData(PokedexGridView);
            }
            
        }

        private void PokedexGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PokedexGridView.Rows)
            {
                string captured = row.Cells[6].Value.ToString();
                if (captured == "NON")
                {
                    row.Cells[6].Style.BackColor = Color.Red;
                }
                else if (captured == "OUI")
                {
                    row.Cells[6].Style.BackColor = Color.Green;
                }
            }
        }
    }
}
