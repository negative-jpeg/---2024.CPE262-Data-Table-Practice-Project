namespace WinFormsApp3___Data_Table_Practice_Project
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btn_Load = new Button();
            btn_Save = new Button();
            btnAddRow = new Button();
            btnAddColumn = new Button();
            btnDeleteColumn = new Button();
            btnDeleteRow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 225);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "LASTNAME";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "FIRSTNAME";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "MI";
            Column3.Name = "Column3";
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(12, 322);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(96, 23);
            btn_Load.TabIndex = 1;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(12, 293);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(96, 23);
            btn_Save.TabIndex = 2;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btnAddRow
            // 
            btnAddRow.Location = new Point(12, 380);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(96, 23);
            btnAddRow.TabIndex = 3;
            btnAddRow.Text = "Add Row";
            btnAddRow.UseVisualStyleBackColor = true;
            btnAddRow.Click += btnAddRow_Click;
            // 
            // btnAddColumn
            // 
            btnAddColumn.Location = new Point(12, 351);
            btnAddColumn.Name = "btnAddColumn";
            btnAddColumn.Size = new Size(96, 23);
            btnAddColumn.TabIndex = 4;
            btnAddColumn.Text = "Add Column";
            btnAddColumn.UseVisualStyleBackColor = true;
            btnAddColumn.Click += btnAddColumn_Click;
            // 
            // btnDeleteColumn
            // 
            btnDeleteColumn.Location = new Point(114, 351);
            btnDeleteColumn.Name = "btnDeleteColumn";
            btnDeleteColumn.Size = new Size(96, 23);
            btnDeleteColumn.TabIndex = 5;
            btnDeleteColumn.Text = "Delete Column";
            btnDeleteColumn.UseVisualStyleBackColor = true;
            btnDeleteColumn.Click += btnDeleteColumn_Click;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.Location = new Point(114, 380);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(96, 23);
            btnDeleteRow.TabIndex = 6;
            btnDeleteRow.Text = "Delete Row";
            btnDeleteRow.UseVisualStyleBackColor = true;
            btnDeleteRow.Click += btnDeleteRow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteRow);
            Controls.Add(btnDeleteColumn);
            Controls.Add(btnAddColumn);
            Controls.Add(btnAddRow);
            Controls.Add(btn_Save);
            Controls.Add(btn_Load);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btn_Load;
        private Button btn_Save;
        private Button btnAddRow;
        private Button btnAddColumn;
        private Button btnDeleteColumn;
        private Button btnDeleteRow;
    }
}
