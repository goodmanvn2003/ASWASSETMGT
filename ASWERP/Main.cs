using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ASWERP.Models;

namespace ASWERP
{
    public partial class Main : Form
    {
        public Login login { get; set; }
        public List<Form> Forms = null;

        public Main()
        {
            InitializeComponent();

            dgvAssets.AutoGenerateColumns = false;
            dgvAssets.DataSource = Loader.ReadDatabase();

            Forms = new List<Form>();
        }

        private void exitMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAssets_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dgvAssets_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAssets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("Id"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["Id"].Value);
                if (_value.Length == 0 && e.RowIndex != dgvAssets.NewRowIndex)
                    dgvAssets.Rows[e.RowIndex].Cells["Id"].Value = String.Format("{0}.{1}", AssetVM.ID_PREFIX, Utilities.GenerateAssetsId());
            }

            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("EmployeeName"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["EmployeeName"].Value);
                if (!_value.IsUpper())
                    dgvAssets.Rows[e.RowIndex].Cells["EmployeeName"].Value = _value.Trim().ToUpper();
            }

            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("ComputerName"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["ComputerName"].Value);
                if (!_value.ToLower().Contains("asw"))
                    dgvAssets.Rows[e.RowIndex].Cells["ComputerName"].Value = String.Format("ASW{0}", String.Empty).ToUpper();
            }

            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("EmailAddress"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["EmailAddress"].Value);
                if (!Utilities.IsValidEmail(_value))
                {
                    DataGridViewCell cell =
                        dgvAssets.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    e.CellStyle.BackColor = Color.FromArgb(250, 167, 167);
                    cell.ToolTipText = "A valid email should have at least \"@\" and permissible characters";
                }
            }

            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("XLite"))
            {
                string _value = Convert.ToString(dgvAssets.Rows[e.RowIndex].Cells["XLite"].Value);
                if (!_value.HasAllNumbers())
                {
                    DataGridViewCell cell =
                        dgvAssets.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    e.CellStyle.BackColor = Color.FromArgb(250, 167, 167);
                    cell.ToolTipText = "The value must only contain digits";
                }
            }
        }

        private void dgvAssets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssets.Columns[e.ColumnIndex].Name.Equals("More"))
            {
                var id = dgvAssets.Rows[e.RowIndex].Cells["Id"].Value;
                var employeeName = dgvAssets.Rows[e.RowIndex].Cells["EmployeeName"].Value;

                AssetsHandover assetsHandover = new AssetsHandover(this, Convert.ToString(id), Convert.ToString(employeeName));
                Forms.Add(assetsHandover);

                assetsHandover.Show();
            }
        }

        private void assetsHandoverMnItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var form in Forms)
            {
                form.Close();
            }
            this.login.Show();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Forms = new List<Form>();
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
                 
        }

        private void dgvAssets_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ExecuteSavingAssets();
        }

        private void dgvAssets_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void ExecuteSavingAssets()
        {
            List<AssetVM> _details = new List<AssetVM>();
            for (var i = 0; i < dgvAssets.Rows.Count; i++)
            {
                if (dgvAssets.Rows[i].Index != dgvAssets.NewRowIndex)
                {
                    var _item = new AssetVM()
                    {
                        Id = Convert.ToString(dgvAssets.Rows[i].Cells["Id"].Value),
                        EmployeeName = Convert.ToString(dgvAssets.Rows[i].Cells["EmployeeName"].Value),
                        XLite = Convert.ToString(dgvAssets.Rows[i].Cells["XLite"].Value),
                        ComputerName = Convert.ToString(dgvAssets.Rows[i].Cells["ComputerName"].Value),
                        ComputerType = Convert.ToString(dgvAssets.Rows[i].Cells["ComputerType"].Value),
                        EmailAddress = Convert.ToString(dgvAssets.Rows[i].Cells["EmailAddress"].Value)
                    };
                    _details.Add(_item);
                }
            }
            Saver dbSaver = new Saver();
            dbSaver.Invoke<AssetVM>(Saver.TYPE_ASSETS, null, _details);
        }

        private void dgvAssets_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ExecuteSavingAssets();
        }

        private void dgvAssets_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
        }
    }
}
