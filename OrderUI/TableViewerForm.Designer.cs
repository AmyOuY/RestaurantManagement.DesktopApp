namespace OrderUI
{
    partial class TableViewerForm
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
            this.createTableButton = new System.Windows.Forms.Button();
            this.seatsValue = new System.Windows.Forms.TextBox();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.tableNumberValue = new System.Windows.Forms.TextBox();
            this.tableNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTableButton
            // 
            this.createTableButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTableButton.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTableButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.createTableButton.Location = new System.Drawing.Point(872, 196);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(219, 74);
            this.createTableButton.TabIndex = 21;
            this.createTableButton.Text = "Create Table";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // seatsValue
            // 
            this.seatsValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsValue.Location = new System.Drawing.Point(521, 262);
            this.seatsValue.Name = "seatsValue";
            this.seatsValue.Size = new System.Drawing.Size(218, 51);
            this.seatsValue.TabIndex = 20;
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.seatsLabel.Location = new System.Drawing.Point(289, 262);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(97, 45);
            this.seatsLabel.TabIndex = 19;
            this.seatsLabel.Text = "Seats";
            // 
            // tableNumberValue
            // 
            this.tableNumberValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumberValue.Location = new System.Drawing.Point(521, 157);
            this.tableNumberValue.Name = "tableNumberValue";
            this.tableNumberValue.Size = new System.Drawing.Size(218, 51);
            this.tableNumberValue.TabIndex = 18;
            // 
            // tableNumberLabel
            // 
            this.tableNumberLabel.AutoSize = true;
            this.tableNumberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumberLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableNumberLabel.Location = new System.Drawing.Point(289, 157);
            this.tableNumberLabel.Name = "tableNumberLabel";
            this.tableNumberLabel.Size = new System.Drawing.Size(222, 45);
            this.tableNumberLabel.TabIndex = 17;
            this.tableNumberLabel.Text = "Table Number";
            // 
            // TableViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.seatsValue);
            this.Controls.Add(this.seatsLabel);
            this.Controls.Add(this.tableNumberValue);
            this.Controls.Add(this.tableNumberLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TableViewerForm";
            this.Text = "TableViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.TextBox seatsValue;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.TextBox tableNumberValue;
        private System.Windows.Forms.Label tableNumberLabel;
    }
}