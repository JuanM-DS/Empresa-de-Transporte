namespace WinFormsApp.Panels.Buses
{
    partial class UpdateBusPanel
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
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textYear = new TextBox();
            textColor = new TextBox();
            textPlate = new TextBox();
            textModel = new TextBox();
            textBrand = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F);
            label6.Location = new Point(671, 57);
            label6.Name = "label6";
            label6.Size = new Size(44, 18);
            label6.TabIndex = 33;
            label6.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(376, 147);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 30;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(376, 57);
            label5.Name = "label5";
            label5.Size = new Size(50, 18);
            label5.TabIndex = 28;
            label5.Text = "Plate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(81, 147);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 26;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(81, 57);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 24;
            label2.Text = "Brand";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 23;
            label1.Text = "Insert Bus";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(777, 170);
            button1.Name = "button1";
            button1.Size = new Size(151, 53);
            button1.TabIndex = 35;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textYear
            // 
            textYear.Font = new Font("Verdana", 14.25F);
            textYear.Location = new Point(671, 78);
            textYear.Multiline = true;
            textYear.Name = "textYear";
            textYear.Size = new Size(257, 46);
            textYear.TabIndex = 40;
            textYear.TextAlign = HorizontalAlignment.Center;
            // 
            // textColor
            // 
            textColor.Font = new Font("Verdana", 14.25F);
            textColor.Location = new Point(376, 168);
            textColor.Multiline = true;
            textColor.Name = "textColor";
            textColor.Size = new Size(257, 46);
            textColor.TabIndex = 39;
            textColor.TextAlign = HorizontalAlignment.Center;
            // 
            // textPlate
            // 
            textPlate.Font = new Font("Verdana", 14.25F);
            textPlate.Location = new Point(376, 78);
            textPlate.Multiline = true;
            textPlate.Name = "textPlate";
            textPlate.Size = new Size(257, 46);
            textPlate.TabIndex = 38;
            textPlate.TextAlign = HorizontalAlignment.Center;
            // 
            // textModel
            // 
            textModel.Font = new Font("Verdana", 14.25F);
            textModel.Location = new Point(81, 168);
            textModel.Multiline = true;
            textModel.Name = "textModel";
            textModel.Size = new Size(257, 46);
            textModel.TabIndex = 37;
            textModel.TextAlign = HorizontalAlignment.Center;
            // 
            // textBrand
            // 
            textBrand.AccessibleRole = AccessibleRole.TitleBar;
            textBrand.Font = new Font("Verdana", 14.25F);
            textBrand.Location = new Point(81, 78);
            textBrand.Multiline = true;
            textBrand.Name = "textBrand";
            textBrand.Size = new Size(257, 46);
            textBrand.TabIndex = 36;
            textBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // UpdateBusPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 264);
            Controls.Add(textYear);
            Controls.Add(textColor);
            Controls.Add(textPlate);
            Controls.Add(textModel);
            Controls.Add(textBrand);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateBusPanel";
            Text = "UpdateBusPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textYear;
        private TextBox textColor;
        private TextBox textPlate;
        private TextBox textModel;
        private TextBox textBrand;
    }
}