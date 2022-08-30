
namespace IDE
{
    partial class FrmSettings
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
            this.tabControlSchedular = new System.Windows.Forms.TabControl();
            this.tabUserMgt = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRuleEngine = new System.Windows.Forms.TabPage();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.tabSchedular = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlSchedular.SuspendLayout();
            this.tabUserMgt.SuspendLayout();
            this.tabSchedular.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSchedular
            // 
            this.tabControlSchedular.Controls.Add(this.tabUserMgt);
            this.tabControlSchedular.Controls.Add(this.tabRuleEngine);
            this.tabControlSchedular.Controls.Add(this.tabDatabase);
            this.tabControlSchedular.Controls.Add(this.tabCommon);
            this.tabControlSchedular.Controls.Add(this.tabSchedular);
            this.tabControlSchedular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSchedular.Location = new System.Drawing.Point(0, 0);
            this.tabControlSchedular.Name = "tabControlSchedular";
            this.tabControlSchedular.SelectedIndex = 0;
            this.tabControlSchedular.Size = new System.Drawing.Size(800, 450);
            this.tabControlSchedular.TabIndex = 0;
            // 
            // tabUserMgt
            // 
            this.tabUserMgt.BackColor = System.Drawing.Color.Gainsboro;
            this.tabUserMgt.Controls.Add(this.button3);
            this.tabUserMgt.Controls.Add(this.textBox3);
            this.tabUserMgt.Controls.Add(this.textBox2);
            this.tabUserMgt.Controls.Add(this.textBox1);
            this.tabUserMgt.Controls.Add(this.label4);
            this.tabUserMgt.Controls.Add(this.label3);
            this.tabUserMgt.Controls.Add(this.label2);
            this.tabUserMgt.Controls.Add(this.label1);
            this.tabUserMgt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabUserMgt.Location = new System.Drawing.Point(4, 22);
            this.tabUserMgt.Name = "tabUserMgt";
            this.tabUserMgt.Size = new System.Drawing.Size(792, 424);
            this.tabUserMgt.TabIndex = 3;
            this.tabUserMgt.Text = "User Mgt";
            this.tabUserMgt.Click += new System.EventHandler(this.tabUserMgt_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(370, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(400, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(347, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabRuleEngine
            // 
            this.tabRuleEngine.Location = new System.Drawing.Point(4, 22);
            this.tabRuleEngine.Name = "tabRuleEngine";
            this.tabRuleEngine.Size = new System.Drawing.Size(792, 424);
            this.tabRuleEngine.TabIndex = 4;
            this.tabRuleEngine.Text = "Rule Engine";
            this.tabRuleEngine.UseVisualStyleBackColor = true;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Size = new System.Drawing.Size(792, 424);
            this.tabDatabase.TabIndex = 2;
            this.tabDatabase.Text = "Database";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // tabCommon
            // 
            this.tabCommon.Location = new System.Drawing.Point(4, 22);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(792, 424);
            this.tabCommon.TabIndex = 1;
            this.tabCommon.Text = "Common Settings";
            this.tabCommon.UseVisualStyleBackColor = true;
            // 
            // tabSchedular
            // 
            this.tabSchedular.Controls.Add(this.button2);
            this.tabSchedular.Controls.Add(this.button1);
            this.tabSchedular.Location = new System.Drawing.Point(4, 22);
            this.tabSchedular.Name = "tabSchedular";
            this.tabSchedular.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedular.Size = new System.Drawing.Size(792, 424);
            this.tabSchedular.TabIndex = 0;
            this.tabSchedular.Text = "Schedular";
            this.tabSchedular.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSchedular);
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Configuration Settings";
            this.tabControlSchedular.ResumeLayout(false);
            this.tabUserMgt.ResumeLayout(false);
            this.tabUserMgt.PerformLayout();
            this.tabSchedular.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSchedular;
        private System.Windows.Forms.TabPage tabRuleEngine;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.TabPage tabSchedular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabUserMgt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}