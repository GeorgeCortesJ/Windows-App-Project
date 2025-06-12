namespace Windows_App_Project {
    partial class FrmMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maxBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pcbMenu = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHistorialClientes = new System.Windows.Forms.Button();
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BSalir = new System.Windows.Forms.Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.sidebarMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.FillColor = System.Drawing.Color.Transparent;
            this.closeBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBox.IconColor = System.Drawing.Color.Black;
            this.closeBox.Location = new System.Drawing.Point(1244, 0);
            this.closeBox.Margin = new System.Windows.Forms.Padding(4);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(60, 36);
            this.closeBox.TabIndex = 0;
            // 
            // minBox
            // 
            this.minBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minBox.FillColor = System.Drawing.Color.Transparent;
            this.minBox.IconColor = System.Drawing.Color.Black;
            this.minBox.Location = new System.Drawing.Point(1108, 0);
            this.minBox.Margin = new System.Windows.Forms.Padding(4);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(60, 36);
            this.minBox.TabIndex = 1;
            // 
            // maxBox
            // 
            this.maxBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maxBox.FillColor = System.Drawing.Color.Transparent;
            this.maxBox.IconColor = System.Drawing.Color.Black;
            this.maxBox.Location = new System.Drawing.Point(1176, 0);
            this.maxBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(60, 36);
            this.maxBox.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pcbMenu
            // 
            this.pcbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pcbMenu.Image")));
            this.pcbMenu.Location = new System.Drawing.Point(1, 1);
            this.pcbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pcbMenu.Name = "pcbMenu";
            this.pcbMenu.Size = new System.Drawing.Size(68, 58);
            this.pcbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMenu.TabIndex = 4;
            this.pcbMenu.TabStop = false;
            this.pcbMenu.Click += new System.EventHandler(this.pcbMenu_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pcbMenu);
            this.panelHeader.Controls.Add(this.minBox);
            this.panelHeader.Controls.Add(this.maxBox);
            this.panelHeader.Controls.Add(this.closeBox);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1304, 62);
            this.panelHeader.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "BIG FOOD SERVICES";
            // 
            // sidebarMenu
            // 
            this.sidebarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.sidebarMenu.Controls.Add(this.guna2Separator3);
            this.sidebarMenu.Controls.Add(this.panel1);
            this.sidebarMenu.Controls.Add(this.guna2Separator1);
            this.sidebarMenu.Controls.Add(this.panel2);
            this.sidebarMenu.Controls.Add(this.guna2Separator4);
            this.sidebarMenu.Controls.Add(this.panel4);
            this.sidebarMenu.Controls.Add(this.guna2Separator5);
            this.sidebarMenu.Controls.Add(this.panel3);
            this.sidebarMenu.Controls.Add(this.guna2Separator6);
            this.sidebarMenu.Controls.Add(this.panel5);
            this.sidebarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarMenu.Location = new System.Drawing.Point(0, 62);
            this.sidebarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.sidebarMenu.Name = "sidebarMenu";
            this.sidebarMenu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.sidebarMenu.Size = new System.Drawing.Size(327, 574);
            this.sidebarMenu.TabIndex = 6;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.guna2Separator3.Location = new System.Drawing.Point(17, 4);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(211, 12);
            this.guna2Separator3.TabIndex = 14;
            this.guna2Separator3.UseTransparentBackground = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Location = new System.Drawing.Point(17, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 66);
            this.panel1.TabIndex = 7;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(-9, -15);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(300, 90);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator1.Location = new System.Drawing.Point(17, 98);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(281, 12);
            this.guna2Separator1.TabIndex = 12;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Location = new System.Drawing.Point(17, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 66);
            this.panel2.TabIndex = 9;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-15, -11);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(305, 87);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "     Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator4.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator4.Location = new System.Drawing.Point(17, 192);
            this.guna2Separator4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(281, 12);
            this.guna2Separator4.TabIndex = 13;
            this.guna2Separator4.UseTransparentBackground = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMenu);
            this.panel4.Location = new System.Drawing.Point(17, 212);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 66);
            this.panel4.TabIndex = 11;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-9, -16);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(300, 95);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = " Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator5.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator5.Location = new System.Drawing.Point(17, 286);
            this.guna2Separator5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(281, 12);
            this.guna2Separator5.TabIndex = 13;
            this.guna2Separator5.UseTransparentBackground = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHistorialClientes);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(17, 306);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 66);
            this.panel3.TabIndex = 10;
            // 
            // btnHistorialClientes
            // 
            this.btnHistorialClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.btnHistorialClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistorialClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorialClientes.Image")));
            this.btnHistorialClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialClientes.Location = new System.Drawing.Point(-11, -15);
            this.btnHistorialClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorialClientes.Name = "btnHistorialClientes";
            this.btnHistorialClientes.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHistorialClientes.Size = new System.Drawing.Size(301, 96);
            this.btnHistorialClientes.TabIndex = 8;
            this.btnHistorialClientes.Text = "      Historial";
            this.btnHistorialClientes.UseVisualStyleBackColor = false;
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator6.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Separator6.Location = new System.Drawing.Point(17, 380);
            this.guna2Separator6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(281, 12);
            this.guna2Separator6.TabIndex = 13;
            this.guna2Separator6.UseTransparentBackground = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BSalir);
            this.panel5.Controls.Add(this.guna2Separator2);
            this.panel5.Location = new System.Drawing.Point(17, 400);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 66);
            this.panel5.TabIndex = 12;
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(-9, -16);
            this.BSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BSalir.Name = "BSalir";
            this.BSalir.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BSalir.Size = new System.Drawing.Size(300, 95);
            this.BSalir.TabIndex = 8;
            this.BSalir.Text = "  Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.Location = new System.Drawing.Point(4, 0);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(211, 12);
            this.guna2Separator2.TabIndex = 13;
            this.guna2Separator2.UseTransparentBackground = true;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Big Food Services";
            this.notifyIcon1.BalloonTipTitle = "Big Food Services";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Software Big Food Services v1.0";
            this.notifyIcon1.Visible = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 636);
            this.Controls.Add(this.sidebarMenu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.sidebarMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox maxBox;
        private Guna.UI2.WinForms.Guna2ControlBox minBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pcbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sidebarMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHistorialClientes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMenu;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BSalir;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

