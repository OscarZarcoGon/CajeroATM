namespace Cajero
{
    partial class CajeroOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajeroOpciones));
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            btnCambiarNip = new Button();
            btnSalir = new Button();
            btnDepositar = new Button();
            btnRetirar = new Button();
            label2 = new Label();
            btnTransferir = new Button();
            btnSaldo = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl0 = new Label();
            lbl9 = new Label();
            lbl8 = new Label();
            lbl7 = new Label();
            lbl6 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lblcancelar = new Label();
            lblaceptar = new Label();
            lblborrar = new Label();
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
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnCambiarNip);
            tabPage1.Controls.Add(btnSalir);
            tabPage1.Controls.Add(btnDepositar);
            tabPage1.Controls.Add(btnRetirar);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnTransferir);
            tabPage1.Controls.Add(btnSaldo);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(571, 271);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 251);
            label3.Name = "label3";
            label3.Size = new Size(301, 20);
            label3.TabIndex = 13;
            label3.Text = "Presione el botón cancelar para regresar.";
            // 
            // btnCambiarNip
            // 
            btnCambiarNip.BackColor = Color.PowderBlue;
            btnCambiarNip.Cursor = Cursors.Hand;
            btnCambiarNip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarNip.Location = new Point(410, 169);
            btnCambiarNip.Margin = new Padding(6);
            btnCambiarNip.Name = "btnCambiarNip";
            btnCambiarNip.Size = new Size(110, 50);
            btnCambiarNip.TabIndex = 12;
            btnCambiarNip.Text = "Cambiar NIP";
            btnCambiarNip.UseVisualStyleBackColor = false;
            btnCambiarNip.Click += btnCambiarNip_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.PowderBlue;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(410, 84);
            btnSalir.Margin = new Padding(6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 50);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.PowderBlue;
            btnDepositar.Cursor = Cursors.Hand;
            btnDepositar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepositar.Location = new Point(230, 169);
            btnDepositar.Margin = new Padding(6);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(110, 50);
            btnDepositar.TabIndex = 10;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.BackColor = Color.PowderBlue;
            btnRetirar.Cursor = Cursors.Hand;
            btnRetirar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetirar.Location = new Point(230, 84);
            btnRetirar.Margin = new Padding(6);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(110, 50);
            btnRetirar.TabIndex = 9;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = false;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 24);
            label2.Name = "label2";
            label2.Size = new Size(228, 28);
            label2.TabIndex = 8;
            label2.Text = "Seleccione una opción:";
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.PowderBlue;
            btnTransferir.Cursor = Cursors.Hand;
            btnTransferir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransferir.Location = new Point(50, 169);
            btnTransferir.Margin = new Padding(6);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(110, 50);
            btnTransferir.TabIndex = 7;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnSaldo
            // 
            btnSaldo.BackColor = Color.PowderBlue;
            btnSaldo.Cursor = Cursors.Hand;
            btnSaldo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaldo.Location = new Point(50, 84);
            btnSaldo.Margin = new Padding(6);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(110, 50);
            btnSaldo.TabIndex = 6;
            btnSaldo.Text = "Saldo";
            btnSaldo.UseVisualStyleBackColor = false;
            btnSaldo.Click += btnSaldo_Click;
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
            lbl1.TabIndex = 4;
            lbl1.Text = "1";
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
            lbl2.TabIndex = 5;
            lbl2.Text = "2";
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
            lbl3.TabIndex = 6;
            lbl3.Text = "3";
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
            lbl0.TabIndex = 7;
            lbl0.Text = "0";
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
            lbl9.TabIndex = 17;
            lbl9.Text = "9";
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
            lbl8.TabIndex = 16;
            lbl8.Text = "8";
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
            lbl7.TabIndex = 15;
            lbl7.Text = "7";
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
            lbl6.TabIndex = 14;
            lbl6.Text = "6";
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
            lbl5.TabIndex = 13;
            lbl5.Text = "5";
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
            lbl4.TabIndex = 12;
            lbl4.Text = "4";
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
            lblcancelar.TabIndex = 20;
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
            lblaceptar.TabIndex = 19;
            lblaceptar.Text = "ACEPTAR";
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
            lblborrar.TabIndex = 18;
            lblborrar.Text = "BORRAR";
            // 
            // CajeroOpciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 741);
            Controls.Add(lbl0);
            Controls.Add(lbl9);
            Controls.Add(lblcancelar);
            Controls.Add(lbl8);
            Controls.Add(lblaceptar);
            Controls.Add(lbl7);
            Controls.Add(lblborrar);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CajeroOpciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CajeroOpciones";
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
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl0;
        private Label lbl9;
        private Label lbl8;
        private Label lbl7;
        private Label lbl6;
        private Label lbl5;
        private Label lbl4;
        private Label lblcancelar;
        private Label lblaceptar;
        private Label lblborrar;
        private Button btnSalir;
        private Button btnDepositar;
        private Button btnRetirar;
        private Label label2;
        private Button btnTransferir;
        private Button btnSaldo;
        private Button btnCambiarNip;
        private Label label3;
    }
}