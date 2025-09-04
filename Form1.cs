namespace TiketBioskopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int HargaTiket(string film)
        {
            return 40000;
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = txtnama.Text;
            string film = txtfilm.Text;
            int jumlah = (int)nmjumlah.Value;

            int harga = HargaTiket(film);
            int total = jumlah * harga;

            txttotal.Text = "Rp " + total.ToString("NO");
            GroupBox1.Text =
                "== Tiket Bioskop ==\n" +
                "Nama Penonton : " + nama + "\n" +
                "Film : " + film + "\n" +
                "Jumlah Tiket : " + jumlah + "\n" +
                "Total : Rp " +
                harga.ToString("N0") + "\n" +
                "Total : Rp " +
                total.ToString("N0") + "\n" +
                "=======================";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? film = txtfilm.SelectedItem?.ToString();
            int harga = 40000; // default harga tiket
            Image? poster = null;

            switch (film)
            {
                
                case "Spiderman":
                    {
                        using (MemoryStream ms = new MemoryStream(Properties.Resources.Spiderman))
                        {
                            poster = Image.FromStream(ms);
                        }
                        break;
                    }

                case "The Jungle Book (Disney)":
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.The_Jungle_Book_Disney))
                    {
                        poster = Image.FromStream(ms);
                    }
                    break;

                case "The Sea Beast":
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.The_Sea_Beast))
                    {
                        poster = Image.FromStream(ms);
                    }
                    break;

                case "LUCA (Disney)":
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.LUCA_Disney))
                    {
                        poster = Image.FromStream(ms);
                    }
                    break;

                case "COCO (Disney)":
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.COCO_Disney))
                    {
                        poster = Image.FromStream(ms);
                    }
                    break;

                case "The Croods (Disney)":
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.The_Croods))
                    {
                        poster = Image.FromStream(ms);
                    }
                    break;
            }

            // tampilkan poster
            pictmovie.Image = poster;

            // hitung total (kalau jumlah tiket sudah dipilih)
            int jumlah = (int)nmjumlah.Value; // nmJumlah = NumericUpDown
            int total = jumlah * harga;
            txttotal.Text = "Rp " + total.ToString("N0");
            HitungTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetControls(this); // 'this' = seluruh form, termasuk semua GroupBox
            txttotal.Clear();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {
            txtnama.Text = txtnama.Text;
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            int harga = 40000;
            int jumlah = (int)nmjumlah.Value;
            int total = harga * jumlah;
            txttotal.Text = total.ToString("Rp #,##0");
        }

        private void nmjumlah_ValueChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }
        private void HitungTotal()
        {
            int harga = 40000;
            int jumlah = (int)nmjumlah.Value;
            int total = harga * jumlah;
            txttotal.Text = total.ToString();
        }

        private void pictmovie_Click(object sender, EventArgs e)
        {

        }
        private void ResetControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                    tb.Clear();
                else if (ctrl is RichTextBox rtb)
                    rtb.Clear();
                else if (ctrl is ComboBox cb)
                    cb.SelectedIndex = -1;
                else if (ctrl is NumericUpDown nud)
                    nud.Value = nud.Minimum; 
                else if (ctrl is PictureBox pb)
                    pb.Image = null;
                else if (ctrl is GroupBox gb)
                    ResetControls(gb);
            }
        }

    }
}
