using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Entities;

namespace TP1
{
    public partial class TabPartition : Form
    {
        public TabPartition()
        {
            InitializeComponent();
        }

        private void TabPartition_Load(object sender, EventArgs e)
        {
            bsPartition.DataSource = Modele.listePartition(); //appel de la méthode listePartition
            dgvPartition.DataSource = bsPartition;
        }
    }
}
