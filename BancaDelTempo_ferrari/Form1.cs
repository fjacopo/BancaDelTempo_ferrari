using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BancaDelTempo_ferrari
{
    public partial class Form1 : Form
    {
        public List<Socio> soci = new List<Socio>();
        public List<Prestazione> prestazioni = new List<Prestazione>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdateUI();

        }

        private void LoadData()
        {
            // Caricare dati da file JSON
            if (File.Exists("soci.json"))
            {
                string sociJson = File.ReadAllText("soci.json");
                soci = JsonConvert.DeserializeObject<List<Socio>>(sociJson);
            }

            if (File.Exists("prestazioni.json"))
            {
                string prestazioniJson = File.ReadAllText("prestazioni.json");
                prestazioni = JsonConvert.DeserializeObject<List<Prestazione>>(prestazioniJson);
            }
        }

        private void SaveData()
        {
            // Salvare dati su file JSON
            string sociJson = JsonConvert.SerializeObject(soci);
            File.WriteAllText("soci.json", sociJson);

            string prestazioniJson = JsonConvert.SerializeObject(prestazioni);
            File.WriteAllText("prestazioni.json", prestazioniJson);
        }

        private void UpdateUI()
        {
            // Aggiornare la visualizzazione dei dati nell'interfaccia grafica
            listSoci.Items.Clear();
            foreach (Socio socio in soci)
            {
                listSoci.Items.Add($"{socio.Cognome}, {socio.Nome} - Tel: {socio.Telefono}");
            }
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            // Logica per produrre l'elenco dei soci con debito
            List<Socio> debitori = soci.Where(s => s.CalcolaDebito() > 0).ToList();

            listDebito.Items.Clear();
            foreach (Socio debitor in debitori)
            {
                listDebito.Items.Add($"{debitor.Cognome}, {debitor.Nome} | Debito: {debitor.Debito}");
            }
        }

       

        private void btnOrdinaPrestazioni_Click(object sender, EventArgs e)
        {
            //  ordina e visualizza le prestazioni
            List<Prestazione> prestazioniOrdinate = prestazioni.OrderByDescending(p => p.Ore).ToList();

            listPrestazioni.Items.Clear();
            foreach (Prestazione prestazione in prestazioniOrdinate)
            {
                listPrestazioni.Items.Add($"{prestazione.Erogatore.Cognome}, {prestazione.Erogatore.Nome} -> {prestazione.Ricevente.Cognome}, {prestazione.Ricevente.Nome} - {prestazione.Ore} ore di {prestazione.Tipo}");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            UpdateUI();
        }

       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void InitializeComponent()
        {
            this.listSegreteria = new System.Windows.Forms.ListBox();
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.listSoci = new System.Windows.Forms.ListBox();
            this.listDebito = new System.Windows.Forms.ListBox();
            this.btnDebito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSegreteria
            // 
            this.listSegreteria.FormattingEnabled = true;
            this.listSegreteria.ItemHeight = 16;
            this.listSegreteria.Location = new System.Drawing.Point(12, 75);
            this.listSegreteria.Name = "listSegreteria";
            this.listSegreteria.Size = new System.Drawing.Size(219, 324);
            this.listSegreteria.TabIndex = 0;
            // 
            // btnSegreteria
            // 
            this.btnSegreteria.Location = new System.Drawing.Point(12, 30);
            this.btnSegreteria.Name = "btnSegreteria";
            this.btnSegreteria.Size = new System.Drawing.Size(153, 39);
            this.btnSegreteria.TabIndex = 1;
            this.btnSegreteria.Text = "Segreteria";
            this.btnSegreteria.UseVisualStyleBackColor = true;
            this.btnSegreteria.Click += new System.EventHandler(this.btnSegreteria_Click_1);
            // 
            // listSoci
            // 
            this.listSoci.FormattingEnabled = true;
            this.listSoci.ItemHeight = 16;
            this.listSoci.Location = new System.Drawing.Point(330, 75);
            this.listSoci.Name = "listSoci";
            this.listSoci.Size = new System.Drawing.Size(218, 324);
            this.listSoci.TabIndex = 2;
            // 
            // listDebito
            // 
            this.listDebito.FormattingEnabled = true;
            this.listDebito.ItemHeight = 16;
            this.listDebito.Location = new System.Drawing.Point(645, 75);
            this.listDebito.Name = "listDebito";
            this.listDebito.Size = new System.Drawing.Size(218, 324);
            this.listDebito.TabIndex = 3;
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(645, 30);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(153, 39);
            this.btnDebito.TabIndex = 4;
            this.btnDebito.Text = "Debito";
            this.btnDebito.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1398, 497);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.listDebito);
            this.Controls.Add(this.listSoci);
            this.Controls.Add(this.btnSegreteria);
            this.Controls.Add(this.listSegreteria);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void btnSegreteria_Click_1(object sender, EventArgs e)
        {
            //  visualizza i soci della segreteria
            List<Socio> segreteriaSoci = soci.Where(s => s.Segreteria).ToList();

            listSegreteria.Items.Clear();
            foreach (Socio segreteriaSocio in segreteriaSoci)
            {
                listSegreteria.Items.Add($"{segreteriaSocio.Cognome}, {segreteriaSocio.Nome} - Tel: {segreteriaSocio.Telefono}");
            }
        }

      
    }
}
