namespace sakkTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int a = i + j;
                    if (a % 2 == 0)
                    {
                        Button uj = new Button();
                        uj.Width = 60;
                        uj.Height = 60;
                        uj.Top = i * 60;
                        uj.Left = j * 60;
                        Controls.Add(uj);
                    }
                    
                }
            }
        }
    }
}
