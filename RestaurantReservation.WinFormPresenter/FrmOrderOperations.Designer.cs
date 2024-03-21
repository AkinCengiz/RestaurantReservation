namespace RestaurantReservation.WinFormPresenter;

partial class FrmOrderOperations
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
        gbxOrderOperations = new GroupBox();
        gbxOrderList = new GroupBox();
        dgvMenu = new DataGridView();
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
        gbxOrderOperations.SuspendLayout();
        gbxOrderList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
        SuspendLayout();
        // 
        // gbxOrderOperations
        // 
        gbxOrderOperations.Controls.Add(cbxIsDeleted);
        gbxOrderOperations.Controls.Add(cbxIsActive);
        gbxOrderOperations.Controls.Add(rdbIsActive);
        gbxOrderOperations.Controls.Add(rdbIsNotActive);
        gbxOrderOperations.Controls.Add(rdbAll);
        gbxOrderOperations.Controls.Add(btnClear);
        gbxOrderOperations.Controls.Add(btnGet);
        gbxOrderOperations.Controls.Add(btnGetList);
        gbxOrderOperations.Controls.Add(btnDelete);
        gbxOrderOperations.Controls.Add(btnUpdate);
        gbxOrderOperations.Controls.Add(btnAdd);
        gbxOrderOperations.Controls.Add(dtpDate);
        gbxOrderOperations.Controls.Add(txtAddress);
        gbxOrderOperations.Controls.Add(txtPhone);
        gbxOrderOperations.Controls.Add(txtEmail);
        gbxOrderOperations.Controls.Add(txtSurname);
        gbxOrderOperations.Controls.Add(txtName);
        gbxOrderOperations.Controls.Add(label7);
        gbxOrderOperations.Controls.Add(label6);
        gbxOrderOperations.Controls.Add(label5);
        gbxOrderOperations.Controls.Add(label4);
        gbxOrderOperations.Controls.Add(label3);
        gbxOrderOperations.Controls.Add(label2);
        gbxOrderOperations.Controls.Add(txtId);
        gbxOrderOperations.Controls.Add(label1);
        gbxOrderOperations.ForeColor = Color.White;
        gbxOrderOperations.Location = new Point(13, 11);
        gbxOrderOperations.Name = "gbxOrderOperations";
        gbxOrderOperations.Size = new Size(1223, 156);
        gbxOrderOperations.TabIndex = 5;
        gbxOrderOperations.TabStop = false;
        gbxOrderOperations.Text = "Order CRUD";
        // 
        // gbxOrderList
        // 
        gbxOrderList.Controls.Add(dgvMenu);
        gbxOrderList.ForeColor = Color.Black;
        gbxOrderList.Location = new Point(13, 173);
        gbxOrderList.Name = "gbxOrderList";
        gbxOrderList.Size = new Size(1223, 627);
        gbxOrderList.TabIndex = 4;
        gbxOrderList.TabStop = false;
        gbxOrderList.Text = "Order List";
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
        dgvMenu.Location = new Point(3, 28);
        dgvMenu.Name = "dgvMenu";
        dgvMenu.Size = new Size(1217, 596);
        dgvMenu.TabIndex = 0;
        // 
        // cbxIsDeleted
        // 
        cbxIsDeleted.AutoSize = true;
        cbxIsDeleted.Location = new Point(680, 66);
        cbxIsDeleted.Name = "cbxIsDeleted";
        cbxIsDeleted.Size = new Size(109, 29);
        cbxIsDeleted.TabIndex = 49;
        cbxIsDeleted.Text = "IsDeleted";
        cbxIsDeleted.UseVisualStyleBackColor = true;
        // 
        // cbxIsActive
        // 
        cbxIsActive.AutoSize = true;
        cbxIsActive.Checked = true;
        cbxIsActive.CheckState = CheckState.Checked;
        cbxIsActive.Location = new Point(559, 66);
        cbxIsActive.Name = "cbxIsActive";
        cbxIsActive.Size = new Size(95, 29);
        cbxIsActive.TabIndex = 48;
        cbxIsActive.Text = "IsActive";
        cbxIsActive.UseVisualStyleBackColor = true;
        // 
        // rdbIsActive
        // 
        rdbIsActive.AutoSize = true;
        rdbIsActive.Location = new Point(703, 107);
        rdbIsActive.Name = "rdbIsActive";
        rdbIsActive.Size = new Size(94, 29);
        rdbIsActive.TabIndex = 47;
        rdbIsActive.TabStop = true;
        rdbIsActive.Text = "IsActive";
        rdbIsActive.UseVisualStyleBackColor = true;
        // 
        // rdbIsNotActive
        // 
        rdbIsNotActive.AutoSize = true;
        rdbIsNotActive.Location = new Point(803, 107);
        rdbIsNotActive.Name = "rdbIsNotActive";
        rdbIsNotActive.Size = new Size(135, 29);
        rdbIsNotActive.TabIndex = 46;
        rdbIsNotActive.Text = "Is Not Active";
        rdbIsNotActive.UseVisualStyleBackColor = true;
        // 
        // rdbAll
        // 
        rdbAll.AutoSize = true;
        rdbAll.Checked = true;
        rdbAll.Location = new Point(559, 105);
        rdbAll.Name = "rdbAll";
        rdbAll.Size = new Size(138, 29);
        rdbAll.TabIndex = 45;
        rdbAll.TabStop = true;
        rdbAll.Text = "All Customer";
        rdbAll.UseVisualStyleBackColor = true;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.Green;
        btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnClear.ForeColor = Color.White;
        btnClear.Location = new Point(1085, 104);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(115, 32);
        btnClear.TabIndex = 44;
        btnClear.Text = "CLEAR";
        btnClear.UseVisualStyleBackColor = false;
        // 
        // btnGet
        // 
        btnGet.BackColor = Color.Green;
        btnGet.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnGet.ForeColor = Color.White;
        btnGet.Location = new Point(1085, 63);
        btnGet.Name = "btnGet";
        btnGet.Size = new Size(115, 32);
        btnGet.TabIndex = 43;
        btnGet.Text = "GET";
        btnGet.UseVisualStyleBackColor = false;
        // 
        // btnGetList
        // 
        btnGetList.BackColor = Color.Green;
        btnGetList.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnGetList.ForeColor = Color.White;
        btnGetList.Location = new Point(1085, 23);
        btnGetList.Name = "btnGetList";
        btnGetList.Size = new Size(115, 32);
        btnGetList.TabIndex = 42;
        btnGetList.Text = "GET LİST";
        btnGetList.UseVisualStyleBackColor = false;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Green;
        btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(961, 104);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(115, 32);
        btnDelete.TabIndex = 41;
        btnDelete.Text = "DELETE";
        btnDelete.UseVisualStyleBackColor = false;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.Green;
        btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnUpdate.ForeColor = Color.White;
        btnUpdate.Location = new Point(961, 63);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(115, 32);
        btnUpdate.TabIndex = 40;
        btnUpdate.Text = "UPDATE";
        btnUpdate.UseVisualStyleBackColor = false;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.Green;
        btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(961, 23);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(115, 32);
        btnAdd.TabIndex = 39;
        btnAdd.Text = "ADD";
        btnAdd.UseVisualStyleBackColor = false;
        // 
        // dtpDate
        // 
        dtpDate.Location = new Point(680, 21);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(255, 32);
        dtpDate.TabIndex = 38;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(380, 104);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(163, 32);
        txtAddress.TabIndex = 37;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(380, 64);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(163, 32);
        txtPhone.TabIndex = 36;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(380, 24);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(163, 32);
        txtEmail.TabIndex = 35;
        // 
        // txtSurname
        // 
        txtSurname.Location = new Point(120, 104);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(163, 32);
        txtSurname.TabIndex = 34;
        // 
        // txtName
        // 
        txtName.Location = new Point(120, 64);
        txtName.Name = "txtName";
        txtName.Size = new Size(163, 32);
        txtName.TabIndex = 33;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = Color.White;
        label7.Location = new Point(550, 27);
        label7.Name = "label7";
        label7.Size = new Size(114, 25);
        label7.TabIndex = 32;
        label7.Text = "Order Date :";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.White;
        label6.Location = new Point(291, 107);
        label6.Name = "label6";
        label6.Size = new Size(88, 25);
        label6.TabIndex = 31;
        label6.Text = "Address :";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.ForeColor = Color.White;
        label5.Location = new Point(304, 67);
        label5.Name = "label5";
        label5.Size = new Size(75, 25);
        label5.TabIndex = 30;
        label5.Text = "Phone :";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.White;
        label4.Location = new Point(312, 27);
        label4.Name = "label4";
        label4.Size = new Size(67, 25);
        label4.TabIndex = 29;
        label4.Text = "Email :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.White;
        label3.Location = new Point(23, 107);
        label3.Name = "label3";
        label3.Size = new Size(96, 25);
        label3.TabIndex = 28;
        label3.Text = "Surname :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.White;
        label2.Location = new Point(48, 67);
        label2.Name = "label2";
        label2.Size = new Size(71, 25);
        label2.TabIndex = 27;
        label2.Text = "Name :";
        // 
        // txtId
        // 
        txtId.Enabled = false;
        txtId.Location = new Point(120, 24);
        txtId.Name = "txtId";
        txtId.Size = new Size(163, 32);
        txtId.TabIndex = 26;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.White;
        label1.Location = new Point(82, 27);
        label1.Name = "label1";
        label1.Size = new Size(37, 25);
        label1.TabIndex = 25;
        label1.Text = "Id :";
        // 
        // FrmOrderOperations
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkGreen;
        ClientSize = new Size(1249, 811);
        Controls.Add(gbxOrderOperations);
        Controls.Add(gbxOrderList);
        Font = new Font("Segoe UI", 14F);
        Margin = new Padding(5, 5, 5, 5);
        Name = "FrmOrderOperations";
        Text = "FrmOrderOperations";
        gbxOrderOperations.ResumeLayout(false);
        gbxOrderOperations.PerformLayout();
        gbxOrderList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox gbxOrderOperations;
    private GroupBox gbxOrderList;
    private DataGridView dgvMenu;
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
}