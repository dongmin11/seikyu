namespace BillingSystem.BaseFrom
{
    partial class BaseFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLoginUserName = new System.Windows.Forms.Label();
            this.LblProcessName = new System.Windows.Forms.Label();
            this.LblSystemName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.LblLoginUserName);
            this.panel2.Controls.Add(this.LblProcessName);
            this.panel2.Controls.Add(this.LblSystemName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1249, 41);
            this.panel2.TabIndex = 8;
            // 
            // LblLoginUserName
            // 
            this.LblLoginUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblLoginUserName.AutoSize = true;
            this.LblLoginUserName.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblLoginUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblLoginUserName.Location = new System.Drawing.Point(1158, 8);
            this.LblLoginUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLoginUserName.Name = "LblLoginUserName";
            this.LblLoginUserName.Size = new System.Drawing.Size(83, 20);
            this.LblLoginUserName.TabIndex = 4;
            this.LblLoginUserName.Text = "テストユーザ";
            this.LblLoginUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblProcessName
            // 
            this.LblProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProcessName.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblProcessName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblProcessName.Location = new System.Drawing.Point(221, 1);
            this.LblProcessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProcessName.Name = "LblProcessName";
            this.LblProcessName.Size = new System.Drawing.Size(807, 39);
            this.LblProcessName.TabIndex = 4;
            this.LblProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSystemName
            // 
            this.LblSystemName.AutoSize = true;
            this.LblSystemName.Font = new System.Drawing.Font("Meiryo UI", 14.25F);
            this.LblSystemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblSystemName.Location = new System.Drawing.Point(4, 8);
            this.LblSystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSystemName.Name = "LblSystemName";
            this.LblSystemName.Size = new System.Drawing.Size(167, 24);
            this.LblSystemName.TabIndex = 4;
            this.LblSystemName.Text = "請求書発行システム";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 41);
            this.panel1.TabIndex = 7;
            // 
            // BaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1249, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BaseFrm";
            this.Text = "BaseForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label LblLoginUserName;
        public System.Windows.Forms.Label LblProcessName;
        private System.Windows.Forms.Label LblSystemName;
        private System.Windows.Forms.Panel panel1;
    }
}