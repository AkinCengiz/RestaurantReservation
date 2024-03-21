namespace RestaurantReservation.WinFormPresenter;

partial class FrmTableOperations
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
        gbxCustomerOperations = new GroupBox();
        cbxIsDeleted = new CheckBox();
        btnClear = new Button();
        cbxIsActive = new CheckBox();
        rdbIsActive = new RadioButton();
        btnGet = new Button();
        rdbIsNotActive = new RadioButton();
        btnGetList = new Button();
        rdbAll = new RadioButton();
        btnDelete = new Button();
        btnUpdate = new Button();
        btnAdd = new Button();
        txtCapacity = new TextBox();
        txtName = new TextBox();
        label3 = new Label();
        label2 = new Label();
        txtId = new TextBox();
        label1 = new Label();
        gbxCustomerList = new GroupBox();
        dgvTable = new DataGridView();
        gbxCustomerOperations.SuspendLayout();
        gbxCustomerList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
        SuspendLayout();
        // 
        // gbxCustomerOperations
        // 
        gbxCustomerOperations.Controls.Add(cbxIsDeleted);
        gbxCustomerOperations.Controls.Add(btnClear);
        gbxCustomerOperations.Controls.Add(cbxIsActive);
        gbxCustomerOperations.Controls.Add(rdbIsActive);
        gbxCustomerOperations.Controls.Add(btnGet);
        gbxCustomerOperations.Controls.Add(rdbIsNotActive);
        gbxCustomerOperations.Controls.Add(btnGetList);
        gbxCustomerOperations.Controls.Add(rdbAll);
        gbxCustomerOperations.Controls.Add(btnDelete);
        gbxCustomerOperations.Controls.Add(btnUpdate);
        gbxCustomerOperations.Controls.Add(btnAdd);
        gbxCustomerOperations.Controls.Add(txtCapacity);
        gbxCustomerOperations.Controls.Add(txtName);
        gbxCustomerOperations.Controls.Add(label3);
        gbxCustomerOperations.Controls.Add(label2);
        gbxCustomerOperations.Controls.Add(txtId);
        gbxCustomerOperations.Controls.Add(label1);
        gbxCustomerOperations.ForeColor = Color.White;
        gbxCustomerOperations.Location = new Point(10, 10);
        gbxCustomerOperations.Name = "gbxCustomerOperations";
        gbxCustomerOperations.Size = new Size(1223, 170);
        gbxCustomerOperations.TabIndex = 5;
        gbxCustomerOperations.TabStop = false;
        gbxCustomerOperations.Text = "Table CRUD";
        // 
        // cbxIsDeleted
        // 
        cbxIsDeleted.AutoSize = true;
        cbxIsDeleted.Location = new Point(445, 33);
        cbxIsDeleted.Name = "cbxIsDeleted";
        cbxIsDeleted.Size = new Size(109, 29);
        cbxIsDeleted.TabIndex = 29;
        cbxIsDeleted.Text = "IsDeleted";
        cbxIsDeleted.UseVisualStyleBackColor = true;
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
        // cbxIsActive
        // 
        cbxIsActive.AutoSize = true;
        cbxIsActive.Checked = true;
        cbxIsActive.CheckState = CheckState.Checked;
        cbxIsActive.Location = new Point(324, 33);
        cbxIsActive.Name = "cbxIsActive";
        cbxIsActive.Size = new Size(95, 29);
        cbxIsActive.TabIndex = 28;
        cbxIsActive.Text = "IsActive";
        cbxIsActive.UseVisualStyleBackColor = true;
        // 
        // rdbIsActive
        // 
        rdbIsActive.AutoSize = true;
        rdbIsActive.Location = new Point(445, 113);
        rdbIsActive.Name = "rdbIsActive";
        rdbIsActive.Size = new Size(94, 29);
        rdbIsActive.TabIndex = 27;
        rdbIsActive.TabStop = true;
        rdbIsActive.Text = "IsActive";
        rdbIsActive.UseVisualStyleBackColor = true;
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
        // rdbIsNotActive
        // 
        rdbIsNotActive.AutoSize = true;
        rdbIsNotActive.Location = new Point(545, 114);
        rdbIsNotActive.Name = "rdbIsNotActive";
        rdbIsNotActive.Size = new Size(135, 29);
        rdbIsNotActive.TabIndex = 26;
        rdbIsNotActive.Text = "Is Not Active";
        rdbIsNotActive.UseVisualStyleBackColor = true;
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
        // rdbAll
        // 
        rdbAll.AutoSize = true;
        rdbAll.Checked = true;
        rdbAll.Location = new Point(324, 112);
        rdbAll.Name = "rdbAll";
        rdbAll.Size = new Size(106, 29);
        rdbAll.TabIndex = 25;
        rdbAll.TabStop = true;
        rdbAll.Text = "All Menu";
        rdbAll.UseVisualStyleBackColor = true;
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
        // txtCapacity
        // 
        txtCapacity.Location = new Point(116, 111);
        txtCapacity.Name = "txtCapacity";
        txtCapacity.Size = new Size(163, 32);
        txtCapacity.TabIndex = 9;
        // 
        // txtName
        // 
        txtName.Location = new Point(116, 71);
        txtName.Name = "txtName";
        txtName.Size = new Size(163, 32);
        txtName.TabIndex = 8;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.White;
        label3.Location = new Point(19, 114);
        label3.Name = "label3";
        label3.Size = new Size(93, 25);
        label3.TabIndex = 3;
        label3.Text = "Capacity :";
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
        // gbxCustomerList
        // 
        gbxCustomerList.Controls.Add(dgvTable);
        gbxCustomerList.ForeColor = Color.Black;
        gbxCustomerList.Location = new Point(10, 186);
        gbxCustomerList.Name = "gbxCustomerList";
        gbxCustomerList.Size = new Size(1223, 613);
        gbxCustomerList.TabIndex = 4;
        gbxCustomerList.TabStop = false;
        gbxCustomerList.Text = "Table List";
        // 
        // dgvTable
        // 
        dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTable.Dock = DockStyle.Fill;
        dgvTable.Location = new Point(3, 28);
        dgvTable.Name = "dgvTable";
        dgvTable.Size = new Size(1217, 582);
        dgvTable.TabIndex = 0;
        dgvTable.SelectionChanged += dgvTable_SelectionChanged;
        dgvTable.DoubleClick += dgvTable_DoubleClick;
        // 
        // FrmTableOperations
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkGreen;
        ClientSize = new Size(1243, 809);
        Controls.Add(gbxCustomerOperations);
        Controls.Add(gbxCustomerList);
        Font = new Font("Segoe UI", 14F);
        Margin = new Padding(5);
        Name = "FrmTableOperations";
        Text = "FrmTableOperations";
        Load += FrmTableOperations_Load;
        gbxCustomerOperations.ResumeLayout(false);
        gbxCustomerOperations.PerformLayout();
        gbxCustomerList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox gbxCustomerOperations;
    private Button btnClear;
    private Button btnGet;
    private Button btnGetList;
    private Button btnDelete;
    private Button btnUpdate;
    private Button btnAdd;
    private TextBox txtCapacity;
    private TextBox txtName;
    private Label label3;
    private Label label2;
    private TextBox txtId;
    private Label label1;
    private GroupBox gbxCustomerList;
    private DataGridView dgvTable;
    private CheckBox cbxIsDeleted;
    private CheckBox cbxIsActive;
    private RadioButton rdbIsActive;
    private RadioButton rdbIsNotActive;
    private RadioButton rdbAll;
}