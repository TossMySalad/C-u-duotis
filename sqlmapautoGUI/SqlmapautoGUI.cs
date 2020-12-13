using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sqlmapautoLIB;

namespace sqlmapautoGUI
{
    public partial class SqlmapautoGUI : Form
    {
        private string _host = "193.219.91.103";
        private int _port = 8775;

        public SqlmapautoGUI()
        {
            InitializeComponent();
            this.ComboBoxFlushSession.SelectedItem = "No";
            this.ComboBoxScanLVL.SelectedItem = "1";
            this.ComboBoxScanRisk.SelectedItem = "Low";
            this.ComboBoxThreads.SelectedItem = "10";
            this.ComboBoxDBMS.SelectedItem = "Unknown";
            this.ComboBoxOS.SelectedItem = "Unknown";
            this.CheckedListBoxSQLiMethods.SetItemChecked(0, true);

            this.ListBoxLog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListBoxLog.MeasureItem += lst_MeasureItem;
            this.ListBoxLog.DrawItem += lst_DrawItem;
        }

        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(this.ListBoxLog.Items[e.Index].ToString(), 
                                                         this.ListBoxLog.Font, 
                                                         this.ListBoxLog.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(this.ListBoxLog.Items[e.Index].ToString(), 
                                  e.Font, 
                                  new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void sqlmapautoGUI_Load(object sender, EventArgs e)
        {

        }

        private void TabPageTechniqueDB_Click(object sender, EventArgs e)
        {

        }

        private void TabPageGeneral_Click(object sender, EventArgs e)
        {

        }

        private void LabelTargetURL_Click(object sender, EventArgs e)
        {

        }

        private void LabelFlushSession_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTargetURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxFlushSession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonScan_Click(object sender, EventArgs e)
        {
            this.ListBoxLog.Items.Clear();
            using (SqlmapManager mgr = new SqlmapManager(new SqlmapSession(_host, _port)))
            {
                string taskID = mgr.NewTask();

                Dictionary<string, object> options = mgr.GetOptions(taskID);
                SetOptions(options);

                mgr.StartTask(taskID, options);

                System.Timers.Timer t = new System.Timers.Timer();
                t.Interval = 10000;
                t.AutoReset = true;
                t.Elapsed += (sndr, ev) => TimerElapsed(sndr, ev, taskID);
                t.Start();
            }
        }

        private void TimerElapsed(Object obj, 
                                  ElapsedEventArgs e,
                                  string taskID)
        {
            using (SqlmapManager mgr = new SqlmapManager(new SqlmapSession(_host, _port)))
            {
                SqlmapStatus status = mgr.GetScanStatus(taskID);
                this.ListBoxLog.Invoke(new Action(delegate { this.ListBoxLog.Items.Add("The scan is " + status.Status + "."); }));
                if (status.Status == "terminated")
                {
                    System.Timers.Timer t = obj as System.Timers.Timer;
                    t.Stop();
                    WriteLog(mgr, taskID);
                    mgr.DeleteTask(taskID);
                }
            }
        }

        private void WriteLog(SqlmapManager mgr, string taskID)
        {
            List<SqlmapLogItem> logItems = mgr.GetLog(taskID);
            foreach (SqlmapLogItem item in logItems)
                this.ListBoxLog.Invoke(new Action(delegate { this.ListBoxLog.Items.Add(item.Message); }));
        }

        private void SetOptions(Dictionary<string, object> options)
        {
            options["url"] = this.TextBoxTargetURL.Text;
            options["flushSession"] = this.ComboBoxFlushSession.SelectedItem.ToString() == "No" ? false : true;

            options["technique"] = buildTechniqueString(options);

            options["level"] = this.ComboBoxScanLVL.SelectedItem.ToString();
            options["risk"] = mapRisk(this.ComboBoxScanRisk.SelectedItem.ToString());
            options["threads"] = this.ComboBoxThreads.SelectedItem.ToString();
            if(this.ComboBoxDBMS.SelectedItem.ToString() != "Unknown")
                options["dbms"] = this.ComboBoxDBMS.SelectedItem.ToString();
            if (this.ComboBoxOS.SelectedItem.ToString() != "Unknown")
                options["os"] = this.ComboBoxOS.SelectedItem.ToString();
            options["db"] = this.TextboxDatabases.Text;

            setOptionsOptions(options);
        }

        private string mapRisk(string risk)
        {
            switch(risk)
            {
                case "Low":
                    return "1";
                case "Medium":
                    return "2";
                default:
                    return "3";
            }
        }

        private string buildTechniqueString(Dictionary<string, object> opts)
        {
            StringBuilder technique = new StringBuilder("");
            bool exitLoop = false;
            foreach (var item in this.CheckedListBoxSQLiMethods.CheckedItems)
            {
                string tech = item.ToString();
                switch (tech)
                {
                    case "Test ALL!":
                        technique.Append("BEUSTQ");
                        exitLoop = true;
                        break;
                    case "Boolean Based Blind":
                        technique.Append("B");
                        break;
                    case "Error Based":
                        technique.Append("E");
                        break;
                    case "Inline Queries":
                        technique.Append("Q");
                        break;
                    case "Stacked Queries":
                        technique.Append("S");
                        break;
                    case "Time Based Blind":
                        technique.Append("T");
                        break;
                    case "Union Based":
                        technique.Append("U");
                        break;
                }
                if (exitLoop) break;
            }
            return technique.ToString();
        }

        private void setOptionsOptions(Dictionary<string, object> options)
        {
            foreach (var item in this.CheckedListBoxOptions.CheckedItems)
            {
                string opt = item.ToString();
                bool exit = false;
                switch (opt)
                {
                    case "Everything":
                        options["dumpAll"] = true;
                        exit = true;
                        break;
                    case "Banner":
                        options["getBanner"] = true;
                        break;
                    case "Current User":
                        options["getCurrentUser"] = true;
                        break;
                    case "Current Database":
                        options["getCurrentDb"] = true;
                        break;
                    case "Hostname":
                        options["getHostname"] = true;
                        break;
                    case "Detect if current user is DBA":
                        options["isDba"] = true;
                        break;
                    case "Users":
                        options["getUsers"] = true;
                        break;
                    case "User Password Hashes":
                        options["getPasswordHashes"] = true;
                        break;
                    case "User Privileges":
                        options["getPrivileges"] = true;
                        break;
                    case "User Roles":
                        options["getRoles"] = true;
                        break;
                    case "Databases":
                        options["getDbs"] = true;
                        break;
                    case "Tables":
                        options["getTables"] = true;
                        break;
                    case "Columns":
                        options["getColumns"] = true;
                        break;
                    case "Schema":
                        options["getSchema"] = true;
                        break;
                    case "Count":
                        options["getCount"] = true;
                        break;
                    case "Dump":
                        options["dumpTable"] = true;
                        break;
                    case "Dump All":
                        options["dumpAll"] = true;
                        break;
                }
                if (exit) return;
            }
        }

        private void CheckedListBoxSQLiMethods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelSQLiMethods_Click(object sender, EventArgs e)
        {

        }

        private void LabelOS_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxOS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelLog_Click_1(object sender, EventArgs e)
        {

        }

        private void LabelOptions_Click(object sender, EventArgs e)
        {

        }
    }
}
