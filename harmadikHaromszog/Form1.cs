namespace harmadikHaromszog
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
                    if (i >= j)
                    {
                        Button uj = new Button();
                        uj.Height = 30;
                        uj.Width = 30;
                        uj.Left = j * 30;
                        uj.Top = i * 30;
                        Controls.Add(uj);
                    }
                }
            }
        }
    }
}
