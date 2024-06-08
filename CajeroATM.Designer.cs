namespace Cajero
{
    partial class CajeroATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajeroATM));
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtPassword = new TextBox();
            lblNIP = new Label();
            txtNumTar = new TextBox();
            lblNumTar = new Label();
            lblTitulo = new Label();
            lbl0 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            lbl7 = new Label();
            lbl8 = new Label();
            lbl9 = new Label();
            lblborrar = new Label();
            lblaceptar = new Label();
            lblcancelar = new Label();
            lblmenos = new Label();
            btnAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(755, 741);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(89, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(579, 280);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(lblNIP);
            tabPage1.Controls.Add(txtNumTar);
            tabPage1.Controls.Add(lblNumTar);
            tabPage1.Controls.Add(lblTitulo);
            tabPage1.ImeMode = ImeMode.NoControl;
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(571, 271);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.Click += tabPage1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(244, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(295, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Click += txtPassword_Click;
            // 
            // lblNIP
            // 
            lblNIP.AutoSize = true;
            lblNIP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNIP.Location = new Point(172, 188);
            lblNIP.Name = "lblNIP";
            lblNIP.Size = new Size(51, 28);
            lblNIP.TabIndex = 3;
            lblNIP.Text = "NIP:";
            lblNIP.Click += lblNIP_Click;
            // 
            // txtNumTar
            // 
            txtNumTar.BackColor = SystemColors.ControlLight;
            txtNumTar.Cursor = Cursors.IBeam;
            txtNumTar.Location = new Point(244, 112);
            txtNumTar.Name = "txtNumTar";
            txtNumTar.ReadOnly = true;
            txtNumTar.Size = new Size(295, 27);
            txtNumTar.TabIndex = 2;
            txtNumTar.Click += txtNumTar_Click;
            // 
            // lblNumTar
            // 
            lblNumTar.AutoSize = true;
            lblNumTar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumTar.Location = new Point(31, 112);
            lblNumTar.Name = "lblNumTar";
            lblNumTar.Size = new Size(192, 28);
            lblNumTar.TabIndex = 1;
            lblNumTar.Text = "Número de tarjeta:";
            lblNumTar.Click += lblNumTar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Desktop;
            lblTitulo.Location = new Point(158, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(252, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cajero ATM ";
            lblTitulo.Click += Titulo;
            // 
            // lbl0
            // 
            lbl0.AutoSize = true;
            lbl0.BackColor = Color.Transparent;
            lbl0.Cursor = Cursors.Hand;
            lbl0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0.Location = new Point(281, 654);
            lbl0.Name = "lbl0";
            lbl0.Size = new Size(35, 41);
            lbl0.TabIndex = 2;
            lbl0.Text = "0";
            lbl0.Click += lbl0_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Cursor = Cursors.Hand;
            lbl1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(215, 600);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(35, 41);
            lbl1.TabIndex = 3;
            lbl1.Text = "1";
            lbl1.Click += lbl1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Cursor = Cursors.Hand;
            lbl2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(281, 600);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(35, 41);
            lbl2.TabIndex = 4;
            lbl2.Text = "2";
            lbl2.Click += lbl2_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Cursor = Cursors.Hand;
            lbl3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(348, 600);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(35, 41);
            lbl3.TabIndex = 5;
            lbl3.Text = "3";
            lbl3.Click += lbl3_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.Transparent;
            lbl4.Cursor = Cursors.Hand;
            lbl4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(215, 548);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(35, 41);
            lbl4.TabIndex = 6;
            lbl4.Text = "4";
            lbl4.Click += lbl4_Click;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = Color.Transparent;
            lbl5.Cursor = Cursors.Hand;
            lbl5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.Location = new Point(281, 548);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(35, 41);
            lbl5.TabIndex = 7;
            lbl5.Text = "5";
            lbl5.Click += lbl5_Click;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.BackColor = Color.Transparent;
            lbl6.Cursor = Cursors.Hand;
            lbl6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.Location = new Point(348, 548);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(35, 41);
            lbl6.TabIndex = 8;
            lbl6.Text = "6";
            lbl6.Click += lbl6_Click;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.BackColor = Color.Transparent;
            lbl7.Cursor = Cursors.Hand;
            lbl7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl7.Location = new Point(215, 493);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(35, 41);
            lbl7.TabIndex = 9;
            lbl7.Text = "7";
            lbl7.Click += lbl7_Click;
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.BackColor = Color.Transparent;
            lbl8.Cursor = Cursors.Hand;
            lbl8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl8.Location = new Point(281, 493);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(35, 41);
            lbl8.TabIndex = 10;
            lbl8.Text = "8";
            lbl8.Click += lbl8_Click;
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.BackColor = Color.Transparent;
            lbl9.Cursor = Cursors.Hand;
            lbl9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl9.Location = new Point(348, 493);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(35, 41);
            lbl9.TabIndex = 11;
            lbl9.Text = "9";
            lbl9.Click += lbl9_Click;
            // 
            // lblborrar
            // 
            lblborrar.AutoSize = true;
            lblborrar.BackColor = Color.Transparent;
            lblborrar.Cursor = Cursors.Hand;
            lblborrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblborrar.Location = new Point(455, 551);
            lblborrar.Name = "lblborrar";
            lblborrar.Size = new Size(79, 23);
            lblborrar.TabIndex = 12;
            lblborrar.Text = "BORRAR";
            lblborrar.Click += lblborrar_Click;
            // 
            // lblaceptar
            // 
            lblaceptar.AutoSize = true;
            lblaceptar.BackColor = Color.Transparent;
            lblaceptar.Cursor = Cursors.Hand;
            lblaceptar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblaceptar.Location = new Point(453, 658);
            lblaceptar.Name = "lblaceptar";
            lblaceptar.Size = new Size(84, 23);
            lblaceptar.TabIndex = 13;
            lblaceptar.Text = "ACEPTAR";
            lblaceptar.Click += lblAceptar_Click;
            // 
            // lblcancelar
            // 
            lblcancelar.AutoSize = true;
            lblcancelar.BackColor = Color.Transparent;
            lblcancelar.Cursor = Cursors.Hand;
            lblcancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcancelar.Location = new Point(447, 496);
            lblcancelar.Name = "lblcancelar";
            lblcancelar.Size = new Size(98, 23);
            lblcancelar.TabIndex = 14;
            lblcancelar.Text = "CANCELAR";
            lblcancelar.Click += lblcancelar_Click;
            // 
            // lblmenos
            // 
            lblmenos.AutoSize = true;
            lblmenos.BackColor = Color.Transparent;
            lblmenos.Cursor = Cursors.Hand;
            lblmenos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmenos.Location = new Point(218, 657);
            lblmenos.Name = "lblmenos";
            lblmenos.Size = new Size(0, 38);
            lblmenos.TabIndex = 15;
            lblmenos.Click += lblmenos_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.Location = new Point(657, 355);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(69, 27);
            btnAdmin.TabIndex = 16;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // CajeroATM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 741);
            Controls.Add(btnAdmin);
            Controls.Add(lblmenos);
            Controls.Add(lblcancelar);
            Controls.Add(lblaceptar);
            Controls.Add(lblborrar);
            Controls.Add(lbl9);
            Controls.Add(lbl8);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lbl0);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CajeroATM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CajeroATM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblTitulo;
        private TextBox txtNumTar;
        private Label lblNumTar;
        private Label lblNIP;
        private TextBox txtPassword;
        private Label lbl0;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private Label lbl6;
        private Label lbl7;
        private Label lbl8;
        private Label lbl9;
        private Label lblborrar;
        private Label lblaceptar;
        private Label lblcancelar;
        private Label lblmenos;
        private Button btnAdmin;
    }
}
