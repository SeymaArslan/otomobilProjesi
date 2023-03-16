using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomobil
{
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adres adrs = new Adres();
            adrs.Hide();
            adrs.Show();
            this.Visible = false;
        }
    }
}
