namespace WindowsFormsApp1
{
    partial class WarehouseForm
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
            this.zoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCurX = new System.Windows.Forms.TextBox();
            this.txtCurY = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCurNo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFieldRemove = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnRemoveField = new System.Windows.Forms.Button();
            this.wpx = new System.Windows.Forms.TextBox();
            this.wpy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rotate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddField = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemovePackage = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Field_add = new System.Windows.Forms.Button();
            this.px = new System.Windows.Forms.TextBox();
            this.py = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMovePackage = new System.Windows.Forms.Button();
            this.To = new System.Windows.Forms.GroupBox();
            this.txtToX = new System.Windows.Forms.TextBox();
            this.txtToY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtToNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.GroupBox();
            this.txtFromX = new System.Windows.Forms.TextBox();
            this.txtFromY = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFromNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.To.SuspendLayout();
            this.From.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoom
            // 
            this.zoom.Location = new System.Drawing.Point(98, 29);
            this.zoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(67, 26);
            this.zoom.TabIndex = 1;
            this.zoom.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom(%):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCurX);
            this.groupBox1.Controls.Add(this.txtCurY);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtCurNo);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.change);
            this.groupBox1.Controls.Add(this.zoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(177, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // txtCurX
            // 
            this.txtCurX.Location = new System.Drawing.Point(98, 102);
            this.txtCurX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurX.Name = "txtCurX";
            this.txtCurX.Size = new System.Drawing.Size(58, 26);
            this.txtCurX.TabIndex = 21;
            // 
            // txtCurY
            // 
            this.txtCurY.Location = new System.Drawing.Point(98, 132);
            this.txtCurY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurY.Name = "txtCurY";
            this.txtCurY.Size = new System.Drawing.Size(58, 26);
            this.txtCurY.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 106);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 19;
            this.label19.Text = "Pos X:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 137);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 20);
            this.label21.TabIndex = 18;
            this.label21.Text = "Pos Y: ";
            // 
            // txtCurNo
            // 
            this.txtCurNo.Location = new System.Drawing.Point(98, 163);
            this.txtCurNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurNo.Name = "txtCurNo";
            this.txtCurNo.Size = new System.Drawing.Size(58, 26);
            this.txtCurNo.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 166);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "No: ";
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(28, 63);
            this.change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(112, 35);
            this.change.TabIndex = 3;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFieldRemove);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.btnRemoveField);
            this.groupBox2.Controls.Add(this.wpx);
            this.groupBox2.Controls.Add(this.wpy);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.rotate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAddField);
            this.groupBox2.Controls.Add(this.width);
            this.groupBox2.Controls.Add(this.height);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(204, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(352, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Warehouse";
            // 
            // txtFieldRemove
            // 
            this.txtFieldRemove.Location = new System.Drawing.Point(256, 109);
            this.txtFieldRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFieldRemove.Name = "txtFieldRemove";
            this.txtFieldRemove.Size = new System.Drawing.Size(58, 26);
            this.txtFieldRemove.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(186, 112);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 20);
            this.label23.TabIndex = 20;
            this.label23.Text = "Field:";
            // 
            // btnRemoveField
            // 
            this.btnRemoveField.Location = new System.Drawing.Point(190, 152);
            this.btnRemoveField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.Size = new System.Drawing.Size(135, 34);
            this.btnRemoveField.TabIndex = 19;
            this.btnRemoveField.Text = "Remove";
            this.btnRemoveField.UseVisualStyleBackColor = true;
            this.btnRemoveField.Click += new System.EventHandler(this.btnRemoveField_Click);
            // 
            // wpx
            // 
            this.wpx.Location = new System.Drawing.Point(84, 28);
            this.wpx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wpx.Name = "wpx";
            this.wpx.Size = new System.Drawing.Size(58, 26);
            this.wpx.TabIndex = 18;
            // 
            // wpy
            // 
            this.wpy.Location = new System.Drawing.Point(84, 67);
            this.wpy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wpy.Name = "wpy";
            this.wpy.Size = new System.Drawing.Size(58, 26);
            this.wpy.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pos Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Pos X:";
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(84, 109);
            this.rotate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(58, 26);
            this.rotate.TabIndex = 14;
            this.rotate.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rotate:";
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(18, 152);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(140, 34);
            this.btnAddField.TabIndex = 4;
            this.btnAddField.Text = "Add";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(256, 69);
            this.width.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(58, 26);
            this.width.TabIndex = 3;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(256, 29);
            this.height.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(58, 26);
            this.height.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemovePackage);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Field_add);
            this.groupBox3.Controls.Add(this.px);
            this.groupBox3.Controls.Add(this.py);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.type);
            this.groupBox3.Controls.Add(this.no);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(574, 45);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(512, 197);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Field";
            // 
            // btnRemovePackage
            // 
            this.btnRemovePackage.Location = new System.Drawing.Point(306, 152);
            this.btnRemovePackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemovePackage.Name = "btnRemovePackage";
            this.btnRemovePackage.Size = new System.Drawing.Size(135, 34);
            this.btnRemovePackage.TabIndex = 17;
            this.btnRemovePackage.Text = "Remove";
            this.btnRemovePackage.UseVisualStyleBackColor = true;
            this.btnRemovePackage.Click += new System.EventHandler(this.btnRemovePackage_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(98, 135);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 26);
            this.txtPrice.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Price";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(98, 103);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(178, 26);
            this.txtDate.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Date:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(260, 68);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 26);
            this.txtID.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "ID:";
            // 
            // Field_add
            // 
            this.Field_add.Location = new System.Drawing.Point(306, 106);
            this.Field_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Field_add.Name = "Field_add";
            this.Field_add.Size = new System.Drawing.Size(135, 34);
            this.Field_add.TabIndex = 10;
            this.Field_add.Text = "Add";
            this.Field_add.UseVisualStyleBackColor = true;
            this.Field_add.Click += new System.EventHandler(this.Field_add_Click);
            // 
            // px
            // 
            this.px.Location = new System.Drawing.Point(102, 25);
            this.px.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.px.Name = "px";
            this.px.Size = new System.Drawing.Size(58, 26);
            this.px.TabIndex = 9;
            // 
            // py
            // 
            this.py.Location = new System.Drawing.Point(260, 28);
            this.py.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.py.Name = "py";
            this.py.Size = new System.Drawing.Size(58, 26);
            this.py.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pos X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pos Y: ";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(102, 63);
            this.type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(58, 26);
            this.type.TabIndex = 5;
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(400, 31);
            this.no.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(58, 26);
            this.no.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "No: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Location = new System.Drawing.Point(444, 245);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1075, 583);
            this.panel.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMovePackage);
            this.groupBox4.Controls.Add(this.To);
            this.groupBox4.Controls.Add(this.From);
            this.groupBox4.Location = new System.Drawing.Point(1106, 45);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(416, 197);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Move Package";
            // 
            // btnMovePackage
            // 
            this.btnMovePackage.Location = new System.Drawing.Point(130, 158);
            this.btnMovePackage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMovePackage.Name = "btnMovePackage";
            this.btnMovePackage.Size = new System.Drawing.Size(135, 34);
            this.btnMovePackage.TabIndex = 12;
            this.btnMovePackage.Text = "Move";
            this.btnMovePackage.UseVisualStyleBackColor = true;
            this.btnMovePackage.Click += new System.EventHandler(this.btnMovePackage_Click);
            // 
            // To
            // 
            this.To.Controls.Add(this.txtToX);
            this.To.Controls.Add(this.txtToY);
            this.To.Controls.Add(this.label14);
            this.To.Controls.Add(this.label15);
            this.To.Controls.Add(this.txtToNo);
            this.To.Controls.Add(this.label16);
            this.To.Location = new System.Drawing.Point(242, 28);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(159, 129);
            this.To.TabIndex = 11;
            this.To.TabStop = false;
            this.To.Text = "To";
            // 
            // txtToX
            // 
            this.txtToX.Location = new System.Drawing.Point(92, 12);
            this.txtToX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToX.Name = "txtToX";
            this.txtToX.Size = new System.Drawing.Size(58, 26);
            this.txtToX.TabIndex = 15;
            // 
            // txtToY
            // 
            this.txtToY.Location = new System.Drawing.Point(92, 52);
            this.txtToY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToY.Name = "txtToY";
            this.txtToY.Size = new System.Drawing.Size(58, 26);
            this.txtToY.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Pos X:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Pos Y: ";
            // 
            // txtToNo
            // 
            this.txtToNo.Location = new System.Drawing.Point(92, 95);
            this.txtToNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToNo.Name = "txtToNo";
            this.txtToNo.Size = new System.Drawing.Size(58, 26);
            this.txtToNo.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 95);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "No: ";
            // 
            // From
            // 
            this.From.Controls.Add(this.txtFromX);
            this.From.Controls.Add(this.txtFromY);
            this.From.Controls.Add(this.label17);
            this.From.Controls.Add(this.label18);
            this.From.Controls.Add(this.txtFromNo);
            this.From.Controls.Add(this.label20);
            this.From.Location = new System.Drawing.Point(27, 28);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(159, 129);
            this.From.TabIndex = 10;
            this.From.TabStop = false;
            this.From.Text = "From";
            // 
            // txtFromX
            // 
            this.txtFromX.Location = new System.Drawing.Point(92, 12);
            this.txtFromX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFromX.Name = "txtFromX";
            this.txtFromX.Size = new System.Drawing.Size(58, 26);
            this.txtFromX.TabIndex = 15;
            // 
            // txtFromY
            // 
            this.txtFromY.Location = new System.Drawing.Point(92, 52);
            this.txtFromY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFromY.Name = "txtFromY";
            this.txtFromY.Size = new System.Drawing.Size(58, 26);
            this.txtFromY.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Pos X:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 55);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Pos Y: ";
            // 
            // txtFromNo
            // 
            this.txtFromNo.Location = new System.Drawing.Point(92, 95);
            this.txtFromNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFromNo.Name = "txtFromNo";
            this.txtFromNo.Size = new System.Drawing.Size(58, 26);
            this.txtFromNo.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 95);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 20);
            this.label20.TabIndex = 10;
            this.label20.Text = "No: ";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 2);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(106, 37);
            this.btnFile.TabIndex = 12;
            this.btnFile.Text = "Open";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(258, 114);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 30;
            this.button4.Text = "&Reconnect";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(291, 75);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 24);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Client";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(196, 75);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 24);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Server";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(114, 74);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(58, 26);
            this.textBox7.TabIndex = 27;
            this.textBox7.Text = "8000";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(321, 35);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(58, 26);
            this.textBox6.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(252, 35);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(58, 26);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 35);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(58, 26);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 35);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 26);
            this.textBox3.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(136, 114);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "&Disconnect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(15, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "&Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(62, 78);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 20);
            this.label24.TabIndex = 20;
            this.label24.Text = "Port:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 40);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 20);
            this.label25.TabIndex = 18;
            this.label25.Text = "IP address:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Location = new System.Drawing.Point(18, 248);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(418, 580);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sync";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(10, 446);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 31);
            this.button5.TabIndex = 34;
            this.button5.Text = "Cl&ear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(288, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "&Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(10, 488);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 74);
            this.panel2.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(392, 74);
            this.textBox2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(10, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 265);
            this.panel1.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(393, 265);
            this.textBox1.TabIndex = 2;
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 845);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WarehouseForm";
            this.Text = "WareHouse Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.To.ResumeLayout(false);
            this.To.PerformLayout();
            this.From.ResumeLayout(false);
            this.From.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox zoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Field_add;
        private System.Windows.Forms.TextBox px;
        private System.Windows.Forms.TextBox py;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rotate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox wpx;
        private System.Windows.Forms.TextBox wpy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRemoveField;
        private System.Windows.Forms.Button btnRemovePackage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMovePackage;
        private System.Windows.Forms.GroupBox To;
        private System.Windows.Forms.TextBox txtToX;
        private System.Windows.Forms.TextBox txtToY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtToNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox From;
        private System.Windows.Forms.TextBox txtFromX;
        private System.Windows.Forms.TextBox txtFromY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFromNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCurX;
        private System.Windows.Forms.TextBox txtCurY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCurNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtFieldRemove;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

