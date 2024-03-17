namespace WinFormsApp.Panels.Buses
{
    partial class AddBusPanel
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
            button2 = new Button();
            textColor = new TextBox();
            label4 = new Label();
            textPlate = new TextBox();
            label5 = new Label();
            textModel = new TextBox();
            label3 = new Label();
            textBrand = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textYear = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(775, 169);
            button2.Name = "button2";
            button2.Size = new Size(151, 53);
            button2.TabIndex = 20;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // textColor
            // 
            textColor.Font = new Font("Verdana", 14.25F);
            textColor.Location = new Point(374, 173);
            textColor.Multiline = true;
            textColor.Name = "textColor";
            textColor.Size = new Size(257, 46);
            textColor.TabIndex = 19;
            textColor.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(374, 147);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 18;
            label4.Text = "Color";
            // 
            // textPlate
            // 
            textPlate.Font = new Font("Verdana", 14.25F);
            textPlate.Location = new Point(374, 83);
            textPlate.Multiline = true;
            textPlate.Name = "textPlate";
            textPlate.Size = new Size(257, 46);
            textPlate.TabIndex = 17;
            textPlate.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(374, 57);
            label5.Name = "label5";
            label5.Size = new Size(50, 18);
            label5.TabIndex = 16;
            label5.Text = "Plate";
            // 
            // textModel
            // 
            textModel.Font = new Font("Verdana", 14.25F);
            textModel.Location = new Point(79, 173);
            textModel.Multiline = true;
            textModel.Name = "textModel";
            textModel.Size = new Size(257, 46);
            textModel.TabIndex = 15;
            textModel.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(79, 147);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 14;
            label3.Text = "Model";
            // 
            // textBrand
            // 
            textBrand.AccessibleRole = AccessibleRole.TitleBar;
            textBrand.Font = new Font("Verdana", 14.25F);
            textBrand.Location = new Point(79, 83);
            textBrand.Multiline = true;
            textBrand.Name = "textBrand";
            textBrand.Size = new Size(257, 46);
            textBrand.TabIndex = 13;
            textBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(79, 57);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 12;
            label2.Text = "Brand";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 11;
            label1.Text = "Insert Bus";
            // 
            // textYear
            // 
            textYear.Font = new Font("Verdana", 14.25F);
            textYear.Location = new Point(669, 83);
            textYear.Multiline = true;
            textYear.Name = "textYear";
            textYear.Size = new Size(257, 46);
            textYear.TabIndex = 22;
            textYear.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F);
            label6.Location = new Point(669, 57);
            label6.Name = "label6";
            label6.Size = new Size(44, 18);
            label6.TabIndex = 21;
            label6.Text = "Year";
            // 
            // AddBusPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 264);
            Controls.Add(textYear);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textColor);
            Controls.Add(label4);
            Controls.Add(textPlate);
            Controls.Add(label5);
            Controls.Add(textModel);
            Controls.Add(label3);
            Controls.Add(textBrand);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBusPanel";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textColor;
        private Label label4;
        private TextBox textPlate;
        private Label label5;
        private TextBox textModel;
        private Label label3;
        private TextBox textBrand;
        private Label label2;
        private Label label1;
        private TextBox textYear;
        private Label label6;
    }
}