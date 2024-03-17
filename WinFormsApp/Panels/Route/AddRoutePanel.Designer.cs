namespace WinFormsApp.Panels
{
    partial class AddRoutePanel
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
            textDescription = new TextBox();
            label3 = new Label();
            textName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(423, 171);
            button2.Name = "button2";
            button2.Size = new Size(151, 53);
            button2.TabIndex = 20;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // textDescription
            // 
            textDescription.Font = new Font("Verdana", 14.25F);
            textDescription.Location = new Point(522, 85);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(313, 46);
            textDescription.TabIndex = 15;
            textDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(522, 59);
            label3.Name = "label3";
            label3.Size = new Size(100, 18);
            label3.TabIndex = 14;
            label3.Text = "Description";
            // 
            // textName
            // 
            textName.Font = new Font("Verdana", 14.25F);
            textName.Location = new Point(156, 85);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(313, 46);
            textName.TabIndex = 13;
            textName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(156, 59);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 11;
            label1.Text = "Insert Route";
            // 
            // AddRoutePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 264);
            Controls.Add(button2);
            Controls.Add(textDescription);
            Controls.Add(label3);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddRoutePanel";
            Text = "AddRoutePanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textDescription;
        private Label label3;
        private TextBox textName;
        private Label label2;
        private Label label1;
    }
}