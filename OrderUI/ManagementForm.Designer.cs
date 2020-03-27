namespace OrderUI
{
    partial class ManagementForm
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
            this.managementLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.foodButton = new System.Windows.Forms.Button();
            this.attendantButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managementLabel
            // 
            this.managementLabel.AutoSize = true;
            this.managementLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.managementLabel.Location = new System.Drawing.Point(551, 68);
            this.managementLabel.Name = "managementLabel";
            this.managementLabel.Size = new System.Drawing.Size(259, 54);
            this.managementLabel.TabIndex = 27;
            this.managementLabel.Text = "Management";
            // 
            // orderButton
            // 
            this.orderButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.orderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.orderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.orderButton.Location = new System.Drawing.Point(208, 252);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(199, 80);
            this.orderButton.TabIndex = 34;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // foodButton
            // 
            this.foodButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.foodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.foodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.foodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.foodButton.Location = new System.Drawing.Point(480, 252);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(199, 80);
            this.foodButton.TabIndex = 35;
            this.foodButton.Text = "Food";
            this.foodButton.UseVisualStyleBackColor = true;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // attendantButton
            // 
            this.attendantButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.attendantButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.attendantButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.attendantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendantButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendantButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.attendantButton.Location = new System.Drawing.Point(1044, 252);
            this.attendantButton.Name = "attendantButton";
            this.attendantButton.Size = new System.Drawing.Size(199, 80);
            this.attendantButton.TabIndex = 36;
            this.attendantButton.Text = "Attendant";
            this.attendantButton.UseVisualStyleBackColor = true;
            this.attendantButton.Click += new System.EventHandler(this.attendantButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.tableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.tableButton.Location = new System.Drawing.Point(761, 252);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(199, 80);
            this.tableButton.TabIndex = 37;
            this.tableButton.Text = "Table";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1041);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.attendantButton);
            this.Controls.Add(this.foodButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.managementLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ManagementForm";
            this.Text = "Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button foodButton;
        private System.Windows.Forms.Button attendantButton;
        private System.Windows.Forms.Button tableButton;
    }
}