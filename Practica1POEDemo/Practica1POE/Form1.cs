namespace Practica1POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                switch (e.KeyCode)
                {
                    case Keys.S:
                        MessageBox.Show("Guardar acci�n realizada", "Informaci�n");
                        break;
                    case Keys.O:
                        MessageBox.Show("Abrir acci�n realizada", "Informaci�n");
                        break;
                }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MayusculasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
