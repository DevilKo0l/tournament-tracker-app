using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

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
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellPhoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";                
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
        }

        private bool ValidateForm()
        {
            // TODO - Add validation to the form
            if(firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if(lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if(cellPhoneValue.Text.Length == 0)
            {
                return false;
            }

            if(emailLabel.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void teamOneScoreValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteSelectedPlayersButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void eLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
