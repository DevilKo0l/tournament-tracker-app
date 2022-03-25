using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        private List<TeamModel> availableTeams = new List<TeamModel>();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
        }

        private void WireUpList()
        {
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentPlayerListBox.DataSource = selectedTeams;
            tournamentPlayerListBox.DisplayMember = "TeamName";
        }
        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
