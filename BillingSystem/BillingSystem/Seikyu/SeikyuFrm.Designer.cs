namespace BillingSystem
{
    partial class SeikyuFrm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ApproveByManager = new System.Windows.Forms.CheckBox();
            this.ApproveBySupervisor = new System.Windows.Forms.CheckBox();
            this.ShowDeleted = new System.Windows.Forms.CheckBox();
            this.BillingEndDate = new System.Windows.Forms.DateTimePicker();
            this.BillingStartDate = new System.Windows.Forms.DateTimePicker();
            this.BillingRecipient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalCount = new System.Windows.Forms.Label();
            this.DisplayCount = new System.Windows.Forms.Label();
            this.BillingInfoGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.BillingInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLoginUserName
            // 
            this.LblLoginUserName.Location = new System.Drawing.Point(1140, 9);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SearchButton);
            this.panel3.Controls.Add(this.ApproveByManager);
            this.panel3.Controls.Add(this.ApproveBySupervisor);
            this.panel3.Controls.Add(this.ShowDeleted);
            this.panel3.Controls.Add(this.BillingEndDate);
            this.panel3.Controls.Add(this.BillingStartDate);
            this.panel3.Controls.Add(this.BillingRecipient);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(5, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1489, 135);
            this.panel3.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(499, 86);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(120, 38);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApproveByManager
            // 
            this.ApproveByManager.AutoSize = true;
            this.ApproveByManager.Location = new System.Drawing.Point(782, 16);
            this.ApproveByManager.Margin = new System.Windows.Forms.Padding(4);
            this.ApproveByManager.Name = "ApproveByManager";
            this.ApproveByManager.Size = new System.Drawing.Size(134, 29);
            this.ApproveByManager.TabIndex = 3;
            this.ApproveByManager.Text = "管理承認済";
            this.ApproveByManager.UseVisualStyleBackColor = true;
            // 
            // ApproveBySupervisor
            // 
            this.ApproveBySupervisor.AutoSize = true;
            this.ApproveBySupervisor.Location = new System.Drawing.Point(626, 16);
            this.ApproveBySupervisor.Margin = new System.Windows.Forms.Padding(4);
            this.ApproveBySupervisor.Name = "ApproveBySupervisor";
            this.ApproveBySupervisor.Size = new System.Drawing.Size(154, 29);
            this.ApproveBySupervisor.TabIndex = 3;
            this.ApproveBySupervisor.Text = "担当者承認済";
            this.ApproveBySupervisor.UseVisualStyleBackColor = true;
            // 
            // ShowDeleted
            // 
            this.ShowDeleted.AutoSize = true;
            this.ShowDeleted.Location = new System.Drawing.Point(14, 94);
            this.ShowDeleted.Margin = new System.Windows.Forms.Padding(4);
            this.ShowDeleted.Name = "ShowDeleted";
            this.ShowDeleted.Size = new System.Drawing.Size(129, 29);
            this.ShowDeleted.TabIndex = 3;
            this.ShowDeleted.Text = "削除も表示";
            this.ShowDeleted.UseVisualStyleBackColor = true;
            // 
            // BillingEndDate
            // 
            this.BillingEndDate.Location = new System.Drawing.Point(335, 9);
            this.BillingEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.BillingEndDate.Name = "BillingEndDate";
            this.BillingEndDate.Size = new System.Drawing.Size(184, 33);
            this.BillingEndDate.TabIndex = 2;
            // 
            // BillingStartDate
            // 
            this.BillingStartDate.Location = new System.Drawing.Point(106, 9);
            this.BillingStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.BillingStartDate.Name = "BillingStartDate";
            this.BillingStartDate.Size = new System.Drawing.Size(184, 33);
            this.BillingStartDate.TabIndex = 2;
            // 
            // BillingRecipient
            // 
            this.BillingRecipient.FormattingEnabled = true;
            this.BillingRecipient.Location = new System.Drawing.Point(106, 51);
            this.BillingRecipient.Margin = new System.Windows.Forms.Padding(4);
            this.BillingRecipient.Name = "BillingRecipient";
            this.BillingRecipient.Size = new System.Drawing.Size(329, 33);
            this.BillingRecipient.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "状態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "請求先";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "～";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "請求期間";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PreviousButton);
            this.panel4.Controls.Add(this.NextButton);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.TotalCount);
            this.panel4.Controls.Add(this.DisplayCount);
            this.panel4.Controls.Add(this.BillingInfoGridView);
            this.panel4.Location = new System.Drawing.Point(5, 211);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1489, 529);
            this.panel4.TabIndex = 10;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(1355, 4);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(4);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(60, 38);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "前頁";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1422, 4);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(60, 38);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "次頁";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1264, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "/";
            // 
            // TotalCount
            // 
            this.TotalCount.AutoSize = true;
            this.TotalCount.Location = new System.Drawing.Point(1278, 11);
            this.TotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(68, 25);
            this.TotalCount.TabIndex = 1;
            this.TotalCount.Text = "520件";
            // 
            // DisplayCount
            // 
            this.DisplayCount.AutoSize = true;
            this.DisplayCount.Location = new System.Drawing.Point(1222, 11);
            this.DisplayCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisplayCount.Name = "DisplayCount";
            this.DisplayCount.Size = new System.Drawing.Size(48, 25);
            this.DisplayCount.TabIndex = 1;
            this.DisplayCount.Text = "100";
            // 
            // BillingInfoGridView
            // 
            this.BillingInfoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillingInfoGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.BillingInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillingInfoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillingDate,
            this.PaymentType,
            this.CustomerName,
            this.BillingNo,
            this.BillingAmount,
            this.BillingTax,
            this.TransportationAmount,
            this.BillingTotal});
            this.BillingInfoGridView.Location = new System.Drawing.Point(0, 49);
            this.BillingInfoGridView.Margin = new System.Windows.Forms.Padding(4);
            this.BillingInfoGridView.Name = "BillingInfoGridView";
            this.BillingInfoGridView.RowHeadersWidth = 51;
            this.BillingInfoGridView.RowTemplate.Height = 21;
            this.BillingInfoGridView.Size = new System.Drawing.Size(1484, 476);
            this.BillingInfoGridView.TabIndex = 0;
            // 
            // BillingDate
            // 
            this.BillingDate.DataPropertyName = "BillingDate";
            this.BillingDate.HeaderText = "請求日";
            this.BillingDate.MinimumWidth = 6;
            this.BillingDate.Name = "BillingDate";
            this.BillingDate.Width = 125;
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            this.PaymentType.HeaderText = "状態";
            this.PaymentType.MinimumWidth = 6;
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "請求先";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 300;
            // 
            // BillingNo
            // 
            this.BillingNo.DataPropertyName = "BillingNo";
            this.BillingNo.HeaderText = "請求No";
            this.BillingNo.MinimumWidth = 6;
            this.BillingNo.Name = "BillingNo";
            this.BillingNo.Width = 150;
            // 
            // BillingAmount
            // 
            this.BillingAmount.DataPropertyName = "BillingAmount";
            this.BillingAmount.HeaderText = "請求金額(税抜き)";
            this.BillingAmount.MinimumWidth = 6;
            this.BillingAmount.Name = "BillingAmount";
            this.BillingAmount.Width = 125;
            // 
            // BillingTax
            // 
            this.BillingTax.DataPropertyName = "BillingTax";
            this.BillingTax.HeaderText = "消費税";
            this.BillingTax.MinimumWidth = 6;
            this.BillingTax.Name = "BillingTax";
            this.BillingTax.Width = 125;
            // 
            // TransportationAmount
            // 
            this.TransportationAmount.DataPropertyName = "TransportationAmount";
            this.TransportationAmount.HeaderText = "交通費";
            this.TransportationAmount.MinimumWidth = 6;
            this.TransportationAmount.Name = "TransportationAmount";
            this.TransportationAmount.Width = 125;
            // 
            // BillingTotal
            // 
            this.BillingTotal.DataPropertyName = "BillingTotal";
            this.BillingTotal.HeaderText = "合計金額";
            this.BillingTotal.MinimumWidth = 6;
            this.BillingTotal.Name = "BillingTotal";
            this.BillingTotal.Width = 120;
            // 
            // SeikyuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1499, 799);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SeikyuFrm";
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillingInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckBox ApproveByManager;
        private System.Windows.Forms.CheckBox ApproveBySupervisor;
        private System.Windows.Forms.CheckBox ShowDeleted;
        private System.Windows.Forms.DateTimePicker BillingEndDate;
        private System.Windows.Forms.DateTimePicker BillingStartDate;
        private System.Windows.Forms.ComboBox BillingRecipient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView BillingInfoGridView;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Label DisplayCount;
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
