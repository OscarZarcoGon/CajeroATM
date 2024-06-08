namespace Cajero
{
    partial class CajeroRetirar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajeroRetirar));
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            txtCantidadUsuario = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnSeisMil = new Button();
            btnCincoMil = new Button();
            btnCuatroMil = new Button();
            btnDosMil = new Button();
            btnMil = new Button();
            lblcancelar = new Label();
            lblaceptar = new Label();
            lblborrar = new Label();
            lbl9 = new Label();
            lbl8 = new Label();
            lbl7 = new Label();
            lbl6 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            lbl0 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
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
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtCantidadUsuario);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnSeisMil);
            tabPage1.Controls.Add(btnCincoMil);
            tabPage1.Controls.Add(btnCuatroMil);
            tabPage1.Controls.Add(btnDosMil);
            tabPage1.Controls.Add(btnMil);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(571, 271);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(455, 172);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 16;
            label2.Text = "Otra";
            // 
            // txtCantidadUsuario
            // 
            txtCantidadUsuario.Location = new Point(423, 205);
            txtCantidadUsuario.Name = "txtCantidadUsuario";
            txtCantidadUsuario.ReadOnly = true;
            txtCantidadUsuario.Size = new Size(120, 27);
            txtCantidadUsuario.TabIndex = 15;
            txtCantidadUsuario.Click += txtCantidadUsuario_Click;
            txtCantidadUsuario.TextChanged += textBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 251);
            label3.Name = "label3";
            label3.Size = new Size(301, 20);
            label3.TabIndex = 14;
            label3.Text = "Presione el botón cancelar para regresar.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 25);
            label1.Name = "label1";
            label1.Size = new Size(445, 38);
            label1.TabIndex = 6;
            label1.Text = "Seleccione una cantidad a retirar";
            // 
            // btnSeisMil
            // 
            btnSeisMil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeisMil.Location = new Point(233, 172);
            btnSeisMil.Name = "btnSeisMil";
            btnSeisMil.Size = new Size(120, 60);
            btnSeisMil.TabIndex = 4;
            btnSeisMil.Text = "6000";
            btnSeisMil.UseVisualStyleBackColor = true;
            btnSeisMil.Click += btnSeisMil_Click;
            // 
            // btnCincoMil
            // 
            btnCincoMil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCincoMil.Location = new Point(43, 172);
            btnCincoMil.Name = "btnCincoMil";
            btnCincoMil.Size = new Size(120, 60);
            btnCincoMil.TabIndex = 3;
            btnCincoMil.Text = "5000";
            btnCincoMil.UseVisualStyleBackColor = true;
            btnCincoMil.Click += btnCincoMil_Click;
            // 
            // btnCuatroMil
            // 
            btnCuatroMil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCuatroMil.Location = new Point(423, 87);
            btnCuatroMil.Name = "btnCuatroMil";
            btnCuatroMil.Size = new Size(120, 60);
            btnCuatroMil.TabIndex = 2;
            btnCuatroMil.Text = "4000";
            btnCuatroMil.UseVisualStyleBackColor = true;
            btnCuatroMil.Click += btnCuatroMil_Click;
            // 
            // btnDosMil
            // 
            btnDosMil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDosMil.Location = new Point(233, 87);
            btnDosMil.Name = "btnDosMil";
            btnDosMil.Size = new Size(120, 60);
            btnDosMil.TabIndex = 1;
            btnDosMil.Text = "2000";
            btnDosMil.UseVisualStyleBackColor = true;
            btnDosMil.Click += btnDosMil_Click;
            // 
            // btnMil
            // 
            btnMil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMil.Location = new Point(43, 87);
            btnMil.Name = "btnMil";
            btnMil.Size = new Size(120, 60);
            btnMil.TabIndex = 0;
            btnMil.Text = "1000";
            btnMil.UseVisualStyleBackColor = true;
            btnMil.Click += btnMil_Click;
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
            lblcancelar.TabIndex = 27;
            lblcancelar.Text = "CANCELAR";
            lblcancelar.Click += lblcancelar_Click;
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
            lblaceptar.TabIndex = 26;
            lblaceptar.Text = "ACEPTAR";
            lblaceptar.Click += btnAceptar_Click;
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
            lblborrar.TabIndex = 25;
            lblborrar.Text = "BORRAR";
            lblborrar.Click += lblborrar_Click;
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
            lbl9.TabIndex = 24;
            lbl9.Text = "9";
            lbl9.Click += lbl9_Click;
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
            lbl8.TabIndex = 23;
            lbl8.Text = "8";
            lbl8.Click += lbl8_Click;
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
            lbl7.TabIndex = 22;
            lbl7.Text = "7";
            lbl7.Click += lbl7_Click;
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
            lbl6.TabIndex = 21;
            lbl6.Text = "6";
            lbl6.Click += lbl6_Click;
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
            lbl5.TabIndex = 20;
            lbl5.Text = "5";
            lbl5.Click += lbl5_Click;
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
            lbl4.TabIndex = 19;
            lbl4.Text = "4";
            lbl4.Click += lbl4_Click;
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
            lbl3.TabIndex = 18;
            lbl3.Text = "3";
            lbl3.Click += lbl3_Click;
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
            lbl2.TabIndex = 17;
            lbl2.Text = "2";
            lbl2.Click += lbl2_Click;
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
            lbl1.TabIndex = 16;
            lbl1.Text = "1";
            lbl1.Click += lbl1_Click;
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
            lbl0.TabIndex = 15;
            lbl0.Text = "0";
            lbl0.Click += lbl0_Click;
            // 
            // CajeroRetirar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 741);
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
            MinimizeBox = false;
            Name = "CajeroRetirar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CajeroRetirar";
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
        private Label lblcancelar;
        private Label lblaceptar;
        private Label lblborrar;
        private Label lbl9;
        private Label lbl8;
        private Label lbl7;
        private Label lbl6;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private Label lbl0;
        private Button btnMil;
        private Button btnDosMil;
        private Button btnCuatroMil;
        private Button btnSeisMil;
        private Button btnCincoMil;
        private Label label1;
        private Label label3;
        private TextBox txtCantidadUsuario;
        private Label label2;
    }
}