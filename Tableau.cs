namespace TP1
{
    public partial class Tableau : Form
    {
        public Tableau()
        {
            InitializeComponent();
        }

        private void Tableau_Load(object sender, EventArgs e)
        {
            bsClients.DataSource = Modele.listeClients(); //appel de la méthode listeClients
            dgvClients.DataSource = bsClients;
        }
    }
}