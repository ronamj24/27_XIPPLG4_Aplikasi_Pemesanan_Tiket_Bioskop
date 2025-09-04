namespace TiketBioskopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtnama = new TextBox();
            label3 = new Label();
            txtfilm = new ComboBox();
            label4 = new Label();
            nmjumlah = new NumericUpDown();
            label5 = new Label();
            txttotal = new TextBox();
            btnpesan = new Button();
            btnreset = new Button();
            GroupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictmovie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nmjumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictmovie).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 21);
            label1.Name = "label1";
            label1.Size = new Size(460, 45);
            label1.TabIndex = 0;
            label1.Text = "PEMESANAN TIKET BIOSKOP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(39, 104);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Penonton";
            label2.Click += label2_Click;
            // 
            // txtnama
            // 
            txtnama.AccessibleName = "lblview";
            txtnama.Location = new Point(185, 104);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(342, 31);
            txtnama.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(39, 158);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 3;
            label3.Text = "Film";
            // 
            // txtfilm
            // 
            txtfilm.AccessibleName = "";
            txtfilm.FormattingEnabled = true;
            txtfilm.Items.AddRange(new object[] { "Spiderman", "The Jungle Book (Disney)", "The Sea Beast", "LUCA (Disney)", "COCO (Disney)", "The Croods (Disney)" });
            txtfilm.Location = new Point(185, 155);
            txtfilm.Name = "txtfilm";
            txtfilm.Size = new Size(342, 33);
            txtfilm.TabIndex = 4;
            txtfilm.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(39, 210);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 5;
            label4.Text = "Jumlah Tiket";
            // 
            // nmjumlah
            // 
            nmjumlah.AccessibleName = "";
            nmjumlah.BackColor = Color.White;
            nmjumlah.ForeColor = Color.Black;
            nmjumlah.Location = new Point(185, 210);
            nmjumlah.Name = "nmjumlah";
            nmjumlah.Size = new Size(342, 31);
            nmjumlah.TabIndex = 6;
            nmjumlah.ValueChanged += nmjumlah_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(39, 261);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 7;
            label5.Text = "Total";
            // 
            // txttotal
            // 
            txttotal.AccessibleName = "";
            txttotal.Location = new Point(185, 261);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(342, 31);
            txttotal.TabIndex = 8;
            txttotal.TextChanged += txttotal_TextChanged;
            // 
            // btnpesan
            // 
            btnpesan.AccessibleName = "";
            btnpesan.BackColor = Color.MediumSeaGreen;
            btnpesan.FlatStyle = FlatStyle.Flat;
            btnpesan.ForeColor = Color.White;
            btnpesan.Location = new Point(185, 320);
            btnpesan.Name = "btnpesan";
            btnpesan.Size = new Size(162, 43);
            btnpesan.TabIndex = 9;
            btnpesan.Text = "PESAN";
            btnpesan.UseVisualStyleBackColor = false;
            btnpesan.Click += button1_Click;
            // 
            // btnreset
            // 
            btnreset.AccessibleName = "btnreset";
            btnreset.BackColor = Color.IndianRed;
            btnreset.FlatStyle = FlatStyle.Flat;
            btnreset.ForeColor = Color.White;
            btnreset.Location = new Point(365, 320);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(162, 43);
            btnreset.TabIndex = 10;
            btnreset.Text = "RESET";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += button2_Click;
            // 
            // GroupBox1
            // 
            GroupBox1.AccessibleName = "";
            GroupBox1.BackColor = Color.WhiteSmoke;
            GroupBox1.BackgroundImage = (Image)resources.GetObject("GroupBox1.BackgroundImage");
            GroupBox1.ForeColor = Color.Black;
            GroupBox1.Location = new Point(555, 242);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(232, 168);
            GroupBox1.TabIndex = 11;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Tiket Bioskop";
            GroupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(622, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictmovie
            // 
            pictmovie.AccessibleName = "";
            pictmovie.BackColor = Color.Transparent;
            pictmovie.Location = new Point(555, 104);
            pictmovie.Name = "pictmovie";
            pictmovie.Size = new Size(232, 131);
            pictmovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictmovie.TabIndex = 14;
            pictmovie.TabStop = false;
            pictmovie.Click += pictmovie_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 434);
            Controls.Add(pictmovie);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(GroupBox1);
            Controls.Add(btnreset);
            Controls.Add(btnpesan);
            Controls.Add(txttotal);
            Controls.Add(label5);
            Controls.Add(nmjumlah);
            Controls.Add(label4);
            Controls.Add(txtfilm);
            Controls.Add(label3);
            Controls.Add(txtnama);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)nmjumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictmovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnama;
        private Label label3;
        private ComboBox txtfilm;
        private Label label4;
        private NumericUpDown nmjumlah;
        private Label label5;
        private TextBox txttotal;
        private Button btnpesan;
        private Button btnreset;
        private GroupBox GroupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictmovie;
    }
}
