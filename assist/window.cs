using System.Diagnostics;

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
                    MessageBox.Show(":3");
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
                    MessageBox.Show(":3");
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string program = textBox1.Text;

            Process[] pname = Process.GetProcessesByName(program);
            if (pname.Length == 0)
                MessageBox.Show("Application not running :(");
            else
                foreach (var process in Process.GetProcessesByName(program))
                {
                    process.Kill();
                    MessageBox.Show(":3");
                }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}