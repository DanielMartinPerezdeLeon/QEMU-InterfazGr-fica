using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazVisualQEMU_DanielMartin
{

    public partial class Form3 : Form
    {

        string nombre;
        public Form3(string nom)
        {
            InitializeComponent();
            nombre = nom;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //qemu-img.exe snapshot -c m .\alpine.qcow2
            string comando = @"/C start C:\qemu\qemu-img.exe snapshot -c "+nombre+@" C:\qemu\"+nombre+@".qcow2";
            MessageBox.Show(comando);
            System.Diagnostics.Process.Start("CMD.exe", comando);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string comando = @"/C taskkill /IM ""qemu-system-x86_64.exe"" /F";
            System.Diagnostics.Process.Start("CMD.exe", comando);

            Application.ExitThread();

            Environment.Exit(-1);
        }
    }
}
