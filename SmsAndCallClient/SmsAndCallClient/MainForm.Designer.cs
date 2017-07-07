namespace MatthiWare.SmsAndCallClient
{
    partial class MainForm
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
            this.cbApis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSms = new System.Windows.Forms.CheckBox();
            this.cbCall = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnText = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbApis
            // 
            this.cbApis.FormattingEnabled = true;
            this.cbApis.Location = new System.Drawing.Point(110, 12);
            this.cbApis.Name = "cbApis";
            this.cbApis.Size = new System.Drawing.Size(203, 21);
            this.cbApis.TabIndex = 0;
            this.cbApis.SelectedValueChanged += new System.EventHandler(this.cbApis_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select API to use:";
            // 
            // cbSms
            // 
            this.cbSms.AutoSize = true;
            this.cbSms.Enabled = false;
            this.cbSms.Location = new System.Drawing.Point(15, 43);
            this.cbSms.Name = "cbSms";
            this.cbSms.Size = new System.Drawing.Size(141, 17);
            this.cbSms.TabIndex = 2;
            this.cbSms.Text = "Can send text messages";
            this.cbSms.UseVisualStyleBackColor = true;
            // 
            // cbCall
            // 
            this.cbCall.AutoSize = true;
            this.cbCall.Enabled = false;
            this.cbCall.Location = new System.Drawing.Point(15, 66);
            this.cbCall.Name = "cbCall";
            this.cbCall.Size = new System.Drawing.Size(64, 17);
            this.cbCall.TabIndex = 3;
            this.cbCall.Text = "Can call";
            this.cbCall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To: ";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(51, 87);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(262, 20);
            this.txtFrom.TabIndex = 6;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(51, 113);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(262, 20);
            this.txtTo.TabIndex = 7;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(15, 157);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(298, 146);
            this.txtBody.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message: ";
            // 
            // btnText
            // 
            this.btnText.Enabled = false;
            this.btnText.Location = new System.Drawing.Point(15, 309);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(141, 23);
            this.btnText.TabIndex = 10;
            this.btnText.Text = "Sms";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnCall
            // 
            this.btnCall.Enabled = false;
            this.btnCall.Location = new System.Drawing.Point(162, 309);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(151, 23);
            this.btnCall.TabIndex = 11;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 341);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status: waiting..";
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(238, 336);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStatus.TabIndex = 13;
            this.btnUpdateStatus.Text = "Refresh";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 365);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCall);
            this.Controls.Add(this.cbSms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbApis);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbApis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSms;
        private System.Windows.Forms.CheckBox cbCall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}

