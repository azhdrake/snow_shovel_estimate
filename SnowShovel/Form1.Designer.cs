namespace SnowShovel
{
  partial class Form1
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
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.dtDateRequested = new System.Windows.Forms.DateTimePicker();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbSingle = new System.Windows.Forms.RadioButton();
      this.rbCorner = new System.Windows.Forms.RadioButton();
      this.btnAddRequest = new System.Windows.Forms.Button();
      this.btnGetEstimate = new System.Windows.Forms.Button();
      this.txtEstimate = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lblSpecialRequests = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(208, 44);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(368, 31);
      this.txtName.TabIndex = 0;
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(208, 95);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(368, 31);
      this.txtAddress.TabIndex = 1;
      // 
      // dtDateRequested
      // 
      this.dtDateRequested.Location = new System.Drawing.Point(208, 142);
      this.dtDateRequested.Name = "dtDateRequested";
      this.dtDateRequested.Size = new System.Drawing.Size(368, 31);
      this.dtDateRequested.TabIndex = 2;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbCorner);
      this.groupBox1.Controls.Add(this.rbSingle);
      this.groupBox1.Location = new System.Drawing.Point(33, 195);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(178, 187);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Sidewalk Type";
      // 
      // rbSingle
      // 
      this.rbSingle.AutoSize = true;
      this.rbSingle.Location = new System.Drawing.Point(7, 52);
      this.rbSingle.Name = "rbSingle";
      this.rbSingle.Size = new System.Drawing.Size(103, 29);
      this.rbSingle.TabIndex = 0;
      this.rbSingle.TabStop = true;
      this.rbSingle.Text = "Single";
      this.rbSingle.UseVisualStyleBackColor = true;
      // 
      // rbCorner
      // 
      this.rbCorner.AutoSize = true;
      this.rbCorner.Location = new System.Drawing.Point(7, 105);
      this.rbCorner.Name = "rbCorner";
      this.rbCorner.Size = new System.Drawing.Size(108, 29);
      this.rbCorner.TabIndex = 1;
      this.rbCorner.TabStop = true;
      this.rbCorner.Text = "Corner";
      this.rbCorner.UseVisualStyleBackColor = true;
      // 
      // btnAddRequest
      // 
      this.btnAddRequest.Location = new System.Drawing.Point(414, 334);
      this.btnAddRequest.Name = "btnAddRequest";
      this.btnAddRequest.Size = new System.Drawing.Size(161, 48);
      this.btnAddRequest.TabIndex = 4;
      this.btnAddRequest.Text = "Add Request";
      this.btnAddRequest.UseVisualStyleBackColor = true;
      this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
      // 
      // btnGetEstimate
      // 
      this.btnGetEstimate.Location = new System.Drawing.Point(40, 388);
      this.btnGetEstimate.Name = "btnGetEstimate";
      this.btnGetEstimate.Size = new System.Drawing.Size(165, 50);
      this.btnGetEstimate.TabIndex = 5;
      this.btnGetEstimate.Text = "Get Estimate";
      this.btnGetEstimate.UseVisualStyleBackColor = true;
      this.btnGetEstimate.Click += new System.EventHandler(this.btnGetEstimate_Click);
      // 
      // txtEstimate
      // 
      this.txtEstimate.Location = new System.Drawing.Point(337, 404);
      this.txtEstimate.Name = "txtEstimate";
      this.txtEstimate.ReadOnly = true;
      this.txtEstimate.Size = new System.Drawing.Size(239, 31);
      this.txtEstimate.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(35, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 25);
      this.label1.TabIndex = 7;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(35, 98);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "Address";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(35, 147);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(167, 25);
      this.label3.TabIndex = 9;
      this.label3.Text = "Date Requested";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(236, 407);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(95, 25);
      this.label4.TabIndex = 10;
      this.label4.Text = "Estimate";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lblSpecialRequests);
      this.groupBox2.Location = new System.Drawing.Point(241, 195);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(334, 133);
      this.groupBox2.TabIndex = 11;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Special Requests";
      // 
      // lblSpecialRequests
      // 
      this.lblSpecialRequests.AutoEllipsis = true;
      this.lblSpecialRequests.Location = new System.Drawing.Point(7, 31);
      this.lblSpecialRequests.Name = "lblSpecialRequests";
      this.lblSpecialRequests.Size = new System.Drawing.Size(321, 99);
      this.lblSpecialRequests.TabIndex = 0;
      this.lblSpecialRequests.Text = "No Special Requests Entered";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(612, 460);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtEstimate);
      this.Controls.Add(this.btnGetEstimate);
      this.Controls.Add(this.btnAddRequest);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dtDateRequested);
      this.Controls.Add(this.txtAddress);
      this.Controls.Add(this.txtName);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtDateRequested;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCorner;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnGetEstimate;
        private System.Windows.Forms.TextBox txtEstimate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSpecialRequests;
    }
}

