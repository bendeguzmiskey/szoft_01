namespace szorzoTablaGyak
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
                    Button uj = new Button();
                    uj.Width = 40;
                    uj.Height = 40;
                    uj.Top = 50 * j;
                    uj.Left = 50 * i;
                    uj.Text = (i * j).ToString();
                    Controls.Add(uj);
                }
            }
        }
    }
}
