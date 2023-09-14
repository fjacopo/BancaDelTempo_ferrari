using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadData();
            UpdateUI();
        }

        private void LoadData()
        {
            // Caricadati da file JSON
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

        

        private void UpdateUI()
        {
            // Aggiorna l'interfaccia grafica
            listSoci.Items.Clear();
            foreach (Socio socio in soci)
            {
                listSoci.Items.Add($"{socio.Cognome}, {socio.Nome} - Tel: {socio.Telefono}");
            }
        }
    
        

        private void InitializeComponent()
        {
            this.listSegreteria = new System.Windows.Forms.ListBox();
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.listSoci = new System.Windows.Forms.ListBox();
            this.listDebito = new System.Windows.Forms.ListBox();
            this.btnDebito = new System.Windows.Forms.Button();
            this.listPrestazioni = new System.Windows.Forms.ListBox();
            this.btnPrestazioni = new System.Windows.Forms.Button();
            this.btnRicarica = new System.Windows.Forms.Button();
            this.btnaggiungi = new System.Windows.Forms.Button();
            this.cognometextbox = new System.Windows.Forms.TextBox();
            this.teltextbox = new System.Windows.Forms.TextBox();
            this.nometextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listSegreteria
            // 
            this.listSegreteria.FormattingEnabled = true;
            this.listSegreteria.ItemHeight = 16;
            this.listSegreteria.Location = new System.Drawing.Point(12, 75);
            this.listSegreteria.Name = "listSegreteria";
            this.listSegreteria.Size = new System.Drawing.Size(302, 324);
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
            this.listSoci.Location = new System.Drawing.Point(365, 75);
            this.listSoci.Name = "listSoci";
            this.listSoci.Size = new System.Drawing.Size(302, 324);
            this.listSoci.TabIndex = 2;
            this.listSoci.SelectedIndexChanged += new System.EventHandler(this.listSoci_SelectedIndexChanged);
            // 
            // listDebito
            // 
            this.listDebito.FormattingEnabled = true;
            this.listDebito.ItemHeight = 16;
            this.listDebito.Location = new System.Drawing.Point(726, 75);
            this.listDebito.Name = "listDebito";
            this.listDebito.Size = new System.Drawing.Size(302, 324);
            this.listDebito.TabIndex = 3;
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(726, 30);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(153, 39);
            this.btnDebito.TabIndex = 4;
            this.btnDebito.Text = "Debito";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click_1);
            // 
            // listPrestazioni
            // 
            this.listPrestazioni.FormattingEnabled = true;
            this.listPrestazioni.ItemHeight = 16;
            this.listPrestazioni.Location = new System.Drawing.Point(1084, 75);
            this.listPrestazioni.Name = "listPrestazioni";
            this.listPrestazioni.Size = new System.Drawing.Size(302, 324);
            this.listPrestazioni.TabIndex = 5;
            this.listPrestazioni.SelectedIndexChanged += new System.EventHandler(this.listPrestazioni_SelectedIndexChanged);
            // 
            // btnPrestazioni
            // 
            this.btnPrestazioni.Location = new System.Drawing.Point(1084, 30);
            this.btnPrestazioni.Name = "btnPrestazioni";
            this.btnPrestazioni.Size = new System.Drawing.Size(153, 39);
            this.btnPrestazioni.TabIndex = 6;
            this.btnPrestazioni.Text = "Prestazioni";
            this.btnPrestazioni.UseVisualStyleBackColor = true;
            this.btnPrestazioni.Click += new System.EventHandler(this.btnPrestazioni_Click);
            // 
            // btnRicarica
            // 
            this.btnRicarica.Location = new System.Drawing.Point(12, 422);
            this.btnRicarica.Name = "btnRicarica";
            this.btnRicarica.Size = new System.Drawing.Size(114, 51);
            this.btnRicarica.TabIndex = 7;
            this.btnRicarica.Text = "RICARICA";
            this.btnRicarica.UseVisualStyleBackColor = true;
            this.btnRicarica.Click += new System.EventHandler(this.btnRicarica_Click);
            // 
            // btnaggiungi
            // 
            this.btnaggiungi.Location = new System.Drawing.Point(212, 416);
            this.btnaggiungi.Name = "btnaggiungi";
            this.btnaggiungi.Size = new System.Drawing.Size(199, 62);
            this.btnaggiungi.TabIndex = 8;
            this.btnaggiungi.Text = "AGGIUNGI";
            this.btnaggiungi.UseVisualStyleBackColor = true;
            this.btnaggiungi.Click += new System.EventHandler(this.btnaggiungi_Click);
            // 
            // cognometextbox
            // 
            this.cognometextbox.Location = new System.Drawing.Point(643, 456);
            this.cognometextbox.Name = "cognometextbox";
            this.cognometextbox.Size = new System.Drawing.Size(183, 22);
            this.cognometextbox.TabIndex = 9;
            // 
            // teltextbox
            // 
            this.teltextbox.Location = new System.Drawing.Point(845, 456);
            this.teltextbox.Name = "teltextbox";
            this.teltextbox.Size = new System.Drawing.Size(183, 22);
            this.teltextbox.TabIndex = 10;
            // 
            // nometextbox
            // 
            this.nometextbox.Location = new System.Drawing.Point(438, 456);
            this.nometextbox.Name = "nometextbox";
            this.nometextbox.Size = new System.Drawing.Size(183, 22);
            this.nometextbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefono";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1398, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nometextbox);
            this.Controls.Add(this.teltextbox);
            this.Controls.Add(this.cognometextbox);
            this.Controls.Add(this.btnaggiungi);
            this.Controls.Add(this.btnRicarica);
            this.Controls.Add(this.btnPrestazioni);
            this.Controls.Add(this.listPrestazioni);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.listDebito);
            this.Controls.Add(this.listSoci);
            this.Controls.Add(this.btnSegreteria);
            this.Controls.Add(this.listSegreteria);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void btnDebito_Click_1(object sender, EventArgs e)
        {
            // fa l'elenco dei soci con debito
            List<Socio> debitori = soci.Where(s => s.CalcolaDebito() > 0).ToList();

            listDebito.Items.Clear();
            foreach (Socio debitor in debitori)
            {
                listDebito.Items.Add($"{debitor.Cognome}, {debitor.Nome} | Debito: {debitor.Debito}");
            }
        }

        private void btnPrestazioni_Click(object sender, EventArgs e)
        {
            //  ordina e visualizza le prestazioni
            List<Prestazione> prestazioniOrdinate = prestazioni.OrderByDescending(p => p.Ore).ToList();

            listPrestazioni.Items.Clear();
            foreach (Prestazione prestazione in prestazioniOrdinate)
            {
                listPrestazioni.Items.Add($"{prestazione.Erogatore.Cognome}, {prestazione.Erogatore.Nome} -> {prestazione.Ricevente.Cognome}, {prestazione.Ricevente.Nome} - {prestazione.Ore} ore di {prestazione.Tipo}");
            }
        }

        private void btnRicarica_Click(object sender, EventArgs e)
        {
            LoadData();
            UpdateUI();
        }

        private void listSoci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPrestazioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
        public static void Aggiungi(Socio nuovo)
        {
            //B = variabile per aprire il file in modalità scrittura e visualizzazione
            var B = new FileStream(@"soci.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            B.Close();
            StreamReader sr = new StreamReader(@"soci.json"); 
            StreamWriter sw = new StreamWriter(@"./socii.json"); //file temporaneo per le modifiche

            string s = ""; //stringa per memorizzare le righe nel file json
            int i = 0; //diventa 1 se viene scritto l'oggetto

            while (!sr.EndOfStream || i != 1)
            {
                s = sr.ReadLine(); //legge e memorizza la righa del file nella stringa s

                if (s != null && i == 0 && s != "]")
                {
                    sw.WriteLine(s);
                }
                else if (s == "]")
                {
                    sw.WriteLine(",");
                    
                    string jsonString = JsonConvert.SerializeObject(nuovo, Formatting.None);
                    sw.WriteLine(jsonString);
                    sw.WriteLine("]");
                    i = 1;
                }
            }
            sr.Close();
            sw.Close();

            System.IO.File.Delete(@"soci.json");
            System.IO.File.Move(@"./socii.json", @"soci.json"); //sostituisco il file temporaneo con soci.json

        }

        private void btnaggiungi_Click(object sender, EventArgs e)
        {
            bool a = true;
            double tel2;
            //controlli per vedere se è corretto, se non sono corretti a diventa false
            if (String.IsNullOrWhiteSpace(cognometextbox.Text))
            {
                a = false;
                MessageBox.Show("Cognome non valido");
            }
            if (String.IsNullOrWhiteSpace(nometextbox.Text))
            {
                a = false;
                MessageBox.Show("Nome non valido");
            }
            if (String.IsNullOrWhiteSpace(teltextbox.Text) || teltextbox.Text.Length != 10)
            {
                try
                {
                    tel2 = double.Parse(teltextbox.Text);
                }
                catch
                {
                    a = false;
                    MessageBox.Show("Telefono non valido");
                }
            }

            if (a)
            {
                //creo un nuovo oggetto Socio con i valori inseriti dall'utente
                Socio nuovo = new Socio(cognometextbox.Text, nometextbox.Text, double.Parse(teltextbox.Text), 0 , false);
                Aggiungi(nuovo);
                
            }
        }
    }
}
