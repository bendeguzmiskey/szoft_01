namespace fibonacciSorGyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Elem> elem = new List<Elem>();

            for (int i = 0; i < 10; i++)
            {
                Elem uj = new Elem();
                uj.Ertek = Fibonacci(i);
                uj.Sorszam = i;

                elem.Add(uj);
            }
            dataGridView1.DataSource = elem;
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
