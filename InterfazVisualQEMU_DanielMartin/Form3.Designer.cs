namespace InterfazVisualQEMU_DanielMartin
{
    partial class Form3
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
            this.botonapagar = new System.Windows.Forms.Button();
            this.botonsnapshot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonapagar
            // 
            this.botonapagar.Location = new System.Drawing.Point(89, 40);
            this.botonapagar.Name = "botonapagar";
            this.botonapagar.Size = new System.Drawing.Size(101, 46);
            this.botonapagar.TabIndex = 0;
            this.botonapagar.Text = "Forzar apagado \r\nmaquina";
            this.botonapagar.UseVisualStyleBackColor = true;
            this.botonapagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonsnapshot
            // 
            this.botonsnapshot.Location = new System.Drawing.Point(89, 134);
            this.botonsnapshot.Name = "botonsnapshot";
            this.botonsnapshot.Size = new System.Drawing.Size(101, 40);
            this.botonsnapshot.TabIndex = 1;
            this.botonsnapshot.Text = "Guardar Snapshot";
            this.botonsnapshot.UseVisualStyleBackColor = true;
            this.botonsnapshot.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 202);
            this.Controls.Add(this.botonsnapshot);
            this.Controls.Add(this.botonapagar);
            this.Name = "Form3";
            this.Text = "Controlador MV";
            this.ResumeLayout(false);

        }

        #endregion

        private Button botonapagar;
        private Button botonsnapshot;
    }
}