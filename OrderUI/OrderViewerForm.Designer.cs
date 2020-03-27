namespace OrderUI
{
    partial class OrderViewerForm
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
            this.attendantLabel = new System.Windows.Forms.Label();
            this.orderByTableLabel = new System.Windows.Forms.Label();
            this.orderByTableValue = new System.Windows.Forms.Label();
            this.attendantValue = new System.Windows.Forms.Label();
            this.orderedFoodListBox = new System.Windows.Forms.ListBox();
            this.subtotalValue = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxValue = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.payBillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attendantLabel
            // 
            this.attendantLabel.AutoSize = true;
            this.attendantLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendantLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.attendantLabel.Location = new System.Drawing.Point(753, 41);
            this.attendantLabel.Name = "attendantLabel";
            this.attendantLabel.Size = new System.Drawing.Size(199, 51);
            this.attendantLabel.TabIndex = 30;
            this.attendantLabel.Text = "Attendant:";
            // 
            // orderByTableLabel
            // 
            this.orderByTableLabel.AutoSize = true;
            this.orderByTableLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByTableLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.orderByTableLabel.Location = new System.Drawing.Point(221, 41);
            this.orderByTableLabel.Name = "orderByTableLabel";
            this.orderByTableLabel.Size = new System.Drawing.Size(273, 51);
            this.orderByTableLabel.TabIndex = 28;
            this.orderByTableLabel.Text = "Order By Table:";
            // 
            // orderByTableValue
            // 
            this.orderByTableValue.AutoSize = true;
            this.orderByTableValue.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByTableValue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.orderByTableValue.Location = new System.Drawing.Point(490, 41);
            this.orderByTableValue.Name = "orderByTableValue";
            this.orderByTableValue.Size = new System.Drawing.Size(160, 51);
            this.orderByTableValue.TabIndex = 31;
            this.orderByTableValue.Text = "<none>";
            // 
            // attendantValue
            // 
            this.attendantValue.AutoSize = true;
            this.attendantValue.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendantValue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.attendantValue.Location = new System.Drawing.Point(944, 41);
            this.attendantValue.Name = "attendantValue";
            this.attendantValue.Size = new System.Drawing.Size(160, 51);
            this.attendantValue.TabIndex = 32;
            this.attendantValue.Text = "<none>";
            // 
            // orderedFoodListBox
            // 
            this.orderedFoodListBox.FormattingEnabled = true;
            this.orderedFoodListBox.ItemHeight = 37;
            this.orderedFoodListBox.Location = new System.Drawing.Point(194, 123);
            this.orderedFoodListBox.Name = "orderedFoodListBox";
            this.orderedFoodListBox.Size = new System.Drawing.Size(437, 411);
            this.orderedFoodListBox.TabIndex = 33;
            // 
            // subtotalValue
            // 
            this.subtotalValue.AutoSize = true;
            this.subtotalValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalValue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.subtotalValue.Location = new System.Drawing.Point(924, 207);
            this.subtotalValue.Name = "subtotalValue";
            this.subtotalValue.Size = new System.Drawing.Size(140, 45);
            this.subtotalValue.TabIndex = 35;
            this.subtotalValue.Text = "<none>";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.subtotalLabel.Location = new System.Drawing.Point(753, 207);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(149, 45);
            this.subtotalLabel.TabIndex = 34;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxValue
            // 
            this.taxValue.AutoSize = true;
            this.taxValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxValue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.taxValue.Location = new System.Drawing.Point(924, 288);
            this.taxValue.Name = "taxValue";
            this.taxValue.Size = new System.Drawing.Size(140, 45);
            this.taxValue.TabIndex = 37;
            this.taxValue.Text = "<none>";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.taxLabel.Location = new System.Drawing.Point(753, 288);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(72, 45);
            this.taxLabel.TabIndex = 36;
            this.taxLabel.Text = "Tax:";
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.totalValue.Location = new System.Drawing.Point(924, 369);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(140, 45);
            this.totalValue.TabIndex = 39;
            this.totalValue.Text = "<none>";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.totalLabel.Location = new System.Drawing.Point(753, 369);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(96, 45);
            this.totalLabel.TabIndex = 38;
            this.totalLabel.Text = "Total:";
            // 
            // payBillButton
            // 
            this.payBillButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.payBillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.payBillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.payBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBillButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBillButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.payBillButton.Location = new System.Drawing.Point(798, 474);
            this.payBillButton.Name = "payBillButton";
            this.payBillButton.Size = new System.Drawing.Size(199, 80);
            this.payBillButton.TabIndex = 40;
            this.payBillButton.Text = "Pay Bill";
            this.payBillButton.UseVisualStyleBackColor = true;
            this.payBillButton.Click += new System.EventHandler(this.payBillButton_Click);
            // 
            // OrderViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1041);
            this.Controls.Add(this.payBillButton);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxValue);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalValue);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.orderedFoodListBox);
            this.Controls.Add(this.attendantValue);
            this.Controls.Add(this.orderByTableValue);
            this.Controls.Add(this.attendantLabel);
            this.Controls.Add(this.orderByTableLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "OrderViewerForm";
            this.Text = "OrderViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label attendantLabel;
        private System.Windows.Forms.Label orderByTableLabel;
        private System.Windows.Forms.Label orderByTableValue;
        private System.Windows.Forms.Label attendantValue;
        private System.Windows.Forms.ListBox orderedFoodListBox;
        private System.Windows.Forms.Label subtotalValue;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxValue;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button payBillButton;
    }
}