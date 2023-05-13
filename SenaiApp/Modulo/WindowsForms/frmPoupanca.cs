using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmPoupanca : Form
    {
        public frmPoupanca()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(lblValorPoupanca.Text != "")
            {
                var depositoInicial = double.Parse(txtValorPoupanca.Text);

                const double taxaDeJuros = 0.0071;

                var montante = depositoInicial + taxaDeJuros * depositoInicial;

                pnlExibirValorPoupanca.Visible = true;

                pnlExibirValorPoupanca.BackColor = Color.FromArgb(102, 255, 153);

                lblExibirValorPoupanca.Text = "R$" + montante.ToString();
            }
        }
    }
}
