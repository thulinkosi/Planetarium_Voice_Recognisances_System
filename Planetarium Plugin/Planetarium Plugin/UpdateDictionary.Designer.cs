namespace Planetarium_Plugin
{
    partial class UpdateDictionary
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

        /// <summary>
        /// show the slide number of the selected slide on the user controller for updating a dictionary
        /// </summary>
        /// <param name="id">the slide id of the selected slide</param>
        /// <param name="num">the slide number of the selected slide</param>
        public void showSlideNumber(string id, string num)
        {
            txtSlideNumber.Tag = id;
            txtSlideNumber.Text = num;
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdUpdateDictionary = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSlideNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdFinish = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdRenameSave = new System.Windows.Forms.Button();
            this.txtOldName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDictionary = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdUpdateDictionary
            // 
            this.cmdUpdateDictionary.Location = new System.Drawing.Point(48, 89);
            this.cmdUpdateDictionary.Name = "cmdUpdateDictionary";
            this.cmdUpdateDictionary.Size = new System.Drawing.Size(91, 23);
            this.cmdUpdateDictionary.TabIndex = 4;
            this.cmdUpdateDictionary.Text = "Update slide";
            this.cmdUpdateDictionary.UseVisualStyleBackColor = true;
            this.cmdUpdateDictionary.Click += new System.EventHandler(this.cmdUpdateDictionary_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(73, 45);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(91, 20);
            this.txtKeyword.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdUpdateDictionary);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSlideNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(16, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 129);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Keyword";
            // 
            // txtSlideNumber
            // 
            this.txtSlideNumber.Enabled = false;
            this.txtSlideNumber.Location = new System.Drawing.Point(80, 10);
            this.txtSlideNumber.Name = "txtSlideNumber";
            this.txtSlideNumber.Size = new System.Drawing.Size(81, 20);
            this.txtSlideNumber.TabIndex = 1;
            this.txtSlideNumber.TextChanged += new System.EventHandler(this.txtSlideNumber_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Slide number:";
            // 
            // cmdFinish
            // 
            this.cmdFinish.Location = new System.Drawing.Point(74, 484);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(91, 23);
            this.cmdFinish.TabIndex = 8;
            this.cmdFinish.Text = "Finish";
            this.cmdFinish.UseVisualStyleBackColor = true;
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(6, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 157);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rename a dictionary";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmdRenameSave);
            this.panel3.Controls.Add(this.txtOldName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtRename);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(10, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 123);
            this.panel3.TabIndex = 10;
            // 
            // cmdRenameSave
            // 
            this.cmdRenameSave.Location = new System.Drawing.Point(61, 90);
            this.cmdRenameSave.Name = "cmdRenameSave";
            this.cmdRenameSave.Size = new System.Drawing.Size(89, 21);
            this.cmdRenameSave.TabIndex = 4;
            this.cmdRenameSave.Text = "Save";
            this.cmdRenameSave.UseVisualStyleBackColor = true;
            this.cmdRenameSave.Click += new System.EventHandler(this.cmdRenameSave_Click);
            // 
            // txtOldName
            // 
            this.txtOldName.Location = new System.Drawing.Point(86, 20);
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.ReadOnly = true;
            this.txtOldName.Size = new System.Drawing.Size(103, 20);
            this.txtOldName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Name";
            // 
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(74, 54);
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(115, 20);
            this.txtRename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(13, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 163);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rename a slide";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(16, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 92);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dictionaries";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbDictionary);
            this.panel2.Location = new System.Drawing.Point(13, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 68);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select a dictionary";
            // 
            // cmbDictionary
            // 
            this.cmbDictionary.FormattingEnabled = true;
            this.cmbDictionary.Location = new System.Drawing.Point(9, 27);
            this.cmbDictionary.Name = "cmbDictionary";
            this.cmbDictionary.Size = new System.Drawing.Size(164, 21);
            this.cmbDictionary.TabIndex = 6;
            this.cmbDictionary.SelectionChangeCommitted += new System.EventHandler(this.cmbDictionary_SelectedIndexChanged);
            // 
            // UpdateDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdFinish);
            this.Name = "UpdateDictionary";
            this.Size = new System.Drawing.Size(232, 538);
            this.Load += new System.EventHandler(this.UpdateDictionary_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUpdateDictionary;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSlideNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdFinish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOldName;
        private System.Windows.Forms.Button cmdRenameSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDictionary;
    }
}
