
namespace Repaso_2do_bloque_BF
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige una opción";
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(31, 58);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(320, 45);
            this.BTN.TabIndex = 1;
            this.BTN.Text = "Repaso 1 - Números aleatorio";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN2
            // 
            this.BTN2.Location = new System.Drawing.Point(31, 121);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(320, 49);
            this.BTN2.TabIndex = 2;
            this.BTN2.Text = "Repaso 2 - Alumno Aleatorio";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 197);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN;
        private System.Windows.Forms.Button BTN2;
    }
}

