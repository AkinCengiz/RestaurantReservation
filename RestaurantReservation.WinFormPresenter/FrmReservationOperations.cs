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
public partial class FrmReservationOperations : Form
{
    private IReservationService _reservationService;
    public FrmReservationOperations(IReservationService reservationService)
    {
        _reservationService = reservationService;
        InitializeComponent();
    }

    private void FrmReservationOperations_Load(object sender, EventArgs e)
    {
        LoadControls();
        ClearControls();
    }

    void LoadControls()
    {
        cmbCustomers.DataSource = _reservationService.GetListByCustomer();
        cmbCustomers.DisplayMember = "Name";
        cmbCustomers.ValueMember = "Id";
        cmbTables.DataSource = _reservationService.GetListByTable();
        cmbTables.DisplayMember = "Name";
        cmbTables.ValueMember = "Id";
        dgvReservations.DataSource = _reservationService.GetListUnConditional();
        ControlsVisible(false);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Reservation reservation = new()
        {
            CustomerId = Convert.ToInt32(cmbCustomers.SelectedValue),
            TableId = Convert.ToInt32(cmbTables.SelectedValue),
            DateInfo = Convert.ToDateTime(dtpDate.Value),
            TimeInfo = Convert.ToDateTime(dtpTime.Value),
            IsActive = true,
            IsDeleted = false,
            CreatedDate = DateTime.Now
        };
        _reservationService.Add(reservation);
        LoadControls();
        ClearControls();

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (txtId.Text != "")
        {
            ControlsVisible(true);
            Reservation reservation = _reservationService.Get(Convert.ToInt32(txtId.Text));
            if (reservation != null)
            {
                reservation.CustomerId = Convert.ToInt32(cmbCustomers.SelectedValue);
                reservation.TableId = Convert.ToInt32(cmbTables.SelectedValue);
                reservation.DateInfo = dtpDate.Value;
                reservation.TimeInfo = dtpTime.Value;
                if (cbxIsActive.Checked)
                    reservation.IsActive = true;
                else reservation.IsActive = false;
                if(cbxIsDeleted.Checked) reservation.IsDeleted = true;
                else reservation.IsDeleted = false;
            }
            _reservationService.Update(reservation);
            LoadControls();
            ClearControls();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        Reservation reservation = _reservationService.Get(Convert.ToInt32(txtId.Text));
        reservation.IsDeleted = true;
        _reservationService.Update(reservation);
    }

    private void btnGetList_Click(object sender, EventArgs e)
    {
        if(rdbAll.Checked) dgvReservations.DataSource = _reservationService.GetAll();
        else if (rdbIsActive.Checked) dgvReservations.DataSource = _reservationService.GetListByIsActive();
        else dgvReservations.DataSource = _reservationService.GetListByInActive();
    }

    private void btnGet_Click(object sender, EventArgs e)
    {
        GetReservation();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearControls();
    }

    void ClearControls()
    {
        txtId.Clear();
        cmbCustomers.SelectedIndex = 0;
        cmbTables.SelectedIndex = 0;
        dtpDate.Value = DateTime.Now;
        dtpTime.Value = DateTime.Now;
        ControlsVisible(false);
    }

    void ControlsVisible(bool isVisible)
    {
        cbxIsActive.Visible = isVisible;
        cbxIsDeleted.Visible = isVisible;
    }

    private void dgvReservations_DoubleClick(object sender, EventArgs e)
    {
        GetReservation();
    }

    private void dgvReservations_SelectionChanged(object sender, EventArgs e)
    {
        txtId.Text = dgvReservations.CurrentRow.Cells["Id"].Value.ToString();
    }

    void GetReservation()
    {
        Reservation reservation =
            _reservationService.Get(Convert.ToInt32(dgvReservations.CurrentRow.Cells["Id"].Value));
        if (reservation != null)
        {
            txtId.Text = reservation.Id.ToString();
            cmbCustomers.SelectedValue = reservation.CustomerId;
            cmbTables.SelectedValue = reservation.TableId;
            dtpDate.Value = reservation.DateInfo.Date;
            dtpTime.Text = reservation.TimeInfo.ToShortTimeString();
        }
    }
}
