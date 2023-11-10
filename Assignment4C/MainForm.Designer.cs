namespace PartyOrganizer

{
    partial class MainForm
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
            gBoxNewParty = new GroupBox();
            txtFeePerPers = new TextBox();
            txtCostPerPers = new TextBox();
            txtMaxNumGuest = new TextBox();
            btnCreateList = new Button();
            lblFeePerPers = new Label();
            lblCostPerPers = new Label();
            lblMaxNrGuest = new Label();
            gBoxInviteGuest = new GroupBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnAddGuest = new Button();
            lBoxGuestList = new ListBox();
            lblGuestList = new Label();
            btnChange = new Button();
            btnDelete = new Button();
            lblTotGuests = new Label();
            lblTotCost = new Label();
            lblTotFee = new Label();
            lblSurpDef = new Label();
            lblResNumGuest = new Label();
            lblResTotalCost = new Label();
            lblResTotalFees = new Label();
            lblResSurpDef = new Label();
            gBoxNewParty.SuspendLayout();
            gBoxInviteGuest.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxNewParty
            // 
            gBoxNewParty.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gBoxNewParty.Controls.Add(txtFeePerPers);
            gBoxNewParty.Controls.Add(txtCostPerPers);
            gBoxNewParty.Controls.Add(txtMaxNumGuest);
            gBoxNewParty.Controls.Add(btnCreateList);
            gBoxNewParty.Controls.Add(lblFeePerPers);
            gBoxNewParty.Controls.Add(lblCostPerPers);
            gBoxNewParty.Controls.Add(lblMaxNrGuest);
            gBoxNewParty.Location = new Point(12, 21);
            gBoxNewParty.Name = "gBoxNewParty";
            gBoxNewParty.Size = new Size(292, 168);
            gBoxNewParty.TabIndex = 0;
            gBoxNewParty.TabStop = false;
            gBoxNewParty.Text = "New Party";
            // 
            // txtFeePerPers
            // 
            txtFeePerPers.Location = new Point(190, 86);
            txtFeePerPers.Name = "txtFeePerPers";
            txtFeePerPers.Size = new Size(89, 23);
            txtFeePerPers.TabIndex = 6;
            // 
            // txtCostPerPers
            // 
            txtCostPerPers.Location = new Point(190, 56);
            txtCostPerPers.Name = "txtCostPerPers";
            txtCostPerPers.Size = new Size(89, 23);
            txtCostPerPers.TabIndex = 5;
            // 
            // txtMaxNumGuest
            // 
            txtMaxNumGuest.Location = new Point(190, 26);
            txtMaxNumGuest.Name = "txtMaxNumGuest";
            txtMaxNumGuest.Size = new Size(89, 23);
            txtMaxNumGuest.TabIndex = 4;
            // 
            // btnCreateList
            // 
            btnCreateList.Location = new Point(103, 121);
            btnCreateList.Name = "btnCreateList";
            btnCreateList.Size = new Size(91, 30);
            btnCreateList.TabIndex = 3;
            btnCreateList.Text = "Create List";
            btnCreateList.UseVisualStyleBackColor = true;
            btnCreateList.Click += btnCreateList_Click;
            // 
            // lblFeePerPers
            // 
            lblFeePerPers.AutoSize = true;
            lblFeePerPers.Location = new Point(12, 90);
            lblFeePerPers.Name = "lblFeePerPers";
            lblFeePerPers.Size = new Size(84, 15);
            lblFeePerPers.TabIndex = 2;
            lblFeePerPers.Text = "Fee per person";
            // 
            // lblCostPerPers
            // 
            lblCostPerPers.AutoSize = true;
            lblCostPerPers.Location = new Point(12, 60);
            lblCostPerPers.Name = "lblCostPerPers";
            lblCostPerPers.Size = new Size(90, 15);
            lblCostPerPers.TabIndex = 1;
            lblCostPerPers.Text = "Cost per person";
            // 
            // lblMaxNrGuest
            // 
            lblMaxNrGuest.AutoSize = true;
            lblMaxNrGuest.Location = new Point(12, 30);
            lblMaxNrGuest.Name = "lblMaxNrGuest";
            lblMaxNrGuest.Size = new Size(121, 15);
            lblMaxNrGuest.TabIndex = 0;
            lblMaxNrGuest.Text = "Max number of guest";
            // 
            // gBoxInviteGuest
            // 
            gBoxInviteGuest.Controls.Add(txtLastName);
            gBoxInviteGuest.Controls.Add(txtFirstName);
            gBoxInviteGuest.Controls.Add(lblLastName);
            gBoxInviteGuest.Controls.Add(lblFirstName);
            gBoxInviteGuest.Controls.Add(btnAddGuest);
            gBoxInviteGuest.Location = new Point(12, 195);
            gBoxInviteGuest.Name = "gBoxInviteGuest";
            gBoxInviteGuest.Size = new Size(292, 153);
            gBoxInviteGuest.TabIndex = 1;
            gBoxInviteGuest.TabStop = false;
            gBoxInviteGuest.Text = "Invite Guest";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(94, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 23);
            txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(94, 28);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 23);
            txtFirstName.TabIndex = 7;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 66);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 32);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name";
            // 
            // btnAddGuest
            // 
            btnAddGuest.Location = new Point(103, 107);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(93, 30);
            btnAddGuest.TabIndex = 4;
            btnAddGuest.Text = "Add";
            btnAddGuest.UseVisualStyleBackColor = true;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // lBoxGuestList
            // 
            lBoxGuestList.FormattingEnabled = true;
            lBoxGuestList.ItemHeight = 15;
            lBoxGuestList.Location = new Point(326, 40);
            lBoxGuestList.Name = "lBoxGuestList";
            lBoxGuestList.Size = new Size(315, 394);
            lBoxGuestList.TabIndex = 2;
            // 
            // lblGuestList
            // 
            lblGuestList.AutoSize = true;
            lblGuestList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGuestList.Location = new Point(443, 12);
            lblGuestList.Name = "lblGuestList";
            lblGuestList.Size = new Size(78, 21);
            lblGuestList.TabIndex = 3;
            lblGuestList.Text = "Guest List";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(390, 440);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(93, 30);
            btnChange.TabIndex = 9;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(489, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 30);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTotGuests
            // 
            lblTotGuests.AutoSize = true;
            lblTotGuests.Location = new Point(24, 372);
            lblTotGuests.Name = "lblTotGuests";
            lblTotGuests.Size = new Size(100, 15);
            lblTotGuests.TabIndex = 11;
            lblTotGuests.Text = "Number of guest ";
            // 
            // lblTotCost
            // 
            lblTotCost.AutoSize = true;
            lblTotCost.Location = new Point(24, 395);
            lblTotCost.Name = "lblTotCost";
            lblTotCost.Size = new Size(59, 15);
            lblTotCost.TabIndex = 12;
            lblTotCost.Text = "Total Cost";
            // 
            // lblTotFee
            // 
            lblTotFee.AutoSize = true;
            lblTotFee.Location = new Point(24, 418);
            lblTotFee.Name = "lblTotFee";
            lblTotFee.Size = new Size(56, 15);
            lblTotFee.TabIndex = 13;
            lblTotFee.Text = "Total fees";
            // 
            // lblSurpDef
            // 
            lblSurpDef.AutoSize = true;
            lblSurpDef.Location = new Point(24, 441);
            lblSurpDef.Name = "lblSurpDef";
            lblSurpDef.Size = new Size(84, 15);
            lblSurpDef.TabIndex = 14;
            lblSurpDef.Text = "Surplus/deficit";
            // 
            // lblResNumGuest
            // 
            lblResNumGuest.AutoSize = true;
            lblResNumGuest.BorderStyle = BorderStyle.Fixed3D;
            lblResNumGuest.Location = new Point(178, 368);
            lblResNumGuest.MinimumSize = new Size(110, 23);
            lblResNumGuest.Name = "lblResNumGuest";
            lblResNumGuest.Size = new Size(110, 23);
            lblResNumGuest.TabIndex = 15;
            // 
            // lblResTotalCost
            // 
            lblResTotalCost.AutoSize = true;
            lblResTotalCost.BorderStyle = BorderStyle.Fixed3D;
            lblResTotalCost.Location = new Point(178, 391);
            lblResTotalCost.MinimumSize = new Size(110, 23);
            lblResTotalCost.Name = "lblResTotalCost";
            lblResTotalCost.Size = new Size(110, 23);
            lblResTotalCost.TabIndex = 16;
            // 
            // lblResTotalFees
            // 
            lblResTotalFees.AutoSize = true;
            lblResTotalFees.BorderStyle = BorderStyle.Fixed3D;
            lblResTotalFees.Location = new Point(178, 414);
            lblResTotalFees.MinimumSize = new Size(110, 23);
            lblResTotalFees.Name = "lblResTotalFees";
            lblResTotalFees.Size = new Size(110, 23);
            lblResTotalFees.TabIndex = 17;
            // 
            // lblResSurpDef
            // 
            lblResSurpDef.AutoSize = true;
            lblResSurpDef.BorderStyle = BorderStyle.Fixed3D;
            lblResSurpDef.Location = new Point(178, 437);
            lblResSurpDef.MinimumSize = new Size(110, 23);
            lblResSurpDef.Name = "lblResSurpDef";
            lblResSurpDef.Size = new Size(110, 23);
            lblResSurpDef.TabIndex = 18;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 491);
            Controls.Add(lblResSurpDef);
            Controls.Add(lblResTotalFees);
            Controls.Add(lblResTotalCost);
            Controls.Add(lblResNumGuest);
            Controls.Add(lblSurpDef);
            Controls.Add(lblTotFee);
            Controls.Add(lblTotCost);
            Controls.Add(lblTotGuests);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(lblGuestList);
            Controls.Add(lBoxGuestList);
            Controls.Add(gBoxInviteGuest);
            Controls.Add(gBoxNewParty);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = " ";
            gBoxNewParty.ResumeLayout(false);
            gBoxNewParty.PerformLayout();
            gBoxInviteGuest.ResumeLayout(false);
            gBoxInviteGuest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxNewParty;
        private GroupBox gBoxInviteGuest;
        private TextBox txtFeePerPers;
        private TextBox txtCostPerPers;
        private TextBox txtMaxNumGuest;
        private Button btnCreateList;
        private Label lblFeePerPers;
        private Label lblCostPerPers;
        private Label lblMaxNrGuest;
        private Button btnAddGuest;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ListBox lBoxGuestList;
        private Label lblGuestList;
        private Button btnChange;
        private Button btnDelete;
        private Label lblTotGuests;
        private Label lblTotCost;
        private Label lblTotFee;
        private Label lblSurpDef;
        private Label lblResNumGuest;
        private Label lblResTotalCost;
        private Label lblResTotalFees;
        private Label lblResSurpDef;
    }
}