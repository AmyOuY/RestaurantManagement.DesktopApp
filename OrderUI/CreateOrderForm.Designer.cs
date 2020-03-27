namespace OrderUI
{
    partial class CreateOrderForm
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
            this.priceValue = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.FoodTypeLabel = new System.Windows.Forms.Label();
            this.quantityValue = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.orderByTableLabel = new System.Windows.Forms.Label();
            this.orderByTableDropDown = new System.Windows.Forms.ComboBox();
            this.attendantDropDown = new System.Windows.Forms.ComboBox();
            this.attendantLabel = new System.Windows.Forms.Label();
            this.foodTypeDropDown = new System.Windows.Forms.ComboBox();
            this.foodNameDropDown = new System.Windows.Forms.ComboBox();
            this.selectedFoodListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.selectFoodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceValue
            // 
            this.priceValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceValue.Location = new System.Drawing.Point(303, 323);
            this.priceValue.Name = "priceValue";
            this.priceValue.Size = new System.Drawing.Size(343, 51);
            this.priceValue.TabIndex = 21;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.priceLabel.Location = new System.Drawing.Point(100, 323);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(89, 45);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Price";
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.foodNameLabel.Location = new System.Drawing.Point(100, 237);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(189, 45);
            this.foodNameLabel.TabIndex = 18;
            this.foodNameLabel.Text = "Food Name";
            // 
            // FoodTypeLabel
            // 
            this.FoodTypeLabel.AutoSize = true;
            this.FoodTypeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodTypeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FoodTypeLabel.Location = new System.Drawing.Point(100, 155);
            this.FoodTypeLabel.Name = "FoodTypeLabel";
            this.FoodTypeLabel.Size = new System.Drawing.Size(169, 45);
            this.FoodTypeLabel.TabIndex = 16;
            this.FoodTypeLabel.Text = "Food Type";
            // 
            // quantityValue
            // 
            this.quantityValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityValue.Location = new System.Drawing.Point(303, 404);
            this.quantityValue.Name = "quantityValue";
            this.quantityValue.Size = new System.Drawing.Size(343, 51);
            this.quantityValue.TabIndex = 23;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.quantityLabel.Location = new System.Drawing.Point(100, 404);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(146, 45);
            this.quantityLabel.TabIndex = 22;
            this.quantityLabel.Text = "Quantity";
            // 
            // orderByTableLabel
            // 
            this.orderByTableLabel.AutoSize = true;
            this.orderByTableLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByTableLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.orderByTableLabel.Location = new System.Drawing.Point(252, 41);
            this.orderByTableLabel.Name = "orderByTableLabel";
            this.orderByTableLabel.Size = new System.Drawing.Size(230, 45);
            this.orderByTableLabel.TabIndex = 24;
            this.orderByTableLabel.Text = "Order By Table";
            // 
            // orderByTableDropDown
            // 
            this.orderByTableDropDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByTableDropDown.FormattingEnabled = true;
            this.orderByTableDropDown.Location = new System.Drawing.Point(463, 41);
            this.orderByTableDropDown.Name = "orderByTableDropDown";
            this.orderByTableDropDown.Size = new System.Drawing.Size(111, 53);
            this.orderByTableDropDown.TabIndex = 25;
            this.orderByTableDropDown.SelectedIndexChanged += new System.EventHandler(this.orderByTableDropDown_SelectedIndexChanged);
            // 
            // attendantDropDown
            // 
            this.attendantDropDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendantDropDown.FormattingEnabled = true;
            this.attendantDropDown.Location = new System.Drawing.Point(850, 41);
            this.attendantDropDown.Name = "attendantDropDown";
            this.attendantDropDown.Size = new System.Drawing.Size(229, 53);
            this.attendantDropDown.TabIndex = 27;
            // 
            // attendantLabel
            // 
            this.attendantLabel.AutoSize = true;
            this.attendantLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendantLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.attendantLabel.Location = new System.Drawing.Point(693, 41);
            this.attendantLabel.Name = "attendantLabel";
            this.attendantLabel.Size = new System.Drawing.Size(165, 45);
            this.attendantLabel.TabIndex = 26;
            this.attendantLabel.Text = "Attendant";
            // 
            // foodTypeDropDown
            // 
            this.foodTypeDropDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTypeDropDown.FormattingEnabled = true;
            this.foodTypeDropDown.Location = new System.Drawing.Point(303, 155);
            this.foodTypeDropDown.Name = "foodTypeDropDown";
            this.foodTypeDropDown.Size = new System.Drawing.Size(343, 53);
            this.foodTypeDropDown.TabIndex = 28;
            this.foodTypeDropDown.SelectedIndexChanged += new System.EventHandler(this.foodTypeDropDown_SelectedIndexChanged);
            // 
            // foodNameDropDown
            // 
            this.foodNameDropDown.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameDropDown.FormattingEnabled = true;
            this.foodNameDropDown.Location = new System.Drawing.Point(303, 237);
            this.foodNameDropDown.Name = "foodNameDropDown";
            this.foodNameDropDown.Size = new System.Drawing.Size(343, 53);
            this.foodNameDropDown.TabIndex = 29;
            this.foodNameDropDown.SelectedIndexChanged += new System.EventHandler(this.foodNameDropDown_SelectedIndexChanged);
            // 
            // selectedFoodListBox
            // 
            this.selectedFoodListBox.FormattingEnabled = true;
            this.selectedFoodListBox.ItemHeight = 37;
            this.selectedFoodListBox.Location = new System.Drawing.Point(747, 155);
            this.selectedFoodListBox.Name = "selectedFoodListBox";
            this.selectedFoodListBox.Size = new System.Drawing.Size(427, 300);
            this.selectedFoodListBox.TabIndex = 30;
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.deleteSelectedButton.Location = new System.Drawing.Point(1199, 263);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(139, 87);
            this.deleteSelectedButton.TabIndex = 31;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // createOrderButton
            // 
            this.createOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrderButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.createOrderButton.Location = new System.Drawing.Point(854, 483);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(199, 80);
            this.createOrderButton.TabIndex = 32;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // selectFoodButton
            // 
            this.selectFoodButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectFoodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.selectFoodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectFoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFoodButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFoodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.selectFoodButton.Location = new System.Drawing.Point(377, 483);
            this.selectFoodButton.Name = "selectFoodButton";
            this.selectFoodButton.Size = new System.Drawing.Size(199, 80);
            this.selectFoodButton.TabIndex = 33;
            this.selectFoodButton.Text = "Select Food";
            this.selectFoodButton.UseVisualStyleBackColor = true;
            this.selectFoodButton.Click += new System.EventHandler(this.selectFoodButton_Click);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1041);
            this.Controls.Add(this.selectFoodButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.selectedFoodListBox);
            this.Controls.Add(this.foodNameDropDown);
            this.Controls.Add(this.foodTypeDropDown);
            this.Controls.Add(this.attendantDropDown);
            this.Controls.Add(this.attendantLabel);
            this.Controls.Add(this.orderByTableDropDown);
            this.Controls.Add(this.orderByTableLabel);
            this.Controls.Add(this.quantityValue);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceValue);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.foodNameLabel);
            this.Controls.Add(this.FoodTypeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateOrderForm";
            this.Text = "Order Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceValue;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.Label FoodTypeLabel;
        private System.Windows.Forms.TextBox quantityValue;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label orderByTableLabel;
        private System.Windows.Forms.ComboBox orderByTableDropDown;
        private System.Windows.Forms.ComboBox attendantDropDown;
        private System.Windows.Forms.Label attendantLabel;
        private System.Windows.Forms.ComboBox foodTypeDropDown;
        private System.Windows.Forms.ComboBox foodNameDropDown;
        private System.Windows.Forms.ListBox selectedFoodListBox;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button selectFoodButton;
    }
}