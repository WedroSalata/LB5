
namespace LB5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btEnter = new System.Windows.Forms.Button();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.LbItemList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAllArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(794, 90);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(95, 25);
            this.btEnter.TabIndex = 0;
            this.btEnter.Text = "Створити";
            this.btEnter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // tbEnter
            // 
            this.tbEnter.Location = new System.Drawing.Point(482, 92);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(306, 22);
            this.tbEnter.TabIndex = 1;
            // 
            // LbItemList
            // 
            this.LbItemList.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbItemList.FormattingEnabled = true;
            this.LbItemList.ItemHeight = 16;
            this.LbItemList.Location = new System.Drawing.Point(482, 140);
            this.LbItemList.Name = "LbItemList";
            this.LbItemList.Size = new System.Drawing.Size(407, 372);
            this.LbItemList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список елементів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Загальна площа";
            // 
            // tbAllArea
            // 
            this.tbAllArea.Location = new System.Drawing.Point(601, 518);
            this.tbAllArea.Name = "tbAllArea";
            this.tbAllArea.ReadOnly = true;
            this.tbAllArea.Size = new System.Drawing.Size(288, 22);
            this.tbAllArea.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Місце для вводу";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 140);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(462, 372);
            this.pb1.TabIndex = 8;
            this.pb1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Намалювати";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(269, 89);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(99, 25);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Очистити";
            this.btClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 548);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAllArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbItemList);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.btEnter);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №5";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.ListBox LbItemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAllArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btClear;
    }
}

