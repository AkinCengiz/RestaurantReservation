using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantReservation.Business.Abstract;
using RestaurantReservation.Entities.Concrete;

namespace RestaurantReservation.WinFormPresenter;
public partial class FrmTableOperations : Form
{
    private ITableService _tableService;
    public FrmTableOperations(ITableService tableService)
    {
        _tableService = tableService;
        InitializeComponent();
    }

    private void FrmTableOperations_Load(object sender, EventArgs e)
    {
        LoadControls();
        ClearControls();
    }


    void LoadControls()
    {
        dgvTable.DataSource = _tableService.GetAll();
        ControlsVisible(false);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Table table = new()
        {
            Name = txtName.Text,
            Capacity = Convert.ToInt32(txtCapacity.Text),
            IsDeleted = false,
            IsActive = true,
            CreatedDate = DateTime.Now
        };
        _tableService.Add(table);
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        Table table = _tableService.Get(Convert.ToInt32(txtId.Text));
        table.Name = txtName.Text;
        table.Capacity = Convert.ToInt32(txtCapacity.Text);
        if(cbxIsActive.Checked)
            table.IsActive = true;
        else
        {
            table.IsActive = false;
        }
        if (cbxIsDeleted.Checked)
            table.IsDeleted = true;
        else
        {
            table.IsDeleted = false;
        }
        _tableService.Update(table);
        LoadControls();
        ClearControls();


    }

    private void btnDelete_Click(object sender, EventArgs e)
    {

    }

    private void btnGetList_Click(object sender, EventArgs e)
    {

    }

    private void btnGet_Click(object sender, EventArgs e)
    {
        if (txtId.Text != "")
        {
            ControlsVisible(true);
            int id = Convert.ToInt32(txtId.Text);
            Table table = _tableService.Get(id);
            txtName.Text = table.Name;
            txtCapacity.Text = table.Capacity.ToString();
            cbxIsActive.Checked = table.IsActive;
            cbxIsDeleted.Checked = table.IsDeleted;
        }
        
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearControls();
    }

    private void dgvTable_DoubleClick(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(dgvTable.CurrentRow.Cells["Id"].Value);
        Table table = _tableService.Get(id);
        ControlsVisible(true);
        ControlsFill(table);
    }

    private void dgvTable_SelectionChanged(object sender, EventArgs e)
    {
        txtId.Text = dgvTable.CurrentRow.Cells["Id"].Value.ToString();
    }

    void ClearControls()
    {
        ControlsVisible(false);
        txtId.Clear();
        txtName.Clear();
        txtCapacity.Clear();
    }

    void ControlsFill(Table table)
    {
        txtId.Text = table.Id.ToString();
        txtCapacity.Text = table.Capacity.ToString();
        txtName.Text = table.Name;
        cbxIsActive.Checked = table.IsActive;
        cbxIsDeleted.Checked = table.IsDeleted;
    }

    void ControlsVisible(bool isVisible)
    {
        cbxIsActive.Visible = isVisible;
        cbxIsDeleted.Visible = isVisible;
    }
}
