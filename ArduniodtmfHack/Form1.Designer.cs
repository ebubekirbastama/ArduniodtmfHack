namespace ArduniodtmfHack
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxEx2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(9, 9);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 78);
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Connect";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(115, 9);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(112, 78);
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "Disconnect";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(233, 15);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(109, 20);
            this.comboBoxEx1.TabIndex = 2;
            // 
            // comboBoxEx2
            // 
            this.comboBoxEx2.DisplayMember = "Text";
            this.comboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx2.FormattingEnabled = true;
            this.comboBoxEx2.ItemHeight = 14;
            this.comboBoxEx2.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.comboBoxEx2.Location = new System.Drawing.Point(233, 41);
            this.comboBoxEx2.Name = "comboBoxEx2";
            this.comboBoxEx2.Size = new System.Drawing.Size(109, 20);
            this.comboBoxEx2.TabIndex = 3;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "4800";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "9600";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(247, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.reflectionLabel2);
            this.groupPanel2.Controls.Add(this.buttonX3);
            this.groupPanel2.Controls.Add(this.buttonX5);
            this.groupPanel2.Controls.Add(this.buttonX4);
            this.groupPanel2.Controls.Add(this.reflectionLabel1);
            this.groupPanel2.Controls.Add(this.textBoxX1);
            this.groupPanel2.Controls.Add(this.buttonX1);
            this.groupPanel2.Controls.Add(this.buttonX2);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.comboBoxEx1);
            this.groupPanel2.Controls.Add(this.comboBoxEx2);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(590, 396);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 7;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(477, 109);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(107, 47);
            this.buttonX3.TabIndex = 12;
            this.buttonX3.Text = "Open Telephone";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Location = new System.Drawing.Point(538, 41);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(37, 20);
            this.buttonX5.TabIndex = 11;
            this.buttonX5.Text = "clear";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(541, 0);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(43, 36);
            this.buttonX4.TabIndex = 10;
            this.buttonX4.Text = "X";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Location = new System.Drawing.Point(359, 9);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(178, 26);
            this.reflectionLabel1.TabIndex = 9;
            this.reflectionLabel1.Text = "<b><font size=\"+4\"><i>Password</i><font color=\"#B02B2C\"> decodering</font></font>" +
    "</b>";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(358, 41);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(179, 20);
            this.textBoxX1.TabIndex = 8;
            // 
            // reflectionLabel2
            // 
            this.reflectionLabel2.Location = new System.Drawing.Point(3, 162);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(581, 225);
            this.reflectionLabel2.TabIndex = 13;
            this.reflectionLabel2.Text = "<br/><b><font size=\"+4\"><i>Dtmf</i><font color=\"#B02B2C\"> Hacking</font></font></" +
    "b>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 396);
            this.Controls.Add(this.groupPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
    }
}

