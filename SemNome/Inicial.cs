using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemNome
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnVamosLa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Montagem abreTelaMontagem = new Montagem();
            abreTelaMontagem.ShowDialog();
            
        }
    }
}
