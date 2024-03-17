namespace WinFormsApp.Panels.RoutOfTravel
{
    partial class UpdateTravelOfRoutePanel
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
            boxBus = new ComboBox();
            boxRoute = new ComboBox();
            boxConductor = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // boxBus
            // 
            boxBus.FormattingEnabled = true;
            boxBus.Location = new Point(693, 85);
            boxBus.Name = "boxBus";
            boxBus.Size = new Size(250, 23);
            boxBus.TabIndex = 46;
            // 
            // boxRoute
            // 
            boxRoute.FormattingEnabled = true;
            boxRoute.Location = new Point(381, 85);
            boxRoute.Name = "boxRoute";
            boxRoute.Size = new Size(250, 23);
            boxRoute.TabIndex = 45;
            // 
            // boxConductor
            // 
            boxConductor.FormattingEnabled = true;
            boxConductor.Location = new Point(69, 85);
            boxConductor.Name = "boxConductor";
            boxConductor.Size = new Size(250, 23);
            boxConductor.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(693, 59);
            label4.Name = "label4";
            label4.Size = new Size(38, 18);
            label4.TabIndex = 43;
            label4.Text = "Bus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(381, 59);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 41;
            label3.Text = "Route";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(69, 59);
            label2.Name = "label2";
            label2.Size = new Size(90, 18);
            label2.TabIndex = 40;
            label2.Text = "Conductor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(270, 25);
            label1.TabIndex = 39;
            label1.Text = "Insert Route of Travel";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(424, 161);
            button2.Name = "button2";
            button2.Size = new Size(151, 53);
            button2.TabIndex = 47;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddRoutOftravelPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 264);
            Controls.Add(button2);
            Controls.Add(boxBus);
            Controls.Add(boxRoute);
            Controls.Add(boxConductor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddRoutOftravelPanel";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox boxBus;
        private ComboBox boxRoute;
        private ComboBox boxConductor;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}