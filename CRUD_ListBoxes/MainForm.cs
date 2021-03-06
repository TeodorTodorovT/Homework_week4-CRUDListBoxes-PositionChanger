﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ListBoxes
{
    public partial class MainForm : Form
    {
        private int lastMatch = 0;
        List<string> result = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text.Trim();
            if (input != "")
            {
                result.Add(input);
                lbResult.Items.Clear();
                lbResult.Items.AddRange(result.ToArray());
                tbInput.Text = "";
            }
            else
            {
                MessageBox.Show("Enter valid data!");
            }
        }

        private void btnRemoveElement_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIndex = lbResult.SelectedIndex;
                result.RemoveAt(currentIndex);
                lbResult.Items.RemoveAt(currentIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Enter item before removing!");
            }
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            result.Clear();
            lbResult.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string edit = tbInput.Text;
                int currentIndex = lbResult.SelectedIndex;
                lbResult.Items[currentIndex] = edit;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an item!");

            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            if (lbResult.Items.Contains(search))
            {
                MessageBox.Show("This item is in the list!");
            }
            else
            {
                MessageBox.Show("This item is not in the list!");
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbResult.Sorted = true;
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
