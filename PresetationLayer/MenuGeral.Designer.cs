namespace PresetationLayer
{
    partial class MenuGeral
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            DateAndHourLabel = new Label();
            BtnMarcarSaida = new Button();
            MarcarEntradaButton = new Button();
            VigenciaButton = new Button();
            DataGridMenuMovimentaçoes = new DataGridView();
            label3 = new Label();
            TotalValueLabel = new Label();
            ReloadGrid = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridMenuMovimentaçoes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 20);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 1;
            label1.Text = "Estacionamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 48);
            label2.Name = "label2";
            label2.Size = new Size(276, 38);
            label2.TabIndex = 3;
            label2.Text = "Carro Bem Guardado";
            // 
            // DateAndHourLabel
            // 
            DateAndHourLabel.AutoSize = true;
            DateAndHourLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateAndHourLabel.Location = new Point(803, 9);
            DateAndHourLabel.Name = "DateAndHourLabel";
            DateAndHourLabel.Size = new Size(151, 28);
            DateAndHourLabel.TabIndex = 4;
            DateAndHourLabel.Text = "Estacionamento";
            // 
            // BtnMarcarSaida
            // 
            BtnMarcarSaida.BackColor = Color.Snow;
            BtnMarcarSaida.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnMarcarSaida.ForeColor = Color.Red;
            BtnMarcarSaida.Location = new Point(539, 20);
            BtnMarcarSaida.Name = "BtnMarcarSaida";
            BtnMarcarSaida.Size = new Size(219, 66);
            BtnMarcarSaida.TabIndex = 5;
            BtnMarcarSaida.Text = "Marcar Saida";
            BtnMarcarSaida.UseVisualStyleBackColor = false;
            BtnMarcarSaida.Click += BtnMarcarSaida_Click;
            // 
            // MarcarEntradaButton
            // 
            MarcarEntradaButton.BackColor = Color.Snow;
            MarcarEntradaButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MarcarEntradaButton.ForeColor = Color.GreenYellow;
            MarcarEntradaButton.Location = new Point(12, 20);
            MarcarEntradaButton.Name = "MarcarEntradaButton";
            MarcarEntradaButton.Size = new Size(219, 66);
            MarcarEntradaButton.TabIndex = 6;
            MarcarEntradaButton.Text = "Marcar Entrada";
            MarcarEntradaButton.UseVisualStyleBackColor = false;
            MarcarEntradaButton.Click += MarcarEntradaButton_Click;
            // 
            // VigenciaButton
            // 
            VigenciaButton.BackColor = Color.Snow;
            VigenciaButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            VigenciaButton.ForeColor = Color.Red;
            VigenciaButton.Location = new Point(803, 40);
            VigenciaButton.Name = "VigenciaButton";
            VigenciaButton.Size = new Size(151, 46);
            VigenciaButton.TabIndex = 7;
            VigenciaButton.Text = "Alterar VIgencia";
            VigenciaButton.UseVisualStyleBackColor = false;
            VigenciaButton.Click += VigenciaButton_Click;
            // 
            // DataGridMenuMovimentaçoes
            // 
            DataGridMenuMovimentaçoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridMenuMovimentaçoes.Location = new Point(12, 147);
            DataGridMenuMovimentaçoes.Name = "DataGridMenuMovimentaçoes";
            DataGridMenuMovimentaçoes.RowHeadersWidth = 51;
            DataGridMenuMovimentaçoes.Size = new Size(942, 451);
            DataGridMenuMovimentaçoes.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(216, 28);
            label3.TabIndex = 9;
            label3.Text = "Valor total Adquirido =";
            // 
            // TotalValueLabel
            // 
            TotalValueLabel.AutoSize = true;
            TotalValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalValueLabel.Location = new Point(225, 101);
            TotalValueLabel.Name = "TotalValueLabel";
            TotalValueLabel.Size = new Size(23, 28);
            TotalValueLabel.TabIndex = 10;
            TotalValueLabel.Text = "0";
            // 
            // ReloadGrid
            // 
            ReloadGrid.BackColor = Color.Snow;
            ReloadGrid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReloadGrid.ForeColor = Color.Red;
            ReloadGrid.Location = new Point(834, 101);
            ReloadGrid.Name = "ReloadGrid";
            ReloadGrid.Size = new Size(120, 46);
            ReloadGrid.TabIndex = 11;
            ReloadGrid.Text = "Atualizar Grid";
            ReloadGrid.UseVisualStyleBackColor = false;
            ReloadGrid.Click += ReloadGrid_Click;
            // 
            // MenuGeral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(967, 610);
            Controls.Add(ReloadGrid);
            Controls.Add(TotalValueLabel);
            Controls.Add(label3);
            Controls.Add(DataGridMenuMovimentaçoes);
            Controls.Add(VigenciaButton);
            Controls.Add(MarcarEntradaButton);
            Controls.Add(BtnMarcarSaida);
            Controls.Add(DateAndHourLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuGeral";
            Text = "Form1";
            Load += MenuGeral_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridMenuMovimentaçoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label DateAndHourLabel;
        private Button BtnMarcarSaida;
        private Button MarcarEntradaButton;
        private Button VigenciaButton;
        private DataGridView DataGridMenuMovimentaçoes;
        private Label label3;
        private Label TotalValueLabel;
        private Button ReloadGrid;
    }
}
