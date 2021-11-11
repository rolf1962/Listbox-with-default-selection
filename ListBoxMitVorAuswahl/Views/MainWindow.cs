using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            TestWindow1 = new TestWindow1();
            TestWindow2 = new TestWindow2();

            TestWindow1.FormClosing += TestWindow_FormClosing;
            TestWindow2.FormClosing += TestWindow_FormClosing;

            TestWindow1.Show(this);
            TestWindow2.Show(this);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationExiting = true;
            Application.Exit();
        }

        private void TestWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ApplicationExiting;
        }

        public bool ApplicationExiting { get; private set; } = false;
        public TestWindow1 TestWindow1 { get; private set; }
        public TestWindow2 TestWindow2 { get; private set; }
    }
}
