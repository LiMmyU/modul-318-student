using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;


namespace TransportNow
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Transport t = new Transport();
            dgviewAbfahrtsplan.DataSource = t.GetConnections(txtDeparture.Text, txtDestination.Text).ConnectionList;

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
