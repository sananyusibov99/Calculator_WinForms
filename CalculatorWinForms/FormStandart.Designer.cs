namespace CalculatorWinForms
{
    partial class FormStandart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStandart));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtShow = new System.Windows.Forms.RichTextBox();
            this.btnDivSign = new System.Windows.Forms.Button();
            this.btnMultSign = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnMinusSign = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnEqualSign = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnPlusSign = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(289, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.programmerToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.viewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewToolStripMenuItem.Image")));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("standartToolStripMenuItem.Image")));
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standartToolStripMenuItem.Text = "Standart";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scientificToolStripMenuItem.Image")));
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.ScientificToolStripMenuItem_Click);
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("programmerToolStripMenuItem.Image")));
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmerToolStripMenuItem.Text = "Programmer";
            this.programmerToolStripMenuItem.Click += new System.EventHandler(this.ProgrammerToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statisticsToolStripMenuItem.Image")));
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.StatisticslaterToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // txtShow
            // 
            this.txtShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShow.Location = new System.Drawing.Point(3, 3);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(283, 94);
            this.txtShow.TabIndex = 4;
            this.txtShow.Text = "";
            // 
            // btnDivSign
            // 
            this.btnDivSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivSign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDivSign.Location = new System.Drawing.Point(231, 3);
            this.btnDivSign.Name = "btnDivSign";
            this.btnDivSign.Size = new System.Drawing.Size(55, 51);
            this.btnDivSign.TabIndex = 26;
            this.btnDivSign.Text = "/";
            this.btnDivSign.UseVisualStyleBackColor = true;
            this.btnDivSign.Click += new System.EventHandler(this.BtnDivSign_Click);
            // 
            // btnMultSign
            // 
            this.btnMultSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultSign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMultSign.Location = new System.Drawing.Point(174, 3);
            this.btnMultSign.Name = "btnMultSign";
            this.btnMultSign.Size = new System.Drawing.Size(51, 51);
            this.btnMultSign.TabIndex = 25;
            this.btnMultSign.Text = "*";
            this.btnMultSign.UseVisualStyleBackColor = true;
            this.btnMultSign.Click += new System.EventHandler(this.BtnMultSign_Click);
            // 
            // btnNumber9
            // 
            this.btnNumber9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber9.Location = new System.Drawing.Point(117, 3);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(51, 51);
            this.btnNumber9.TabIndex = 24;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnCE
            // 
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.Location = new System.Drawing.Point(231, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(55, 51);
            this.btnCE.TabIndex = 23;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // btnNumber6
            // 
            this.btnNumber6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber6.Location = new System.Drawing.Point(117, 3);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(51, 51);
            this.btnNumber6.TabIndex = 22;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnNumber8
            // 
            this.btnNumber8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber8.Location = new System.Drawing.Point(3, 3);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(51, 51);
            this.btnNumber8.TabIndex = 27;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnNumber5
            // 
            this.btnNumber5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber5.Location = new System.Drawing.Point(60, 3);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(51, 51);
            this.btnNumber5.TabIndex = 10;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackspace.Location = new System.Drawing.Point(117, 61);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(53, 53);
            this.btnBackspace.TabIndex = 19;
            this.btnBackspace.Text = "⌫";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // btnNumber7
            // 
            this.btnNumber7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber7.Location = new System.Drawing.Point(60, 3);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(51, 51);
            this.btnNumber7.TabIndex = 18;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnMinusSign
            // 
            this.btnMinusSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinusSign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinusSign.Location = new System.Drawing.Point(174, 3);
            this.btnMinusSign.Name = "btnMinusSign";
            this.btnMinusSign.Size = new System.Drawing.Size(51, 51);
            this.btnMinusSign.TabIndex = 17;
            this.btnMinusSign.Text = "-";
            this.btnMinusSign.UseVisualStyleBackColor = true;
            this.btnMinusSign.Click += new System.EventHandler(this.BtnMinusSign_Click);
            // 
            // btnNumber4
            // 
            this.btnNumber4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber4.Location = new System.Drawing.Point(3, 3);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNumber4.Size = new System.Drawing.Size(51, 51);
            this.btnNumber4.TabIndex = 16;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnNumber3
            // 
            this.btnNumber3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber3.Location = new System.Drawing.Point(117, 3);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(53, 52);
            this.btnNumber3.TabIndex = 15;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnEqualSign
            // 
            this.btnEqualSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqualSign.Location = new System.Drawing.Point(61, 3);
            this.btnEqualSign.Name = "btnEqualSign";
            this.btnEqualSign.Size = new System.Drawing.Size(52, 111);
            this.btnEqualSign.TabIndex = 14;
            this.btnEqualSign.Text = "=";
            this.btnEqualSign.UseVisualStyleBackColor = true;
            this.btnEqualSign.Click += new System.EventHandler(this.BtnEqualSign_Click);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber2.Location = new System.Drawing.Point(60, 3);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(51, 52);
            this.btnNumber2.TabIndex = 13;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnPlusSign
            // 
            this.btnPlusSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlusSign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlusSign.Location = new System.Drawing.Point(3, 3);
            this.btnPlusSign.Name = "btnPlusSign";
            this.btnPlusSign.Size = new System.Drawing.Size(52, 111);
            this.btnPlusSign.TabIndex = 12;
            this.btnPlusSign.Text = "+";
            this.btnPlusSign.UseVisualStyleBackColor = true;
            this.btnPlusSign.Click += new System.EventHandler(this.BtnPlusSign_Click);
            // 
            // btnNumber1
            // 
            this.btnNumber1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber1.Location = new System.Drawing.Point(3, 3);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(51, 52);
            this.btnNumber1.TabIndex = 11;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnComma
            // 
            this.btnComma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComma.Location = new System.Drawing.Point(60, 61);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(51, 53);
            this.btnComma.TabIndex = 20;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnNumber0
            // 
            this.btnNumber0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumber0.Location = new System.Drawing.Point(3, 61);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(51, 53);
            this.btnNumber0.TabIndex = 21;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            this.btnNumber0.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtShow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 331);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 231);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Controls.Add(this.btnDivSign, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnMultSign, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnNumber9, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnNumber7, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnNumber8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(289, 57);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.92647F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.07353F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 114);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(289, 117);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btnBackspace, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnComma, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnNumber0, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnNumber3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnNumber2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnNumber1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(173, 117);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnEqualSign, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPlusSign, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(173, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(116, 117);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Controls.Add(this.btnCE, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnNumber6, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnNumber5, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnMinusSign, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnNumber4, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(289, 57);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // FormStandart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 394);
            this.Name = "FormStandart";
            this.Text = "Standart";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtShow;
        private System.Windows.Forms.Button btnDivSign;
        private System.Windows.Forms.Button btnMultSign;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnMinusSign;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnEqualSign;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnPlusSign;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}