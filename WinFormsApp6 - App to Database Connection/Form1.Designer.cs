namespace WinFormsApp6___App_to_Database_Connection
{
    partial class Form1
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
            button1 = new Button();
            dgvStudentInfo = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxID = new TextBox();
            tbxLname = new TextBox();
            tbxFname = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 292);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 0;
            button1.Text = "Connection Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvStudentInfo
            // 
            dgvStudentInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentInfo.Location = new Point(188, 9);
            dgvStudentInfo.Name = "dgvStudentInfo";
            dgvStudentInfo.ReadOnly = true;
            dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentInfo.Size = new Size(562, 303);
            dgvStudentInfo.TabIndex = 1;
            dgvStudentInfo.CellClick += dgvStudentInfo_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(12, 263);
            button2.Name = "button2";
            button2.Size = new Size(149, 23);
            button2.TabIndex = 2;
            button2.Text = "Load Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "STUDENT ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "LAST NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "FIRST NAME:";
            // 
            // tbxID
            // 
            tbxID.Location = new Point(84, 31);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(100, 23);
            tbxID.TabIndex = 6;
            tbxID.TextChanged += tbxID_TextChanged;
            // 
            // tbxLname
            // 
            tbxLname.Location = new Point(84, 58);
            tbxLname.Name = "tbxLname";
            tbxLname.Size = new Size(100, 23);
            tbxLname.TabIndex = 7;
            // 
            // tbxFname
            // 
            tbxFname.Location = new Point(84, 84);
            tbxFname.Name = "tbxFname";
            tbxFname.Size = new Size(100, 23);
            tbxFname.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 126);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 324);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(tbxFname);
            Controls.Add(tbxLname);
            Controls.Add(tbxID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dgvStudentInfo);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvStudentInfo;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxID;
        private TextBox tbxLname;
        private TextBox tbxFname;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
