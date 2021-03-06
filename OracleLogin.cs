using System;
using System.Windows.Forms;
using HdbPoet.Properties;
using System.Collections.Specialized;
namespace HdbPoet
{
    /// <summary>
    /// Summary description for OracleLogin.
    /// </summary>
    public class OracleLogin : System.Windows.Forms.Form
    {

        public OracleConnectionInfo ConnectionInfo;

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComboBox comboBoxHostList;
        private Label label3;
        private Button buttonEdit;
        private Label label4;
        private TextBox txtPort;
        private System.ComponentModel.IContainer components;

        public OracleLogin(string defaultHostname = "")
        {
            InitializeComponent();
            ConnectionInfo = new OracleConnectionInfo();
            LoadUserPrefs(defaultHostname);
        }


        void LoadUserPrefs(string defaultHostname = "")
        {
            //this.comboBoxHostList.Items.Clear();

            this.comboBoxHostList.DisplayMember = "ServicePrefix";
            this.comboBoxHostList.ValueMember = "Host";
            this.comboBoxHostList.DataSource = Settings.GetConnectionInfoList();
            //this.comboBoxHostList.Items.AddRange(Settings.GetServiceNames());



            if (comboBoxHostList.Items.Count > 0)
            {
                if (defaultHostname != "")
                {
                    this.comboBoxHostList.SelectedValue = defaultHostname;
                }
                else
                    if (Settings.Default.SelectedHdbHost.Trim() == "")
                    {
                        comboBoxHostList.SelectedIndex = 0;// select first as default
                    }
                    else
                    {
                        this.comboBoxHostList.SelectedValue = Settings.Default.SelectedHdbHost;
                    }
            }
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.comboBoxHostList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(295, 43);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 24);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(104, 48);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(295, 11);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 24);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "password:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "username:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HdbPoet.Properties.Settings.Default, "OracleUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUser.Location = new System.Drawing.Point(104, 16);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.Text = global::HdbPoet.Properties.Settings.Default.OracleUsername;
            // 
            // comboBoxHostList
            // 
            this.comboBoxHostList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHostList.FormattingEnabled = true;
            this.comboBoxHostList.Location = new System.Drawing.Point(101, 79);
            this.comboBoxHostList.Name = "comboBoxHostList";
            this.comboBoxHostList.Size = new System.Drawing.Size(157, 21);
            this.comboBoxHostList.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "database:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(258, 78);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(30, 22);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "...";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(101, 106);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "1521";
            // 
            // OracleLogin
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(373, 146);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxHostList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OracleLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Oracle Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {



            string servicePrefix = "";
            if (this.comboBoxHostList.SelectedValue != null)
            {
                servicePrefix = this.comboBoxHostList.SelectedValue.ToString();
            }

            ConnectionInfo = Settings.GetConnectionInfo(servicePrefix);
            ConnectionInfo.Username = this.textBoxUser.Text;
            ConnectionInfo.Password = this.textBoxPass.Text;

            Settings.Default.SelectedHdbHost = servicePrefix;
            if(string.IsNullOrEmpty(this.txtPort.Text))
                {
                    MessageBox.Show("You must enter a port number - Default is 1521", "HDB Poet");
                }
            else
                {
                    ConnectionInfo.Port = this.txtPort.Text;
                }
            

            Close();
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {

            EditStringCollection es = new EditStringCollection();
            StringCollection sc = Settings.Default.HdbServers;
            string[] items = new string[sc.Count];
            Settings.Default.HdbServers.CopyTo(items, 0);

            es.Items = items;
            if (es.ShowDialog() == DialogResult.OK)
            {
                sc.Clear();
                sc.AddRange(es.Items);
                LoadUserPrefs();
            }

        }
    }
}
