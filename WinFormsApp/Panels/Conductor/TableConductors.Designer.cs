namespace WinFormsApp.Paneles
{
    partial class TableConductors
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateNacDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idBusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idrouteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            availabilityDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            conductorBindingSource3 = new BindingSource(components);
            conductorBindingSource1 = new BindingSource(components);
            conductorBindingSource = new BindingSource(components);
            button2 = new Button();
            button1 = new Button();
            conductorBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, dateNacDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, idBusDataGridViewTextBoxColumn, idrouteDataGridViewTextBoxColumn, availabilityDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = conductorBindingSource3;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1010, 333);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 120;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 124;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 122;
            // 
            // dateNacDataGridViewTextBoxColumn
            // 
            dateNacDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            dateNacDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            dateNacDataGridViewTextBoxColumn.Name = "dateNacDataGridViewTextBoxColumn";
            dateNacDataGridViewTextBoxColumn.ReadOnly = true;
            dateNacDataGridViewTextBoxColumn.Width = 120;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            dNIDataGridViewTextBoxColumn.Width = 120;
            // 
            // idBusDataGridViewTextBoxColumn
            // 
            idBusDataGridViewTextBoxColumn.DataPropertyName = "IdBus";
            idBusDataGridViewTextBoxColumn.HeaderText = "IdBus";
            idBusDataGridViewTextBoxColumn.Name = "idBusDataGridViewTextBoxColumn";
            idBusDataGridViewTextBoxColumn.ReadOnly = true;
            idBusDataGridViewTextBoxColumn.Width = 120;
            // 
            // idrouteDataGridViewTextBoxColumn
            // 
            idrouteDataGridViewTextBoxColumn.DataPropertyName = "Idroute";
            idrouteDataGridViewTextBoxColumn.HeaderText = "Idroute";
            idrouteDataGridViewTextBoxColumn.Name = "idrouteDataGridViewTextBoxColumn";
            idrouteDataGridViewTextBoxColumn.ReadOnly = true;
            idrouteDataGridViewTextBoxColumn.Width = 120;
            // 
            // availabilityDataGridViewCheckBoxColumn
            // 
            availabilityDataGridViewCheckBoxColumn.DataPropertyName = "availability";
            availabilityDataGridViewCheckBoxColumn.HeaderText = "availability";
            availabilityDataGridViewCheckBoxColumn.Name = "availabilityDataGridViewCheckBoxColumn";
            availabilityDataGridViewCheckBoxColumn.ReadOnly = true;
            availabilityDataGridViewCheckBoxColumn.Width = 120;
            // 
            // conductorBindingSource3
            // 
            conductorBindingSource3.DataSource = typeof(Modelos.Conductor);
            // 
            // conductorBindingSource1
            // 
            conductorBindingSource1.DataSource = typeof(Modelos.Conductor);
            // 
            // conductorBindingSource
            // 
            conductorBindingSource.DataSource = typeof(Modelos.Conductor);
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(847, 339);
            button2.Name = "button2";
            button2.Size = new Size(151, 53);
            button2.TabIndex = 10;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(690, 339);
            button1.Name = "button1";
            button1.Size = new Size(151, 53);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // conductorBindingSource2
            // 
            conductorBindingSource2.DataSource = typeof(Modelos.Conductor);
            // 
            // TableConductors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 404);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TableConductors";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource conductorBindingSource;
        private BindingSource conductorBindingSource1;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateNacDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idrouteDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn availabilityDataGridViewCheckBoxColumn;
        private BindingSource conductorBindingSource3;
        private BindingSource conductorBindingSource2;
    }
}