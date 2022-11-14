namespace InterfazVisualQEMU_DanielMartin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string os=Environment.OSVersion.ToString();
            os=os.ToLower();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new Form2().Show();
            this.Hide();
        }

        private void botonabrirmaquinas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Interfaz Gráfica para QEMU \n" +
                "----------------------------------------------\n"+
                "Autor: Daniel Martín Pérez de Leon (https://github.com/DanielMartinPerezdeLeon)\n" +
                "Ultima Versión: 14/11/2022 (https://github.com/DanielMartinPerezdeLeon/QEMU-InterfazGr-fica)\n" +
                "Información: Actualmente solo funciona en sistemas windows, solo crea maquinas virtuales y crea/guarda imagenes/snapshot\n");
        }
    }
}