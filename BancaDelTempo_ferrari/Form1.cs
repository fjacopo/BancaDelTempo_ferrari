using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lstSoci.Items.Clear();
            foreach (Socio socio in soci)
            {
                lstSoci.Items.Add($"{socio.Cognome}, {socio.Nome} - Tel: {socio.Telefono}");
            }
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            // Logica per produrre l'elenco dei soci con debito
            List<Socio> debitori = soci.Where(s => s.CalcolaDebito() > 0).ToList();

            lstDebito.Items.Clear();
            foreach (Socio debitor in debitori)
            {
                lstDebito.Items.Add($"{debitor.Cognome}, {debitor.Nome} | Debito: {debitor.Debito}");
            }
        }

        private void btnSegreteria_Click(object sender, EventArgs e)
        {
            // Logica per visualizzare i soci della segreteria
            List<Socio> segreteriaSoci = soci.Where(s => s.Segreteria).ToList();

            lstSegreteria.Items.Clear();
            foreach (Socio segreteriaSocio in segreteriaSoci)
            {
                lstSegreteria.Items.Add($"{segreteriaSocio.Cognome}, {segreteriaSocio.Nome} - Tel: {segreteriaSocio.Telefono}");
            }
        }

        private void btnOrdinaPrestazioni_Click(object sender, EventArgs e)
        {
            // Logica per ordinare e visualizzare le prestazioni
            List<Prestazione> prestazioniOrdinate = prestazioni.OrderByDescending(p => p.Ore).ToList();

            lstPrestazioni.Items.Clear();
            foreach (Prestazione prestazione in prestazioniOrdinate)
            {
                lstPrestazioni.Items.Add($"{prestazione.Erogatore.Cognome}, {prestazione.Erogatore.Nome} -> {prestazione.Ricevente.Cognome}, {prestazione.Ricevente.Nome} - {prestazione.Ore} ore di {prestazione.Tipo}");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            UpdateUI();
        }

        // Metodo per calcolare il devito di tutti i soci
        /*/public void CalcolaDebito()
        {
            foreach (Prestazione prestazione in prestazioni)
            {
                prestazione.Erogatore.Debito -= prestazione.Ore;
                MessageBox.Show(prestazione.Erogatore.ToString());
                prestazione.Ricevente.Debito += prestazione.Ore;
                MessageBox.Show(prestazione.Ricevente.ToString());
            }
            foreach (Socio p in soci)
            {
                MessageBox.Show(p.ToString());
            }
        }/*/

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveData();
        }
    }
}
