using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace CidadeInteligente
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbDtInclusao.Text = "";
            txbRG.Text = "";
            txbCPF.Text = "";
            txbCTPS.Text = "";
            txbCNH.Text = "";
        }
    }
}
