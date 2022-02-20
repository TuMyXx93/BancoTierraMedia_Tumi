
namespace BancoTierraMedia_Tumi
{
    partial class Prestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.lblSaludo = new System.Windows.Forms.Label();
            this.bntVolver = new System.Windows.Forms.Button();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDatosPersonales = new System.Windows.Forms.Panel();
            this.cbxLugares = new System.Windows.Forms.ComboBox();
            this.cbxRazas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDatosPrestamo = new System.Windows.Forms.Panel();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cbxCuotas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDatosPersonales.SuspendLayout();
            this.pnlDatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaludo.Location = new System.Drawing.Point(52, 35);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(158, 29);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Bienvenido, ";
            // 
            // bntVolver
            // 
            this.bntVolver.BackColor = System.Drawing.Color.OrangeRed;
            this.bntVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntVolver.Location = new System.Drawing.Point(680, 396);
            this.bntVolver.Name = "bntVolver";
            this.bntVolver.Size = new System.Drawing.Size(112, 53);
            this.bntVolver.TabIndex = 1;
            this.bntVolver.Text = "VOLVER";
            this.bntVolver.UseVisualStyleBackColor = false;
            this.bntVolver.Click += new System.EventHandler(this.bntVolver_Click);
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSolicitud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(342, 324);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(119, 71);
            this.btnConfirmarSolicitud.TabIndex = 2;
            this.btnConfirmarSolicitud.Text = "Confirmar Solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.btnConfirmarSolicitud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos personales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(435, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle del préstamo:";
            // 
            // pnlDatosPersonales
            // 
            this.pnlDatosPersonales.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlDatosPersonales.Controls.Add(this.cbxLugares);
            this.pnlDatosPersonales.Controls.Add(this.cbxRazas);
            this.pnlDatosPersonales.Controls.Add(this.label4);
            this.pnlDatosPersonales.Controls.Add(this.label3);
            this.pnlDatosPersonales.Location = new System.Drawing.Point(57, 161);
            this.pnlDatosPersonales.Name = "pnlDatosPersonales";
            this.pnlDatosPersonales.Size = new System.Drawing.Size(316, 141);
            this.pnlDatosPersonales.TabIndex = 5;
            // 
            // cbxLugares
            // 
            this.cbxLugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLugares.FormattingEnabled = true;
            this.cbxLugares.Location = new System.Drawing.Point(140, 93);
            this.cbxLugares.Name = "cbxLugares";
            this.cbxLugares.Size = new System.Drawing.Size(173, 21);
            this.cbxLugares.TabIndex = 3;
            // 
            // cbxRazas
            // 
            this.cbxRazas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRazas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRazas.FormattingEnabled = true;
            this.cbxRazas.Location = new System.Drawing.Point(140, 19);
            this.cbxRazas.Name = "cbxRazas";
            this.cbxRazas.Size = new System.Drawing.Size(173, 21);
            this.cbxRazas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(4, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lugar de origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(82, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Raza:";
            // 
            // pnlDatosPrestamo
            // 
            this.pnlDatosPrestamo.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlDatosPrestamo.Controls.Add(this.txtMonto);
            this.pnlDatosPrestamo.Controls.Add(this.cbxCuotas);
            this.pnlDatosPrestamo.Controls.Add(this.label6);
            this.pnlDatosPrestamo.Controls.Add(this.label5);
            this.pnlDatosPrestamo.Location = new System.Drawing.Point(438, 161);
            this.pnlDatosPrestamo.Name = "pnlDatosPrestamo";
            this.pnlDatosPrestamo.Size = new System.Drawing.Size(315, 141);
            this.pnlDatosPrestamo.TabIndex = 6;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(174, 20);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(138, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // cbxCuotas
            // 
            this.cbxCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCuotas.FormattingEnabled = true;
            this.cbxCuotas.Location = new System.Drawing.Point(174, 92);
            this.cbxCuotas.Name = "cbxCuotas";
            this.cbxCuotas.Size = new System.Drawing.Size(138, 21);
            this.cbxCuotas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(101, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cuotas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto del préstamo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pnlDatosPrestamo);
            this.Controls.Add(this.pnlDatosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.bntVolver);
            this.Controls.Add(this.lblSaludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.pnlDatosPersonales.ResumeLayout(false);
            this.pnlDatosPersonales.PerformLayout();
            this.pnlDatosPrestamo.ResumeLayout(false);
            this.pnlDatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button bntVolver;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDatosPersonales;
        private System.Windows.Forms.Panel pnlDatosPrestamo;
        private System.Windows.Forms.ComboBox cbxLugares;
        private System.Windows.Forms.ComboBox cbxRazas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cbxCuotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}