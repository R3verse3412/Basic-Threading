using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Basic_Threading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Before Starting Thread");
            MyThreadClass threadClass = new MyThreadClass();

          

            Thread threadA = new Thread(new ThreadStart(threadClass.Thread1));
            threadA.Name = "Thread A Process";

            Thread threadB = new Thread(new ThreadStart(threadClass.Thread1));
            threadB.Name = "Thread B Proccess";

            threadA.Start();
            threadB.Start();
            threadA.Join();
            threadB.Join();

            Console.WriteLine("End of Thread");
            label1.Text = "  End of Thread";

        }
    }
}
