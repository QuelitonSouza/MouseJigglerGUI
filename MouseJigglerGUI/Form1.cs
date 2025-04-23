using System.Runtime.InteropServices;

namespace MouseJigglerGUI
{
    public partial class Form1 : Form
    {
        private bool isShowMessage = true;
        private bool isRunning = false;
        private bool toggle = true;
        private MouseMode currentMode = MouseMode.Real;

        [DllImport("user32.dll")] static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")] static extern bool GetCursorPos(out MousesStruct.POINT lpPoint);
        [DllImport("kernel32.dll", SetLastError = true)] static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        [DllImport("user32.dll", SetLastError = true)] static extern uint SendInput(uint nInputs, MousesStruct.INPUT[] pInputs, int cbSize);

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Mouse Jiggler";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkAutoStart.Checked = AutoStartManager.IsAutoStartEnabled();

            numIntervalo.Value = Properties.Settings.Default.InatividadeSegundos;
            currentMode = Properties.Settings.Default.ModoFantasma ? MouseMode.Virtual : MouseMode.Real;

            checkMouseVirtual.Checked = StatusMouseVirtual();
            modoFantasmaToolStripMenuItem.Text = StatusMouseVirtual() ? "Modo Fantasma (Ativado)" : "Modo Fantasma (Desativado)";

            if (chkAutoStart.Checked)
                btnToggle.PerformClick();
        }

        private void SalvarConfiguracoes()
        {
            Properties.Settings.Default.InatividadeSegundos = (int)numIntervalo.Value;
            Properties.Settings.Default.ModoFantasma = checkMouseVirtual.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            AutoStartManager.SetAutoStart(chkAutoStart.Checked);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (isRunning)
            {
                jiggleTimer.Interval = (int)numIntervalo.Value * 1000;
                jiggleTimer.Start();
                btnToggle.Text = "Parar";
                lblStatus.Text = "Status: Rodando";
                iniciarPararToolStripMenuItem.Text = "Parar";

                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
            }
            else
            {
                jiggleTimer.Stop();
                btnToggle.Text = "Iniciar";
                lblStatus.Text = "Status: Parado";
                iniciarPararToolStripMenuItem.Text = "Iniciar";

                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
            }

            SalvarConfiguracoes();
        }

        private void jiggleTimer_Tick(object sender, EventArgs e)
        {
            if (StatusMouseVirtual())
                EnviarMovimentoMouseFantasma();
            else
                MoverMouseFisico();

            lblStatus.Text = $"Status: Próxima execução {DateTime.Now.AddMilliseconds(jiggleTimer.Interval):HH:mm:ss}";
        }

        private void MoverMouseFisico()
        {
            GetCursorPos(out MousesStruct.POINT pos);
            int offset = toggle ? 1 : -1;
            SetCursorPos(pos.X + offset, pos.Y + offset);
            toggle = !toggle;
        }

        private void EnviarMovimentoMouseFantasma()
        {
            MousesStruct.INPUT[] inputs = new MousesStruct.INPUT[1];
            inputs[0].type = MousesStruct.INPUT_MOUSE;
            inputs[0].mi.dx = 0;
            inputs[0].mi.dy = 0;
            inputs[0].mi.dwFlags = MousesStruct.MOUSEEVENTF_MOVE;
            inputs[0].mi.mouseData = 0;
            inputs[0].mi.dwExtraInfo = IntPtr.Zero;
            inputs[0].mi.time = 0;

            SendInput(1, inputs, Marshal.SizeOf(typeof(MousesStruct.INPUT)));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                if (isShowMessage)
                {
                    notifyIcon1.BalloonTipTitle = "Mouse Jiggler";
                    notifyIcon1.BalloonTipText = "O Jiggler está rodando em segundo plano.";
                    notifyIcon1.ShowBalloonTip(1000);
                }
                notifyIcon1.ContextMenuStrip = contextMenuStrip1;
                isShowMessage = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            MostrarJanela();
        }

        private void menuItemMostrar_Click(object sender, EventArgs e)
        {
            MostrarJanela();
        }

        private void MostrarJanela()
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            BringToFront();
            isShowMessage = true;
        }

        private void menuItemToggle_Click(object sender, EventArgs e)
        {
            btnToggle.PerformClick();
        }

        private void menuModoFantasma_Click(object sender, EventArgs e)
        {
            currentMode = currentMode == MouseMode.Real ? MouseMode.Virtual : MouseMode.Real;
            checkMouseVirtual.Checked = StatusMouseVirtual();
            modoFantasmaToolStripMenuItem.Text = StatusMouseVirtual() ? "Modo Fantasma (Ativado)" : "Modo Fantasma (Desativado)";
            SalvarConfiguracoes();
        }

        private void menuItemSair_Click(object sender, EventArgs e)
        {
            SalvarConfiguracoes();
            Application.Exit();
        }

        private bool StatusMouseVirtual() => currentMode == MouseMode.Virtual;
    }
}
