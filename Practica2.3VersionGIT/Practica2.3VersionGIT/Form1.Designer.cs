namespace Practica2._3VersionGIT
{
    partial class PracticaGit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bcalcular = new System.Windows.Forms.Button();
            this.lcoste = new System.Windows.Forms.Label();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.ltext = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bcalcular
            // 
            this.bcalcular.Location = new System.Drawing.Point(395, 304);
            this.bcalcular.Name = "bcalcular";
            this.bcalcular.Size = new System.Drawing.Size(75, 23);
            this.bcalcular.TabIndex = 4;
            this.bcalcular.Text = "Calcular";
            this.bcalcular.UseVisualStyleBackColor = true;
            this.bcalcular.Click += new System.EventHandler(this.bcalcular_Click);
            // 
            // lcoste
            // 
            this.lcoste.AutoSize = true;
            this.lcoste.Location = new System.Drawing.Point(43, 313);
            this.lcoste.Name = "lcoste";
            this.lcoste.Size = new System.Drawing.Size(40, 15);
            this.lcoste.TabIndex = 1;
            this.lcoste.Text = "Coste:";
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(57, 225);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(73, 19);
            this.cbUrgente.TabIndex = 5;
            this.cbUrgente.Text = "Urgente?";
            this.cbUrgente.UseVisualStyleBackColor = true;
            // 
            // ltext
            // 
            this.ltext.AutoSize = true;
            this.ltext.Location = new System.Drawing.Point(43, 32);
            this.ltext.Name = "ltext";
            this.ltext.Size = new System.Drawing.Size(35, 15);
            this.ltext.TabIndex = 0;
            this.ltext.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(43, 69);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(391, 94);
            this.txtTelegrama.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(89, 310);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(164, 23);
            this.txtPrecio.TabIndex = 6;
            // 
            // PracticaGit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 369);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cbUrgente);
            this.Controls.Add(this.bcalcular);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lcoste);
            this.Controls.Add(this.ltext);
            this.Name = "PracticaGit";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bcalcular;
        private Label lcoste;
        private CheckBox cbUrgente;
        private Label ltext;
        private TextBox txtTelegrama;
        private TextBox txtPrecio;
    }
}