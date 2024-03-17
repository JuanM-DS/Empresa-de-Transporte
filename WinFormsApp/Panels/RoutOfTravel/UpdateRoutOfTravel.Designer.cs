namespace WinFormsApp.Panels.RoutOfTravel
{
    partial class UpdateRoutOfTravel
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
            label1 = new Label();
            boxBus = new ComboBox();
            boxRoute = new ComboBox();
            boxConductor = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(414, 158);
            button2.Name = "button2";
            button2.Size = new Size(151, 53);
            button2.TabIndex = 20;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 11;
            label1.Text = "Update Conductor";
            // 
            // boxBus
            // 
            boxBus.FormattingEnabled = true;
            boxBus.Location = new Point(695, 82);
            boxBus.Name = "boxBus";
            boxBus.Size = new Size(250, 23);
            boxBus.TabIndex = 52;
            // 
            // boxRoute
            // 
            boxRoute.FormattingEnabled = true;
            boxRoute.Location = new Point(383, 82);
            boxRoute.Name = "boxRoute";
            boxRoute.Size = new Size(250, 23);
            boxRoute.TabIndex = 51;
            // 
            // boxConductor
            // 
            boxConductor.FormattingEnabled = true;
            boxConductor.Location = new Point(71, 82);
            boxConductor.Name = "boxConductor";
            boxConductor.Size = new Size(250, 23);
            boxConductor.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(695, 56);
            label4.Name = "label4";
            label4.Size = new Size(38, 18);
            label4.TabIndex = 49;
            label4.Text = "Bus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(383, 56);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 48;
            label3.Text = "Route";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(71, 56);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 47;
            label2.Text = "Conductor";
            // 
            // UpdateRoutOfTravel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 264);
            Controls.Add(boxBus);
            Controls.Add(boxRoute);
            Controls.Add(boxConductor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateRoutOfTravel";
            Text = "UpdateRoutOfTravel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private ComboBox boxBus;
        private ComboBox boxRoute;
        private ComboBox boxConductor;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}