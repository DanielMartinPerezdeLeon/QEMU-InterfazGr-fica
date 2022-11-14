using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InterfazVisualQEMU_DanielMartin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tamano.Visible = false;
            label5.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            DialogResult resultado = archivo.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                texto_iso.Text = archivo.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string principal = @"/C start C:\qemu\qemu-system-x86_64.exe";
            String nombre = @" -name " + texto_nombre.Text;
            String rutaiso = @" -cdrom " +texto_iso.Text;
            String ram = @" -m "+lista1.SelectedItem.ToString();
            string nucleos = @" -smp " + lista2.SelectedItem.ToString();

            if (checkguardar.Checked)
            {
                string crear = @"/C start C:\qemu\qemu-img.exe create -f qcow2 C:\qemu\" + texto_nombre.Text + @".qcow2 " + tamano.Text+ "G";
                System.Diagnostics.Process.Start("CMD.exe",crear );
            }

            String comando = principal + nombre + rutaiso + ram + nucleos;

            //FUNCIONA System.Diagnostics.Process.Start("CMD.exe", @"/C start C:\qemu\qemu-system-x86_64.exe -cdrom D:\maquinas_virtuales\LinuxMintMate.iso -m 1024 -name p1 -smp 1");

            System.Diagnostics.Process.Start("CMD.exe", comando);

            new Form3(nombre).Show();
            this.Hide();

            //taskkill /IM "qemu-system-x86_64.exe" /F


            /* System.Diagnostics.Process process = new System.Diagnostics.Process();
             System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
             startInfo.FileName = @"cmd.exe";
             startInfo.Arguments = " /C"+nombre + rutaiso +ram +nucleos;
             process.StartInfo = startInfo;
             process.Start(); */


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkguardar_CheckedChanged(object sender, EventArgs e)
        {
            tamano.Visible = checkguardar.Checked;
            label5.Visible = checkguardar.Checked;

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
