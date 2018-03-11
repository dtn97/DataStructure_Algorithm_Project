namespace WindowsFormsApp1
{
    partial class FieldForm
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
            this.btnRemovePackage = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMovePackage = new System.Windows.Forms.Button();
            this.To = new System.Windows.Forms.GroupBox();
            this.txtToX = new System.Windows.Forms.TextBox();
            this.txtToY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.GroupBox();
            this.txtFromX = new System.Windows.Forms.TextBox();
            this.txtFromY = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCurNo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.txtCurX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCurY = new System.Windows.Forms.TextBox();
            this.zoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox4.SuspendLayout();
            this.To.SuspendLayout();
            this.From.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnRemovePackage.Click += new System.EventHandler(this.btnRemovePackage_Click_1);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMovePackage);
            this.groupBox4.Controls.Add(this.To);
            this.groupBox4.Controls.Add(this.From);
            this.groupBox4.Location = new System.Drawing.Point(724, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(416, 197);
            this.groupBox4.TabIndex = 15;
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
            this.btnMovePackage.Click += new System.EventHandler(this.btnMovePackage_Click_1);
            // 
            // To
            // 
            this.To.Controls.Add(this.txtToX);
            this.To.Controls.Add(this.txtToY);
            this.To.Controls.Add(this.label14);
            this.To.Controls.Add(this.label15);
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
            // From
            // 
            this.From.Controls.Add(this.txtFromX);
            this.From.Controls.Add(this.txtFromY);
            this.From.Controls.Add(this.label17);
            this.From.Controls.Add(this.label18);
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
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(204, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(512, 197);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Field";
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
            this.Field_add.Click += new System.EventHandler(this.Field_add_Click_1);
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
            this.change.Click += new System.EventHandler(this.change_Click_1);
            // 
            // txtCurX
            // 
            this.txtCurX.Location = new System.Drawing.Point(98, 102);
            this.txtCurX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurX.Name = "txtCurX";
            this.txtCurX.Size = new System.Drawing.Size(58, 26);
            this.txtCurX.TabIndex = 21;
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
            this.groupBox1.Location = new System.Drawing.Point(14, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(177, 197);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // txtCurY
            // 
            this.txtCurY.Location = new System.Drawing.Point(98, 132);
            this.txtCurY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurY.Name = "txtCurY";
            this.txtCurY.Size = new System.Drawing.Size(58, 26);
            this.txtCurY.TabIndex = 20;
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
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Location = new System.Drawing.Point(12, 220);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1233, 546);
            this.panel.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 778);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Field Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.groupBox4.ResumeLayout(false);
            this.To.ResumeLayout(false);
            this.To.PerformLayout();
            this.From.ResumeLayout(false);
            this.From.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemovePackage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMovePackage;
        private System.Windows.Forms.GroupBox To;
        private System.Windows.Forms.TextBox txtToX;
        private System.Windows.Forms.TextBox txtToY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox From;
        private System.Windows.Forms.TextBox txtFromX;
        private System.Windows.Forms.TextBox txtFromY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Field_add;
        private System.Windows.Forms.TextBox px;
        private System.Windows.Forms.TextBox py;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCurNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox txtCurX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCurY;
        private System.Windows.Forms.TextBox zoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
    }
}