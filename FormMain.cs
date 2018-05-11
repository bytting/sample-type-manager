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
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Xml;

namespace SampleTypeManager
{
    public partial class FormMain : Form
    {
        Font Arial_10_Bold = new Font("Arial", 10.0f, FontStyle.Bold);

        string NumSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        string NL = Environment.NewLine;        
        XmlDocument doc = new XmlDocument();
        string filename;
        bool modified = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            lblSelectedSample.Text = "";
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            if(modified)
            {
                if(MessageBox.Show("File has been modified. Do you want to save changes?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    menuItemSave_Click(sender, e);
                }
            }
            Close();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {                
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                tree.Nodes.Clear();

                doc.Load(ofd.FileName);
                modified = false;
                menuItemSave.Enabled = true;
                filename = ofd.FileName;
                XmlElement root = doc.DocumentElement;
                TreeNode tnode = tree.Nodes.Add("Sample types");
                tnode.NodeFont = Arial_10_Bold;
                tnode.Tag = root;
                AddSampleTypes(root, tnode);

                tnode.Expand();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSampleTypes(XmlNode node, TreeNode tnode)
        {
            foreach (XmlNode n in node.ChildNodes)
            {
                if (n.NodeType == XmlNodeType.Element && n.Name.ToLower() == "sampletype")
                {
                    TreeNode newNode = new TreeNode(n.Attributes["name"].InnerText);
                    newNode.ToolTipText = tnode.ToolTipText + "/" + n.Attributes["name"].InnerText;
                    newNode.Tag = n;
                    tnode.Nodes.Add(newNode);
                    AddSampleTypes(n, newNode);
                }
            }
        }

        private string GetNodePath(XmlNode node)
        {
            if (node == doc.DocumentElement)
                return "/sampletypes/";

            string path = "sampletype[@name = \"" + node.Attributes["name"].InnerText + "\"]/";
            XmlNode search = null;
            while ((search = node.ParentNode).Name.ToLower() != "sampletypes")
            {
                path = "sampletype[@name = \"" + search.Attributes["name"].InnerText + "\"]/" + path;
                node = search;
            }
            return "/sampletypes/" + path.Substring(0, path.Length - 1);
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                lblSelectedSample.Text = e.Node.Text;
                PopulateComponents(e.Node);

                menuItemTypeAdd.Enabled = true;
                menuItemTypeRemove.Enabled = true;
                btnTypeAdd.Enabled = true;
                btnTypeRemove.Enabled = true;
                menuItemComponentAdd.Enabled = true;
                btnComponentAdd.Enabled = true;
                menuItemComponentRemove.Enabled = false;
                btnComponentRemove.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateComponents(TreeNode node)
        {
            lbComponents.Items.Clear();
            lbComponents2.Items.Clear();

            if (node.Level == 0)
                return;

            XmlNode xnode = node.Tag as XmlNode;
            string path = GetNodePath(xnode) + "/component";
            XmlNodeList nodes = doc.SelectNodes(path);

            foreach (XmlNode n in nodes)
                lbComponents.Items.Add(n.Attributes["name"].InnerText);

            while(xnode.ParentNode != doc.DocumentElement)
            {
                xnode = xnode.ParentNode;

                path = GetNodePath(xnode) + "/component";
                nodes = doc.SelectNodes(path);

                foreach (XmlNode n in nodes)
                    lbComponents2.Items.Add(n.Attributes["name"].InnerText);
            }
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.CheckFileExists = false;
                ofd.CheckPathExists = false;
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                if(File.Exists(ofd.FileName))
                {
                    MessageBox.Show("File " + ofd.FileName + " already exists");
                    return;
                }

                tree.Nodes.Clear();

                doc.LoadXml("<sampletypes></sampletypes>");
                doc.Save(ofd.FileName);
                modified = false;
                menuItemSave.Enabled = true;
                filename = ofd.FileName;

                XmlElement root = doc.DocumentElement;
                TreeNode tnode = tree.Nodes.Add("Sample types");
                tnode.NodeFont = new Font("Arial", 10.0f, FontStyle.Bold);
                tnode.Tag = root;
                AddSampleTypes(root, tnode);

                tnode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemTypeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tree.SelectedNode == null)
                {
                    MessageBox.Show("You must select a parent node first");
                    return;
                }

                FormGetName form = new FormGetName();
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                if (String.IsNullOrEmpty(form.SelectedNorwegianName))
                {
                    MessageBox.Show("Can not use empty names");
                    return;
                }

                TreeNode tn = tree.SelectedNode;

                foreach (TreeNode node in tn.Nodes)
                {
                    string name = node.Text;
                    if (name.ToLower() == form.SelectedNorwegianName.ToLower())
                    {
                        MessageBox.Show("Name " + name + " already exist at this location");
                        return;
                    }
                }

                XmlNode xn = tree.SelectedNode.Tag as XmlNode;
                XmlElement newXn = doc.CreateElement(String.Empty, "sampletype", "");
                newXn.SetAttribute("name", form.SelectedNorwegianName);
                newXn.SetAttribute("name_english", "");
                newXn.SetAttribute("name_latin", "");
                xn.AppendChild(newXn);
                TreeNode newTn = tn.Nodes.Add(form.SelectedNorwegianName);
                newTn.ToolTipText = tn.ToolTipText + "/" + form.SelectedNorwegianName;
                newTn.Tag = newXn;
                modified = true;

                lblStatus.Text = "Sample type " + form.SelectedNorwegianName + " added";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemTypeRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (tree.SelectedNode == null)
                {
                    MessageBox.Show("You must select a node first");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to remove " + tree.SelectedNode.Text + " and all its children?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                XmlNode remNode = tree.SelectedNode.Tag as XmlNode;

                RemoveNodes(tree.SelectedNode);

                remNode.RemoveAll();
                remNode.ParentNode.RemoveChild(remNode);
                modified = true;

                lblStatus.Text = "Sample type " + tree.SelectedNode + " removed";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void RemoveNodes(TreeNode node)
        {
            foreach(TreeNode n in node.Nodes)            
                RemoveNodes(n);            
            node.Remove();          
        }

        private void menuItemComponentAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tree.SelectedNode == null)
                {
                    MessageBox.Show("You must select a parent node first");
                    return;
                }

                FormGetName form = new FormGetName();
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                if (String.IsNullOrEmpty(form.SelectedNorwegianName))
                {
                    MessageBox.Show("Can not use empty names");
                    return;
                }

                XmlNode xn = tree.SelectedNode.Tag as XmlNode;
                XmlElement newXn = doc.CreateElement(String.Empty, "component", "");
                newXn.SetAttribute("name", form.SelectedNorwegianName);
                newXn.SetAttribute("name_english", "");
                newXn.SetAttribute("name_latin", "");
                xn.AppendChild(newXn);
                modified = true;

                PopulateComponents(tree.SelectedNode);

                lblStatus.Text = "Component " + form.SelectedNorwegianName + " added";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemComponentRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (tree.SelectedNode == null)
                {
                    MessageBox.Show("You must select a node first");
                    return;
                }

                if (lbComponents.SelectedItems.Count < 1)
                {
                    MessageBox.Show("You must select a component first");
                    return;
                }

                string comp = lbComponents.SelectedItems[0] as String;

                if (MessageBox.Show("Are you sure you want to remove component " + comp + "?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                XmlNode remNode = tree.SelectedNode.Tag as XmlNode;
                XmlNode remComp = null;

                foreach (XmlNode n in remNode.ChildNodes)
                {
                    if (n.Attributes["name"].InnerText.ToLower() == comp.ToLower())
                    {
                        remComp = n;
                        break;
                    }
                }

                if (remComp != null)
                {
                    remNode.RemoveChild(remComp);
                    lbComponents.Items.Remove(comp);
                }

                modified = true;

                lblStatus.Text = "Component " + comp + " removed";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                doc.Save(filename);
                modified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbComponents.SelectedItems.Count < 1)
            {
                menuItemComponentAdd.Enabled = false;
                menuItemComponentRemove.Enabled = false;
                btnComponentAdd.Enabled = false;
                btnComponentRemove.Enabled = false;
            }
            else
            {
                menuItemComponentAdd.Enabled = true;
                menuItemComponentRemove.Enabled = true;
                btnComponentAdd.Enabled = true;
                btnComponentRemove.Enabled = true;
            }
        }
    }
}
