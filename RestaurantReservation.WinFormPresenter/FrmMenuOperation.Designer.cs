namespace RestaurantReservation.WinFormPresenter;

partial class FrmMenuOperation
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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
        txtPrice = new TextBox();
        txtDescription = new TextBox();
        txtTitle = new TextBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        txtId = new TextBox();
        label1 = new Label();
        gbxCustomerOperations = new GroupBox();
        gbxCustomerList = new GroupBox();
        dgvMenu = new DataGridView();
        gbxCustomerOperations.SuspendLayout();
        gbxCustomerList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
        SuspendLayout();
        // 
        // cbxIsDeleted
        // 
        cbxIsDeleted.AutoSize = true;
        cbxIsDeleted.Location = new Point(676, 32);
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
        cbxIsActive.Location = new Point(555, 32);
        cbxIsActive.Name = "cbxIsActive";
        cbxIsActive.Size = new Size(95, 29);
        cbxIsActive.TabIndex = 23;
        cbxIsActive.Text = "IsActive";
        cbxIsActive.UseVisualStyleBackColor = true;
        // 
        // rdbIsActive
        // 
        rdbIsActive.AutoSize = true;
        rdbIsActive.Location = new Point(676, 72);
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
        rdbIsNotActive.Location = new Point(776, 73);
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
        rdbAll.Location = new Point(555, 71);
        rdbAll.Name = "rdbAll";
        rdbAll.Size = new Size(106, 29);
        rdbAll.TabIndex = 20;
        rdbAll.TabStop = true;
        rdbAll.Text = "All Menu";
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
        // txtPrice
        // 
        txtPrice.Location = new Point(368, 71);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(163, 33);
        txtPrice.TabIndex = 10;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(368, 31);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(163, 33);
        txtDescription.TabIndex = 9;
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(74, 71);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(163, 33);
        txtTitle.TabIndex = 8;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.White;
        label4.Location = new Point(300, 74);
        label4.Name = "label4";
        label4.Size = new Size(63, 25);
        label4.TabIndex = 4;
        label4.Text = "Price :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.White;
        label3.Location = new Point(249, 34);
        label3.Name = "label3";
        label3.Size = new Size(117, 25);
        label3.TabIndex = 3;
        label3.Text = "Description :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.White;
        label2.Location = new Point(15, 74);
        label2.Name = "label2";
        label2.Size = new Size(57, 25);
        label2.TabIndex = 2;
        label2.Text = "Title :";
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(74, 31);
        txtId.Name = "txtId";
        txtId.Size = new Size(163, 33);
        txtId.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.White;
        label1.Location = new Point(35, 34);
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
        gbxCustomerOperations.Controls.Add(txtPrice);
        gbxCustomerOperations.Controls.Add(txtDescription);
        gbxCustomerOperations.Controls.Add(txtTitle);
        gbxCustomerOperations.Controls.Add(label4);
        gbxCustomerOperations.Controls.Add(label3);
        gbxCustomerOperations.Controls.Add(label2);
        gbxCustomerOperations.Controls.Add(txtId);
        gbxCustomerOperations.Controls.Add(label1);
        gbxCustomerOperations.ForeColor = Color.White;
        gbxCustomerOperations.Location = new Point(11, 13);
        gbxCustomerOperations.Name = "gbxCustomerOperations";
        gbxCustomerOperations.Size = new Size(1223, 156);
        gbxCustomerOperations.TabIndex = 3;
        gbxCustomerOperations.TabStop = false;
        gbxCustomerOperations.Text = "Menu CRUD";
        // 
        // gbxCustomerList
        // 
        gbxCustomerList.Controls.Add(dgvMenu);
        gbxCustomerList.ForeColor = Color.Black;
        gbxCustomerList.Location = new Point(11, 175);
        gbxCustomerList.Name = "gbxCustomerList";
        gbxCustomerList.Size = new Size(1223, 627);
        gbxCustomerList.TabIndex = 2;
        gbxCustomerList.TabStop = false;
        gbxCustomerList.Text = "Menu List";
        // 
        // dgvMenu
        // 
        dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Window;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 14F);
        dataGridViewCellStyle4.ForeColor = Color.Black;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        dgvMenu.DefaultCellStyle = dataGridViewCellStyle4;
        dgvMenu.Dock = DockStyle.Fill;
        dgvMenu.Location = new Point(3, 29);
        dgvMenu.Name = "dgvMenu";
        dgvMenu.Size = new Size(1217, 595);
        dgvMenu.TabIndex = 0;
        dgvMenu.SelectionChanged += dgvMenu_SelectionChanged;
        dgvMenu.DoubleClick += dgvMenu_DoubleClick;
        // 
        // FrmMenuOperation
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkGreen;
        ClientSize = new Size(1244, 814);
        Controls.Add(gbxCustomerOperations);
        Controls.Add(gbxCustomerList);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
        Margin = new Padding(5);
        Name = "FrmMenuOperation";
        Text = "FrmMenu";
        Load += FrmMenuOperation_Load;
        gbxCustomerOperations.ResumeLayout(false);
        gbxCustomerOperations.PerformLayout();
        gbxCustomerList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
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
    private TextBox txtPrice;
    private TextBox txtDescription;
    private TextBox txtTitle;
    private Label label4;
    private Label label3;
    private Label label2;
    private TextBox txtId;
    private Label label1;
    private GroupBox gbxCustomerOperations;
    private GroupBox gbxCustomerList;
    private DataGridView dgvMenu;
}