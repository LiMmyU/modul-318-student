using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using SwissTransport;


namespace TransportNow
{
    public partial class mainForm : Form
    {
        Transport t = new Transport();

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //DataTAble erstellen
            DataTable dtConnections = new DataTable();
            dtConnections.Columns.Add("Abfahrtszeit");
            dtConnections.Columns.Add("AbfahrtsOrt");
            dtConnections.Columns.Add("Zielort");
            dtConnections.Columns.Add("Zielzeit");

            //Verbindungen auslesen
            Connections stb = t.GetConnections(txtDeparture.Text, txtDestination.Text);

            //Verbindungen in DataTAble speichern
            foreach (Connection station in stb.ConnectionList)
            {
                dtConnections.Rows.Add(station.From.Departure, station.From.Station.Name, station.To.Station.Name,
                    station.To.Arrival);
            }

            //DatatAble in DataGrdid hinzufühen
            dgviewAbfahrtsplan.DataSource = dtConnections;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            txtDeparture.Select();
        }

        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            fillListbox(lboxDeparture, txtDeparture);
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            fillListbox(lboxDestination, txtDestination);
        }
        private void txtDeparture_KeyDown(object sender, KeyEventArgs e)
        {
            focusListBox(lboxDeparture,e);
        }
        private void lboxDeparture_KeyDown(object sender, KeyEventArgs e)
        {
            selectLocation(lboxDeparture, txtDeparture, e);
        }
        private void txtDestination_KeyDown(object sender, KeyEventArgs e)
        {
            focusListBox(lboxDestination, e);
        }
        private void lboxDestination_KeyDown(object sender, KeyEventArgs e)
        {
            selectLocation(lboxDestination, txtDestination, e);
        }

        /// <summary>
        /// Füllt die Suchvorschläge in die Combobox ab    
        /// </summary>
        private void fillListbox(ListBox lbox, TextBox txt)
        {
 
            lbox.Items.Clear();
            foreach (object o in t.GetStations(txt.Text).StationList)
            {
                lbox.Items.Add(o.ToString());
            }
            if (txt.Text != "")
            {
                lbox.Visible = true;
            }
        }
        /// <summary>
        /// Nimmt die Listbox in den Fokus
        /// </summary>
        private void focusListBox(ListBox lbox, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbox.Focus();
            }

        }
        /// <summary>
        /// Suchort aus Listbox auswählen
        /// </summary>
        private void selectLocation(ListBox lbox, TextBox txt, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txt.Text = lbox.SelectedItem.ToString();
                txt.Focus();
                lbox.Visible = false;
            }


        }
    }
}
