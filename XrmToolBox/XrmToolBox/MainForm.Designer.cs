﻿using System.Drawing;

namespace XrmToolBox
{
    sealed partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomePageTab = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.tsbManageTabs = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeAllTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllTabsExceptActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startADiscussionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateThisToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDonate = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.HomePageTab);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 682);
            this.tabControl1.TabIndex = 0;
            // 
            // HomePageTab
            // 
            this.HomePageTab.AutoScroll = true;
            this.HomePageTab.Location = new System.Drawing.Point(4, 28);
            this.HomePageTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomePageTab.Name = "HomePageTab";
            this.HomePageTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomePageTab.Size = new System.Drawing.Size(1171, 650);
            this.HomePageTab.TabIndex = 0;
            this.HomePageTab.Text = "Home";
            this.HomePageTab.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "access.png");
            this.imageList1.Images.SetKeyName(1, "acroread.png");
            this.imageList1.Images.SetKeyName(2, "agent.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnect,
            this.toolStripSeparator2,
            this.tsbView,
            this.tsbManageTabs,
            this.toolStripSeparator5,
            this.tsbAbout,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.toolStripSeparator4,
            this.tsbDonate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1179, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConnect
            // 
            this.tsbConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnect.Image")));
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(136, 24);
            this.tsbConnect.Text = "Connect to CRM";
            this.tsbConnect.Click += new System.EventHandler(this.TsbConnectClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbView
            // 
            this.tsbView.Image = ((System.Drawing.Image)(resources.GetObject("tsbView.Image")));
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(61, 24);
            this.tsbView.Tag = "1";
            this.tsbView.Text = "View";
            this.tsbView.Visible = false;
            this.tsbView.Click += new System.EventHandler(this.TsbViewClick);
            // 
            // tsbManageTabs
            // 
            this.tsbManageTabs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllTabsToolStripMenuItem,
            this.closeAllTabsExceptActiveToolStripMenuItem});
            this.tsbManageTabs.Image = ((System.Drawing.Image)(resources.GetObject("tsbManageTabs.Image")));
            this.tsbManageTabs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbManageTabs.Name = "tsbManageTabs";
            this.tsbManageTabs.Size = new System.Drawing.Size(69, 24);
            this.tsbManageTabs.Text = "Tabs";
            // 
            // closeAllTabsToolStripMenuItem
            // 
            this.closeAllTabsToolStripMenuItem.Name = "closeAllTabsToolStripMenuItem";
            this.closeAllTabsToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.closeAllTabsToolStripMenuItem.Text = "Close all";
            this.closeAllTabsToolStripMenuItem.Click += new System.EventHandler(this.CloseAllTabsToolStripMenuItemClick);
            // 
            // closeAllTabsExceptActiveToolStripMenuItem
            // 
            this.closeAllTabsExceptActiveToolStripMenuItem.Name = "closeAllTabsExceptActiveToolStripMenuItem";
            this.closeAllTabsExceptActiveToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.closeAllTabsExceptActiveToolStripMenuItem.Text = "Close all except active tab";
            this.closeAllTabsExceptActiveToolStripMenuItem.Click += new System.EventHandler(this.CloseAllTabsExceptActiveToolStripMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(23, 24);
            this.tsbAbout.Text = "About";
            this.tsbAbout.Click += new System.EventHandler(this.TsbAboutClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportABugToolStripMenuItem,
            this.startADiscussionToolStripMenuItem,
            this.rateThisToolToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(100, 24);
            this.toolStripDropDownButton1.Text = "CodePlex";
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportABugToolStripMenuItem.Image")));
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.reportABugToolStripMenuItem.Text = "Report a bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.TsbReportBugClick);
            // 
            // startADiscussionToolStripMenuItem
            // 
            this.startADiscussionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startADiscussionToolStripMenuItem.Image")));
            this.startADiscussionToolStripMenuItem.Name = "startADiscussionToolStripMenuItem";
            this.startADiscussionToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.startADiscussionToolStripMenuItem.Text = "Start a discussion";
            this.startADiscussionToolStripMenuItem.Click += new System.EventHandler(this.TsbDiscussClick);
            // 
            // rateThisToolToolStripMenuItem
            // 
            this.rateThisToolToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rateThisToolToolStripMenuItem.Image")));
            this.rateThisToolToolStripMenuItem.Name = "rateThisToolToolStripMenuItem";
            this.rateThisToolToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.rateThisToolToolStripMenuItem.Text = "Rate this tool";
            this.rateThisToolToolStripMenuItem.Click += new System.EventHandler(this.TsbRateClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbDonate
            // 
            this.tsbDonate.Image = ((System.Drawing.Image)(resources.GetObject("tsbDonate.Image")));
            this.tsbDonate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDonate.Name = "tsbDonate";
            this.tsbDonate.Size = new System.Drawing.Size(78, 24);
            this.tsbDonate.Text = "Donate";
            this.tsbDonate.ToolTipText = "Make a donation using Paypal.\r\n\r\nSupport my work for the community by making a do" +
    "nation on Paypal.\r\n\r\nThank you!";
            this.tsbDonate.Click += new System.EventHandler(this.TsbDonateClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 753);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "ToolBox for Microsoft Dynamics CRM 2011";
            this.Load += new System.EventHandler(this.Form1Load);
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomePageTab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbDonate;
        private System.Windows.Forms.ToolStripDropDownButton tsbManageTabs;
        private System.Windows.Forms.ToolStripMenuItem closeAllTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllTabsExceptActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startADiscussionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateThisToolToolStripMenuItem;
    }
}
