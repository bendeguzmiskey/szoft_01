namespace elsoOra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal hitelOsszeg = decimal.Parse(tbHitelOsszeg.Text);
            decimal haviKamat = decimal.Parse(tbHaviKamat.Text);
            decimal haviTorleszto = decimal.Parse(tbHaviTorleszto.Text);

            decimal hatralek = hitelOsszeg;
            decimal befizetes = 0;

            List<sor> sorok = new List<sor>();

            int honap = 1;

            while (hatralek > 0)
            {
                hatralek += haviKamat * (hatralek / 100m);
                hatralek -= haviTorleszto;
                befizetes += haviTorleszto;
                honap++;

                sor uj = new sor();
                uj.hatralek = Math.Round(hatralek);
                uj.honap = honap;

                sorok.Add(uj);

                dataGridView1.DataSource = sorok;
            }



        }
    }
}
