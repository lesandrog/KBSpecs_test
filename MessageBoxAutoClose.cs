using Krypton.Toolkit;

namespace KBSpecs_test
{
    public partial class MessageBoxAutoClose : KryptonForm
    {
        public MessageBoxAutoClose( string caption, int timeout)
        {
            InitializeComponent();
            Text = caption;

            timerClose.Interval = timeout;
            timerClose.Tick += (s, e) => Close();
            timerClose.Start();
        }

        // Chamada estática para facilitar o uso
        public static void Show( string caption, int timeout)
        {
            new MessageBoxAutoClose( caption, timeout).ShowDialog();
        }


    }
}
