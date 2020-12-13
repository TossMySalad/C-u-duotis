namespace sqlmapautoGUI
{
    partial class SqlmapautoGUI
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
            this.TabControlApp = new System.Windows.Forms.TabControl();
            this.TabPageGeneral = new System.Windows.Forms.TabPage();
            this.LabelLog = new System.Windows.Forms.Label();
            this.ButtonScan = new System.Windows.Forms.Button();
            this.ComboBoxFlushSession = new System.Windows.Forms.ComboBox();
            this.LabelFlushSession = new System.Windows.Forms.Label();
            this.LabelTargetURL = new System.Windows.Forms.Label();
            this.TextBoxTargetURL = new System.Windows.Forms.TextBox();
            this.TabPageTechniqueDB = new System.Windows.Forms.TabPage();
            this.ButtonScan2 = new System.Windows.Forms.Button();
            this.ComboBoxOS = new System.Windows.Forms.ComboBox();
            this.LabelOS = new System.Windows.Forms.Label();
            this.ComboBoxDBMS = new System.Windows.Forms.ComboBox();
            this.LabelDBMS = new System.Windows.Forms.Label();
            this.ComboBoxThreads = new System.Windows.Forms.ComboBox();
            this.LabelThreads = new System.Windows.Forms.Label();
            this.ComboBoxScanRisk = new System.Windows.Forms.ComboBox();
            this.LabelScanRisk = new System.Windows.Forms.Label();
            this.ComboBoxScanLVL = new System.Windows.Forms.ComboBox();
            this.LabelScanLvl = new System.Windows.Forms.Label();
            this.LabelSQLiMethods = new System.Windows.Forms.Label();
            this.CheckedListBoxSQLiMethods = new System.Windows.Forms.CheckedListBox();
            this.TabPageEnumeration = new System.Windows.Forms.TabPage();
            this.LabelOptions = new System.Windows.Forms.Label();
            this.CheckedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.LabelDumpDBS = new System.Windows.Forms.Label();
            this.TextboxDatabases = new System.Windows.Forms.TextBox();
            this.ButtonScan3 = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.ListBoxLog = new System.Windows.Forms.ListBox();
            this.TabControlApp.SuspendLayout();
            this.TabPageGeneral.SuspendLayout();
            this.TabPageTechniqueDB.SuspendLayout();
            this.TabPageEnumeration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlApp
            // 
            this.TabControlApp.Controls.Add(this.TabPageGeneral);
            this.TabControlApp.Controls.Add(this.TabPageTechniqueDB);
            this.TabControlApp.Controls.Add(this.TabPageEnumeration);
            this.TabControlApp.Location = new System.Drawing.Point(1, 0);
            this.TabControlApp.Name = "TabControlApp";
            this.TabControlApp.SelectedIndex = 0;
            this.TabControlApp.Size = new System.Drawing.Size(477, 594);
            this.TabControlApp.TabIndex = 0;
            // 
            // TabPageGeneral
            // 
            this.TabPageGeneral.Controls.Add(this.ListBoxLog);
            this.TabPageGeneral.Controls.Add(this.LabelLog);
            this.TabPageGeneral.Controls.Add(this.ButtonScan);
            this.TabPageGeneral.Controls.Add(this.ComboBoxFlushSession);
            this.TabPageGeneral.Controls.Add(this.LabelFlushSession);
            this.TabPageGeneral.Controls.Add(this.LabelTargetURL);
            this.TabPageGeneral.Controls.Add(this.TextBoxTargetURL);
            this.TabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.TabPageGeneral.Name = "TabPageGeneral";
            this.TabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageGeneral.Size = new System.Drawing.Size(469, 568);
            this.TabPageGeneral.TabIndex = 0;
            this.TabPageGeneral.Text = "General";
            this.TabPageGeneral.UseVisualStyleBackColor = true;
            this.TabPageGeneral.Click += new System.EventHandler(this.TabPageGeneral_Click);
            // 
            // LabelLog
            // 
            this.LabelLog.AutoSize = true;
            this.LabelLog.Location = new System.Drawing.Point(24, 152);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(28, 13);
            this.LabelLog.TabIndex = 7;
            this.LabelLog.Text = "Log:";
            this.LabelLog.Click += new System.EventHandler(this.LabelLog_Click_1);
            // 
            // ButtonScan
            // 
            this.ButtonScan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonScan.Location = new System.Drawing.Point(180, 530);
            this.ButtonScan.Name = "ButtonScan";
            this.ButtonScan.Size = new System.Drawing.Size(113, 23);
            this.ButtonScan.TabIndex = 5;
            this.ButtonScan.Text = "Run sqlmap Scan";
            this.ButtonScan.UseVisualStyleBackColor = true;
            this.ButtonScan.Click += new System.EventHandler(this.ButtonScan_Click);
            // 
            // ComboBoxFlushSession
            // 
            this.ComboBoxFlushSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFlushSession.FormattingEnabled = true;
            this.ComboBoxFlushSession.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ComboBoxFlushSession.Location = new System.Drawing.Point(27, 98);
            this.ComboBoxFlushSession.Name = "ComboBoxFlushSession";
            this.ComboBoxFlushSession.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFlushSession.TabIndex = 4;
            this.ComboBoxFlushSession.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFlushSession_SelectedIndexChanged);
            // 
            // LabelFlushSession
            // 
            this.LabelFlushSession.AutoSize = true;
            this.LabelFlushSession.Location = new System.Drawing.Point(24, 82);
            this.LabelFlushSession.Name = "LabelFlushSession";
            this.LabelFlushSession.Size = new System.Drawing.Size(135, 13);
            this.LabelFlushSession.TabIndex = 3;
            this.LabelFlushSession.Text = "Flush Existing Session Info:";
            this.LabelFlushSession.Click += new System.EventHandler(this.LabelFlushSession_Click);
            // 
            // LabelTargetURL
            // 
            this.LabelTargetURL.AutoSize = true;
            this.LabelTargetURL.Location = new System.Drawing.Point(24, 35);
            this.LabelTargetURL.Name = "LabelTargetURL";
            this.LabelTargetURL.Size = new System.Drawing.Size(66, 13);
            this.LabelTargetURL.TabIndex = 1;
            this.LabelTargetURL.Text = "Target URL:";
            this.LabelTargetURL.Click += new System.EventHandler(this.LabelTargetURL_Click);
            // 
            // TextBoxTargetURL
            // 
            this.TextBoxTargetURL.Location = new System.Drawing.Point(27, 51);
            this.TextBoxTargetURL.Name = "TextBoxTargetURL";
            this.TextBoxTargetURL.Size = new System.Drawing.Size(416, 20);
            this.TextBoxTargetURL.TabIndex = 0;
            this.TextBoxTargetURL.TextChanged += new System.EventHandler(this.TextBoxTargetURL_TextChanged);
            // 
            // TabPageTechniqueDB
            // 
            this.TabPageTechniqueDB.Controls.Add(this.ButtonScan2);
            this.TabPageTechniqueDB.Controls.Add(this.ComboBoxOS);
            this.TabPageTechniqueDB.Controls.Add(this.LabelOS);
            this.TabPageTechniqueDB.Controls.Add(this.ComboBoxDBMS);
            this.TabPageTechniqueDB.Controls.Add(this.LabelDBMS);
            this.TabPageTechniqueDB.Controls.Add(this.ComboBoxThreads);
            this.TabPageTechniqueDB.Controls.Add(this.LabelThreads);
            this.TabPageTechniqueDB.Controls.Add(this.ComboBoxScanRisk);
            this.TabPageTechniqueDB.Controls.Add(this.LabelScanRisk);
            this.TabPageTechniqueDB.Controls.Add(this.ComboBoxScanLVL);
            this.TabPageTechniqueDB.Controls.Add(this.LabelScanLvl);
            this.TabPageTechniqueDB.Controls.Add(this.LabelSQLiMethods);
            this.TabPageTechniqueDB.Controls.Add(this.CheckedListBoxSQLiMethods);
            this.TabPageTechniqueDB.Location = new System.Drawing.Point(4, 22);
            this.TabPageTechniqueDB.Name = "TabPageTechniqueDB";
            this.TabPageTechniqueDB.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTechniqueDB.Size = new System.Drawing.Size(469, 568);
            this.TabPageTechniqueDB.TabIndex = 1;
            this.TabPageTechniqueDB.Text = "Technique & Database";
            this.TabPageTechniqueDB.UseVisualStyleBackColor = true;
            this.TabPageTechniqueDB.Click += new System.EventHandler(this.TabPageTechniqueDB_Click);
            // 
            // ButtonScan2
            // 
            this.ButtonScan2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonScan2.Location = new System.Drawing.Point(180, 530);
            this.ButtonScan2.Name = "ButtonScan2";
            this.ButtonScan2.Size = new System.Drawing.Size(113, 23);
            this.ButtonScan2.TabIndex = 16;
            this.ButtonScan2.Text = "Run sqlmap Scan";
            this.ButtonScan2.UseVisualStyleBackColor = true;
            // 
            // ComboBoxOS
            // 
            this.ComboBoxOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOS.FormattingEnabled = true;
            this.ComboBoxOS.Items.AddRange(new object[] {
            "Unknown",
            "Linux",
            "Windows"});
            this.ComboBoxOS.Location = new System.Drawing.Point(27, 461);
            this.ComboBoxOS.Name = "ComboBoxOS";
            this.ComboBoxOS.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxOS.TabIndex = 15;
            this.ComboBoxOS.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOS_SelectedIndexChanged);
            // 
            // LabelOS
            // 
            this.LabelOS.AutoSize = true;
            this.LabelOS.Location = new System.Drawing.Point(24, 445);
            this.LabelOS.Name = "LabelOS";
            this.LabelOS.Size = new System.Drawing.Size(71, 13);
            this.LabelOS.TabIndex = 14;
            this.LabelOS.Text = "Backend OS:";
            this.LabelOS.Click += new System.EventHandler(this.LabelOS_Click);
            // 
            // ComboBoxDBMS
            // 
            this.ComboBoxDBMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDBMS.FormattingEnabled = true;
            this.ComboBoxDBMS.Items.AddRange(new object[] {
            "Unknown",
            "MySQL",
            "Oracle",
            "PostgreSQL",
            "Microsoft SQL Server",
            "Microsoft Access",
            "IBM DB2",
            "SQLite",
            "Firebird",
            "Sybase",
            "SAP MaxDB",
            "Informix",
            "MariaDB",
            "Percona",
            "MemSQL",
            "TiDB",
            "CockroachDB",
            "HSQLDB",
            "H2",
            "MonetDB",
            "Apache Derby",
            "Amazon Redshift",
            "Vertica",
            "Mckoi",
            "Presto",
            "Altibase",
            "MimerSQL",
            "CrateDB",
            "Greenplum",
            "Drizzle",
            "Apache Ignite",
            "Cubrid",
            "InterSystems Cache",
            "IRIS",
            "eXtremeDB",
            "FrontBase"});
            this.ComboBoxDBMS.Location = new System.Drawing.Point(27, 407);
            this.ComboBoxDBMS.Name = "ComboBoxDBMS";
            this.ComboBoxDBMS.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxDBMS.TabIndex = 13;
            // 
            // LabelDBMS
            // 
            this.LabelDBMS.AutoSize = true;
            this.LabelDBMS.Location = new System.Drawing.Point(24, 391);
            this.LabelDBMS.Name = "LabelDBMS";
            this.LabelDBMS.Size = new System.Drawing.Size(87, 13);
            this.LabelDBMS.TabIndex = 12;
            this.LabelDBMS.Text = "Backend DBMS:";
            // 
            // ComboBoxThreads
            // 
            this.ComboBoxThreads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxThreads.FormattingEnabled = true;
            this.ComboBoxThreads.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBoxThreads.Location = new System.Drawing.Point(27, 352);
            this.ComboBoxThreads.Name = "ComboBoxThreads";
            this.ComboBoxThreads.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxThreads.TabIndex = 11;
            // 
            // LabelThreads
            // 
            this.LabelThreads.AutoSize = true;
            this.LabelThreads.Location = new System.Drawing.Point(24, 336);
            this.LabelThreads.Name = "LabelThreads";
            this.LabelThreads.Size = new System.Drawing.Size(46, 13);
            this.LabelThreads.TabIndex = 10;
            this.LabelThreads.Text = "Threads";
            // 
            // ComboBoxScanRisk
            // 
            this.ComboBoxScanRisk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxScanRisk.FormattingEnabled = true;
            this.ComboBoxScanRisk.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.ComboBoxScanRisk.Location = new System.Drawing.Point(27, 301);
            this.ComboBoxScanRisk.Name = "ComboBoxScanRisk";
            this.ComboBoxScanRisk.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxScanRisk.TabIndex = 9;
            // 
            // LabelScanRisk
            // 
            this.LabelScanRisk.AutoSize = true;
            this.LabelScanRisk.Location = new System.Drawing.Point(24, 285);
            this.LabelScanRisk.Name = "LabelScanRisk";
            this.LabelScanRisk.Size = new System.Drawing.Size(59, 13);
            this.LabelScanRisk.TabIndex = 8;
            this.LabelScanRisk.Text = "Scan Risk:";
            // 
            // ComboBoxScanLVL
            // 
            this.ComboBoxScanLVL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxScanLVL.FormattingEnabled = true;
            this.ComboBoxScanLVL.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ComboBoxScanLVL.Location = new System.Drawing.Point(27, 250);
            this.ComboBoxScanLVL.Name = "ComboBoxScanLVL";
            this.ComboBoxScanLVL.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxScanLVL.TabIndex = 7;
            // 
            // LabelScanLvl
            // 
            this.LabelScanLvl.AutoSize = true;
            this.LabelScanLvl.Location = new System.Drawing.Point(24, 234);
            this.LabelScanLvl.Name = "LabelScanLvl";
            this.LabelScanLvl.Size = new System.Drawing.Size(64, 13);
            this.LabelScanLvl.TabIndex = 6;
            this.LabelScanLvl.Text = "Scan Level:";
            // 
            // LabelSQLiMethods
            // 
            this.LabelSQLiMethods.AutoSize = true;
            this.LabelSQLiMethods.Location = new System.Drawing.Point(24, 54);
            this.LabelSQLiMethods.Name = "LabelSQLiMethods";
            this.LabelSQLiMethods.Size = new System.Drawing.Size(146, 13);
            this.LabelSQLiMethods.TabIndex = 5;
            this.LabelSQLiMethods.Text = "Select SQLi Methods to Test:";
            this.LabelSQLiMethods.Click += new System.EventHandler(this.LabelSQLiMethods_Click);
            // 
            // CheckedListBoxSQLiMethods
            // 
            this.CheckedListBoxSQLiMethods.CheckOnClick = true;
            this.CheckedListBoxSQLiMethods.FormattingEnabled = true;
            this.CheckedListBoxSQLiMethods.Items.AddRange(new object[] {
            "Test ALL!",
            "Boolean Based Blind",
            "Error Based",
            "Inline Queries",
            "Stacked Queries",
            "Time Based Blind",
            "Union Based"});
            this.CheckedListBoxSQLiMethods.Location = new System.Drawing.Point(27, 70);
            this.CheckedListBoxSQLiMethods.Name = "CheckedListBoxSQLiMethods";
            this.CheckedListBoxSQLiMethods.Size = new System.Drawing.Size(416, 109);
            this.CheckedListBoxSQLiMethods.TabIndex = 4;
            this.CheckedListBoxSQLiMethods.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxSQLiMethods_SelectedIndexChanged);
            // 
            // TabPageEnumeration
            // 
            this.TabPageEnumeration.Controls.Add(this.LabelOptions);
            this.TabPageEnumeration.Controls.Add(this.CheckedListBoxOptions);
            this.TabPageEnumeration.Controls.Add(this.LabelDumpDBS);
            this.TabPageEnumeration.Controls.Add(this.TextboxDatabases);
            this.TabPageEnumeration.Controls.Add(this.ButtonScan3);
            this.TabPageEnumeration.Location = new System.Drawing.Point(4, 22);
            this.TabPageEnumeration.Name = "TabPageEnumeration";
            this.TabPageEnumeration.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEnumeration.Size = new System.Drawing.Size(469, 568);
            this.TabPageEnumeration.TabIndex = 2;
            this.TabPageEnumeration.Text = "Enumeration";
            this.TabPageEnumeration.UseVisualStyleBackColor = true;
            // 
            // LabelOptions
            // 
            this.LabelOptions.AutoSize = true;
            this.LabelOptions.Location = new System.Drawing.Point(24, 198);
            this.LabelOptions.Name = "LabelOptions";
            this.LabelOptions.Size = new System.Drawing.Size(46, 13);
            this.LabelOptions.TabIndex = 21;
            this.LabelOptions.Text = "Options:";
            this.LabelOptions.Click += new System.EventHandler(this.LabelOptions_Click);
            // 
            // CheckedListBoxOptions
            // 
            this.CheckedListBoxOptions.CheckOnClick = true;
            this.CheckedListBoxOptions.FormattingEnabled = true;
            this.CheckedListBoxOptions.Items.AddRange(new object[] {
            "Everything",
            "Banner",
            "Current User",
            "Current Database",
            "Hostname",
            "Detect if current user is DBA",
            "Users",
            "User Password Hashes",
            "User Privileges",
            "User Roles",
            "Databases",
            "Tables",
            "Columns",
            "Schema",
            "Count",
            "Dump",
            "Dump All"});
            this.CheckedListBoxOptions.Location = new System.Drawing.Point(27, 214);
            this.CheckedListBoxOptions.Name = "CheckedListBoxOptions";
            this.CheckedListBoxOptions.Size = new System.Drawing.Size(416, 274);
            this.CheckedListBoxOptions.TabIndex = 20;
            // 
            // LabelDumpDBS
            // 
            this.LabelDumpDBS.AutoSize = true;
            this.LabelDumpDBS.Location = new System.Drawing.Point(24, 35);
            this.LabelDumpDBS.Name = "LabelDumpDBS";
            this.LabelDumpDBS.Size = new System.Drawing.Size(127, 13);
            this.LabelDumpDBS.TabIndex = 19;
            this.LabelDumpDBS.Text = "Databases to Enumerate:";
            // 
            // TextboxDatabases
            // 
            this.TextboxDatabases.Location = new System.Drawing.Point(27, 51);
            this.TextboxDatabases.Name = "TextboxDatabases";
            this.TextboxDatabases.Size = new System.Drawing.Size(416, 20);
            this.TextboxDatabases.TabIndex = 18;
            // 
            // ButtonScan3
            // 
            this.ButtonScan3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonScan3.Location = new System.Drawing.Point(180, 530);
            this.ButtonScan3.Name = "ButtonScan3";
            this.ButtonScan3.Size = new System.Drawing.Size(113, 23);
            this.ButtonScan3.TabIndex = 17;
            this.ButtonScan3.Text = "Run sqlmap Scan";
            this.ButtonScan3.UseVisualStyleBackColor = true;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // ListBoxLog
            // 
            this.ListBoxLog.FormattingEnabled = true;
            this.ListBoxLog.Location = new System.Drawing.Point(27, 168);
            this.ListBoxLog.Name = "ListBoxLog";
            this.ListBoxLog.Size = new System.Drawing.Size(416, 342);
            this.ListBoxLog.TabIndex = 8;
            // 
            // SqlmapautoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 594);
            this.Controls.Add(this.TabControlApp);
            this.Name = "SqlmapautoGUI";
            this.Text = "sqlmapautoGUI";
            this.TabControlApp.ResumeLayout(false);
            this.TabPageGeneral.ResumeLayout(false);
            this.TabPageGeneral.PerformLayout();
            this.TabPageTechniqueDB.ResumeLayout(false);
            this.TabPageTechniqueDB.PerformLayout();
            this.TabPageEnumeration.ResumeLayout(false);
            this.TabPageEnumeration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlApp;
        private System.Windows.Forms.TabPage TabPageGeneral;
        private System.Windows.Forms.TabPage TabPageTechniqueDB;
        private System.Windows.Forms.Label LabelTargetURL;
        private System.Windows.Forms.TextBox TextBoxTargetURL;
        private System.Windows.Forms.TabPage TabPageEnumeration;
        private System.Windows.Forms.Label LabelFlushSession;
        private System.Windows.Forms.ComboBox ComboBoxFlushSession;
        private System.Windows.Forms.Button ButtonScan;
        private System.Windows.Forms.CheckedListBox CheckedListBoxSQLiMethods;
        private System.Windows.Forms.Label LabelSQLiMethods;
        private System.Windows.Forms.ComboBox ComboBoxOS;
        private System.Windows.Forms.Label LabelOS;
        private System.Windows.Forms.ComboBox ComboBoxDBMS;
        private System.Windows.Forms.Label LabelDBMS;
        private System.Windows.Forms.ComboBox ComboBoxThreads;
        private System.Windows.Forms.Label LabelThreads;
        private System.Windows.Forms.ComboBox ComboBoxScanRisk;
        private System.Windows.Forms.Label LabelScanRisk;
        private System.Windows.Forms.ComboBox ComboBoxScanLVL;
        private System.Windows.Forms.Label LabelScanLvl;
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.Button ButtonScan2;
        private System.Windows.Forms.Label LabelOptions;
        private System.Windows.Forms.CheckedListBox CheckedListBoxOptions;
        private System.Windows.Forms.Label LabelDumpDBS;
        private System.Windows.Forms.TextBox TextboxDatabases;
        private System.Windows.Forms.Button ButtonScan3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Diagnostics.EventLog eventLog2;
        private System.Windows.Forms.ListBox ListBoxLog;
    }
}

