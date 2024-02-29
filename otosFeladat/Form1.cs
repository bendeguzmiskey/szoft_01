namespace otosFeladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int szamlalo = 1;
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < szamlalo; j++)
                {
                    Button uj = new Button();

                    uj.Height = 10;
                    uj.Width = 10;

                    uj.Left = j * 10;
                    uj.Top = i * 10;

                    Controls.Add(uj);
                }

                if (szamlalo < 11) szamlalo++;

            }
        }
    }
}