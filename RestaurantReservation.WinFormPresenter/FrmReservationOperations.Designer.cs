namespace RestaurantReservation.WinFormPresenter;

partial class FrmReservationOperations
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        cbxIsDeleted = new CheckBox();
        cbxIsActive = new CheckBox();
        rdbIsActive = new RadioButton();
        rdbIsNotActive = new RadioButton();
        rdbAll = new RadioButton();
        btnClear = new Button();
        btnGet = new Button();
        btnGetList = new Button();
        btnDelete = new Button();
        btnUpdate = new Button();
        btnAdd = new Button();
        dtpDate = new DateTimePicker();
        txtAddress = new TextBox();
        txtPhone = new TextBox();
        txtEmail = new TextBox();
        txtSurname = new TextBox();
        txtName = new TextBox();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        txtId = new TextBox();
        label1 = new Label();
        gbxCustomerOperations = new GroupBox();
        gbxCustomerList = new GroupBox();
        dgvCustomer = new DataGridView();
        gbxCustomerOperations.SuspendLayout();
        gbxCustomerList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
        SuspendLayout();
        // 
        // cbxIsDeleted
        // 
        cbxIsDeleted.AutoSize = true;
        cbxIsDeleted.Location = new Point(676, 73);
        cbxIsDeleted.Name = "cbxIsDeleted";
        cbxIsDeleted.Size = new Size(109, 29);
        cbxIsDeleted.TabIndex = 24;
        cbxIsDeleted.Text = "IsDeleted";
        cbxIsDeleted.UseVisualStyleBackColor = true;
        // 
        // cbxIsActive
        // 
        cbxIsActive.AutoSize = true;
        cbxIsActive.Checked = true;
        cbxIsActive.CheckState = CheckState.Checked;
        cbxIsActive.Location = new Point(555, 73);
        cbxIsActive.Name = "cbxIsActive";
        cbxIsActive.Size = new Size(95, 29);
        cbxIsActive.TabIndex = 23;
        cbxIsActive.Text = "IsActive";
        cbxIsActive.UseVisualStyleBackColor = true;
        // 
        // rdbIsActive
        // 
        rdbIsActive.AutoSize = true;
        rdbIsActive.Location = new Point(699, 114);
        rdbIsActive.Name = "rdbIsActive";
        rdbIsActive.Size = new Size(94, 29);
        rdbIsActive.TabIndex = 22;
        rdbIsActive.TabStop = true;
        rdbIsActive.Text = "IsActive";
        rdbIsActive.UseVisualStyleBackColor = true;
        // 
        // rdbIsNotActive
        // 
        rdbIsNotActive.AutoSize = true;
        rdbIsNotActive.Location = new Point(799, 114);
        rdbIsNotActive.Name = "rdbIsNotActive";
        rdbIsNotActive.Size = new Size(135, 29);
        rdbIsNotActive.TabIndex = 21;
        rdbIsNotActive.Text = "Is Not Active";
        rdbIsNotActive.UseVisualStyleBackColor = true;
        // 
        // rdbAll
        // 
        rdbAll.AutoSize = true;
        rdbAll.Checked = true;
        rdbAll.Location = new Point(555, 112);
        rdbAll.Name = "rdbAll";
        rdbAll.Size = new Size(138, 29);
        rdbAll.TabIndex = 20;
        rdbAll.TabStop = true;
        rdbAll.Text = "All Customer";
        rdbAll.UseVisualStyleBackColor = true;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.Green;
        btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnClear.ForeColor = Color.White;
        btnClear.Location = new Point(1081, 111);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(115, 32);
        btnClear.TabIndex = 19;
        btnClear.Text = "CLEAR";
        btnClear.UseVisualStyleBackColor = false;
        // 
        // btnGet
        // 
        btnGet.BackColor = Color.Green;
        btnGet.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnGet.ForeColor = Color.White;
        btnGet.Location = new Point(1081, 70);
        btnGet.Name = "btnGet";
        btnGet.Size = new Size(115, 32);
        btnGet.TabIndex = 18;
        btnGet.Text = "GET";
        btnGet.UseVisualStyleBackColor = false;
        // 
        // btnGetList
        // 
        btnGetList.BackColor = Color.Green;
        btnGetList.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnGetList.ForeColor = Color.White;
        btnGetList.Location = new Point(1081, 30);
        btnGetList.Name = "btnGetList";
        btnGetList.Size = new Size(115, 32);
        btnGetList.TabIndex = 17;
        btnGetList.Text = "GET LİST";
        btnGetList.UseVisualStyleBackColor = false;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Green;
        btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(957, 111);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(115, 32);
        btnDelete.TabIndex = 16;
        btnDelete.Text = "DELETE";
        btnDelete.UseVisualStyleBackColor = false;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.Green;
        btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnUpdate.ForeColor = Color.White;
        btnUpdate.Location = new Point(957, 70);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(115, 32);
        btnUpdate.TabIndex = 15;
        btnUpdate.Text = "UPDATE";
        btnUpdate.UseVisualStyleBackColor = false;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.Green;
        btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(957, 30);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(115, 32);
        btnAdd.TabIndex = 14;
        btnAdd.Text = "ADD";
        btnAdd.UseVisualStyleBackColor = false;
        // 
        // dtpDate
        // 
        dtpDate.Location = new Point(676, 28);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(255, 32);
        dtpDate.TabIndex = 13;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(376, 111);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(163, 32);
        txtAddress.TabIndex = 12;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(376, 71);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(163, 32);
        txtPhone.TabIndex = 11;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(376, 31);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(163, 32);
        txtEmail.TabIndex = 10;
        // 
        // txtSurname
        // 
        txtSurname.Location = new Point(116, 111);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(163, 32);
        txtSurname.TabIndex = 9;
        // 
        // txtName
        // 
        txtName.Location = new Point(116, 71);
        txtName.Name = "txtName";
        txtName.Size = new Size(163, 32);
        txtName.TabIndex = 8;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = Color.White;
        label7.Location = new Point(546, 34);
        label7.Name = "label7";
        label7.Size = new Size(131, 25);
        label7.TabIndex = 7;
        label7.Text = "Created Date :";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.White;
        label6.Location = new Point(287, 114);
        label6.Name = "label6";
        label6.Size = new Size(88, 25);
        label6.TabIndex = 6;
        label6.Text = "Address :";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.ForeColor = Color.White;
        label5.Location = new Point(300, 74);
        label5.Name = "label5";
        label5.Size = new Size(75, 25);
        label5.TabIndex = 5;
        label5.Text = "Phone :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.White;
        label4.Location = new Point(308, 34);
        label4.Name = "label4";
        label4.Size = new Size(67, 25);
        label4.TabIndex = 4;
        label4.Text = "Email :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.White;
        label3.Location = new Point(19, 114);
        label3.Name = "label3";
        label3.Size = new Size(96, 25);
        label3.TabIndex = 3;
        label3.Text = "Surname :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.White;
        label2.Location = new Point(44, 74);
        label2.Name = "label2";
        label2.Size = new Size(71, 25);
        label2.TabIndex = 2;
        label2.Text = "Name :";
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(116, 31);
        txtId.Name = "txtId";
        txtId.Size = new Size(163, 32);
        txtId.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.White;
        label1.Location = new Point(78, 34);
        label1.Name = "label1";
        label1.Size = new Size(37, 25);
        label1.TabIndex = 0;
        label1.Text = "Id :";
        // 
        // gbxCustomerOperations
        // 
        gbxCustomerOperations.Controls.Add(cbxIsDeleted);
        gbxCustomerOperations.Controls.Add(cbxIsActive);
        gbxCustomerOperations.Controls.Add(rdbIsActive);
        gbxCustomerOperations.Controls.Add(rdbIsNotActive);
        gbxCustomerOperations.Controls.Add(rdbAll);
        gbxCustomerOperations.Controls.Add(btnClear);
        gbxCustomerOperations.Controls.Add(btnGet);
        gbxCustomerOperations.Controls.Add(btnGetList);
        gbxCustomerOperations.Controls.Add(btnDelete);
        gbxCustomerOperations.Controls.Add(btnUpdate);
        gbxCustomerOperations.Controls.Add(btnAdd);
        gbxCustomerOperations.Controls.Add(dtpDate);
        gbxCustomerOperations.Controls.Add(txtAddress);
        gbxCustomerOperations.Controls.Add(txtPhone);
        gbxCustomerOperations.Controls.Add(txtEmail);
        gbxCustomerOperations.Controls.Add(txtSurname);
        gbxCustomerOperations.Controls.Add(txtName);
        gbxCustomerOperations.Controls.Add(label7);
        gbxCustomerOperations.Controls.Add(label6);
        gbxCustomerOperations.Controls.Add(label5);
        gbxCustomerOperations.Controls.Add(label4);
        gbxCustomerOperations.Controls.Add(label3);
        gbxCustomerOperations.Controls.Add(label2);
        gbxCustomerOperations.Controls.Add(txtId);
        gbxCustomerOperations.Controls.Add(label1);
        gbxCustomerOperations.ForeColor = Color.White;
        gbxCustomerOperations.Location = new Point(10, 11);
        gbxCustomerOperations.Name = "gbxCustomerOperations";
        gbxCustomerOperations.Size = new Size(1223, 170);
        gbxCustomerOperations.TabIndex = 3;
        gbxCustomerOperations.TabStop = false;
        gbxCustomerOperations.Text = "Customer CRUD";
        // 
        // gbxCustomerList
        // 
        gbxCustomerList.Controls.Add(dgvCustomer);
        gbxCustomerList.ForeColor = Color.Black;
        gbxCustomerList.Location = new Point(10, 187);
        gbxCustomerList.Name = "gbxCustomerList";
        gbxCustomerList.Size = new Size(1223, 613);
        gbxCustomerList.TabIndex = 2;
        gbxCustomerList.TabStop = false;
        gbxCustomerList.Text = "Customers List";
        // 
        // dgvCustomer
        // 
        dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Window;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
        dataGridViewCellStyle1.ForeColor = Color.Black;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
        dgvCustomer.DefaultCellStyle = dataGridViewCellStyle1;
        dgvCustomer.Dock = DockStyle.Fill;
        dgvCustomer.Location = new Point(3, 28);
        dgvCustomer.Name = "dgvCustomer";
        dgvCustomer.Size = new Size(1217, 582);
        dgvCustomer.TabIndex = 0;
        // 
        // FrmReservationOperations
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkGreen;
        ClientSize = new Size(1243, 810);
        Controls.Add(gbxCustomerOperations);
        Controls.Add(gbxCustomerList);
        Font = new Font("Segoe UI", 14F);
        Margin = new Padding(5, 5, 5, 5);
        Name = "FrmReservationOperations";
        Text = "FrmReservationOperations";
        gbxCustomerOperations.ResumeLayout(false);
        gbxCustomerOperations.PerformLayout();
        gbxCustomerList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private CheckBox cbxIsDeleted;
    private CheckBox cbxIsActive;
    private RadioButton rdbIsActive;
    private RadioButton rdbIsNotActive;
    private RadioButton rdbAll;
    private Button btnClear;
    private Button btnGet;
    private Button btnGetList;
    private Button btnDelete;
    private Button btnUpdate;
    private Button btnAdd;
    private DateTimePicker dtpDate;
    private TextBox txtAddress;
    private TextBox txtPhone;
    private TextBox txtEmail;
    private TextBox txtSurname;
    private TextBox txtName;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private TextBox txtId;
    private Label label1;
    private GroupBox gbxCustomerOperations;
    private GroupBox gbxCustomerList;
    private DataGridView dgvCustomer;
}