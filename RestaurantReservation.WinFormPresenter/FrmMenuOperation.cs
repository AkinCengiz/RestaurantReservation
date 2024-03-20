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
public partial class FrmMenuOperation : Form
{
    private IMenuService _menuService;
    public FrmMenuOperation(IMenuService menuService)
    {
        _menuService = menuService;
        InitializeComponent();
    }


    private void FrmMenuOperation_Load(object sender, EventArgs e)
    {
        cbxIsActive.Visible = false;
        cbxIsDeleted.Visible = false;
        LoadControls();
        ClearControl();
    }

    void LoadControls()
    {
        if (rdbAll.Checked)
        {
            dgvMenu.DataSource = _menuService.GetListUnConditional();
        }
        else if (rdbIsActive.Checked)
        {
            dgvMenu.DataSource = _menuService.GetListIsActive();
        }
        else
        {
            dgvMenu.DataSource = _menuService.GetListIsDeactive();
        }
    }

    private void dgvMenu_DoubleClick(object sender, EventArgs e)
    {
        cbxIsActive.Visible = true;
        cbxIsDeleted.Visible = true;
        GetMenu(Convert.ToInt32(txtId.Text));
    }

    private void dgvMenu_SelectionChanged(object sender, EventArgs e)
    {
        txtId.Text = dgvMenu.CurrentRow.Cells["Id"].Value.ToString();
    }

    void GetMenu(int id)
    {
        Menu menu = _menuService.Get(id);
        txtId.Text = menu.Id.ToString();
        txtDescription.Text = menu.Description;
        txtTitle.Text = menu.Title;
        txtPrice.Text = menu.Price.ToString();
        cbxIsActive.Visible = true;
        cbxIsDeleted.Visible = true;
    }

    private void btnGet_Click(object sender, EventArgs e)
    {
        if (txtId.Text != "")
        {
            GetMenu(Convert.ToInt32(txtId.Text));
        }

    }

    void ClearControl()
    {
        txtId.Clear();
        txtDescription.Clear();
        txtTitle.Clear();
        txtPrice.Clear();
        cbxIsActive.Visible = false;
        cbxIsDeleted.Visible = false;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearControl();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Menu menu = new Menu()
        {
            Title = txtTitle.Text,
            Description = txtDescription.Text,
            Price = Convert.ToDecimal(txtPrice.Text),
            IsDeleted = false,
            IsActive = true,
            CreatedDate = DateTime.Now
        };
        _menuService.Add(menu);
        LoadControls();
        ClearControl();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        Menu menu = _menuService.Get(Convert.ToInt32(txtId.Text));
        menu.Title = txtTitle.Text;
        menu.Description = txtDescription.Text;
        menu.Price = Convert.ToDecimal(txtPrice.Text);
        if (cbxIsActive.Checked)
        {
            menu.IsActive = true;
        }
        else
        {
            menu.IsActive = false;
        }
        if(cbxIsDeleted.Checked)
            menu.IsDeleted = true;
        else
        {
            menu.IsDeleted = false;
        }

        LoadControls();
        ClearControl();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        Menu menu = _menuService.Get(Convert.ToInt32(txtId.Text));
        menu.IsDeleted = true;
        _menuService.Update(menu);
        LoadControls();
        ClearControl();
    }

    private void btnGetList_Click(object sender, EventArgs e)
    {
        dgvMenu.DataSource = _menuService.GetAll();
    }
}
