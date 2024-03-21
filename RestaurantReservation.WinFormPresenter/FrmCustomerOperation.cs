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
public partial class FrmCustomerOperation : Form
{
    public FrmCustomerOperation(ICustomerService customerService)
    {
        _customerService = customerService;
        InitializeComponent();
    }

    private ICustomerService _customerService;

    private void FrmCustomerOperation_Load(object sender, EventArgs e)
    {
        cbxIsActive.Visible = false;
        cbxIsDeleted.Visible = false;
        LoadControls();
    }

    void LoadControls()
    {

        if (rdbAll.Checked)
        {
            dgvCustomer.DataSource = _customerService.GetListUnConditional();
        }
        else if (rdbIsActive.Checked)
        {
            dgvCustomer.DataSource = _customerService.GetByIsActive();
        }
        else
        {
            dgvCustomer.DataSource = _customerService.GetByIsDeactive();
        }
    }

    void ClearControls()
    {
        txtId.Clear();
        txtName.Clear();
        txtSurname.Clear();
        txtEmail.Clear();
        txtPhone.Clear();
        txtAddress.Clear();
        dtpDate.Value = DateTime.Now;
        cbxIsActive.Visible = false;
        cbxIsDeleted.Visible = false;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Customer customer = new()
        {
            Name = txtName.Text,
            Surname = txtSurname.Text,
            Email = txtEmail.Text,
            Phone = txtPhone.Text,
            Address = txtAddress.Text,
            CreatedDate = DateTime.Now
        };
        _customerService.Add(customer);
        LoadControls();
        ClearControls();
    }

    private void btnGetList_Click(object sender, EventArgs e)
    {
        LoadControls();
    }

    private void dgvCustomer_DoubleClick(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["Id"].Value);
        GetCustomer(id);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearControls();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        Customer customer = _customerService.Get(Convert.ToInt32(txtId.Text));
        if (customer != null)
        {
            customer.Name = txtName.Text;
            customer.Surname = txtSurname.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            customer.Address = txtAddress.Text;
            if (cbxIsActive.Checked)
                customer.IsActive = true;
            else
                customer.IsActive = false;
            if (cbxIsDeleted.Checked)
                customer.IsDeleted = true;
            else
                customer.IsDeleted = false;
        }
        cbxIsActive.Visible = false;
        cbxIsDeleted.Visible = false;
        _customerService.Update(customer);
        LoadControls();
        ClearControls();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        Customer customer = _customerService.Get(Convert.ToInt32(txtId.Text));
        _customerService.Delete(customer);
        LoadControls();
    }

    private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
    {
        ClearControls();
        txtId.Text = dgvCustomer.CurrentRow.Cells["Id"].Value.ToString();
    }

    private void btnGet_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text);
        GetCustomer(id);
    }

    void GetCustomer(int id)
    {
        Customer customer = _customerService.Get(id);
        txtId.Text = customer.Id.ToString();
        txtName.Text = customer.Name;
        txtSurname.Text = customer.Surname;
        txtEmail.Text = customer.Email;
        txtPhone.Text = customer.Phone;
        txtAddress.Text = customer.Address;
        cbxIsActive.Checked = customer.IsActive;
        cbxIsDeleted.Checked = customer.IsDeleted;
        cbxIsActive.Visible = true;
        cbxIsDeleted.Visible = true;
    }

    private void gbxCustomerOperations_Enter(object sender, EventArgs e)
    {

    }
}
