namespace WinFormsApp.Panels
{
    partial class UpdateRoute
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
            textDescription = new TextBox();
            label3 = new Label();
            textName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textDescription
            // 
            textDescription.Font = new Font("Verdana", 14.25F);
            textDescription.Location = new Point(523, 84);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(313, 46);
            textDescription.TabIndex = 25;
            textDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(523, 58);
            label3.Name = "label3";
            label3.Size = new Size(100, 18);
            label3.TabIndex = 24;
            label3.Text = "Description";
            // 
            // textName
            // 
            textName.Font = new Font("Verdana", 14.25F);
            textName.Location = new Point(157, 84);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(313, 46);
            textName.TabIndex = 23;
            textName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(157, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 21;
            label1.Text = "Update Route";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(424, 166);
            button1.Name = "button1";
            button1.Size = new Size(151, 53);
            button1.TabIndex = 27;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UpdateRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 264);
            Controls.Add(button1);
            Controls.Add(textDescription);
            Controls.Add(label3);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateRoute";
            Text = "UpdateRoute";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textDescription;
        private Label label3;
        private TextBox textName;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}