namespace CrudOracleClase
{
    partial class FrmCh
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCHID = new System.Windows.Forms.TextBox();
            this.txtCHUSER = new System.Windows.Forms.TextBox();
            this.txtCHPASS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Location = new System.Drawing.Point(519, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(214, 192);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(169, 43);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCHID
            // 
            this.txtCHID.Location = new System.Drawing.Point(214, 47);
            this.txtCHID.Name = "txtCHID";
            this.txtCHID.Size = new System.Drawing.Size(169, 26);
            this.txtCHID.TabIndex = 6;
            // 
            // txtCHUSER
            // 
            this.txtCHUSER.Location = new System.Drawing.Point(214, 96);
            this.txtCHUSER.Name = "txtCHUSER";
            this.txtCHUSER.Size = new System.Drawing.Size(169, 26);
            this.txtCHUSER.TabIndex = 7;
            // 
            // txtCHPASS
            // 
            this.txtCHPASS.Location = new System.Drawing.Point(214, 147);
            this.txtCHPASS.Name = "txtCHPASS";
            this.txtCHPASS.Size = new System.Drawing.Size(169, 26);
            this.txtCHPASS.TabIndex = 8;
            // 
            // FrmCh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 296);
            this.Controls.Add(this.txtCHPASS);
            this.Controls.Add(this.txtCHUSER);
            this.Controls.Add(this.txtCHID);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCHID;
        private System.Windows.Forms.TextBox txtCHUSER;
        private System.Windows.Forms.TextBox txtCHPASS;
    }
}