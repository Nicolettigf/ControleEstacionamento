namespace PresetationLayer
{
    partial class FormMarcarEntrada
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
            MarcarChegadaButton = new Button();
            label2 = new Label();
            label3 = new Label();
            CmbplacasSalvas = new ComboBox();
            txtBoxNewPlaca = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 227);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 19;
            label1.Text = "Horario chegada";
            // 
            // MarcarChegadaButton
            // 
            MarcarChegadaButton.BackColor = Color.Snow;
            MarcarChegadaButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MarcarChegadaButton.ForeColor = Color.Black;
            MarcarChegadaButton.Location = new Point(166, 331);
            MarcarChegadaButton.Name = "MarcarChegadaButton";
            MarcarChegadaButton.Size = new Size(165, 54);
            MarcarChegadaButton.TabIndex = 16;
            MarcarChegadaButton.Text = "Marcar chegada";
            MarcarChegadaButton.UseVisualStyleBackColor = false;
            MarcarChegadaButton.Click += MarcarChegadaButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 15;
            label2.Text = "Placa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 21;
            label3.Text = "Carros Salvo";
            // 
            // CmbplacasSalvas
            // 
            CmbplacasSalvas.FormattingEnabled = true;
            CmbplacasSalvas.Location = new Point(295, 47);
            CmbplacasSalvas.Name = "CmbplacasSalvas";
            CmbplacasSalvas.Size = new Size(181, 28);
            CmbplacasSalvas.TabIndex = 22;
            // 
            // txtBoxNewPlaca
            // 
            txtBoxNewPlaca.Location = new Point(295, 127);
            txtBoxNewPlaca.Name = "txtBoxNewPlaca";
            txtBoxNewPlaca.Size = new Size(181, 27);
            txtBoxNewPlaca.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(226, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // FormMarcarEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(488, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtBoxNewPlaca);
            Controls.Add(CmbplacasSalvas);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(MarcarChegadaButton);
            Controls.Add(label2);
            Name = "FormMarcarEntrada";
            Text = "FormMarcarEntrada";
            Load += FormMarcarEntrada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button MarcarChegadaButton;
        private Label label2;
        private Label label3;
        private ComboBox CmbplacasSalvas;
        private TextBox txtBoxNewPlaca;
        private DateTimePicker dateTimePicker1;
    }
}