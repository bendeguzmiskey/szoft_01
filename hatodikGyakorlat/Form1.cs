namespace hatodikGyakorlat
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lépésszám = 0;
        int hossz = 5;

        List<KígyóElem> kígyó = new List<KígyóElem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            if (lépésszám % 10 == 0)
            {
                Random rnd = new Random();
                Mérgek méreg = new Mérgek();
                méreg.Top = 100 * rnd.Next(5);
                méreg.Left = 100 * rnd.Next(5);
                Controls.Add(méreg);

                Alma alma = new Alma();
                alma.Top = 100 * rnd.Next(5);
                alma.Left = 100 * rnd.Next(5);
                Controls.Add(alma);

            }

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                if (item is Mérgek)
                {
                    Mérgek k = (Mérgek)item;

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

            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke); //Amikor új fejet neveztünk a kígyónak, azt beletesszük a `kígyó` listába is ..
            Controls.Add(ke); //.. és az ûrlap vezérlõinek a listájába is

            //Farokvágás
            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}