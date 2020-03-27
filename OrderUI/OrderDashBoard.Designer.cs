namespace OrderUI
{
    partial class OrderDashBoard
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
            this.orderDashboardLabel = new System.Windows.Forms.Label();
            this.loadOrderByTableLabel = new System.Windows.Forms.Label();
            this.loadOrderByTableDropDown = new System.Windows.Forms.ComboBox();
            this.loadOrderButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderDashboardLabel
            // 
            this.orderDashboardLabel.AutoSize = true;
            this.orderDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDashboardLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.orderDashboardLabel.Location = new System.Drawing.Point(528, 44);
            this.orderDashboardLabel.Name = "orderDashboardLabel";
            this.orderDashboardLabel.Size = new System.Drawing.Size(329, 54);
            this.orderDashboardLabel.TabIndex = 25;
            this.orderDashboardLabel.Text = "Order DashBoard";
            // 
            // loadOrderByTableLabel
            // 
            this.loadOrderByTableLabel.AutoSize = true;
            this.loadOrderByTableLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadOrderByTableLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.loadOrderByTableLabel.Location = new System.Drawing.Point(534, 150);
            this.loadOrderByTableLabel.Name = "loadOrderByTableLabel";
            this.loadOrderByTableLabel.Size = new System.Drawing.Size(323, 45);
            this.loadOrderByTableLabel.TabIndex = 26;
            this.loadOrderByTableLabel.Text = "Load Order By Table";
            // 
            // loadOrderByTableDropDown
            // 
            this.loadOrderByTableDropDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadOrderByTableDropDown.FormattingEnabled = true;
            this.loadOrderByTableDropDown.Location = new System.Drawing.Point(623, 221);
            this.loadOrderByTableDropDown.Name = "loadOrderByTableDropDown";
            this.loadOrderByTableDropDown.Size = new System.Drawing.Size(121, 53);
            this.loadOrderByTableDropDown.TabIndex = 27;
            this.loadOrderByTableDropDown.SelectedIndexChanged += new System.EventHandler(this.loadOrderByTableDropDown_SelectedIndexChanged);
            // 
            // loadOrderButton
            // 
            this.loadOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadOrderButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.loadOrderButton.Location = new System.Drawing.Point(584, 300);
            this.loadOrderButton.Name = "loadOrderButton";
            this.loadOrderButton.Size = new System.Drawing.Size(199, 80);
            this.loadOrderButton.TabIndex = 34;
            this.loadOrderButton.Text = "Load Order";
            this.loadOrderButton.UseVisualStyleBackColor = true;
            this.loadOrderButton.Click += new System.EventHandler(this.loadOrderButton_Click);
            // 
            // createOrderButton
            // 
            this.createOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrderButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.createOrderButton.Location = new System.Drawing.Point(584, 451);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(199, 80);
            this.createOrderButton.TabIndex = 35;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // OrderDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1041);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.loadOrderButton);
            this.Controls.Add(this.loadOrderByTableDropDown);
            this.Controls.Add(this.loadOrderByTableLabel);
            this.Controls.Add(this.orderDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "OrderDashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderDashboardLabel;
        private System.Windows.Forms.Label loadOrderByTableLabel;
        private System.Windows.Forms.ComboBox loadOrderByTableDropDown;
        private System.Windows.Forms.Button loadOrderButton;
        private System.Windows.Forms.Button createOrderButton;
    }
}