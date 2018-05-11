/*	
	Sample Type Manager - Manage XML sample types
    Copyright (C) 2018  Norwegian Radiation Protection Authority

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
// Authors: Dag robole,

using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace SampleTypeManager
{
    public partial class FormGetName : Form
    {
        public string SelectedNorwegianName, SelectedEnglishName, SelectedLatinName;

        public FormGetName()
        {
            InitializeComponent();
        }        

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if("/<>'\"\\".IndexOf(e.KeyChar) >= 0)
                e.Handled = true;            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SelectedNorwegianName = tbNorwegianName.Text.Trim();
            SelectedEnglishName = tbEnglishName.Text.Trim();
            SelectedLatinName = tbLatinName.Text.Trim();
            Close();
        }
    }
}
