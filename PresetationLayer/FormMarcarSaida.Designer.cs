namespace PresetationLayer
{
    partial class FormMarcarSaida
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
            GridCarrosComEntrada = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridCarrosComEntrada).BeginInit();
            SuspendLayout();
            // 
            // GridCarrosComEntrada
            // 
            GridCarrosComEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCarrosComEntrada.Location = new Point(12, 70);
            GridCarrosComEntrada.Name = "GridCarrosComEntrada";
            GridCarrosComEntrada.RowHeadersWidth = 51;
            GridCarrosComEntrada.Size = new Size(962, 530);
            GridCarrosComEntrada.TabIndex = 0;
            GridCarrosComEntrada.CellClick += DataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(680, 38);
            label2.TabIndex = 4;
            label2.Text = "Para marcar a saida Basta clicar na grid do carro a sair";
            // 
            // FormMarcarSaida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(986, 612);
            Controls.Add(label2);
            Controls.Add(GridCarrosComEntrada);
            Name = "FormMarcarSaida";
            Text = "FormMarcarSaida";
            Load += FormMarcarSaida_Load;
            ((System.ComponentModel.ISupportInitialize)GridCarrosComEntrada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridCarrosComEntrada;
        private Label label2;
    }
}