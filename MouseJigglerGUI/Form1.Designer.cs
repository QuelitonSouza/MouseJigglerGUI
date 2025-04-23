namespace MouseJigglerGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnToggle = new Button();
            numIntervalo = new NumericUpDown();
            lblStatus = new Label();
            notifyIcon1 = new NotifyIcon(components);
            jiggleTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            chkAutoStart = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            modoFantasmaToolStripMenuItem = new ToolStripMenuItem();
            iniciarPararToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            checkMouseVirtual = new CheckBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numIntervalo).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnToggle
            // 
            btnToggle.Font = new Font("Segoe UI", 11F);
            btnToggle.Location = new Point(77, 165);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(147, 45);
            btnToggle.TabIndex = 4;
            btnToggle.Text = "Iniciar";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // numIntervalo
            // 
            numIntervalo.Location = new Point(93, 37);
            numIntervalo.Name = "numIntervalo";
            numIntervalo.Size = new Size(84, 27);
            numIntervalo.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 11F);
            lblStatus.Location = new Point(6, 233);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(290, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Parado";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // jiggleTimer
            // 
            jiggleTimer.Interval = 1000;
            jiggleTimer.Tick += jiggleTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Intervalo:";
            // 
            // chkAutoStart
            // 
            chkAutoStart.AutoSize = true;
            chkAutoStart.Location = new Point(15, 71);
            chkAutoStart.Name = "chkAutoStart";
            chkAutoStart.Size = new Size(179, 24);
            chkAutoStart.TabIndex = 2;
            chkAutoStart.Text = "Iniciar com o Windows";
            chkAutoStart.UseVisualStyleBackColor = true;
            chkAutoStart.CheckedChanged += chkAutoStart_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mostrarToolStripMenuItem, modoFantasmaToolStripMenuItem, iniciarPararToolStripMenuItem, sairToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(206, 92);
            contextMenuStrip1.Text = "Menu";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(205, 22);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += menuItemMostrar_Click;
            // 
            // modoFantasmaToolStripMenuItem
            // 
            modoFantasmaToolStripMenuItem.Name = "modoFantasmaToolStripMenuItem";
            modoFantasmaToolStripMenuItem.Size = new Size(205, 22);
            modoFantasmaToolStripMenuItem.Text = "Modo Fantasma (Virtual)";
            modoFantasmaToolStripMenuItem.Click += menuModoFantasma_Click;
            // 
            // iniciarPararToolStripMenuItem
            // 
            iniciarPararToolStripMenuItem.Name = "iniciarPararToolStripMenuItem";
            iniciarPararToolStripMenuItem.Size = new Size(205, 22);
            iniciarPararToolStripMenuItem.Text = "Iniciar/Parar";
            iniciarPararToolStripMenuItem.Click += menuItemToggle_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(205, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += menuItemSair_Click;
            // 
            // checkMouseVirtual
            // 
            checkMouseVirtual.AutoSize = true;
            checkMouseVirtual.Location = new Point(15, 103);
            checkMouseVirtual.Name = "checkMouseVirtual";
            checkMouseVirtual.Size = new Size(130, 24);
            checkMouseVirtual.TabIndex = 3;
            checkMouseVirtual.Text = "Mouse Virtual ?";
            checkMouseVirtual.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkMouseVirtual);
            groupBox1.Controls.Add(numIntervalo);
            groupBox1.Controls.Add(chkAutoStart);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 142);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 40);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "(Segundos)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 262);
            Controls.Add(groupBox1);
            Controls.Add(lblStatus);
            Controls.Add(btnToggle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mouse Jiggler";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numIntervalo).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnToggle;
        private NumericUpDown numIntervalo;
        private Label lblStatus;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer jiggleTimer;
        private Label label1;
        private CheckBox chkAutoStart;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem iniciarPararToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private CheckBox checkMouseVirtual;
        private ToolStripMenuItem modoFantasmaToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label2;
    }
}
