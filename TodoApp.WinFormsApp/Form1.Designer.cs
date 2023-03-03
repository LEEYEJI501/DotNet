namespace TodoApp.WinFormsApp
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
            lblTitle = new Label();
            txtTitle = new TextBox();
            blnIsDone = new CheckBox();
            lblIsDone = new Label();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(92, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "할 일:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(136, 52);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(222, 23);
            txtTitle.TabIndex = 1;
            // 
            // blnIsDone
            // 
            blnIsDone.AutoSize = true;
            blnIsDone.Location = new Point(136, 90);
            blnIsDone.Name = "blnIsDone";
            blnIsDone.Size = new Size(50, 19);
            blnIsDone.TabIndex = 2;
            blnIsDone.Text = "완료";
            blnIsDone.UseVisualStyleBackColor = true;
            // 
            // lblIsDone
            // 
            lblIsDone.AutoSize = true;
            lblIsDone.Location = new Point(92, 91);
            lblIsDone.Name = "lblIsDone";
            lblIsDone.Size = new Size(38, 15);
            lblIsDone.TabIndex = 3;
            lblIsDone.Text = "완 료:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(364, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "등록";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(347, 163);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 377);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(lblIsDone);
            Controls.Add(blnIsDone);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "할 일 목록";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private CheckBox blnIsDone;
        private Label lblIsDone;
        private Button btnAdd;
        private DataGridView dataGridView1;
    }
}