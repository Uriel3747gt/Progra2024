using System;
using System.Windows.Forms;

namespace MiAplicacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Aquí puedes agregar código que se ejecutará cuando se cargue el formulario
        }

        private void mostrarMensajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola! Has presionado la opción del menú para mostrar un mensaje.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
