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
}
