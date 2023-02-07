namespace Persona
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RFC = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPater = new System.Windows.Forms.TextBox();
            this.txtMater = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.labRFC = new System.Windows.Forms.Label();
            this.adverNombre = new System.Windows.Forms.Label();
            this.adverPater = new System.Windows.Forms.Label();
            this.adverMat = new System.Windows.Forms.Label();
            this.adverFecha = new System.Windows.Forms.Label();
            this.adverEmail = new System.Windows.Forms.Label();
            this.adverTele = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(362, 415);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 31);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(271, 203);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(163, 29);
            this.Fecha.TabIndex = 1;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(17, 415);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 31);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculadora de RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese sus nombres:";
            // 
            // RFC
            // 
            this.RFC.AutoSize = true;
            this.RFC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFC.Location = new System.Drawing.Point(13, 368);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(97, 21);
            this.RFC.TabIndex = 5;
            this.RFC.Text = "Tu RFC es:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(198, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 29);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese su Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingrese su Apellido Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingrese su Fecha de Nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ingrese su Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingrese su número de teléfono:";
            // 
            // txtPater
            // 
            this.txtPater.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPater.Location = new System.Drawing.Point(237, 96);
            this.txtPater.Name = "txtPater";
            this.txtPater.Size = new System.Drawing.Size(197, 29);
            this.txtPater.TabIndex = 12;
            this.txtPater.TextChanged += new System.EventHandler(this.txtPater_TextChanged);
            // 
            // txtMater
            // 
            this.txtMater.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMater.Location = new System.Drawing.Point(237, 149);
            this.txtMater.Name = "txtMater";
            this.txtMater.Size = new System.Drawing.Size(197, 29);
            this.txtMater.TabIndex = 13;
            this.txtMater.TextChanged += new System.EventHandler(this.txtMater_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(155, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 29);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(258, 312);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(176, 29);
            this.txtTel.TabIndex = 15;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // labRFC
            // 
            this.labRFC.AutoSize = true;
            this.labRFC.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRFC.Location = new System.Drawing.Point(169, 355);
            this.labRFC.Name = "labRFC";
            this.labRFC.Size = new System.Drawing.Size(203, 36);
            this.labRFC.TabIndex = 16;
            this.labRFC.Text = "XXXX000000";
            this.labRFC.Visible = false;
            // 
            // adverNombre
            // 
            this.adverNombre.AutoSize = true;
            this.adverNombre.ForeColor = System.Drawing.Color.Red;
            this.adverNombre.Location = new System.Drawing.Point(334, 77);
            this.adverNombre.Name = "adverNombre";
            this.adverNombre.Size = new System.Drawing.Size(100, 13);
            this.adverNombre.TabIndex = 17;
            this.adverNombre.Text = "*Ingrese su Nombre";
            this.adverNombre.Visible = false;
            // 
            // adverPater
            // 
            this.adverPater.AutoSize = true;
            this.adverPater.ForeColor = System.Drawing.Color.Red;
            this.adverPater.Location = new System.Drawing.Point(294, 128);
            this.adverPater.Name = "adverPater";
            this.adverPater.Size = new System.Drawing.Size(140, 13);
            this.adverPater.TabIndex = 18;
            this.adverPater.Text = "*Ingrese su Apellido Paterno";
            this.adverPater.Visible = false;
            // 
            // adverMat
            // 
            this.adverMat.AutoSize = true;
            this.adverMat.ForeColor = System.Drawing.Color.Red;
            this.adverMat.Location = new System.Drawing.Point(294, 181);
            this.adverMat.Name = "adverMat";
            this.adverMat.Size = new System.Drawing.Size(142, 13);
            this.adverMat.TabIndex = 19;
            this.adverMat.Text = "*Ingrese su Apellido Materno";
            this.adverMat.Visible = false;
            // 
            // adverFecha
            // 
            this.adverFecha.AutoSize = true;
            this.adverFecha.ForeColor = System.Drawing.Color.Red;
            this.adverFecha.Location = new System.Drawing.Point(205, 235);
            this.adverFecha.Name = "adverFecha";
            this.adverFecha.Size = new System.Drawing.Size(229, 13);
            this.adverFecha.TabIndex = 20;
            this.adverFecha.Text = "*Debes ser mayor de edad para tramitar tu RFC";
            this.adverFecha.Visible = false;
            // 
            // adverEmail
            // 
            this.adverEmail.AutoSize = true;
            this.adverEmail.ForeColor = System.Drawing.Color.Red;
            this.adverEmail.Location = new System.Drawing.Point(309, 290);
            this.adverEmail.Name = "adverEmail";
            this.adverEmail.Size = new System.Drawing.Size(125, 13);
            this.adverEmail.TabIndex = 21;
            this.adverEmail.Text = "*Ingrese un correo valido";
            this.adverEmail.Visible = false;
            // 
            // adverTele
            // 
            this.adverTele.AutoSize = true;
            this.adverTele.ForeColor = System.Drawing.Color.Red;
            this.adverTele.Location = new System.Drawing.Point(248, 342);
            this.adverTele.Name = "adverTele";
            this.adverTele.Size = new System.Drawing.Size(186, 13);
            this.adverTele.TabIndex = 22;
            this.adverTele.Text = "*Ingrese un número de télefono valido";
            this.adverTele.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 458);
            this.Controls.Add(this.adverTele);
            this.Controls.Add(this.adverEmail);
            this.Controls.Add(this.adverFecha);
            this.Controls.Add(this.adverMat);
            this.Controls.Add(this.adverPater);
            this.Controls.Add(this.adverNombre);
            this.Controls.Add(this.labRFC);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMater);
            this.Controls.Add(this.txtPater);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.RFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RFC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RFC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPater;
        private System.Windows.Forms.TextBox txtMater;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label labRFC;
        private System.Windows.Forms.Label adverNombre;
        private System.Windows.Forms.Label adverPater;
        private System.Windows.Forms.Label adverMat;
        private System.Windows.Forms.Label adverFecha;
        private System.Windows.Forms.Label adverEmail;
        private System.Windows.Forms.Label adverTele;
    }
}

