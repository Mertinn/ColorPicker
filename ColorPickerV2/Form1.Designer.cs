
namespace ColorPickerV2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rgbCopyBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageGetter = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.rgbLbl = new System.Windows.Forms.Label();
            this.hexLbl = new System.Windows.Forms.Label();
            this.hexCopyBtn = new System.Windows.Forms.Button();
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.rgbValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hevValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadColor = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbCopyBtn
            // 
            this.rgbCopyBtn.Location = new System.Drawing.Point(78, 200);
            this.rgbCopyBtn.Name = "rgbCopyBtn";
            this.rgbCopyBtn.Size = new System.Drawing.Size(99, 23);
            this.rgbCopyBtn.TabIndex = 1;
            this.rgbCopyBtn.Text = "Kopiuj";
            this.rgbCopyBtn.UseVisualStyleBackColor = true;
            this.rgbCopyBtn.Click += new System.EventHandler(this.rgbCopyBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imageGetter
            // 
            this.imageGetter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.imageGetter_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kliknij CTRL, aby uruchomić.";
            // 
            // rgbLbl
            // 
            this.rgbLbl.AutoSize = true;
            this.rgbLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rgbLbl.Location = new System.Drawing.Point(17, 203);
            this.rgbLbl.Name = "rgbLbl";
            this.rgbLbl.Size = new System.Drawing.Size(58, 16);
            this.rgbLbl.TabIndex = 4;
            this.rgbLbl.Text = "aRGB  - ";
            // 
            // hexLbl
            // 
            this.hexLbl.AutoSize = true;
            this.hexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hexLbl.Location = new System.Drawing.Point(15, 240);
            this.hexLbl.Name = "hexLbl";
            this.hexLbl.Size = new System.Drawing.Size(60, 16);
            this.hexLbl.TabIndex = 5;
            this.hexLbl.Text = "     Hex  - ";
            // 
            // hexCopyBtn
            // 
            this.hexCopyBtn.Location = new System.Drawing.Point(78, 237);
            this.hexCopyBtn.Name = "hexCopyBtn";
            this.hexCopyBtn.Size = new System.Drawing.Size(99, 23);
            this.hexCopyBtn.TabIndex = 6;
            this.hexCopyBtn.Text = "Kopiuj";
            this.hexCopyBtn.UseVisualStyleBackColor = true;
            this.hexCopyBtn.Click += new System.EventHandler(this.hexCopyBtn_Click);
            // 
            // historyTable
            // 
            this.historyTable.AllowUserToResizeColumns = false;
            this.historyTable.AllowUserToResizeRows = false;
            this.historyTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.historyTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rgbValue,
            this.hevValue,
            this.loadColor});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historyTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.historyTable.Location = new System.Drawing.Point(2, 279);
            this.historyTable.Name = "historyTable";
            this.historyTable.ReadOnly = true;
            this.historyTable.RowHeadersVisible = false;
            this.historyTable.Size = new System.Drawing.Size(276, 152);
            this.historyTable.TabIndex = 0;
            this.historyTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyTable_CellClick);
            // 
            // rgbValue
            // 
            this.rgbValue.HeaderText = "RGB";
            this.rgbValue.Name = "rgbValue";
            this.rgbValue.ReadOnly = true;
            // 
            // hevValue
            // 
            this.hevValue.HeaderText = "HEX";
            this.hevValue.Name = "hevValue";
            this.hevValue.ReadOnly = true;
            this.hevValue.Width = 67;
            // 
            // loadColor
            // 
            this.loadColor.FillWeight = 80F;
            this.loadColor.HeaderText = "Wczytaj kolor";
            this.loadColor.Name = "loadColor";
            this.loadColor.ReadOnly = true;
            this.loadColor.Text = "Wczytaj";
            this.loadColor.UseColumnTextForButtonValue = true;
            this.loadColor.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 481);
            this.Controls.Add(this.historyTable);
            this.Controls.Add(this.hexCopyBtn);
            this.Controls.Add(this.hexLbl);
            this.Controls.Add(this.rgbLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rgbCopyBtn);
            this.MaximumSize = new System.Drawing.Size(264, 520);
            this.MinimumSize = new System.Drawing.Size(264, 520);
            this.Name = "Form1";
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rgbCopyBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker imageGetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rgbLbl;
        private System.Windows.Forms.Label hexLbl;
        private System.Windows.Forms.Button hexCopyBtn;
        private System.Windows.Forms.DataGridView historyTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgbValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn hevValue;
        private System.Windows.Forms.DataGridViewButtonColumn loadColor;
    }
}

