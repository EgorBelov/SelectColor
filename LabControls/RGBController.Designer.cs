
namespace LabControls
{
    partial class RGBController
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonDec = new System.Windows.Forms.RadioButton();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.txtBlue = new LabControls.NumberBox(this.components);
            this.txtGreen = new LabControls.NumberBox(this.components);
            this.txtRed = new LabControls.NumberBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зеленый:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Синий:";
            // 
            // radioButtonDec
            // 
            this.radioButtonDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonDec.AutoSize = true;
            this.radioButtonDec.Location = new System.Drawing.Point(7, 136);
            this.radioButtonDec.Name = "radioButtonDec";
            this.radioButtonDec.Size = new System.Drawing.Size(45, 17);
            this.radioButtonDec.TabIndex = 3;
            this.radioButtonDec.TabStop = true;
            this.radioButtonDec.Text = "Dec";
            this.radioButtonDec.UseVisualStyleBackColor = true;
            this.radioButtonDec.CheckedChanged += new System.EventHandler(this.radioButtonDec_CheckedChanged);
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Location = new System.Drawing.Point(78, 136);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(44, 17);
            this.radioButtonHex.TabIndex = 4;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // colorBox
            // 
            this.colorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.Location = new System.Drawing.Point(159, 0);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(162, 161);
            this.colorBox.TabIndex = 8;
            this.colorBox.TabStop = false;
            // 
            // txtBlue
            // 
            this.txtBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBlue.ForeColor = System.Drawing.Color.Black;
            this.txtBlue.IsDec = false;
            this.txtBlue.IsHex = false;
            this.txtBlue.Location = new System.Drawing.Point(61, 94);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(61, 20);
            this.txtBlue.TabIndex = 7;
            this.txtBlue.Text = "0";
            this.txtBlue.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // txtGreen
            // 
            this.txtGreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGreen.ForeColor = System.Drawing.Color.Black;
            this.txtGreen.IsDec = false;
            this.txtGreen.IsHex = false;
            this.txtGreen.Location = new System.Drawing.Point(61, 50);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(61, 20);
            this.txtGreen.TabIndex = 6;
            this.txtGreen.Text = "0";
            this.txtGreen.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // txtRed
            // 
            this.txtRed.ForeColor = System.Drawing.Color.Black;
            this.txtRed.IsDec = false;
            this.txtRed.IsHex = false;
            this.txtRed.Location = new System.Drawing.Point(61, 2);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(61, 20);
            this.txtRed.TabIndex = 5;
            this.txtRed.Text = "0";
            this.txtRed.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // RGBController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.radioButtonHex);
            this.Controls.Add(this.radioButtonDec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RGBController";
            this.Size = new System.Drawing.Size(321, 161);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonDec;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private NumberBox txtRed;
        private NumberBox txtGreen;
        private NumberBox txtBlue;
        private System.Windows.Forms.PictureBox colorBox;
    }
}
