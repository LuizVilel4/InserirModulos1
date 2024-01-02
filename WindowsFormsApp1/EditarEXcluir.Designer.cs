namespace WindowsFormsApp1 {
    partial class EditarEXcluir {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(35, 42);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(438, 31);
            this.txtKey.TabIndex = 3;
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(35, 115);
            this.txtValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(438, 31);
            this.txtValue.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(494, 42);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 31);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // bntCancel
            // 
            this.bntCancel.Font = new System.Drawing.Font("Arial", 10F);
            this.bntCancel.Location = new System.Drawing.Point(494, 115);
            this.bntCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(90, 31);
            this.bntCancel.TabIndex = 6;
            this.bntCancel.Text = "Cancelar";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // EditarEXcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 188);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Name = "EditarEXcluir";
            this.Text = "EditarEXcluir";
            this.Load += new System.EventHandler(this.EditarEXcluir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button bntCancel;
    }
}