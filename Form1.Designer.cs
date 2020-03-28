namespace Copy
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
            this.copyButton = new System.Windows.Forms.Button();
            this.initialFileButton = new System.Windows.Forms.Button();
            this.finalFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(315, 206);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 0;
            this.copyButton.Text = "MOVE";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // initialFileButton
            // 
            this.initialFileButton.Location = new System.Drawing.Point(76, 205);
            this.initialFileButton.Name = "initialFileButton";
            this.initialFileButton.Size = new System.Drawing.Size(75, 23);
            this.initialFileButton.TabIndex = 1;
            this.initialFileButton.Text = "INITIAL";
            this.initialFileButton.UseVisualStyleBackColor = true;
            this.initialFileButton.Click += new System.EventHandler(this.initialFileButton_Click);
            // 
            // finalFileButton
            // 
            this.finalFileButton.Location = new System.Drawing.Point(616, 205);
            this.finalFileButton.Name = "finalFileButton";
            this.finalFileButton.Size = new System.Drawing.Size(75, 23);
            this.finalFileButton.TabIndex = 2;
            this.finalFileButton.Text = "FINAL";
            this.finalFileButton.UseVisualStyleBackColor = true;
            this.finalFileButton.Click += new System.EventHandler(this.finalFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalFileButton);
            this.Controls.Add(this.initialFileButton);
            this.Controls.Add(this.copyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button initialFileButton;
        private System.Windows.Forms.Button finalFileButton;
    }
}

