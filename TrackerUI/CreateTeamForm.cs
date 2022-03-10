using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            // TODO - Add validation to the form
            if(firstNameTextValue.Text.Length == 0)
            {
                return false;
            }

            if(lastNameTextValue.Text.Length == 0)
            {
                return false;
            }

            if(emailTextValue.Text.Length == 0)
            {
                return false;
            }

            if(cellPhoneLabel.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

       
    }
}
