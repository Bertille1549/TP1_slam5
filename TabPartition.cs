using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;
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
            //bsPartition.DataSource = Modele.listePartition(); //appel de la méthode listePartition
            // dgvPartition.DataSource = bsPartition;

            //Liste des partitions ... par style
            cbStyle.ValueMember = "NUMSTYLE"; //permet de stocker l'identifiant
            cbStyle.DisplayMember = "LIBSTYLE";
            bsStyle.DataSource = Modele.listeStyle();
            cbStyle.DataSource = bsStyle;
        }

        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMSTYLE en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IDS = Convert.ToInt32(cbStyle.SelectedValue);
            int IdStyle = Convert.ToInt32(cbStyle.SelectedValue);
            bsPartition.DataSource = Modele.listePartitionParStyle(IdStyle).Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.NumstyleNavigation.Numstyle,
                x.NumstyleNavigation.Libstyle
            })
            .OrderBy(x => x.Prixpart);
            dgvPartition.DataSource = bsPartition;
        }
    }
}
