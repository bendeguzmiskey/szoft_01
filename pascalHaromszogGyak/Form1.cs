namespace pascalHaromszogGyak
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
                        uj.Width = 60;
                        uj.Height = 60;
                        uj.Top = i * 60;
                        uj.Left = ClientRectangle.Width/2-i*30+j*60;
                        int p = Faktorialis(i) / Faktorialis(j) * (i - j);
                        uj.Text = p.ToString();
                        Controls.Add(uj);
                    }
                }
            }
        }

        int Faktorialis(int n)
        {
            int eredmeny = 1;
            for (int i = 1; i <= n; i++)
            {
                eredmeny = eredmeny * i;
            }
            return eredmeny;
        }
    }
}
