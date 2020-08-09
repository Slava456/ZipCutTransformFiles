namespace ZipCutTransformFiles.Forms
{
    partial class MainForm
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
            this.pnfForPnlDrop = new System.Windows.Forms.Panel();
            this.pnlForPnlDropOut = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlForCTBWidth = new System.Windows.Forms.Panel();
            this.pnlForCTBHeight = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.btClear = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.lblBot = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnfForPnlDrop
            // 
            this.pnfForPnlDrop.BackColor = System.Drawing.SystemColors.Control;
            this.pnfForPnlDrop.Location = new System.Drawing.Point(23, 21);
            this.pnfForPnlDrop.Name = "pnfForPnlDrop";
            this.pnfForPnlDrop.Size = new System.Drawing.Size(67, 37);
            this.pnfForPnlDrop.TabIndex = 0;
            // 
            // pnlForPnlDropOut
            // 
            this.pnlForPnlDropOut.BackColor = System.Drawing.SystemColors.Control;
            this.pnlForPnlDropOut.Location = new System.Drawing.Point(23, 88);
            this.pnlForPnlDropOut.Name = "pnlForPnlDropOut";
            this.pnlForPnlDropOut.Size = new System.Drawing.Size(67, 37);
            this.pnlForPnlDropOut.TabIndex = 1;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(96, 21);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(126, 26);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "<-- Перетащите папку с\r\n       файлами";
            // 
            // pnlForCTBWidth
            // 
            this.pnlForCTBWidth.Location = new System.Drawing.Point(255, 47);
            this.pnlForCTBWidth.Name = "pnlForCTBWidth";
            this.pnlForCTBWidth.Size = new System.Drawing.Size(103, 25);
            this.pnlForCTBWidth.TabIndex = 3;
            // 
            // pnlForCTBHeight
            // 
            this.pnlForCTBHeight.Location = new System.Drawing.Point(390, 47);
            this.pnlForCTBHeight.Name = "pnlForCTBHeight";
            this.pnlForCTBHeight.Size = new System.Drawing.Size(103, 25);
            this.pnlForCTBHeight.TabIndex = 4;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.Location = new System.Drawing.Point(364, 52);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(252, 18);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(244, 26);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Новый размер изображений:\r\n(если оставить пустым, размер не изменится)";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(23, 151);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(480, 23);
            this.pb.TabIndex = 7;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(23, 180);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(352, 180);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(151, 23);
            this.btGo.TabIndex = 9;
            this.btGo.Text = "Начать преобразование";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // lblBot
            // 
            this.lblBot.AutoSize = true;
            this.lblBot.Location = new System.Drawing.Point(96, 88);
            this.lblBot.Name = "lblBot";
            this.lblBot.Size = new System.Drawing.Size(160, 26);
            this.lblBot.TabIndex = 10;
            this.lblBot.Text = "<-- Перетащите папку, в \r\n       которой хотите сохранить";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(114, 135);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "label1";
            this.lbl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 210);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblBot);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.pnlForCTBHeight);
            this.Controls.Add(this.pnlForCTBWidth);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.pnlForPnlDropOut);
            this.Controls.Add(this.pnfForPnlDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnfForPnlDrop;
        private System.Windows.Forms.Panel pnlForPnlDropOut;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlForCTBWidth;
        private System.Windows.Forms.Panel pnlForCTBHeight;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Label lblBot;
        private System.Windows.Forms.Label lbl;
    }
}