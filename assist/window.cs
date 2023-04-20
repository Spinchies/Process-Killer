using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace assist
{



    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Process[] pname = Process.GetProcessesByName("GTA5");
            if (pname.Length == 0)
                MessageBox.Show("Application not running :(");
            else
                foreach (var process in Process.GetProcessesByName("GTA5"))
                {
                    process.Kill();
                    MessageBox.Show("Application Successfully Killed <3");
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("cheatengine-x86_64-SSE4-AVX2");
            if (pname.Length == 0)
                MessageBox.Show("Application not running :(");
            else
                foreach (var process in Process.GetProcessesByName("cheatengine-x86_64-SSE4-AVX2"))
                {
                    process.Kill();
                    MessageBox.Show("Application Successfully Killed <3");
                }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            {

                var RAM = Process.GetProcesses();
                var procs = RAM.Where(x => x.SessionId == Process.GetCurrentProcess().SessionId)
                               .OrderByDescending(x => x.PrivateMemorySize64)
                               .ToList();

                foreach (var p in procs)
                {
                    listBox1.Items.Add(p.ProcessName);
                }
            }
        }
            
        class ProcessWrapper
        {
            private Process _process;

            public ProcessWrapper(Process process)
            {
                _process = process;
            }

            public override string ToString()
            {
                return _process.ToString() + " (" + _process.PrivateMemorySize64 / 1000000L + "M)";
            }

        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);

            Process[] pname = Process.GetProcessesByName(text);
            if (pname.Length != 0)
                foreach (var process in Process.GetProcessesByName(text))
                {
                    process.Kill();
                    MessageBox.Show("Application Successfully Killed <3");
                }

            string pgm = textBox1.Text;
            Process[] pname1 = Process.GetProcessesByName(pgm);
            if (pname1.Length != 0)
                foreach (var process in Process.GetProcessesByName(pgm))
                {
                    process.Kill();
                    MessageBox.Show("Application Successfully Killed <3");
                }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string program = textBox1.Text;

            var RAM = Process.GetProcesses();
            var procs = RAM.Where(x => x.SessionId == Process.GetCurrentProcess().SessionId)
                           .OrderByDescending(x => x.PrivateMemorySize64)
                           .ToList();

            foreach (var p in procs)
            {
                listBox1.Items.Clear();
            }

        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("due to my own inability to code, you have to clear the listbox before rescanning :(");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}