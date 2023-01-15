using Entidades.Entidades;
using System;
using System.Windows.Forms;

namespace FormEjercicioException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico("pololkikjujhyujujkiujkjmnjhnbhgbhgbhgbvgfvcgcgfgdgfhteteyeyeterwreteyrhfhdgdgshdgdtegdgwtwedgdgdgstd");
                MessageBox.Show($"Medico creado: {medico.Nombre.Trim()}");


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void crearvacio_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico(" ");
                MessageBox.Show($"Medico creado : {medico.Nombre.Trim()}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
