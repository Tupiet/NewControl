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
            this.label1 = new System.Windows.Forms.Label();
            this.compressButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.introductControlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(187, 238);
            this.copyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(87, 30);
            this.copyButton.TabIndex = 0;
            this.copyButton.Text = "Mover";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Visible = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // initialFileButton
            // 
            this.initialFileButton.Location = new System.Drawing.Point(221, 129);
            this.initialFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.initialFileButton.Name = "initialFileButton";
            this.initialFileButton.Size = new System.Drawing.Size(87, 42);
            this.initialFileButton.TabIndex = 1;
            this.initialFileButton.Text = "Archivo inicial";
            this.initialFileButton.UseVisualStyleBackColor = true;
            this.initialFileButton.Click += new System.EventHandler(this.initialFileButton_Click);
            // 
            // finalFileButton
            // 
            this.finalFileButton.Location = new System.Drawing.Point(386, 129);
            this.finalFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.finalFileButton.Name = "finalFileButton";
            this.finalFileButton.Size = new System.Drawing.Size(87, 42);
            this.finalFileButton.TabIndex = 2;
            this.finalFileButton.Text = "Destinación";
            this.finalFileButton.UseVisualStyleBackColor = true;
            this.finalFileButton.Click += new System.EventHandler(this.finalFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "NewControl";
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(323, 236);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(87, 32);
            this.compressButton.TabIndex = 4;
            this.compressButton.Text = "Comprimir";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Visible = false;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(416, 236);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(87, 32);
            this.extractButton.TabIndex = 5;
            this.extractButton.Text = "Extraer";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Visible = false;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "El panel definitivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Avenir Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Por favor, selecciona el archivo y la ubicación deseada.";
            // 
            // introductControlLabel
            // 
            this.introductControlLabel.AutoSize = true;
            this.introductControlLabel.Font = new System.Drawing.Font("Avenir Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introductControlLabel.Location = new System.Drawing.Point(256, 196);
            this.introductControlLabel.Name = "introductControlLabel";
            this.introductControlLabel.Size = new System.Drawing.Size(194, 21);
            this.introductControlLabel.TabIndex = 8;
            this.introductControlLabel.Text = "Ahora, ¿qué desea hacer?";
            this.introductControlLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 394);
            this.Controls.Add(this.introductControlLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalFileButton);
            this.Controls.Add(this.initialFileButton);
            this.Controls.Add(this.copyButton);
            this.Font = new System.Drawing.Font("Avenir Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "NewControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button initialFileButton;
        private System.Windows.Forms.Button finalFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label introductControlLabel;
    }
}

