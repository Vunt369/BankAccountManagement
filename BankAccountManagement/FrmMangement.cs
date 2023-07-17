using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankAccountManagement
{
    public partial class FrmMangement : Form
    {
        public User _user;
        public BankAccountService _bankAccountService;
        public List<BankAccount> listAccounts;
        public FrmMangement()
        {
            _bankAccountService = new BankAccountService();
            InitializeComponent();
            LoadTable();
        }
        public void LoadTable()
        {
            listAccounts = _bankAccountService.GetAll().ToList();
            dgvAccountList.DataSource = listAccounts;
        }
        public void ClearTextBox()
        {
            txtID.Text = "";
            txtAccountName.Text = "";
            txtBranchName.Text = "";
            cbAccountType.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchValue.Text;
            listAccounts = _bankAccountService.GetAll().Where(p => p.BranchName.ToLower().Contains(searchValue)).ToList();
            if (listAccounts != null)
            {
                txtSearchValue.Text = "";
                dgvAccountList.DataSource = new BindingSource { DataSource = listAccounts };
            }
            else
            {
                LoadTable();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var accountID = txtID.Text;
            var accountName = txtAccountName.Text;
            var branchName = txtBranchName.Text;
            var accountTypeName = cbAccountType.Text;
            AccountTypeService _accountType = new AccountTypeService();
            var existed = _bankAccountService.GetAll().Where(p => p.AccountId.ToLower().Equals(accountID)).FirstOrDefault();
            if (existed != null)
            {
                MessageBox.Show("This ID is existed!!", "Add fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                BankAccount newBankAccount = new BankAccount();
                newBankAccount.AccountId = accountID;
                newBankAccount.AccountName = accountName;
                newBankAccount.OpenDate = DateTime.Now;
                newBankAccount.BranchName = branchName;
                newBankAccount.TypeId = _accountType.findTypeIdByName(accountTypeName);

                bool flag = _bankAccountService.Create(newBankAccount);
                if (!flag)
                {
                    MessageBox.Show("Create fail - That id is already exist in database!", "Thong bao", MessageBoxButtons.OK);

                }
                LoadTable();
                ClearTextBox();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var accountID = txtID.Text;
            var accountName = txtAccountName.Text;
            var branchName = txtBranchName.Text;
            var accountTypeName = cbAccountType.Text;
            AccountTypeService _accountType = new AccountTypeService();
            var newBankAccount = _bankAccountService.GetAll().Where(p => p.AccountId == accountID).FirstOrDefault();
                newBankAccount.AccountName = accountName;
                newBankAccount.OpenDate = DateTime.Now;
                newBankAccount.BranchName = branchName;
                newBankAccount.TypeId = _accountType.findTypeIdByName(accountTypeName);

                bool flag = _bankAccountService.Update(newBankAccount);
                if (!flag)
                {
                    MessageBox.Show("This ID not found!!", "Update fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Updated", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                ClearTextBox();
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var accountID = txtID.Text;

            var toDelete = _bankAccountService.GetAll().Where(p => p.AccountId.Equals(accountID)).FirstOrDefault();
            if (toDelete != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to detele the account with id: " + accountID, "Thong bao", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _bankAccountService.Remove(toDelete);
                    ClearTextBox();
                    LoadTable();

                }
            }

        }

        private void dgvAccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var accountID = dgvAccountList.Rows[e.RowIndex].Cells[0].Value.ToString();
            var Account = _bankAccountService.GetAll().Where(p=>p.AccountId == accountID).FirstOrDefault();
            AccountTypeService accountTypeService = new AccountTypeService();

            if (Account != null)
            {
                txtID.Text = Account.AccountId;
                txtID.ReadOnly = true;
                txtAccountName.Text = Account.AccountName;
                txtBranchName.Text = Account.BranchName;

                var listAccount = accountTypeService.GetAll();
                cbAccountType.Text = accountTypeService.GetAll().Where(p => p.TypeId.Equals(Account.TypeId)).FirstOrDefault().TypeName.ToString();
            }
        }
    }
}
