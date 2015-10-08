namespace Senac
{
    partial class Form2
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
            this.lvwListaContas = new System.Windows.Forms.ListView();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwListaContas
            // 
            this.lvwListaContas.Location = new System.Drawing.Point(12, 12);
            this.lvwListaContas.Name = "lvwListaContas";
            this.lvwListaContas.Size = new System.Drawing.Size(534, 190);
            this.lvwListaContas.TabIndex = 0;
            this.lvwListaContas.UseCompatibleStateImageBehavior = false;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(471, 215);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 1;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 250);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.lvwListaContas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwListaContas;
        private System.Windows.Forms.Button btnDepositar;


    }
}