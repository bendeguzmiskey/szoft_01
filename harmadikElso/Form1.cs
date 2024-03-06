namespace harmadikElso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    VillogoGomb gomb = new VillogoGomb();

                    gomb.Height = 30;
                    gomb.Width = 30;

                    gomb.Top = i*30;
                    gomb.Left = j*30;

                    gomb.Text = (i*j).ToString();
                    Controls.Add(gomb);

                }
            }
            
        }
    }
}
