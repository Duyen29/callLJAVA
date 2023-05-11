using System.Diagnostics;

namespace callLJAVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startsInfo = new ProcessStartInfo();
            startsInfo.CreateNoWindow = true;
            startsInfo.UseShellExecute = false;
            startsInfo.FileName = "C:\\Program Files\\Java\\jdk-19\\bin\\java.exe";
            startsInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startsInfo.RedirectStandardOutput = true;
            startsInfo.WorkingDirectory = "C:\\Users\\Admin\\Documents";
            startsInfo.Arguments = $" duycop {textBox1.Text} {textBox3.Text}";
            try
            {
                using (Process exe = Process.Start(startsInfo))
                {
                    exe.WaitForExit();
                    while (!exe.StandardOutput.EndOfStream)
                    {
                        string line = exe.StandardOutput.ReadLine();
                        textBox33.AppendText(line + "\n");

                    }
                }
            }
            catch (Exception ex)
            {
                textBox33.AppendText(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}