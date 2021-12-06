using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCheaySheet
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Efficacite_Types _EfficaciteType = new Efficacite_Types();
            _EfficaciteType.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PokedexDeGalar _pokedexDeGalar = new PokedexDeGalar();
            _pokedexDeGalar.Show();
        }
    }
}
