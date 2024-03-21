namespace RestaurantReservation.WinFormPresenter;

partial class BaseForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnCustomer = new Button();
        btnMenuOperation = new Button();
        btnOrderOperations = new Button();
        btnReservationOperations = new Button();
        btnTableOperations = new Button();
        SuspendLayout();
        // 
        // btnCustomer
        // 
        btnCustomer.BackColor = Color.Green;
        btnCustomer.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnCustomer.ForeColor = Color.White;
        btnCustomer.Location = new Point(12, 12);
        btnCustomer.Name = "btnCustomer";
        btnCustomer.Size = new Size(137, 115);
        btnCustomer.TabIndex = 0;
        btnCustomer.Text = "Customer Operation";
        btnCustomer.UseVisualStyleBackColor = false;
        btnCustomer.Click += btnCustomer_Click;
        // 
        // btnMenuOperation
        // 
        btnMenuOperation.BackColor = Color.Green;
        btnMenuOperation.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnMenuOperation.ForeColor = Color.White;
        btnMenuOperation.Location = new Point(168, 12);
        btnMenuOperation.Name = "btnMenuOperation";
        btnMenuOperation.Size = new Size(137, 115);
        btnMenuOperation.TabIndex = 1;
        btnMenuOperation.Text = "Menu Operation";
        btnMenuOperation.UseVisualStyleBackColor = false;
        btnMenuOperation.Click += btnMenuOperation_Click;
        // 
        // btnOrderOperations
        // 
        btnOrderOperations.BackColor = Color.Green;
        btnOrderOperations.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnOrderOperations.ForeColor = Color.White;
        btnOrderOperations.Location = new Point(323, 12);
        btnOrderOperations.Name = "btnOrderOperations";
        btnOrderOperations.Size = new Size(137, 115);
        btnOrderOperations.TabIndex = 2;
        btnOrderOperations.Text = "Order Operation";
        btnOrderOperations.UseVisualStyleBackColor = false;
        btnOrderOperations.Click += btnOrderOperations_Click;
        // 
        // btnReservationOperations
        // 
        btnReservationOperations.BackColor = Color.Green;
        btnReservationOperations.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnReservationOperations.ForeColor = Color.White;
        btnReservationOperations.Location = new Point(475, 12);
        btnReservationOperations.Name = "btnReservationOperations";
        btnReservationOperations.Size = new Size(137, 115);
        btnReservationOperations.TabIndex = 3;
        btnReservationOperations.Text = "Reservation Operation";
        btnReservationOperations.UseVisualStyleBackColor = false;
        btnReservationOperations.Click += btnReservationOperations_Click;
        // 
        // btnTableOperations
        // 
        btnTableOperations.BackColor = Color.Green;
        btnTableOperations.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnTableOperations.ForeColor = Color.White;
        btnTableOperations.Location = new Point(628, 12);
        btnTableOperations.Name = "btnTableOperations";
        btnTableOperations.Size = new Size(137, 115);
        btnTableOperations.TabIndex = 4;
        btnTableOperations.Text = "Table Operation";
        btnTableOperations.UseVisualStyleBackColor = false;
        btnTableOperations.Click += btnTableOperations_Click;
        // 
        // BaseForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkGreen;
        ClientSize = new Size(1228, 808);
        Controls.Add(btnTableOperations);
        Controls.Add(btnReservationOperations);
        Controls.Add(btnOrderOperations);
        Controls.Add(btnMenuOperation);
        Controls.Add(btnCustomer);
        Font = new Font("Segoe UI", 14F);
        Margin = new Padding(5);
        Name = "BaseForm";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button btnCustomer;
    private Button btnMenuOperation;
    private Button btnOrderOperations;
    private Button btnReservationOperations;
    private Button btnTableOperations;
}
