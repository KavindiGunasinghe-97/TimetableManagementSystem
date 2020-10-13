using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.LocationAllocation
{
    public partial class AllocateLocationMain : Form
    {
        private SessionDTO selectedSession = null;
        private ISessionService sessionService = new SessionService();
        private bool executedFirstTime;
        public AllocateLocationMain()
        {
            InitializeComponent();
            executedFirstTime = true;
            populateData();
        }
        public void populateData()
        {
            List<SessionDTO> sessionsArray = sessionService.getAllSessions();
            dataGridViewSessionRoom.Rows.Clear();

            foreach (SessionDTO session in sessionsArray)
            {
                dataGridViewSessionRoom.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag, session.Room);
            }

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom locationAllocation = new ManageSessionRoom();
            locationAllocation.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateData();
            selectedSession = new SessionDTO();
        }
    }
}
