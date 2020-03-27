namespace OrderUI
{
    partial class FoodViewerForm
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
            this.createFoodButton = new System.Windows.Forms.Button();
            this.priceValue = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.foodNameValue = new System.Windows.Forms.TextBox();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.foodTypeValue = new System.Windows.Forms.TextBox();
            this.FoodTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createFoodButton
            // 
            this.createFoodButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createFoodButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createFoodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createFoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFoodButton.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFoodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.createFoodButton.Location = new System.Drawing.Point(842, 249);
            this.createFoodButton.Name = "createFoodButton";
            this.createFoodButton.Size = new System.Drawing.Size(321, 74);
            this.createFoodButton.TabIndex = 16;
            this.createFoodButton.Text = "Create Food";
            this.createFoodButton.UseVisualStyleBackColor = true;
            this.createFoodButton.Click += new System.EventHandler(this.createFoodButton_Click);
            // 
            // priceValue
            // 
            this.priceValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceValue.Location = new System.Drawing.Point(372, 352);
            this.priceValue.Name = "priceValue";
            this.priceValue.Size = new System.Drawing.Size(343, 51);
            this.priceValue.TabIndex = 15;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.priceLabel.Location = new System.Drawing.Point(175, 352);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(89, 45);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Price";
            // 
            // foodNameValue
            // 
            this.foodNameValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameValue.Location = new System.Drawing.Point(372, 249);
            this.foodNameValue.Name = "foodNameValue";
            this.foodNameValue.Size = new System.Drawing.Size(343, 51);
            this.foodNameValue.TabIndex = 13;
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.foodNameLabel.Location = new System.Drawing.Point(175, 249);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(189, 45);
            this.foodNameLabel.TabIndex = 12;
            this.foodNameLabel.Text = "Food Name";
            // 
            // foodTypeValue
            // 
            this.foodTypeValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodTypeValue.Location = new System.Drawing.Point(372, 144);
            this.foodTypeValue.Name = "foodTypeValue";
            this.foodTypeValue.Size = new System.Drawing.Size(343, 51);
            this.foodTypeValue.TabIndex = 11;
            // 
            // FoodTypeLabel
            // 
            this.FoodTypeLabel.AutoSize = true;
            this.FoodTypeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodTypeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FoodTypeLabel.Location = new System.Drawing.Point(175, 144);
            this.FoodTypeLabel.Name = "FoodTypeLabel";
            this.FoodTypeLabel.Size = new System.Drawing.Size(169, 45);
            this.FoodTypeLabel.TabIndex = 10;
            this.FoodTypeLabel.Text = "Food Type";
            // 
            // FoodViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1041);
            this.Controls.Add(this.createFoodButton);
            this.Controls.Add(this.priceValue);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.foodNameValue);
            this.Controls.Add(this.foodNameLabel);
            this.Controls.Add(this.foodTypeValue);
            this.Controls.Add(this.FoodTypeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FoodViewerForm";
            this.Text = "FoodViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createFoodButton;
        private System.Windows.Forms.TextBox priceValue;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox foodNameValue;
        private System.Windows.Forms.Label foodNameLabel;
        private System.Windows.Forms.TextBox foodTypeValue;
        private System.Windows.Forms.Label FoodTypeLabel;
    }
}