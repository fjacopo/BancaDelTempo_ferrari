namespace BancaDelTempo_ferrari
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Metodi come nella versione precedente

        private void InitializeComponent()
        {
            this.lstSoci = new System.Windows.Forms.ListBox();
            this.btnDebito = new System.Windows.Forms.Button();
            this.lstDebito = new System.Windows.Forms.ListBox();
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.lstSegreteria = new System.Windows.Forms.ListBox();
            this.btnOrdinaPrestazioni = new System.Windows.Forms.Button();
            this.lstPrestazioni = new System.Windows.Forms.ListBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSoci
            // 
            this.lstSoci.ItemHeight = 16;
            this.lstSoci.Location = new System.Drawing.Point(351, 268);
            this.lstSoci.Name = "lstSoci";
            this.lstSoci.Size = new System.Drawing.Size(287, 164);
            this.lstSoci.TabIndex = 0;
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(104, 240);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(95, 23);
            this.btnDebito.TabIndex = 1;
            this.btnDebito.Text = "Debito";
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // lstDebito
            // 
            this.lstDebito.ItemHeight = 16;
            this.lstDebito.Location = new System.Drawing.Point(12, 269);
            this.lstDebito.Name = "lstDebito";
            this.lstDebito.Size = new System.Drawing.Size(287, 164);
            this.lstDebito.TabIndex = 2;
            // 
            // btnSegreteria
            // 
            this.btnSegreteria.Location = new System.Drawing.Point(449, 19);
            this.btnSegreteria.Name = "btnSegreteria";
            this.btnSegreteria.Size = new System.Drawing.Size(95, 23);
            this.btnSegreteria.TabIndex = 3;
            this.btnSegreteria.Text = "Segreteria";
            this.btnSegreteria.Click += new System.EventHandler(this.btnSegreteria_Click);
            // 
            // lstSegreteria
            // 
            this.lstSegreteria.ItemHeight = 16;
            this.lstSegreteria.Location = new System.Drawing.Point(351, 48);
            this.lstSegreteria.Name = "lstSegreteria";
            this.lstSegreteria.Size = new System.Drawing.Size(287, 164);
            this.lstSegreteria.TabIndex = 4;
            // 
            // btnOrdinaPrestazioni
            // 
            this.btnOrdinaPrestazioni.Location = new System.Drawing.Point(104, 19);
            this.btnOrdinaPrestazioni.Name = "btnOrdinaPrestazioni";
            this.btnOrdinaPrestazioni.Size = new System.Drawing.Size(95, 23);
            this.btnOrdinaPrestazioni.TabIndex = 5;
            this.btnOrdinaPrestazioni.Text = "Prestazioni";
            this.btnOrdinaPrestazioni.Click += new System.EventHandler(this.btnOrdinaPrestazioni_Click);
            // 
            // lstPrestazioni
            // 
            this.lstPrestazioni.ItemHeight = 16;
            this.lstPrestazioni.Location = new System.Drawing.Point(12, 48);
            this.lstPrestazioni.Name = "lstPrestazioni";
            this.lstPrestazioni.Size = new System.Drawing.Size(287, 164);
            this.lstPrestazioni.TabIndex = 6;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(695, 409);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(27, 23);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(734, 444);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lstSoci);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.lstDebito);
            this.Controls.Add(this.btnSegreteria);
            this.Controls.Add(this.lstSegreteria);
            this.Controls.Add(this.btnOrdinaPrestazioni);
            this.Controls.Add(this.lstPrestazioni);
            this.Name = "Form1";
            this.Text = "Banca del Tempo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        // Definizione dei controlli dell'interfaccia grafica qui
        private System.Windows.Forms.ListBox lstSoci;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.ListBox lstDebito;
        private System.Windows.Forms.Button btnSegreteria;
        private System.Windows.Forms.ListBox lstSegreteria;
        private System.Windows.Forms.Button btnOrdinaPrestazioni;
        private System.Windows.Forms.ListBox lstPrestazioni;
        private System.Windows.Forms.Button btnReload;

    }
}

