namespace InterfazVisualQEMU_DanielMartin
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto_iso = new System.Windows.Forms.TextBox();
            this.buscaarchivos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.botoncrear = new System.Windows.Forms.Button();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texto_nombre = new System.Windows.Forms.TextBox();
            this.botoncancelar = new System.Windows.Forms.Button();
            this.checkguardar = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tamano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // texto_iso
            // 
            this.texto_iso.Location = new System.Drawing.Point(310, 87);
            this.texto_iso.Name = "texto_iso";
            this.texto_iso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.texto_iso.Size = new System.Drawing.Size(174, 23);
            this.texto_iso.TabIndex = 0;
            this.texto_iso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buscaarchivos
            // 
            this.buscaarchivos.Location = new System.Drawing.Point(515, 87);
            this.buscaarchivos.Name = "buscaarchivos";
            this.buscaarchivos.Size = new System.Drawing.Size(102, 23);
            this.buscaarchivos.TabIndex = 1;
            this.buscaarchivos.Text = "Buscar Archivos";
            this.buscaarchivos.UseVisualStyleBackColor = true;
            this.buscaarchivos.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazVisualQEMU_DanielMartin.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(490, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta a la .iso de la maquina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "RAM dada a la maquina";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.ItemHeight = 15;
            this.lista1.Items.AddRange(new object[] {
            "1024",
            "2048",
            "3072",
            "4096",
            "5120",
            "6144",
            "7168",
            "8192"});
            this.lista1.Location = new System.Drawing.Point(194, 145);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(120, 124);
            this.lista1.TabIndex = 5;
            this.lista1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // botoncrear
            // 
            this.botoncrear.Location = new System.Drawing.Point(247, 342);
            this.botoncrear.Name = "botoncrear";
            this.botoncrear.Size = new System.Drawing.Size(115, 40);
            this.botoncrear.TabIndex = 6;
            this.botoncrear.Text = "Crear Maquina";
            this.botoncrear.UseVisualStyleBackColor = true;
            this.botoncrear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.ItemHeight = 15;
            this.lista2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.lista2.Location = new System.Drawing.Point(492, 145);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(120, 124);
            this.lista2.TabIndex = 8;
            this.lista2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero de nucleos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre de la maquina";
            // 
            // texto_nombre
            // 
            this.texto_nombre.Location = new System.Drawing.Point(310, 44);
            this.texto_nombre.Name = "texto_nombre";
            this.texto_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.texto_nombre.Size = new System.Drawing.Size(174, 23);
            this.texto_nombre.TabIndex = 10;
            // 
            // botoncancelar
            // 
            this.botoncancelar.Location = new System.Drawing.Point(25, 29);
            this.botoncancelar.Name = "botoncancelar";
            this.botoncancelar.Size = new System.Drawing.Size(75, 23);
            this.botoncancelar.TabIndex = 11;
            this.botoncancelar.Text = "Cancelar";
            this.botoncancelar.UseVisualStyleBackColor = true;
            this.botoncancelar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // checkguardar
            // 
            this.checkguardar.AutoSize = true;
            this.checkguardar.Location = new System.Drawing.Point(194, 290);
            this.checkguardar.Name = "checkguardar";
            this.checkguardar.Size = new System.Drawing.Size(205, 19);
            this.checkguardar.TabIndex = 12;
            this.checkguardar.Text = "Guardar maquina virtual (imagen)";
            this.checkguardar.UseVisualStyleBackColor = true;
            this.checkguardar.CheckedChanged += new System.EventHandler(this.checkguardar_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tamaño (Gigas)";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // tamano
            // 
            this.tamano.Location = new System.Drawing.Point(512, 288);
            this.tamano.Name = "tamano";
            this.tamano.Size = new System.Drawing.Size(100, 23);
            this.tamano.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 394);
            this.Controls.Add(this.tamano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkguardar);
            this.Controls.Add(this.botoncancelar);
            this.Controls.Add(this.texto_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botoncrear);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buscaarchivos);
            this.Controls.Add(this.texto_iso);
            this.Name = "Form2";
            this.Text = "QEMU (creando nueva maquina)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox texto_iso;
        private Button buscaarchivos;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListBox lista1;
        private Button botoncrear;
        private ListBox lista2;
        private Label label3;
        private Label label4;
        private TextBox texto_nombre;
        private Button botoncancelar;
        private CheckBox checkguardar;
        private Label label5;
        private TextBox tamano;
    }
}