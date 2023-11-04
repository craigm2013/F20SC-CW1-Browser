
namespace cm2013_F20SC_CW1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxHTML = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnHideHistory = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.listBoxBookmarks = new System.Windows.Forms.ListBox();
            this.btnHideBookmarks = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHomePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.contextMenuStripBookmark = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripBookmark.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(153, 27);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(809, 20);
            this.textBoxURL.TabIndex = 3;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // textBoxHTML
            // 
            this.textBoxHTML.Location = new System.Drawing.Point(12, 95);
            this.textBoxHTML.Multiline = true;
            this.textBoxHTML.Name = "textBoxHTML";
            this.textBoxHTML.ReadOnly = true;
            this.textBoxHTML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHTML.Size = new System.Drawing.Size(997, 477);
            this.textBoxHTML.TabIndex = 4;
            // 
            // toolTip
            // 
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipHome_Popup);
            // 
            // btnHideHistory
            // 
            this.btnHideHistory.Image = global::cm2013_F20SC_CW1.Properties.Resources.Cancel;
            this.btnHideHistory.Location = new System.Drawing.Point(475, 27);
            this.btnHideHistory.Name = "btnHideHistory";
            this.btnHideHistory.Size = new System.Drawing.Size(28, 26);
            this.btnHideHistory.TabIndex = 15;
            this.toolTip.SetToolTip(this.btnHideHistory, "Hide History Window");
            this.btnHideHistory.UseVisualStyleBackColor = true;
            this.btnHideHistory.Click += new System.EventHandler(this.btnHideHistory_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::cm2013_F20SC_CW1.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(968, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 43);
            this.btnSearch.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnSearch, "Load HTML ");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::cm2013_F20SC_CW1.Properties.Resources.Refresh;
            this.btnRefresh.Location = new System.Drawing.Point(106, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 43);
            this.btnRefresh.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnRefresh, "Refresh Page");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Image = global::cm2013_F20SC_CW1.Properties.Resources.ArrowRight2;
            this.btnNext.Location = new System.Drawing.Point(59, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 43);
            this.btnNext.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnNext, "Right");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Image = global::cm2013_F20SC_CW1.Properties.Resources.ArrowLeft2;
            this.btnPrev.Location = new System.Drawing.Point(12, 27);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(41, 42);
            this.btnPrev.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnPrev, "Back");
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // listBoxBookmarks
            // 
            this.listBoxBookmarks.FormattingEnabled = true;
            this.listBoxBookmarks.Location = new System.Drawing.Point(144, 27);
            this.listBoxBookmarks.Name = "listBoxBookmarks";
            this.listBoxBookmarks.Size = new System.Drawing.Size(359, 511);
            this.listBoxBookmarks.TabIndex = 16;
            this.toolTip.SetToolTip(this.listBoxBookmarks, "Double click to load URL\r\nSingle click for modify options");
            this.listBoxBookmarks.Visible = false;
            this.listBoxBookmarks.SelectedIndexChanged += new System.EventHandler(this.listBoxBookmarks_SelectedIndexChanged);
            this.listBoxBookmarks.DoubleClick += new System.EventHandler(this.listBoxBookmarks_DoubleClick);
            // 
            // btnHideBookmarks
            // 
            this.btnHideBookmarks.Image = global::cm2013_F20SC_CW1.Properties.Resources.Cancel;
            this.btnHideBookmarks.Location = new System.Drawing.Point(475, 27);
            this.btnHideBookmarks.Name = "btnHideBookmarks";
            this.btnHideBookmarks.Size = new System.Drawing.Size(28, 26);
            this.btnHideBookmarks.TabIndex = 17;
            this.toolTip.SetToolTip(this.btnHideBookmarks, "Hide bookmark window");
            this.btnHideBookmarks.UseVisualStyleBackColor = true;
            this.btnHideBookmarks.Visible = false;
            this.btnHideBookmarks.Click += new System.EventHandler(this.btnHideBookmarks_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(231, 50);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(731, 20);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(153, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "HTTP Status:";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.favouritesToolStripMenuItem,
            this.bookmarkPageToolStripMenuItem1,
            this.bulkDownloadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editHomeToolStripMenuItem,
            this.editHomePageToolStripMenuItem});
            this.homeToolStripMenuItem.Image = global::cm2013_F20SC_CW1.Properties.Resources.Home;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // editHomeToolStripMenuItem
            // 
            this.editHomeToolStripMenuItem.Name = "editHomeToolStripMenuItem";
            this.editHomeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editHomeToolStripMenuItem.Text = "Go to home page";
            this.editHomeToolStripMenuItem.ToolTipText = "Click to go to your designated homepage\r\n";
            this.editHomeToolStripMenuItem.Click += new System.EventHandler(this.editHomeToolStripMenuItem_Click);
            // 
            // editHomePageToolStripMenuItem
            // 
            this.editHomePageToolStripMenuItem.Name = "editHomePageToolStripMenuItem";
            this.editHomePageToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editHomePageToolStripMenuItem.Text = "Set home page";
            this.editHomePageToolStripMenuItem.ToolTipText = "Will use the current contents of the url text box to set as the new home page";
            this.editHomePageToolStripMenuItem.Click += new System.EventHandler(this.editHomePageToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = global::cm2013_F20SC_CW1.Properties.Resources.History;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.ToolTipText = "Show history";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.Image = global::cm2013_F20SC_CW1.Properties.Resources.Favourite;
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.favouritesToolStripMenuItem.Text = "Boomarks";
            this.favouritesToolStripMenuItem.Click += new System.EventHandler(this.favouritesToolStripMenuItem_Click);
            // 
            // bookmarkPageToolStripMenuItem1
            // 
            this.bookmarkPageToolStripMenuItem1.Name = "bookmarkPageToolStripMenuItem1";
            this.bookmarkPageToolStripMenuItem1.Size = new System.Drawing.Size(102, 20);
            this.bookmarkPageToolStripMenuItem1.Text = "Bookmark Page";
            this.bookmarkPageToolStripMenuItem1.Click += new System.EventHandler(this.bookmarkPageToolStripMenuItem1_Click);
            // 
            // bulkDownloadToolStripMenuItem
            // 
            this.bulkDownloadToolStripMenuItem.Name = "bulkDownloadToolStripMenuItem";
            this.bulkDownloadToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.bulkDownloadToolStripMenuItem.Text = "Bulk Download";
            this.bulkDownloadToolStripMenuItem.Click += new System.EventHandler(this.bulkDownloadToolStripMenuItem_Click_1);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(74, 27);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(429, 511);
            this.listBoxHistory.TabIndex = 13;
            this.listBoxHistory.Visible = false;
            this.listBoxHistory.SelectedIndexChanged += new System.EventHandler(this.listBoxHistory_DoubleClick);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 75);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(372, 20);
            this.textBoxTitle.TabIndex = 14;
            // 
            // contextMenuStripBookmark
            // 
            this.contextMenuStripBookmark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameBookmarkToolStripMenuItem,
            this.deleteBookmarkToolStripMenuItem});
            this.contextMenuStripBookmark.Name = "contextMenuStrip1";
            this.contextMenuStripBookmark.Size = new System.Drawing.Size(175, 48);
            // 
            // renameBookmarkToolStripMenuItem
            // 
            this.renameBookmarkToolStripMenuItem.Name = "renameBookmarkToolStripMenuItem";
            this.renameBookmarkToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.renameBookmarkToolStripMenuItem.Text = "Rename bookmark";
            this.renameBookmarkToolStripMenuItem.Click += new System.EventHandler(this.renameBookmarkToolStripMenuItem_Click);
            // 
            // deleteBookmarkToolStripMenuItem
            // 
            this.deleteBookmarkToolStripMenuItem.Name = "deleteBookmarkToolStripMenuItem";
            this.deleteBookmarkToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteBookmarkToolStripMenuItem.Text = "Delete bookmark";
            this.deleteBookmarkToolStripMenuItem.Click += new System.EventHandler(this.deleteBookmarkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 602);
            this.Controls.Add(this.btnHideBookmarks);
            this.Controls.Add(this.btnHideHistory);
            this.Controls.Add(this.listBoxBookmarks);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxHTML);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "cm2013 F20SC CW1 Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripBookmark.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxHTML;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHomePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button btnHideHistory;
        private System.Windows.Forms.ListBox listBoxBookmarks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBookmark;
        private System.Windows.Forms.ToolStripMenuItem renameBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookmarkToolStripMenuItem;
        private System.Windows.Forms.Button btnHideBookmarks;
        private System.Windows.Forms.ToolStripMenuItem bookmarkPageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bulkDownloadToolStripMenuItem;
    }
}

