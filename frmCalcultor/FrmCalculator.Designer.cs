namespace frmCalcultor
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.txt_display = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_sign = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_reciprocal = new System.Windows.Forms.Button();
            this.btn_equalto = new System.Windows.Forms.Button();
            this.btn_Mc = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.btn_Ms = new System.Windows.Forms.Button();
            this.btn_MPlus = new System.Windows.Forms.Button();
            this.lbl_MemVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_display
            // 
            this.txt_display.Location = new System.Drawing.Point(12, 23);
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(239, 20);
            this.txt_display.TabIndex = 22;
            this.txt_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_display.TextChanged += new System.EventHandler(this.txt_display_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(62, 67);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 31);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "&Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_clear.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Location = new System.Drawing.Point(143, 67);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 31);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "&Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(52, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(52, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(52, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(52, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(93, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 7;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(93, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 8;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(93, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Enter_Value);
            // 
            // btn_sign
            // 
            this.btn_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign.ForeColor = System.Drawing.Color.Blue;
            this.btn_sign.Location = new System.Drawing.Point(93, 227);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(35, 35);
            this.btn_sign.TabIndex = 10;
            this.btn_sign.Text = "+/-";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Blue;
            this.button10.Location = new System.Drawing.Point(134, 104);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 35);
            this.button10.TabIndex = 11;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Blue;
            this.button11.Location = new System.Drawing.Point(134, 145);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 35);
            this.button11.TabIndex = 12;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Blue;
            this.button12.Location = new System.Drawing.Point(134, 186);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 35);
            this.button12.TabIndex = 13;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Blue;
            this.button13.Location = new System.Drawing.Point(134, 227);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 35);
            this.button13.TabIndex = 14;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(175, 104);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 35);
            this.button14.TabIndex = 15;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Red;
            this.button15.Location = new System.Drawing.Point(175, 145);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 35);
            this.button15.TabIndex = 16;
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Red;
            this.button16.Location = new System.Drawing.Point(175, 186);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 35);
            this.button16.TabIndex = 17;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Enter_Value);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Red;
            this.button17.Location = new System.Drawing.Point(175, 227);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(35, 35);
            this.button17.TabIndex = 18;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Enter_Value);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqrt.ForeColor = System.Drawing.Color.Blue;
            this.btn_sqrt.Location = new System.Drawing.Point(216, 104);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(35, 35);
            this.btn_sqrt.TabIndex = 19;
            this.btn_sqrt.Text = "sqrt";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_reciprocal
            // 
            this.btn_reciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reciprocal.ForeColor = System.Drawing.Color.Blue;
            this.btn_reciprocal.Location = new System.Drawing.Point(216, 145);
            this.btn_reciprocal.Name = "btn_reciprocal";
            this.btn_reciprocal.Size = new System.Drawing.Size(35, 35);
            this.btn_reciprocal.TabIndex = 20;
            this.btn_reciprocal.Text = "1/x";
            this.btn_reciprocal.UseVisualStyleBackColor = true;
            this.btn_reciprocal.Click += new System.EventHandler(this.btn_reciprocal_Click);
            // 
            // btn_equalto
            // 
            this.btn_equalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equalto.ForeColor = System.Drawing.Color.Red;
            this.btn_equalto.Location = new System.Drawing.Point(216, 186);
            this.btn_equalto.Name = "btn_equalto";
            this.btn_equalto.Size = new System.Drawing.Size(35, 76);
            this.btn_equalto.TabIndex = 21;
            this.btn_equalto.Text = "=";
            this.btn_equalto.UseVisualStyleBackColor = true;
            this.btn_equalto.Click += new System.EventHandler(this.btn_equalto_Click);
            // 
            // btn_Mc
            // 
            this.btn_Mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mc.ForeColor = System.Drawing.Color.Red;
            this.btn_Mc.Location = new System.Drawing.Point(11, 104);
            this.btn_Mc.Name = "btn_Mc";
            this.btn_Mc.Size = new System.Drawing.Size(35, 35);
            this.btn_Mc.TabIndex = 23;
            this.btn_Mc.Text = "MC";
            this.btn_Mc.UseVisualStyleBackColor = true;
            this.btn_Mc.Click += new System.EventHandler(this.Enter_Value);
            // 
            // btn_MR
            // 
            this.btn_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MR.ForeColor = System.Drawing.Color.Red;
            this.btn_MR.Location = new System.Drawing.Point(11, 145);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(35, 35);
            this.btn_MR.TabIndex = 24;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = true;
            this.btn_MR.Click += new System.EventHandler(this.Enter_Value);
            // 
            // btn_Ms
            // 
            this.btn_Ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ms.ForeColor = System.Drawing.Color.Red;
            this.btn_Ms.Location = new System.Drawing.Point(11, 186);
            this.btn_Ms.Name = "btn_Ms";
            this.btn_Ms.Size = new System.Drawing.Size(35, 35);
            this.btn_Ms.TabIndex = 25;
            this.btn_Ms.Text = "MS";
            this.btn_Ms.UseVisualStyleBackColor = true;
            this.btn_Ms.Click += new System.EventHandler(this.Enter_Value);
            // 
            // btn_MPlus
            // 
            this.btn_MPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MPlus.ForeColor = System.Drawing.Color.Red;
            this.btn_MPlus.Location = new System.Drawing.Point(11, 227);
            this.btn_MPlus.Name = "btn_MPlus";
            this.btn_MPlus.Size = new System.Drawing.Size(35, 35);
            this.btn_MPlus.TabIndex = 26;
            this.btn_MPlus.Text = "M+";
            this.btn_MPlus.UseVisualStyleBackColor = true;
            this.btn_MPlus.Click += new System.EventHandler(this.Enter_Value);
            // 
            // lbl_MemVal
            // 
            this.lbl_MemVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MemVal.Location = new System.Drawing.Point(12, 67);
            this.lbl_MemVal.Name = "lbl_MemVal";
            this.lbl_MemVal.Size = new System.Drawing.Size(35, 31);
            this.lbl_MemVal.TabIndex = 27;
            // 
            // FrmCalculator
            // 
            this.AcceptButton = this.btn_equalto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(264, 274);
            this.Controls.Add(this.lbl_MemVal);
            this.Controls.Add(this.btn_MPlus);
            this.Controls.Add(this.btn_Ms);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_Mc);
            this.Controls.Add(this.btn_equalto);
            this.Controls.Add(this.btn_reciprocal);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_reciprocal;
        private System.Windows.Forms.Button btn_equalto;
        private System.Windows.Forms.Button btn_Mc;
        private System.Windows.Forms.Button btn_MR;
        private System.Windows.Forms.Button btn_Ms;
        private System.Windows.Forms.Button btn_MPlus;
        private System.Windows.Forms.Label lbl_MemVal;
    }
}

