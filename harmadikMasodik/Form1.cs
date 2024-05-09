namespace harmadikMasodik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    SzamoloGomb gomb = new SzamoloGomb();
                    gomb.Left = i * 30;
                    gomb.Top = j * 30;
                    gomb.Text = (i * j).ToString();
                    Controls.Add(gomb);
                }
            }
        }
    }
}
