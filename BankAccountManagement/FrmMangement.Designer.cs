namespace BankAccountManagement
{
    partial class FrmMangement
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
            dgvAccountList = new DataGridView();
            txtSearchValue = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            ID = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtAccountName = new TextBox();
            txtBranchName = new TextBox();
            cbAccountType = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccountList).BeginInit();
            SuspendLayout();
            // 
            // dgvAccountList
            // 
            dgvAccountList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccountList.Location = new Point(378, 45);
            dgvAccountList.Name = "dgvAccountList";
            dgvAccountList.RowHeadersWidth = 51;
            dgvAccountList.RowTemplate.Height = 29;
            dgvAccountList.Size = new Size(804, 403);
            dgvAccountList.TabIndex = 0;
            dgvAccountList.CellClick += dgvAccountList_CellClick;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(744, 10);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(204, 27);
            txtSearchValue.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(646, 13);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 3;
            label1.Text = "Search:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(982, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(12, 83);
            ID.Name = "ID";
            ID.Size = new Size(27, 20);
            ID.TabIndex = 5;
            ID.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 6;
            label3.Text = "Account Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 6;
            label4.Text = "Branch Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 235);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 7;
            label5.Text = "Account Type:";
            // 
            // txtID
            // 
            txtID.Location = new Point(128, 76);
            txtID.Name = "txtID";
            txtID.Size = new Size(215, 27);
            txtID.TabIndex = 9;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(128, 131);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(215, 27);
            txtAccountName.TabIndex = 10;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(128, 178);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(215, 27);
            txtBranchName.TabIndex = 11;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Items.AddRange(new object[] { "Saving", "Checking", "Trading", "Forex" });
            cbAccountType.Location = new Point(128, 232);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(215, 28);
            cbAccountType.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Create";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(143, 331);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(267, 331);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmMangement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 595);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbAccountType);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ID);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearchValue);
            Controls.Add(dgvAccountList);
            Name = "FrmMangement";
            Text = "FrmMangement";
            ((System.ComponentModel.ISupportInitialize)dgvAccountList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAccountList;
        private TextBox txtSearchValue;
        private Label label1;
        private Button btnSearch;
        private Label ID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtAccountName;
        private TextBox txtBranchName;
        private ComboBox cbAccountType;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}