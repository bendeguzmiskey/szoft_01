namespace randomSzar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {



                    Button uj = new Button();
                    uj.Height = rnd.Next(1, 50);
                    uj.Width = rnd.Next(1, 100);

                    uj.Left = rnd.Next(1, 10) * 110;
                    uj.Top = rnd.Next(1, 10) * 55;

                    uj.BackColor = Color.FromArgb(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255));
                    Controls.Add(uj);
                }
            }
        }
    }
}