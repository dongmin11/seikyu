namespace BillingSystem.Seikyu
{
    partial class SeikyuFrm : BillingSystem.BaseFrom.BaseFrm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSearchButton = new System.Windows.Forms.Button();
            this.CkbxApproveByManager = new System.Windows.Forms.CheckBox();
            this.CkbxApproveBySupervisor = new System.Windows.Forms.CheckBox();
            this.CkbxShowDeleted = new System.Windows.Forms.CheckBox();
            this.DtbBillingEndDate = new System.Windows.Forms.DateTimePicker();
            this.DtbBillingStartDate = new System.Windows.Forms.DateTimePicker();
            this.CbbxBillingRecipient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnPreviousButton = new System.Windows.Forms.Button();
            this.BtnNextButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTotalCount = new System.Windows.Forms.Label();
            this.LblDisplayCount = new System.Windows.Forms.Label();
            this.DgbBillingInfoGridView = new System.Windows.Forms.DataGridView();
            this.BillingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportationAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbBillingInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLoginUserName
            // 
            this.LblLoginUserName.Location = new System.Drawing.Point(958, 7);
            this.LblLoginUserName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // LblProcessName
            // 
            this.LblProcessName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LblProcessName.Size = new System.Drawing.Size(665, 31);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnSearchButton);
            this.panel3.Controls.Add(this.CkbxApproveByManager);
            this.panel3.Controls.Add(this.CkbxApproveBySupervisor);
            this.panel3.Controls.Add(this.CkbxShowDeleted);
            this.panel3.Controls.Add(this.DtbBillingEndDate);
            this.panel3.Controls.Add(this.DtbBillingStartDate);
            this.panel3.Controls.Add(this.CbbxBillingRecipient);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(4, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1241, 108);
            this.panel3.TabIndex = 9;
            // 
            // BtnSearchButton
            // 
            this.BtnSearchButton.Location = new System.Drawing.Point(418, 68);
            this.BtnSearchButton.Name = "BtnSearchButton";
            this.BtnSearchButton.Size = new System.Drawing.Size(100, 30);
            this.BtnSearchButton.TabIndex = 6;
            this.BtnSearchButton.Text = "検索";
            this.BtnSearchButton.UseVisualStyleBackColor = true;
            this.BtnSearchButton.Click += new System.EventHandler(this.searchButton);
            // 
            // CkbxApproveByManager
            // 
            this.CkbxApproveByManager.AutoSize = true;
            this.CkbxApproveByManager.Location = new System.Drawing.Point(684, 11);
            this.CkbxApproveByManager.Name = "CkbxApproveByManager";
            this.CkbxApproveByManager.Size = new System.Drawing.Size(108, 24);
            this.CkbxApproveByManager.TabIndex = 3;
            this.CkbxApproveByManager.Text = "管理承認済";
            this.CkbxApproveByManager.UseVisualStyleBackColor = true;
            // 
            // CkbxApproveBySupervisor
            // 
            this.CkbxApproveBySupervisor.AutoSize = true;
            this.CkbxApproveBySupervisor.Location = new System.Drawing.Point(549, 12);
            this.CkbxApproveBySupervisor.Name = "CkbxApproveBySupervisor";
            this.CkbxApproveBySupervisor.Size = new System.Drawing.Size(124, 24);
            this.CkbxApproveBySupervisor.TabIndex = 2;
            this.CkbxApproveBySupervisor.Text = "担当者承認済";
            this.CkbxApproveBySupervisor.UseVisualStyleBackColor = true;
            // 
            // CkbxShowDeleted
            // 
            this.CkbxShowDeleted.AutoSize = true;
            this.CkbxShowDeleted.Location = new System.Drawing.Point(12, 75);
            this.CkbxShowDeleted.Name = "CkbxShowDeleted";
            this.CkbxShowDeleted.Size = new System.Drawing.Size(104, 24);
            this.CkbxShowDeleted.TabIndex = 5;
            this.CkbxShowDeleted.Text = "削除も表示";
            this.CkbxShowDeleted.UseVisualStyleBackColor = true;
            // 
            // DtbBillingEndDate
            // 
            this.DtbBillingEndDate.Location = new System.Drawing.Point(293, 8);
            this.DtbBillingEndDate.Name = "DtbBillingEndDate";
            this.DtbBillingEndDate.Size = new System.Drawing.Size(190, 28);
            this.DtbBillingEndDate.TabIndex = 1;
            // 
            // DtbBillingStartDate
            // 
            this.DtbBillingStartDate.Location = new System.Drawing.Point(88, 7);
            this.DtbBillingStartDate.Name = "DtbBillingStartDate";
            this.DtbBillingStartDate.Size = new System.Drawing.Size(166, 28);
            this.DtbBillingStartDate.TabIndex = 0;
            this.DtbBillingStartDate.ValueChanged += new System.EventHandler(this.changeStartDate);
            // 
            // CbbxBillingRecipient
            // 
            this.CbbxBillingRecipient.DisplayMember = "CustomerName";
            this.CbbxBillingRecipient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbxBillingRecipient.FormattingEnabled = true;
            this.CbbxBillingRecipient.Location = new System.Drawing.Point(88, 41);
            this.CbbxBillingRecipient.Name = "CbbxBillingRecipient";
            this.CbbxBillingRecipient.Size = new System.Drawing.Size(275, 28);
            this.CbbxBillingRecipient.TabIndex = 4;
            this.CbbxBillingRecipient.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "状態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "請求先";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "～";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "請求期間";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnPreviousButton);
            this.panel4.Controls.Add(this.BtnNextButton);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.LblTotalCount);
            this.panel4.Controls.Add(this.LblDisplayCount);
            this.panel4.Controls.Add(this.DgbBillingInfoGridView);
            this.panel4.Location = new System.Drawing.Point(4, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1241, 423);
            this.panel4.TabIndex = 10;
            // 
            // BtnPreviousButton
            // 
            this.BtnPreviousButton.Location = new System.Drawing.Point(1129, 3);
            this.BtnPreviousButton.Name = "BtnPreviousButton";
            this.BtnPreviousButton.Size = new System.Drawing.Size(50, 30);
            this.BtnPreviousButton.TabIndex = 7;
            this.BtnPreviousButton.Text = "前頁";
            this.BtnPreviousButton.UseVisualStyleBackColor = true;
            this.BtnPreviousButton.Click += new System.EventHandler(this.BtnPreviousButton_Click);
            // 
            // BtnNextButton
            // 
            this.BtnNextButton.Location = new System.Drawing.Point(1185, 3);
            this.BtnNextButton.Name = "BtnNextButton";
            this.BtnNextButton.Size = new System.Drawing.Size(50, 30);
            this.BtnNextButton.TabIndex = 8;
            this.BtnNextButton.Text = "次頁";
            this.BtnNextButton.UseVisualStyleBackColor = true;
            this.BtnNextButton.Click += new System.EventHandler(this.BtnNextButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1053, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "/";
            // 
            // LblTotalCount
            // 
            this.LblTotalCount.AutoSize = true;
            this.LblTotalCount.Location = new System.Drawing.Point(1065, 9);
            this.LblTotalCount.Name = "LblTotalCount";
            this.LblTotalCount.Size = new System.Drawing.Size(55, 20);
            this.LblTotalCount.TabIndex = 1;
            this.LblTotalCount.Text = "520件";
            // 
            // LblDisplayCount
            // 
            this.LblDisplayCount.AutoSize = true;
            this.LblDisplayCount.Location = new System.Drawing.Point(1018, 9);
            this.LblDisplayCount.Name = "LblDisplayCount";
            this.LblDisplayCount.Size = new System.Drawing.Size(39, 20);
            this.LblDisplayCount.TabIndex = 1;
            this.LblDisplayCount.Text = "100";
            // 
            // DgbBillingInfoGridView
            // 
            this.DgbBillingInfoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgbBillingInfoGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgbBillingInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbBillingInfoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillingDate,
            this.PaymentType,
            this.CustomerName,
            this.BillingNo,
            this.BillingAmount,
            this.BillingTax,
            this.TransportationAmount,
            this.BillingTotal});
            this.DgbBillingInfoGridView.Location = new System.Drawing.Point(3, 32);
            this.DgbBillingInfoGridView.MultiSelect = false;
            this.DgbBillingInfoGridView.Name = "DgbBillingInfoGridView";
            this.DgbBillingInfoGridView.ReadOnly = true;
            this.DgbBillingInfoGridView.RowHeadersWidth = 51;
            this.DgbBillingInfoGridView.RowTemplate.Height = 21;
            this.DgbBillingInfoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgbBillingInfoGridView.Size = new System.Drawing.Size(1237, 381);
            this.DgbBillingInfoGridView.TabIndex = 9;
            // 
            // BillingDate
            // 
            this.BillingDate.DataPropertyName = "BillingDate";
            this.BillingDate.HeaderText = "請求日";
            this.BillingDate.MinimumWidth = 6;
            this.BillingDate.Name = "BillingDate";
            this.BillingDate.ReadOnly = true;
            this.BillingDate.Width = 125;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            this.PaymentType.HeaderText = "状態";
            this.PaymentType.MinimumWidth = 6;
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            this.PaymentType.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "請求先";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 300;
            // 
            // BillingNo
            // 
            this.BillingNo.DataPropertyName = "BillingNo";
            this.BillingNo.HeaderText = "請求No";
            this.BillingNo.MinimumWidth = 6;
            this.BillingNo.Name = "BillingNo";
            this.BillingNo.ReadOnly = true;
            this.BillingNo.Width = 150;
            // 
            // BillingAmount
            // 
            this.BillingAmount.DataPropertyName = "BillingAmount";
            this.BillingAmount.HeaderText = "請求金額(税抜き)";
            this.BillingAmount.MinimumWidth = 6;
            this.BillingAmount.Name = "BillingAmount";
            this.BillingAmount.ReadOnly = true;
            this.BillingAmount.Width = 125;
            // 
            // BillingTax
            // 
            this.BillingTax.DataPropertyName = "BillingTax";
            this.BillingTax.HeaderText = "消費税";
            this.BillingTax.MinimumWidth = 6;
            this.BillingTax.Name = "BillingTax";
            this.BillingTax.ReadOnly = true;
            this.BillingTax.Width = 125;
            // 
            // TransportationAmount
            // 
            this.TransportationAmount.DataPropertyName = "TransportationAmount";
            this.TransportationAmount.HeaderText = "交通費";
            this.TransportationAmount.MinimumWidth = 6;
            this.TransportationAmount.Name = "TransportationAmount";
            this.TransportationAmount.ReadOnly = true;
            this.TransportationAmount.Width = 125;
            // 
            // BillingTotal
            // 
            this.BillingTotal.DataPropertyName = "BillingTotal";
            this.BillingTotal.HeaderText = "合計金額";
            this.BillingTotal.MinimumWidth = 6;
            this.BillingTotal.Name = "BillingTotal";
            this.BillingTotal.ReadOnly = true;
            this.BillingTotal.Width = 120;
            // 
            // SeikyuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(1257, 668);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "SeikyuFrm";
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbBillingInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnSearchButton;
        private System.Windows.Forms.CheckBox CkbxApproveByManager;
        private System.Windows.Forms.CheckBox CkbxApproveBySupervisor;
        private System.Windows.Forms.CheckBox CkbxShowDeleted;
        private System.Windows.Forms.DateTimePicker DtbBillingEndDate;
        private System.Windows.Forms.DateTimePicker DtbBillingStartDate;
        private System.Windows.Forms.ComboBox CbbxBillingRecipient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnPreviousButton;
        private System.Windows.Forms.Button BtnNextButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblTotalCount;
        private System.Windows.Forms.Label LblDisplayCount;
        private System.Windows.Forms.DataGridView DgbBillingInfoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportationAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingTotal;
    }
}
