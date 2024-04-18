using CsvHelper;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;

namespace zhGyakorlas
{
    public partial class Form1 : Form
    {
        BindingList<Futok> futok = new();
        public Form1()
        {
            InitializeComponent();
            futokBindingSource.DataSource = futok;
            dataGridView1.DataSource = futokBindingSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<Futok>();
                foreach (var item in tomb)
                {
                    futok.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (futokBindingSource.Current == null)
            {
                MessageBox.Show("Hiba: Nincsen kiválasztva egy érték sem.");
                return;
            }
            if (MessageBox.Show("Megerõsítés", "Biztosan törölni szeretné a kiválasztott sort?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futokBindingSource.RemoveCurrent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSzerkesztes formSzerkesztes = new FormSzerkesztes();
            formSzerkesztes.futok = futokBindingSource.Current as Futok;
            formSzerkesztes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormUjAdat formUjAdat = new FormUjAdat();
            if (formUjAdat.ShowDialog() == DialogResult.OK)
            {
                futok.Add(formUjAdat.ujFutok);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futok);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int hanyAmcsi = 0;
            int leggyorsasbbIdo = 100000;


            foreach (var item in futok)
            {
                if (item.Nemzetiseg == "USA")
                { hanyAmcsi++; }
            }

            double minIdo = 1000;
            Futok legkisebb = new Futok();  
            foreach (var item in futok)
            {
                if (item.EredmenyPerc<minIdo)
                {
                    minIdo = item.EredmenyPerc;
                    legkisebb = item;
                }
            }
            MessageBox.Show($"Az usabol {hanyAmcsi} versenyzo erkezett. A legrovidebbb idot {legkisebb.Nev} futotta.");
        }
    }
}
