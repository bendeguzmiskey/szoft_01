namespace hatodikGyakorlat
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int l�p�ssz�m = 0;
        int hossz = 5;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            if (l�p�ssz�m % 10 == 0)
            {
                Random rnd = new Random();
                M�rgek m�reg = new M�rgek();
                m�reg.Top = 100 * rnd.Next(5);
                m�reg.Left = 100 * rnd.Next(5);
                Controls.Add(m�reg);

                Alma alma = new Alma();
                alma.Top = 100 * rnd.Next(5);
                alma.Left = 100 * rnd.Next(5);
                Controls.Add(alma);

            }

            //Fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                if (item is M�rgek)
                {
                    M�rgek k = (M�rgek)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                if (item is Alma)
                {
                    Alma k = (Alma)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        hossz++;
                        Controls.Remove(k);
                        return;
                    }
                }
            }

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            k�gy�.Add(ke); //Amikor �j fejet nevezt�nk a k�gy�nak, azt beletessz�k a `k�gy�` list�ba is ..
            Controls.Add(ke); //.. �s az �rlap vez�rl�inek a list�j�ba is

            //Farokv�g�s
            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}