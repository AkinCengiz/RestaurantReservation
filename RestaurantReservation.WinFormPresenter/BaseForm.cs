using RestaurantReservation.Business.Concrete;
using RestaurantReservation.DataAccess.Concrete.EntityFramework;

namespace RestaurantReservation.WinFormPresenter;

public partial class BaseForm : Form
{
    public BaseForm()
    {
        InitializeComponent();
    }

    private void btnCustomer_Click(object sender, EventArgs e)
    {
        FrmCustomerOperation frm = new FrmCustomerOperation(new CustomerManager(new EfCustomerDal()));
        frm.Show();
    }

    private void btnMenuOperation_Click(object sender, EventArgs e)
    {
        FrmMenuOperation frm = new FrmMenuOperation(new MenuManager(new EfMenuDal()));
        frm.Show();
    }

    private void btnOrderOperations_Click(object sender, EventArgs e)
    {
        FrmOrderOperations frm = new FrmOrderOperations();
        frm.Show();
    }

    private void btnReservationOperations_Click(object sender, EventArgs e)
    {
        FrmReservationOperations frm = new FrmReservationOperations();
        frm.Show();
    }

    private void btnTableOperations_Click(object sender, EventArgs e)
    {
        FrmTableOperations frm = new FrmTableOperations(new TableManager(new EfTableDal()));
        frm.Show();
    }
}
