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
            createDeparturePlan();
            createStationBoard(txtDeparture);
            lboxDestination.Visible = false;
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

        private void lboxDeparture_DoubleClick(object sender, EventArgs e)
        {
            mouseDoubleClick(lboxDeparture, txtDeparture, e);
        }

        private void lboxDeparture_Leave(object sender, EventArgs e)
        {
            hideListBox(lboxDeparture);
        }

        private void lboxDestination_Leave(object sender, EventArgs e)
        {
            hideListBox(lboxDestination);
        }
        private void txtDestination_Enter(object sender, EventArgs e)
        {
            lboxDeparture.Visible = false;
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
            if (e.KeyCode == Keys.Enter)
            {
                txt.Text = lbox.SelectedItem.ToString();
                txt.Focus();
                lbox.Visible = false;
            }


        }

        /// <summary>
        /// Wandelt zeit in ein hh:mm format um
        /// </summary>
        private string ConvertDateToTime(string dateTime_str)
        {
            //Time zum zurück geben
            string time = string.Empty;

            //DateTime parsen
            DateTime dateTime;
            DateTime.TryParse(dateTime_str, out dateTime);

            //Nur Zeit zum string
            time = dateTime.ToString("HH:mm");

            //Zeit zurück geben
            return time;
        }

        /// <summary>
        /// Doppelklick auf listBox zum Auswählen
        /// </summary>
        private void mouseDoubleClick(ListBox lbox, TextBox txt, EventArgs e)
        {
            txt.Text = lbox.SelectedItem.ToString();
            txt.Focus();
            lbox.Visible = false;
        }

        /// <summary>
        /// Den Abfahrtsplan erstellen
        /// </summary>
        private void createDeparturePlan()
        {
            //DataTable erstellen
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
                dtConnections.Rows.Add(ConvertDateToTime(station.From.Departure), station.From.Station.Name, station.To.Station.Name,
                    ConvertDateToTime(station.To.Arrival));
            }

            //DatatAble in DataGrdid hinzufühen
            dgviewAbfahrtsplan.DataSource = dtConnections;
        }

        /// <summary>
        /// Erstellt die Abfahrtstafel
        /// </summary>
        private void createStationBoard(TextBox txt)
        {
            string stationNameDeparture;
            string stationId;
            Stations stDeparture = t.GetStations(txt.Text);

            //DataTable erstellen
            DataTable dtDepartureBoard = new DataTable();
            dtDepartureBoard.Columns.Add("Abfahrtzeit");
            dtDepartureBoard.Columns.Add("Abfahrtsort");
            dtDepartureBoard.Columns.Add("Zielort");

            //StationBoard holen

            stationNameDeparture = stDeparture.StationList[0].Name;
            stationId = stDeparture.StationList[0].Id;
            StationBoardRoot stbRoot = t.GetStationBoard(txt.Text, stationId);

            foreach (StationBoard s in stbRoot.Entries)
            {
                //StationBoard in Datatable speichern
                dtDepartureBoard.Rows.Add(s.Stop.Departure, s.Name, s.To);
            }

            dgviewAbfahrtstafel.DataSource = dtDepartureBoard;
        }

        /// <summary>
        ///Versteckt die Listbox beim Verlassen der Listbox 
        /// </summary>
        private void hideListBox(ListBox lbox)
        {
            lbox.Visible = false;
        }
    }
}
