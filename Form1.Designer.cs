namespace traductor
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.cmbSourceLanguage = new System.Windows.Forms.ComboBox();
            this.cmbTargetLanguage = new System.Windows.Forms.ComboBox();
            this.ReadSource = new System.Windows.Forms.Button();
            this.ReadTarget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(44, 55);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(150, 67);
            this.txtSource.TabIndex = 0;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(309, 55);
            this.txtTarget.Multiline = true;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(150, 67);
            this.txtTarget.TabIndex = 1;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(205, 146);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(94, 46);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Traducir";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.FormattingEnabled = true;
            this.cmbSourceLanguage.Location = new System.Drawing.Point(44, 28);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.Size = new System.Drawing.Size(150, 21);
            this.cmbSourceLanguage.TabIndex = 3;
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.FormattingEnabled = true;
            this.cmbTargetLanguage.Location = new System.Drawing.Point(309, 28);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.Size = new System.Drawing.Size(150, 21);
            this.cmbTargetLanguage.TabIndex = 4;
            // 
            // ReadSource
            // 
            this.ReadSource.Location = new System.Drawing.Point(44, 128);
            this.ReadSource.Name = "ReadSource";
            this.ReadSource.Size = new System.Drawing.Size(30, 23);
            this.ReadSource.TabIndex = 5;
            this.ReadSource.Text = "🔊";
            this.ReadSource.UseVisualStyleBackColor = true;
            this.ReadSource.Click += new System.EventHandler(this.ReadSource_Click);
            // 
            // ReadTarget
            // 
            this.ReadTarget.Location = new System.Drawing.Point(429, 128);
            this.ReadTarget.Name = "ReadTarget";
            this.ReadTarget.Size = new System.Drawing.Size(30, 23);
            this.ReadTarget.TabIndex = 6;
            this.ReadTarget.Text = "🔊";
            this.ReadTarget.UseVisualStyleBackColor = true;
            this.ReadTarget.Click += new System.EventHandler(this.ReadTarget_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 226);
            this.Controls.Add(this.ReadTarget);
            this.Controls.Add(this.ReadSource);
            this.Controls.Add(this.cmbTargetLanguage);
            this.Controls.Add(this.cmbSourceLanguage);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Traductor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.ComboBox cmbSourceLanguage;
        private System.Windows.Forms.ComboBox cmbTargetLanguage;
        private System.Windows.Forms.Button ReadSource;
        private System.Windows.Forms.Button ReadTarget;
    }
}

