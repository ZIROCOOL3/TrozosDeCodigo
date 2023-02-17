using System.Diagnostics;

namespace TrozosCodigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //control que no haya otra instancia del programa abierta
            bool isNew = false;
            string applicationName = Process.GetCurrentProcess().ProcessName;
            Mutex mtx = new Mutex(true, applicationName, out isNew);
            if (!isNew)
            {
                MessageBox.Show("El programa ya se esta ejecutando");
                this.Close();
                return;

            }
            /////

            //llamar control desde un lugar diferencte de donde se creo
            CheckForIllegalCrossThreadCalls = false;


        }
    }
}