namespace PresetationLayer
{
    partial class FormAlterarVigencia
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
            CHangeCopetenceButton = new Button();
            label2 = new Label();
            InicioVigenciaDate = new DateTimePicker();
            FimVigenciaDate = new DateTimePicker();
            label1 = new Label();
            TxtBoxVigenciaValue = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // CHangeCopetenceButton
            // 
            CHangeCopetenceButton.BackColor = Color.Snow;
            CHangeCopetenceButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CHangeCopetenceButton.ForeColor = Color.Red;
            CHangeCopetenceButton.Location = new Point(365, 278);
            CHangeCopetenceButton.Name = "CHangeCopetenceButton";
            CHangeCopetenceButton.Size = new Size(165, 54);
            CHangeCopetenceButton.TabIndex = 9;
            CHangeCopetenceButton.Text = "Alterar VIgencia";
            CHangeCopetenceButton.UseVisualStyleBackColor = false;
            CHangeCopetenceButton.Click += CHangeCopetenceButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 66);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 8;
            label2.Text = "Inicio da vigencia";
            // 
            // InicioVigenciaDate
            // 
            InicioVigenciaDate.Location = new Point(280, 66);
            InicioVigenciaDate.Name = "InicioVigenciaDate";
            InicioVigenciaDate.Size = new Size(250, 27);
            InicioVigenciaDate.TabIndex = 10;
            // 
            // FimVigenciaDate
            // 
            FimVigenciaDate.Location = new Point(280, 138);
            FimVigenciaDate.Name = "FimVigenciaDate";
            FimVigenciaDate.Size = new Size(250, 27);
            FimVigenciaDate.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 139);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 12;
            label1.Text = "Fim da vigencia";
            // 
            // TxtBoxVigenciaValue
            // 
            TxtBoxVigenciaValue.Location = new Point(280, 207);
            TxtBoxVigenciaValue.Name = "TxtBoxVigenciaValue";
            TxtBoxVigenciaValue.Size = new Size(250, 27);
            TxtBoxVigenciaValue.TabIndex = 13;
            TxtBoxVigenciaValue.KeyPress += CHangeCopetence_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 203);
            label3.Name = "label3";
            label3.Size = new Size(163, 28);
            label3.TabIndex = 14;
            label3.Text = "Valor da Vigencia";
            // 
            // FormAlterarVigencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(544, 450);
            Controls.Add(label3);
            Controls.Add(TxtBoxVigenciaValue);
            Controls.Add(label1);
            Controls.Add(FimVigenciaDate);
            Controls.Add(InicioVigenciaDate);
            Controls.Add(CHangeCopetenceButton);
            Controls.Add(label2);
            Name = "FormAlterarVigencia";
            Text = "FormAlterarVigencia";
            Load += FormAlterarVigencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CHangeCopetenceButton;
        private Label label2;
        private DateTimePicker InicioVigenciaDate;
        private DateTimePicker FimVigenciaDate;
        private Label label1;
        private TextBox TxtBoxVigenciaValue;
        private Label label3;
    }
}