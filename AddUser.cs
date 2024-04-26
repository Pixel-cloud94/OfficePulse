using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficePulse
{
    public partial class AddUser : Form
    {
        private User user = new User();
        private Dictionary<string, int> roles;

        public AddUser()
        {
            InitializeComponent();

            roles = user.GetRoles();

            comboBoxRole.DataSource = new BindingList<KeyValuePair<string, int>>(roles.ToList());
            comboBoxRole.DisplayMember = "Key";
            comboBoxRole.ValueMember = "Value";



        }



        private int roleid;
        private int departmentId = -1;
        private bool isAdmin;
        

        private void buttonADDUSER_Click(object sender, EventArgs e)
        {
            int roleId = roles.Values.ElementAt(roleid);

            User user = new User(
                textBoxFirstName.Text,
                textBoxLastName.Text,
                textBoxUserName.Text,
                textBoxPassword.Text,
                departmentId,
                roleId,
                isAdmin
                );

            user.registerUser();           
            this.Close();
            
        }

        private void buttonCEO_Click(object sender, EventArgs e)
        {
            departmentId = 1;
        }

        private void buttonCS_Click(object sender, EventArgs e)
        {
            departmentId = 2;

        }

        private void buttonIT_Click(object sender, EventArgs e)
        {
            departmentId = 3;

        }

        private void buttonSM_Click(object sender, EventArgs e)
        {
            departmentId = 4;

        }

        private void buttonAF_Click(object sender, EventArgs e)
        {
            departmentId = 5;

        }

        private void buttonPO_Click(object sender, EventArgs e)
        {
            departmentId = 6;

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            roleid = comboBoxRole.SelectedIndex;


        }

        private void AdminToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminToggle.Checked)
            {
                isAdmin = true; 
            }
            else
            {
                isAdmin = false;
            }
        }
    }
}
