namespace elsoOra
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
            button1 = new Button();
            tbHitelOsszeg = new TextBox();
            tbHaviKamat = new TextBox();
            tbHaviTorleszto = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(380, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbHitelOsszeg
            // 
            tbHitelOsszeg.Location = new Point(61, 82);
            tbHitelOsszeg.Name = "tbHitelOsszeg";
            tbHitelOsszeg.Size = new Size(100, 23);
            tbHitelOsszeg.TabIndex = 1;
            // 
            // tbHaviKamat
            // 
            tbHaviKamat.Location = new Point(61, 135);
            tbHaviKamat.Name = "tbHaviKamat";
            tbHaviKamat.Size = new Size(100, 23);
            tbHaviKamat.TabIndex = 2;
            // 
            // tbHaviTorleszto
            // 
            tbHaviTorleszto.Location = new Point(61, 184);
            tbHaviTorleszto.Name = "tbHaviTorleszto";
            tbHaviTorleszto.Size = new Size(100, 23);
            tbHaviTorleszto.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(241, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(tbHaviTorleszto);
            Controls.Add(tbHaviKamat);
            Controls.Add(tbHitelOsszeg);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbHitelOsszeg;
        private TextBox tbHaviKamat;
        private TextBox tbHaviTorleszto;
        private DataGridView dataGridView1;
    }
}
