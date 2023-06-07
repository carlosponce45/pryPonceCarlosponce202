namespace pryPonceCarlos
{
    partial class Frmtablas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Location = new System.Drawing.Point(12, 384);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 36);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(95, 23);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.ReadOnly = true;
            this.txtBaseDatos.Size = new System.Drawing.Size(144, 20);
            this.txtBaseDatos.TabIndex = 13;
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Enabled = false;
            this.lblBaseDatos.Location = new System.Drawing.Point(9, 26);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(80, 13);
            this.lblBaseDatos.TabIndex = 12;
            this.lblBaseDatos.Text = "Base de Datos:";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Enabled = false;
            this.lblTabla.Location = new System.Drawing.Point(245, 26);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(37, 13);
            this.lblTabla.TabIndex = 11;
            this.lblTabla.Text = "Tabla:";
            // 
            // dgvTablas
            // 
            this.dgvTablas.AllowUserToAddRows = false;
            this.dgvTablas.AllowUserToDeleteRows = false;
            this.dgvTablas.AllowUserToOrderColumns = true;
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(12, 72);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.ReadOnly = true;
            this.dgvTablas.RowHeadersVisible = false;
            this.dgvTablas.Size = new System.Drawing.Size(518, 306);
            this.dgvTablas.TabIndex = 10;
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBaseDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBaseDatos.FlatAppearance.BorderSize = 0;
            this.btnBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseDatos.Location = new System.Drawing.Point(427, 14);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(103, 36);
            this.btnBaseDatos.TabIndex = 9;
            this.btnBaseDatos.Text = "Seleccionar BD";
            this.btnBaseDatos.UseVisualStyleBackColor = false;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // cmbTablas
            // 
            this.cmbTablas.Enabled = false;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(288, 23);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(121, 21);
            this.cmbTablas.TabIndex = 8;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // Frmtablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 439);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtBaseDatos);
            this.Controls.Add(this.lblBaseDatos);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.btnBaseDatos);
            this.Controls.Add(this.cmbTablas);
            this.Name = "Frmtablas";
            this.Text = "frmtablas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.ComboBox cmbTablas;
    }
}