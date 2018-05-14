namespace SampleTypeManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemType = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTypeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTypeRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemComponent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemComponentAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemComponentRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tree = new System.Windows.Forms.TreeView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lbComponents = new System.Windows.Forms.ListBox();
            this.split = new System.Windows.Forms.SplitContainer();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.btnTypeAdd = new System.Windows.Forms.ToolStripButton();
            this.btnTypeRemove = new System.Windows.Forms.ToolStripButton();
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lbComponents2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tools2 = new System.Windows.Forms.ToolStrip();
            this.btnComponentAdd = new System.Windows.Forms.ToolStripButton();
            this.btnComponentRemove = new System.Windows.Forms.ToolStripButton();
            this.lblSelectedSample = new System.Windows.Forms.ToolStripLabel();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            this.tools2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemType,
            this.tbSearch,
            this.menuItemComponent,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(790, 27);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemSave,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 23);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Image = global::SampleTypeManager.Properties.Resources.new_library;
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(107, 22);
            this.menuItemNew.Text = "&New...";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Image = global::SampleTypeManager.Properties.Resources.open_library;
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(107, 22);
            this.menuItemOpen.Text = "&Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Enabled = false;
            this.menuItemSave.Image = global::SampleTypeManager.Properties.Resources.save;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(107, 22);
            this.menuItemSave.Text = "&Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = global::SampleTypeManager.Properties.Resources.exit;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(107, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemType
            // 
            this.menuItemType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTypeAdd,
            this.menuItemTypeRemove});
            this.menuItemType.Name = "menuItemType";
            this.menuItemType.Size = new System.Drawing.Size(89, 23);
            this.menuItemType.Text = "&Sample types";
            // 
            // menuItemTypeAdd
            // 
            this.menuItemTypeAdd.Enabled = false;
            this.menuItemTypeAdd.Image = global::SampleTypeManager.Properties.Resources.add;
            this.menuItemTypeAdd.Name = "menuItemTypeAdd";
            this.menuItemTypeAdd.Size = new System.Drawing.Size(117, 22);
            this.menuItemTypeAdd.Text = "&Add...";
            this.menuItemTypeAdd.Click += new System.EventHandler(this.menuItemTypeAdd_Click);
            // 
            // menuItemTypeRemove
            // 
            this.menuItemTypeRemove.Enabled = false;
            this.menuItemTypeRemove.Image = global::SampleTypeManager.Properties.Resources.remove;
            this.menuItemTypeRemove.Name = "menuItemTypeRemove";
            this.menuItemTypeRemove.Size = new System.Drawing.Size(117, 22);
            this.menuItemTypeRemove.Text = "&Remove";
            this.menuItemTypeRemove.Click += new System.EventHandler(this.menuItemTypeRemove_Click);
            // 
            // menuItemComponent
            // 
            this.menuItemComponent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemComponentAdd,
            this.menuItemComponentRemove});
            this.menuItemComponent.Name = "menuItemComponent";
            this.menuItemComponent.Size = new System.Drawing.Size(128, 23);
            this.menuItemComponent.Text = "Sample &components";
            // 
            // menuItemComponentAdd
            // 
            this.menuItemComponentAdd.Enabled = false;
            this.menuItemComponentAdd.Image = global::SampleTypeManager.Properties.Resources.add;
            this.menuItemComponentAdd.Name = "menuItemComponentAdd";
            this.menuItemComponentAdd.Size = new System.Drawing.Size(117, 22);
            this.menuItemComponentAdd.Text = "&Add...";
            this.menuItemComponentAdd.Click += new System.EventHandler(this.menuItemComponentAdd_Click);
            // 
            // menuItemComponentRemove
            // 
            this.menuItemComponentRemove.Enabled = false;
            this.menuItemComponentRemove.Image = global::SampleTypeManager.Properties.Resources.remove;
            this.menuItemComponentRemove.Name = "menuItemComponentRemove";
            this.menuItemComponentRemove.Size = new System.Drawing.Size(117, 22);
            this.menuItemComponentRemove.Text = "&Remove";
            this.menuItemComponentRemove.Click += new System.EventHandler(this.menuItemComponentRemove_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.menuItemAbout.Text = "A&bout";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 23);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.status.Location = new System.Drawing.Point(0, 649);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.status.Size = new System.Drawing.Size(790, 22);
            this.status.TabIndex = 1;
            this.status.Text = "status";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 17);
            this.lblStatus.Text = "<lblStatus>";
            // 
            // tree
            // 
            this.tree.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tree.HideSelection = false;
            this.tree.Indent = 32;
            this.tree.Location = new System.Drawing.Point(0, 25);
            this.tree.Name = "tree";
            this.tree.ShowNodeToolTips = true;
            this.tree.Size = new System.Drawing.Size(546, 597);
            this.tree.TabIndex = 3;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // ofd
            // 
            this.ofd.Filter = "XML files|*.xml|All files|*.*";
            // 
            // lbComponents
            // 
            this.lbComponents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbComponents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbComponents.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComponents.FormattingEnabled = true;
            this.lbComponents.ItemHeight = 16;
            this.lbComponents.Location = new System.Drawing.Point(0, 16);
            this.lbComponents.Name = "lbComponents";
            this.lbComponents.Size = new System.Drawing.Size(240, 269);
            this.lbComponents.TabIndex = 0;
            this.lbComponents.SelectedIndexChanged += new System.EventHandler(this.lbComponents_SelectedIndexChanged);
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 27);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.tree);
            this.split.Panel1.Controls.Add(this.tools);
            this.split.Panel1MinSize = 200;
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.split2);
            this.split.Panel2.Controls.Add(this.tools2);
            this.split.Panel2MinSize = 200;
            this.split.Size = new System.Drawing.Size(790, 622);
            this.split.SplitterDistance = 546;
            this.split.TabIndex = 5;
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTypeAdd,
            this.btnTypeRemove});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(546, 25);
            this.tools.TabIndex = 4;
            this.tools.Text = "toolStrip1";
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTypeAdd.Enabled = false;
            this.btnTypeAdd.Image = global::SampleTypeManager.Properties.Resources.add;
            this.btnTypeAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(23, 22);
            this.btnTypeAdd.Text = "toolStripButton1";
            this.btnTypeAdd.ToolTipText = "Add a new type below the selected sample type";
            this.btnTypeAdd.Click += new System.EventHandler(this.menuItemTypeAdd_Click);
            // 
            // btnTypeRemove
            // 
            this.btnTypeRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTypeRemove.Enabled = false;
            this.btnTypeRemove.Image = global::SampleTypeManager.Properties.Resources.remove;
            this.btnTypeRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTypeRemove.Name = "btnTypeRemove";
            this.btnTypeRemove.Size = new System.Drawing.Size(23, 22);
            this.btnTypeRemove.Text = "toolStripButton2";
            this.btnTypeRemove.ToolTipText = "Remove selected sample type and everything below it";
            this.btnTypeRemove.Click += new System.EventHandler(this.menuItemTypeRemove_Click);
            // 
            // split2
            // 
            this.split2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2.Location = new System.Drawing.Point(0, 25);
            this.split2.Name = "split2";
            this.split2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.Controls.Add(this.lbComponents);
            this.split2.Panel1.Controls.Add(this.label1);
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.Controls.Add(this.lbComponents2);
            this.split2.Panel2.Controls.Add(this.label2);
            this.split2.Size = new System.Drawing.Size(240, 597);
            this.split2.SplitterDistance = 285;
            this.split2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Components";
            // 
            // lbComponents2
            // 
            this.lbComponents2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbComponents2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComponents2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbComponents2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComponents2.FormattingEnabled = true;
            this.lbComponents2.ItemHeight = 16;
            this.lbComponents2.Location = new System.Drawing.Point(0, 16);
            this.lbComponents2.Name = "lbComponents2";
            this.lbComponents2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbComponents2.Size = new System.Drawing.Size(240, 292);
            this.lbComponents2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inherited components";
            // 
            // tools2
            // 
            this.tools2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnComponentAdd,
            this.btnComponentRemove,
            this.lblSelectedSample});
            this.tools2.Location = new System.Drawing.Point(0, 0);
            this.tools2.Name = "tools2";
            this.tools2.Size = new System.Drawing.Size(240, 25);
            this.tools2.TabIndex = 1;
            this.tools2.Text = "toolStrip2";
            // 
            // btnComponentAdd
            // 
            this.btnComponentAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnComponentAdd.Enabled = false;
            this.btnComponentAdd.Image = global::SampleTypeManager.Properties.Resources.add;
            this.btnComponentAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComponentAdd.Name = "btnComponentAdd";
            this.btnComponentAdd.Size = new System.Drawing.Size(23, 22);
            this.btnComponentAdd.Text = "toolStripButton3";
            this.btnComponentAdd.ToolTipText = "Add a new component to the selected sample type";
            this.btnComponentAdd.Click += new System.EventHandler(this.menuItemComponentAdd_Click);
            // 
            // btnComponentRemove
            // 
            this.btnComponentRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnComponentRemove.Enabled = false;
            this.btnComponentRemove.Image = global::SampleTypeManager.Properties.Resources.remove;
            this.btnComponentRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComponentRemove.Name = "btnComponentRemove";
            this.btnComponentRemove.Size = new System.Drawing.Size(23, 22);
            this.btnComponentRemove.Text = "toolStripButton4";
            this.btnComponentRemove.ToolTipText = "Remove component from selected sample type";
            this.btnComponentRemove.Click += new System.EventHandler(this.menuItemComponentRemove_Click);
            // 
            // lblSelectedSample
            // 
            this.lblSelectedSample.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblSelectedSample.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedSample.Name = "lblSelectedSample";
            this.lblSelectedSample.Size = new System.Drawing.Size(126, 22);
            this.lblSelectedSample.Text = "<lblSelectedSample>";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 671);
            this.Controls.Add(this.split);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(600, 460);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Type Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel1.PerformLayout();
            this.split.Panel2.ResumeLayout(false);
            this.split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel1.PerformLayout();
            this.split2.Panel2.ResumeLayout(false);
            this.split2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).EndInit();
            this.split2.ResumeLayout(false);
            this.tools2.ResumeLayout(false);
            this.tools2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ListBox lbComponents;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStrip tools2;
        private System.Windows.Forms.ToolStripMenuItem menuItemType;
        private System.Windows.Forms.ToolStripMenuItem menuItemTypeAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemTypeRemove;
        private System.Windows.Forms.ToolStripMenuItem menuItemComponent;
        private System.Windows.Forms.ToolStripMenuItem menuItemComponentAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemComponentRemove;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnTypeAdd;
        private System.Windows.Forms.ToolStripButton btnTypeRemove;
        private System.Windows.Forms.ToolStripButton btnComponentAdd;
        private System.Windows.Forms.ToolStripButton btnComponentRemove;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripLabel lblSelectedSample;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbComponents2;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
    }
}

