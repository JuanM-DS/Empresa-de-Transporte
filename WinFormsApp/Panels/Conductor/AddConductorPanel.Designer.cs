namespace WinFormsApp.Paneles
{
    partial class AddConductorPanel
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
            label1 = new Label();
            label2 = new Label();
            textFirstName = new TextBox();
            textLastName = new TextBox();
            label3 = new Label();
            textDNI = new TextBox();
            label4 = new Label();
            textBirthdate = new TextBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "Insert Conductor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(81, 57);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // textFirstName
            // 
            textFirstName.Font = new Font("Verdana", 14.25F);
            textFirstName.Location = new Point(81, 83);
            textFirstName.Multiline = true;
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(313, 46);
            textFirstName.TabIndex = 2;
            textFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // textLastName
            // 
            textLastName.Font = new Font("Verdana", 14.25F);
            textLastName.Location = new Point(81, 173);
            textLastName.Multiline = true;
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(313, 46);
            textLastName.TabIndex = 4;
            textLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(81, 147);
            label3.Name = "label3";
            label3.Size = new Size(96, 18);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // textDNI
            // 
            textDNI.Font = new Font("Verdana", 14.25F);
            textDNI.Location = new Point(437, 173);
            textDNI.Multiline = true;
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(313, 46);
            textDNI.TabIndex = 8;
            textDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(437, 147);
            label4.Name = "label4";
            label4.Size = new Size(39, 18);
            label4.TabIndex = 7;
            label4.Text = "DNI";
            // 
            // textBirthdate
            // 
            textBirthdate.Font = new Font("Verdana", 14.25F);
            textBirthdate.Location = new Point(437, 83);
            textBirthdate.Multiline = true;
            textBirthdate.Name = "textBirthdate";
            textBirthdate.Size = new Size(313, 46);
            textBirthdate.TabIndex = 6;
            textBirthdate.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(437, 57);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 5;
            label5.Text = "Birthdate";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(777, 169);
            button2.Name = "button2";
            button2.Size = new Size(151, 53);
            button2.TabIndex = 10;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddConductorPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 264);
            Controls.Add(button2);
            Controls.Add(textDNI);
            Controls.Add(label4);
            Controls.Add(textBirthdate);
            Controls.Add(label5);
            Controls.Add(textLastName);
            Controls.Add(label3);
            Controls.Add(textFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddConductorPanel";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textFirstName;
        private TextBox textLastName;
        private Label label3;
        private TextBox textDNI;
        private Label label4;
        private TextBox textBirthdate;
        private Label label5;
        private Button button2;
    }
}