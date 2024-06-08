namespace Cajero
{
    partial class RegistrarCliente
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
            lblnombre = new Label();
            lblnumTarjeta = new Label();
            lblnumCuenta = new Label();
            lblnumCliente = new Label();
            lblfechaNac = new Label();
            lblfechaCorte = new Label();
            lblSaldoApertura = new Label();
            lblLimite = new Label();
            lblNip = new Label();
            txtNombre = new TextBox();
            txtNumCuenta = new TextBox();
            txtNumTar = new TextBox();
            txtNumCliente = new TextBox();
            txtSaldoApertura = new TextBox();
            txtLimite = new TextBox();
            txtNip = new TextBox();
            btnAceptar = new Button();
            btnRegresar = new Button();
            dateFechaNac = new DateTimePicker();
            dateFechaCorte = new DateTimePicker();
            checkStatus = new CheckBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblnombre.Location = new Point(135, 30);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(86, 25);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre:";
            // 
            // lblnumTarjeta
            // 
            lblnumTarjeta.AutoSize = true;
            lblnumTarjeta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblnumTarjeta.Location = new Point(74, 90);
            lblnumTarjeta.Name = "lblnumTarjeta";
            lblnumTarjeta.Size = new Size(147, 25);
            lblnumTarjeta.TabIndex = 1;
            lblnumTarjeta.Text = "Número tarjeta:";
            lblnumTarjeta.Click += label1_Click;
            // 
            // lblnumCuenta
            // 
            lblnumCuenta.AutoSize = true;
            lblnumCuenta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblnumCuenta.Location = new Point(46, 150);
            lblnumCuenta.Name = "lblnumCuenta";
            lblnumCuenta.Size = new Size(175, 25);
            lblnumCuenta.TabIndex = 2;
            lblnumCuenta.Text = "Número de cuenta:";
            // 
            // lblnumCliente
            // 
            lblnumCliente.AutoSize = true;
            lblnumCliente.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblnumCliente.Location = new Point(47, 210);
            lblnumCliente.Name = "lblnumCliente";
            lblnumCliente.Size = new Size(174, 25);
            lblnumCliente.TabIndex = 3;
            lblnumCliente.Text = "Número de cliente:";
            // 
            // lblfechaNac
            // 
            lblfechaNac.AutoSize = true;
            lblfechaNac.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblfechaNac.Location = new Point(29, 270);
            lblfechaNac.Name = "lblfechaNac";
            lblfechaNac.Size = new Size(192, 25);
            lblfechaNac.TabIndex = 4;
            lblfechaNac.Text = "Fecha de nacimiento:";
            // 
            // lblfechaCorte
            // 
            lblfechaCorte.AutoSize = true;
            lblfechaCorte.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblfechaCorte.Location = new Point(79, 330);
            lblfechaCorte.Name = "lblfechaCorte";
            lblfechaCorte.Size = new Size(142, 25);
            lblfechaCorte.TabIndex = 5;
            lblfechaCorte.Text = "Fecha de corte:";
            // 
            // lblSaldoApertura
            // 
            lblSaldoApertura.AutoSize = true;
            lblSaldoApertura.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblSaldoApertura.Location = new Point(78, 390);
            lblSaldoApertura.Name = "lblSaldoApertura";
            lblSaldoApertura.Size = new Size(143, 25);
            lblSaldoApertura.TabIndex = 6;
            lblSaldoApertura.Text = "Saldo apertura:";
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblLimite.Location = new Point(87, 450);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(134, 25);
            lblLimite.TabIndex = 7;
            lblLimite.Text = "Límite crédito:";
            // 
            // lblNip
            // 
            lblNip.AutoSize = true;
            lblNip.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblNip.Location = new Point(118, 510);
            lblNip.Name = "lblNip";
            lblNip.Size = new Size(103, 25);
            lblNip.TabIndex = 8;
            lblNip.Text = "NIP inicial:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(270, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 28);
            txtNombre.TabIndex = 9;
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.BackColor = SystemColors.Window;
            txtNumCuenta.Cursor = Cursors.IBeam;
            txtNumCuenta.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumCuenta.Location = new Point(270, 150);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(130, 28);
            txtNumCuenta.TabIndex = 10;
            // 
            // txtNumTar
            // 
            txtNumTar.BackColor = SystemColors.Window;
            txtNumTar.Cursor = Cursors.IBeam;
            txtNumTar.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumTar.Location = new Point(270, 90);
            txtNumTar.Name = "txtNumTar";
            txtNumTar.Size = new Size(230, 28);
            txtNumTar.TabIndex = 11;
            // 
            // txtNumCliente
            // 
            txtNumCliente.BackColor = SystemColors.Window;
            txtNumCliente.Cursor = Cursors.IBeam;
            txtNumCliente.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumCliente.Location = new Point(270, 210);
            txtNumCliente.Name = "txtNumCliente";
            txtNumCliente.Size = new Size(130, 28);
            txtNumCliente.TabIndex = 12;
            txtNumCliente.TextChanged += txtNumCliente_TextChanged;
            // 
            // txtSaldoApertura
            // 
            txtSaldoApertura.BackColor = SystemColors.Window;
            txtSaldoApertura.Cursor = Cursors.IBeam;
            txtSaldoApertura.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaldoApertura.Location = new Point(270, 390);
            txtSaldoApertura.Name = "txtSaldoApertura";
            txtSaldoApertura.Size = new Size(130, 28);
            txtSaldoApertura.TabIndex = 15;
            // 
            // txtLimite
            // 
            txtLimite.BackColor = SystemColors.Window;
            txtLimite.Cursor = Cursors.IBeam;
            txtLimite.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLimite.Location = new Point(270, 450);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(130, 28);
            txtLimite.TabIndex = 16;
            // 
            // txtNip
            // 
            txtNip.BackColor = SystemColors.Window;
            txtNip.Cursor = Cursors.IBeam;
            txtNip.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNip.Location = new Point(270, 510);
            txtNip.Name = "txtNip";
            txtNip.Size = new Size(130, 28);
            txtNip.TabIndex = 17;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.Window;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(406, 705);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(270, 705);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 19;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dateFechaNac
            // 
            dateFechaNac.Cursor = Cursors.Hand;
            dateFechaNac.Location = new Point(270, 270);
            dateFechaNac.Name = "dateFechaNac";
            dateFechaNac.Size = new Size(275, 27);
            dateFechaNac.TabIndex = 20;
            dateFechaNac.Value = new DateTime(2024, 5, 30, 12, 6, 44, 0);
            dateFechaNac.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateFechaCorte
            // 
            dateFechaCorte.Cursor = Cursors.Hand;
            dateFechaCorte.Location = new Point(270, 330);
            dateFechaCorte.Name = "dateFechaCorte";
            dateFechaCorte.Size = new Size(275, 27);
            dateFechaCorte.TabIndex = 21;
            dateFechaCorte.Value = new DateTime(2024, 5, 30, 12, 6, 44, 0);
            // 
            // checkStatus
            // 
            checkStatus.AutoSize = true;
            checkStatus.Checked = true;
            checkStatus.CheckState = CheckState.Checked;
            checkStatus.Cursor = Cursors.Hand;
            checkStatus.Location = new Point(270, 658);
            checkStatus.Name = "checkStatus";
            checkStatus.Size = new Size(71, 24);
            checkStatus.TabIndex = 23;
            checkStatus.Text = "Status";
            checkStatus.UseVisualStyleBackColor = true;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTelefono.Location = new Point(130, 570);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(91, 25);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.Window;
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Font = new Font("Calibri Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(270, 570);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 28);
            txtTelefono.TabIndex = 25;
            txtTelefono.Click += txtTelefono_Click;
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 760);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(checkStatus);
            Controls.Add(dateFechaCorte);
            Controls.Add(dateFechaNac);
            Controls.Add(btnRegresar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNip);
            Controls.Add(txtLimite);
            Controls.Add(txtSaldoApertura);
            Controls.Add(txtNumCliente);
            Controls.Add(txtNumTar);
            Controls.Add(txtNumCuenta);
            Controls.Add(txtNombre);
            Controls.Add(lblNip);
            Controls.Add(lblLimite);
            Controls.Add(lblSaldoApertura);
            Controls.Add(lblfechaCorte);
            Controls.Add(lblfechaNac);
            Controls.Add(lblnumCliente);
            Controls.Add(lblnumCuenta);
            Controls.Add(lblnumTarjeta);
            Controls.Add(lblnombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarCliente";
            Load += RegistrarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Label lblnumTarjeta;
        private Label lblnumCuenta;
        private Label lblnumCliente;
        private Label lblfechaNac;
        private Label lblfechaCorte;
        private Label lblSaldoApertura;
        private Label lblLimite;
        private Label lblNip;
        private TextBox txtNombre;
        private TextBox txtNumCuenta;
        private TextBox txtNumTar;
        private TextBox txtNumCliente;
        private TextBox txtSaldoApertura;
        private TextBox txtLimite;
        private TextBox txtNip;
        private Button btnAceptar;
        private Button btnRegresar;
        private DateTimePicker dateFechaNac;
        private DateTimePicker dateFechaCorte;
        private CheckBox checkStatus;
        private Label lblTelefono;
        private TextBox txtTelefono;
    }
}