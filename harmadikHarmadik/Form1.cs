namespace harmadikHarmadik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Button uj = new Button();
                uj.Left = random.Next(1,ClientRectangle.Width);
                uj.Top  = random.Next(1,ClientRectangle.Height);
                uj.Width = random.Next(30);
                uj.Height = random.Next(30);
                uj.BackColor = Color.FromArgb(random.Next(0,255), random.Next(0, 255), random.Next(0, 255));

                Controls.Add(uj);

            }
        }
    }
}
