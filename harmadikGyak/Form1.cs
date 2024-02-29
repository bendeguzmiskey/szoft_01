namespace harmadikGyak
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



                    VillogoGomb uj = new VillogoGomb();
                    uj.Height = 50;
                    uj.Width = 100;

                    uj.Left = i * 110;
                    uj.Top = j*55;
                    uj.Text= (i*j).ToString();

                    Controls.Add(uj);
                }
            }


        }
    }
}