namespace InterfazVisualQEMU_DanielMartin
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
            System.Windows.Forms.Button botonnuevamaquina;
            System.Windows.Forms.Button botonabrirmaquinas;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            botonnuevamaquina = new System.Windows.Forms.Button();
            botonabrirmaquinas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonnuevamaquina
            // 
            botonnuevamaquina.Location = new System.Drawing.Point(122, 226);
            botonnuevamaquina.Name = "botonnuevamaquina";
            botonnuevamaquina.Size = new System.Drawing.Size(108, 56);
            botonnuevamaquina.TabIndex = 1;
            botonnuevamaquina.Text = "Crear Nueva Maquina Virtual";
            botonnuevamaquina.UseVisualStyleBackColor = true;
            botonnuevamaquina.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonabrirmaquinas
            // 
            botonabrirmaquinas.Location = new System.Drawing.Point(418, 226);
            botonabrirmaquinas.Name = "botonabrirmaquinas";
            botonabrirmaquinas.Size = new System.Drawing.Size(108, 56);
            botonabrirmaquinas.TabIndex = 2;
            botonabrirmaquinas.Text = "Abrir imagen de una maquina";
            botonabrirmaquinas.UseVisualStyleBackColor = true;
            botonabrirmaquinas.Click += new System.EventHandler(this.botonabrirmaquinas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazVisualQEMU_DanielMartin.Properties.Resources.QEMU_Logo4;
            this.pictureBox1.Location = new System.Drawing.Point(178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Información";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(botonabrirmaquinas);
            this.Controls.Add(botonnuevamaquina);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "QEMU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button botonnuevamaquina;
        private Button button1;
    }
}