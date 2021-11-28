﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance2.Entities;

namespace UserMaintenance2
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            button_add.Text = Resource1.Add;
            label_FullName.Text = Resource1.FullName;

            listBox_users.DataSource = users;
            listBox_users.ValueMember = "ID";
            listBox_users.DisplayMember = "FullName";
        }

        private void label_LastName_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            User u = new User();
            // u.LastName = textBox_LastName.Text;
            //u.FirstName = textBox_FirstName.Text;
            u.FullName = textBox_FullName.Text;
            users.Add(u);
        }
    }
}
