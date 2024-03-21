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
        label7 = new Label();
        label3 = new Label();
        label2 = new Label();
        txtId = new TextBox();
        label1 = new Label();
        gbxCustomerOperations = new GroupBox();
        cmbTables = new ComboBox();
        cmbCustomers = new ComboBox();
        dtpTime = new DateTimePicker();
        label4 = new Label();
        gbxCustomerList = new GroupBox();
        dgvReservations = new DataGridView();
        gbxCustomerOperations.SuspendLayout();
        gbxCustomerList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
        SuspendLayout();
        // 
        // cbxIsDeleted
        // 
        cbxIsDeleted.AutoSize = true;
        cbxIsDeleted.Location = new Point(738, 73);
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
        cbxIsActive.Location = new Point(738, 33);
        cbxIsActive.Name = "cbxIsActive";
        cbxIsActive.Size = new Size(95, 29);
        cbxIsActive.TabIndex = 23;
        cbxIsActive.Text = "IsActive";
        cbxIsActive.UseVisualStyleBackColor = true;
        // 
        // rdbIsActive
        // 
        rdbIsActive.AutoSize = true;
        rdbIsActive.Location = new Point(542, 111);
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
        rdbIsNotActive.Location = new Point(642, 111);
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
        rdbAll.Location = new Point(401, 110);
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
        btnClear.Click += btnClear_Click;
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
        btnGet.Click += btnGet_Click;
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
        btnGetList.Click += btnGetList_Click;
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
        btnDelete.Click += btnDelete_Click;
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
        btnUpdate.Click += btnUpdate_Click;
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
        btnAdd.Click += btnAdd_Click;
        // 
        // dtpDate
        // 
        dtpDate.Location = new Point(466, 28);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(255, 32);
        dtpDate.TabIndex = 13;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = Color.White;
        label7.Location = new Point(401, 34);
        label7.Name = "label7";
        label7.Size = new Size(60, 25);
        label7.TabIndex = 7;
        label7.Text = "Date :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.White;
        label3.Location = new Point(50, 112);
        label3.Name = "label3";
        label3.Size = new Size(65, 25);
        label3.TabIndex = 3;
        label3.Text = "Table :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.White;
        label2.Location = new Point(13, 75);
        label2.Name = "label2";
        label2.Size = new Size(102, 25);
        label2.TabIndex = 2;
        label2.Text = "Customer :";
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(123, 31);
        txtId.Name = "txtId";
        txtId.Size = new Size(229, 32);
        txtId.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.White;
        label1.Location = new Point(78, 33);
        label1.Name = "label1";
        label1.Size = new Size(37, 25);
        label1.TabIndex = 0;
        label1.Text = "Id :";
        // 
        // gbxCustomerOperations
        // 
        gbxCustomerOperations.Controls.Add(cmbTables);
        gbxCustomerOperations.Controls.Add(cmbCustomers);
        gbxCustomerOperations.Controls.Add(dtpTime);
        gbxCustomerOperations.Controls.Add(label4);
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
        gbxCustomerOperations.Controls.Add(label7);
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
        gbxCustomerOperations.Text = "Reservation CRUD";
        // 
        // cmbTables
        // 
        cmbTables.FormattingEnabled = true;
        cmbTables.Location = new Point(123, 111);
        cmbTables.Name = "cmbTables";
        cmbTables.Size = new Size(229, 33);
        cmbTables.TabIndex = 28;
        // 
        // cmbCustomers
        // 
        cmbCustomers.FormattingEnabled = true;
        cmbCustomers.Location = new Point(123, 71);
        cmbCustomers.Name = "cmbCustomers";
        cmbCustomers.Size = new Size(229, 33);
        cmbCustomers.TabIndex = 27;
        // 
        // dtpTime
        // 
        dtpTime.DropDownAlign = LeftRightAlignment.Right;
        dtpTime.Format = DateTimePickerFormat.Time;
        dtpTime.Location = new Point(466, 68);
        dtpTime.Name = "dtpTime";
        dtpTime.Size = new Size(255, 32);
        dtpTime.TabIndex = 26;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.White;
        label4.Location = new Point(401, 74);
        label4.Name = "label4";
        label4.Size = new Size(62, 25);
        label4.TabIndex = 25;
        label4.Text = "Time :";
        // 
        // gbxCustomerList
        // 
        gbxCustomerList.Controls.Add(dgvReservations);
        gbxCustomerList.ForeColor = Color.Black;
        gbxCustomerList.Location = new Point(10, 187);
        gbxCustomerList.Name = "gbxCustomerList";
        gbxCustomerList.Size = new Size(1223, 613);
        gbxCustomerList.TabIndex = 2;
        gbxCustomerList.TabStop = false;
        gbxCustomerList.Text = "Reservation List";
        // 
        // dgvReservations
        // 
        dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvReservations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Window;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
        dataGridViewCellStyle1.ForeColor = Color.Black;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
        dgvReservations.DefaultCellStyle = dataGridViewCellStyle1;
        dgvReservations.Dock = DockStyle.Fill;
        dgvReservations.Location = new Point(3, 28);
        dgvReservations.Name = "dgvReservations";
        dgvReservations.Size = new Size(1217, 582);
        dgvReservations.TabIndex = 0;
        dgvReservations.SelectionChanged += dgvReservations_SelectionChanged;
        dgvReservations.DoubleClick += dgvReservations_DoubleClick;
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
        Margin = new Padding(5);
        Name = "FrmReservationOperations";
        Text = "FrmReservationOperations";
        Load += FrmReservationOperations_Load;
        gbxCustomerOperations.ResumeLayout(false);
        gbxCustomerOperations.PerformLayout();
        gbxCustomerList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
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
    private Label label7;
    private Label label3;
    private Label label2;
    private TextBox txtId;
    private Label label1;
    private GroupBox gbxCustomerOperations;
    private GroupBox gbxCustomerList;
    private DataGridView dgvReservations;
    private DateTimePicker dtpTime;
    private Label label4;
    private ComboBox cmbTables;
    private ComboBox cmbCustomers;
}