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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDictionary = new System.Windows.Forms.ComboBox();
            this.cmdFinish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdUpdateDictionary
            // 
            this.cmdUpdateDictionary.Location = new System.Drawing.Point(32, 84);
            this.cmdUpdateDictionary.Name = "cmdUpdateDictionary";
            this.cmdUpdateDictionary.Size = new System.Drawing.Size(91, 23);
            this.cmdUpdateDictionary.TabIndex = 4;
            this.cmdUpdateDictionary.Text = "Update slide";
            this.cmdUpdateDictionary.UseVisualStyleBackColor = true;
            this.cmdUpdateDictionary.Click += new System.EventHandler(this.cmdUpdateDictionary_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(6, 58);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(155, 20);
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
            this.panel1.Location = new System.Drawing.Point(13, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 116);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbDictionary);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 56);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dictionaries";
            // 
            // cmbDictionary
            // 
            this.cmbDictionary.FormattingEnabled = true;
            this.cmbDictionary.Location = new System.Drawing.Point(3, 27);
            this.cmbDictionary.Name = "cmbDictionary";
            this.cmbDictionary.Size = new System.Drawing.Size(158, 21);
            this.cmbDictionary.TabIndex = 6;
            this.cmbDictionary.SelectedIndexChanged += new System.EventHandler(this.cmbDictionary_SelectedIndexChanged);
            this.cmbDictionary.Click += new System.EventHandler(this.cmbDictionary_Click_1);
            // 
            // cmdFinish
            // 
            this.cmdFinish.Location = new System.Drawing.Point(46, 209);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(91, 23);
            this.cmdFinish.TabIndex = 8;
            this.cmdFinish.Text = "Finish";
            this.cmdFinish.UseVisualStyleBackColor = true;
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // UpdateDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdFinish);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateDictionary";
            this.Size = new System.Drawing.Size(191, 244);
            this.Load += new System.EventHandler(this.UpdateDictionary_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDictionary;
        private System.Windows.Forms.Button cmdFinish;
    }
}
