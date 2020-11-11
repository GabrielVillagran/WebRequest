namespace webRequest
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
            this.Iniciar = new System.Windows.Forms.Button();
            this.Juegos = new System.Windows.Forms.ListBox();
            this.Información = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Iniciar.Location = new System.Drawing.Point(254, 201);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(118, 46);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = false;
            // 
            // Juegos
            // 
            this.Juegos.AllowDrop = true;
            this.Juegos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Juegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Juegos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Juegos.FormattingEnabled = true;
            this.Juegos.Location = new System.Drawing.Point(7, 12);
            this.Juegos.Name = "Juegos";
            this.Juegos.Size = new System.Drawing.Size(222, 444);
            this.Juegos.TabIndex = 1;
            // 
            // Información
            // 
            this.Información.AllowDrop = true;
            this.Información.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Información.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Información.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Información.FormattingEnabled = true;
            this.Información.Location = new System.Drawing.Point(404, 12);
            this.Información.Name = "Información";
            this.Información.Size = new System.Drawing.Size(229, 444);
            this.Información.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(645, 473);
            this.Controls.Add(this.Información);
            this.Controls.Add(this.Juegos);
            this.Controls.Add(this.Iniciar);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Web Request";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.ListBox Juegos;
        private System.Windows.Forms.ListBox Información;
    }
}

