
namespace Proyecto_007_Arduino_LED
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
            this.btn_Encender = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Encender
            // 
            this.btn_Encender.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Encender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Encender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Encender.Location = new System.Drawing.Point(186, 108);
            this.btn_Encender.Name = "btn_Encender";
            this.btn_Encender.Size = new System.Drawing.Size(165, 63);
            this.btn_Encender.TabIndex = 0;
            this.btn_Encender.Text = "ENCENDER";
            this.btn_Encender.UseVisualStyleBackColor = false;
            this.btn_Encender.Click += new System.EventHandler(this.btn_Encender_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.BackColor = System.Drawing.Color.Red;
            this.btn_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apagar.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Apagar.Location = new System.Drawing.Point(186, 218);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(165, 63);
            this.btn_Apagar.TabIndex = 1;
            this.btn_Apagar.Text = "APAGAR";
            this.btn_Apagar.UseVisualStyleBackColor = false;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(569, 393);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Encender);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CONTROLADOR LED";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.close_form);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Encender;
        private System.Windows.Forms.Button btn_Apagar;
    }
}

