namespace WinFormsApp3___Data_Table_Practice_Project
{
    partial class TextBoxForm
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
            btnSaveColumn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSaveColumn
            // 
            btnSaveColumn.Location = new Point(12, 75);
            btnSaveColumn.Name = "btnSaveColumn";
            btnSaveColumn.Size = new Size(255, 29);
            btnSaveColumn.TabIndex = 0;
            btnSaveColumn.Text = "Save";
            btnSaveColumn.UseVisualStyleBackColor = true;
            btnSaveColumn.Click += btnSaveColumn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Title";
            // 
            // TextBoxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 116);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnSaveColumn);
            Name = "TextBoxForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextBoxForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveColumn;
        private TextBox textBox1;
        private Label label1;
    }
}