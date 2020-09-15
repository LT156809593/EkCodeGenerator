namespace IceInk
{
    partial class CodeGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.databaseUrlbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseIdbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.databasePassbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.databaseCheckList = new System.Windows.Forms.CheckedListBox();
            this.tableCheckList = new System.Windows.Forms.CheckedListBox();
            this.CreateAndSaveFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txSpaceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseUrlbox
            // 
            this.databaseUrlbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.databaseUrlbox.Location = new System.Drawing.Point(159, 120);
            this.databaseUrlbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.databaseUrlbox.Name = "databaseUrlbox";
            this.databaseUrlbox.Size = new System.Drawing.Size(139, 32);
            this.databaseUrlbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库地址：";
            // 
            // databaseIdbox
            // 
            this.databaseIdbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.databaseIdbox.Location = new System.Drawing.Point(159, 185);
            this.databaseIdbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.databaseIdbox.Name = "databaseIdbox";
            this.databaseIdbox.Size = new System.Drawing.Size(139, 32);
            this.databaseIdbox.TabIndex = 0;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
           
            // 
            // databasePassbox
            // 
            this.databasePassbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.databasePassbox.Location = new System.Drawing.Point(159, 250);
            this.databasePassbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.databasePassbox.Name = "databasePassbox";
            this.databasePassbox.Size = new System.Drawing.Size(139, 32);
            this.databasePassbox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "密码：";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(159, 355);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 39);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = ">>测试连接>>";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // databaseCheckList
            // 
            this.databaseCheckList.FormattingEnabled = true;
            this.databaseCheckList.Location = new System.Drawing.Point(378, 42);
            this.databaseCheckList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.databaseCheckList.Name = "databaseCheckList";
            this.databaseCheckList.Size = new System.Drawing.Size(202, 418);
            this.databaseCheckList.TabIndex = 3;
            this.databaseCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.databaseCheckList_ItemCheck);
            // 
            // tableCheckList
            // 
            this.tableCheckList.FormattingEnabled = true;
            this.tableCheckList.Location = new System.Drawing.Point(605, 41);
            this.tableCheckList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableCheckList.Name = "tableCheckList";
            this.tableCheckList.Size = new System.Drawing.Size(273, 418);
            this.tableCheckList.TabIndex = 3;
            // 
            // CreateAndSaveFile
            // 
            this.CreateAndSaveFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateAndSaveFile.Location = new System.Drawing.Point(500, 532);
            this.CreateAndSaveFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CreateAndSaveFile.Name = "CreateAndSaveFile";
            this.CreateAndSaveFile.Size = new System.Drawing.Size(161, 52);
            this.CreateAndSaveFile.TabIndex = 4;
            this.CreateAndSaveFile.Text = "生成实体";
            this.CreateAndSaveFile.UseVisualStyleBackColor = true;
            this.CreateAndSaveFile.Click += new System.EventHandler(this.CreateAndSaveFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableCheckList);
            this.groupBox1.Controls.Add(this.databaseUrlbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.databaseCheckList);
            this.groupBox1.Controls.Add(this.databaseIdbox);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.databasePassbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(904, 487);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "代码生成器";
            // 
            // txSpaceName
            // 
            this.txSpaceName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSpaceName.Location = new System.Drawing.Point(122, 545);
            this.txSpaceName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txSpaceName.Name = "txSpaceName";
            this.txSpaceName.Size = new System.Drawing.Size(347, 32);
            this.txSpaceName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 543);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "命名空间：";
            // 
            // CodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateAndSaveFile);
            this.Controls.Add(this.txSpaceName);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "CodeGenerator";
            this.Text = "IceInk代码生成器";
            this.Load += new System.EventHandler(this.CodeGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox databaseUrlbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox databaseId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox databasePassbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox databaseIdbox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckedListBox databaseCheckList;
        private System.Windows.Forms.CheckedListBox tableCheckList;
        private System.Windows.Forms.Button CreateAndSaveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txSpaceName;
        private System.Windows.Forms.Label label4;
    }
}

