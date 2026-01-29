namespace GertoreCorsi.WindFOrm
{
    partial class AggingiCorso
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
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblnomeCorso = new System.Windows.Forms.Label();
            this.txtNomeCorso = new System.Windows.Forms.TextBox();
            this.txtEdizioneCorso = new System.Windows.Forms.TextBox();
            this.lblEdizioneCorso = new System.Windows.Forms.Label();
            this.lblConfermaAggiunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F);
            this.btnAggiungi.Location = new System.Drawing.Point(313, 51);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(455, 63);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Clicca per aggiungere un corso";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblnomeCorso
            // 
            this.lblnomeCorso.AutoSize = true;
            this.lblnomeCorso.Location = new System.Drawing.Point(22, 51);
            this.lblnomeCorso.Name = "lblnomeCorso";
            this.lblnomeCorso.Size = new System.Drawing.Size(81, 13);
            this.lblnomeCorso.TabIndex = 1;
            this.lblnomeCorso.Text = "Nome del corso";
            // 
            // txtNomeCorso
            // 
            this.txtNomeCorso.Location = new System.Drawing.Point(128, 51);
            this.txtNomeCorso.Name = "txtNomeCorso";
            this.txtNomeCorso.Size = new System.Drawing.Size(141, 20);
            this.txtNomeCorso.TabIndex = 2;
            // 
            // txtEdizioneCorso
            // 
            this.txtEdizioneCorso.Location = new System.Drawing.Point(128, 94);
            this.txtEdizioneCorso.Name = "txtEdizioneCorso";
            this.txtEdizioneCorso.Size = new System.Drawing.Size(141, 20);
            this.txtEdizioneCorso.TabIndex = 4;
            // 
            // lblEdizioneCorso
            // 
            this.lblEdizioneCorso.AutoSize = true;
            this.lblEdizioneCorso.Location = new System.Drawing.Point(22, 94);
            this.lblEdizioneCorso.Name = "lblEdizioneCorso";
            this.lblEdizioneCorso.Size = new System.Drawing.Size(93, 13);
            this.lblEdizioneCorso.TabIndex = 3;
            this.lblEdizioneCorso.Text = "Edizione del corso";
            // 
            // lblConfermaAggiunta
            // 
            this.lblConfermaAggiunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F);
            this.lblConfermaAggiunta.Location = new System.Drawing.Point(25, 187);
            this.lblConfermaAggiunta.Name = "lblConfermaAggiunta";
            this.lblConfermaAggiunta.Size = new System.Drawing.Size(743, 23);
            this.lblConfermaAggiunta.TabIndex = 5;
            // 
            // AggingiCorso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConfermaAggiunta);
            this.Controls.Add(this.txtEdizioneCorso);
            this.Controls.Add(this.lblEdizioneCorso);
            this.Controls.Add(this.txtNomeCorso);
            this.Controls.Add(this.lblnomeCorso);
            this.Controls.Add(this.btnAggiungi);
            this.Name = "AggingiCorso";
            this.Text = "AggingiCorso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblnomeCorso;
        private System.Windows.Forms.TextBox txtNomeCorso;
        private System.Windows.Forms.TextBox txtEdizioneCorso;
        private System.Windows.Forms.Label lblEdizioneCorso;
        private System.Windows.Forms.Label lblConfermaAggiunta;
    }
}