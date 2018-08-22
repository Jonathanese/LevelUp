namespace _6.Calculator
{
    partial class FormMain
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
            this.tbMain = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.lOperator = new System.Windows.Forms.Label();
            this.bSeven = new System.Windows.Forms.Button();
            this.bEight = new System.Windows.Forms.Button();
            this.bNine = new System.Windows.Forms.Button();
            this.bFour = new System.Windows.Forms.Button();
            this.bFive = new System.Windows.Forms.Button();
            this.bSix = new System.Windows.Forms.Button();
            this.bOne = new System.Windows.Forms.Button();
            this.bTwo = new System.Windows.Forms.Button();
            this.bThree = new System.Windows.Forms.Button();
            this.mMPlus = new System.Windows.Forms.Button();
            this.bMMinus = new System.Windows.Forms.Button();
            this.bMR = new System.Windows.Forms.Button();
            this.bMC = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bZero = new System.Windows.Forms.Button();
            this.bRadix = new System.Windows.Forms.Button();
            this.bEquals = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bTimes = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.lMemVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(52, 34);
            this.tbMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(195, 22);
            this.tbMain.TabIndex = 0;
            this.tbMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueEnterEvent);
            // 
            // lResult
            // 
            this.lResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lResult.Location = new System.Drawing.Point(15, 9);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(235, 23);
            this.lResult.TabIndex = 1;
            this.lResult.Text = "__";
            this.lResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lOperator
            // 
            this.lOperator.Location = new System.Drawing.Point(13, 34);
            this.lOperator.Name = "lOperator";
            this.lOperator.Size = new System.Drawing.Size(33, 23);
            this.lOperator.TabIndex = 2;
            this.lOperator.Text = "__";
            this.lOperator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bSeven
            // 
            this.bSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeven.Location = new System.Drawing.Point(13, 185);
            this.bSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSeven.Name = "bSeven";
            this.bSeven.Size = new System.Drawing.Size(53, 46);
            this.bSeven.TabIndex = 3;
            this.bSeven.Text = "7";
            this.bSeven.UseVisualStyleBackColor = true;
            this.bSeven.Click += new System.EventHandler(this.bSeven_Click);
            // 
            // bEight
            // 
            this.bEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEight.Location = new System.Drawing.Point(73, 185);
            this.bEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEight.Name = "bEight";
            this.bEight.Size = new System.Drawing.Size(53, 46);
            this.bEight.TabIndex = 4;
            this.bEight.Text = "8";
            this.bEight.UseVisualStyleBackColor = true;
            this.bEight.Click += new System.EventHandler(this.bEight_Click);
            // 
            // bNine
            // 
            this.bNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNine.Location = new System.Drawing.Point(133, 185);
            this.bNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bNine.Name = "bNine";
            this.bNine.Size = new System.Drawing.Size(53, 46);
            this.bNine.TabIndex = 5;
            this.bNine.Text = "9";
            this.bNine.UseVisualStyleBackColor = true;
            this.bNine.Click += new System.EventHandler(this.bNine_Click);
            // 
            // bFour
            // 
            this.bFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFour.Location = new System.Drawing.Point(13, 236);
            this.bFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bFour.Name = "bFour";
            this.bFour.Size = new System.Drawing.Size(53, 46);
            this.bFour.TabIndex = 6;
            this.bFour.Text = "4";
            this.bFour.UseVisualStyleBackColor = true;
            this.bFour.Click += new System.EventHandler(this.bFour_Click);
            // 
            // bFive
            // 
            this.bFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFive.Location = new System.Drawing.Point(73, 236);
            this.bFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bFive.Name = "bFive";
            this.bFive.Size = new System.Drawing.Size(53, 46);
            this.bFive.TabIndex = 7;
            this.bFive.Text = "5";
            this.bFive.UseVisualStyleBackColor = true;
            this.bFive.Click += new System.EventHandler(this.bFive_Click);
            // 
            // bSix
            // 
            this.bSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSix.Location = new System.Drawing.Point(133, 236);
            this.bSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSix.Name = "bSix";
            this.bSix.Size = new System.Drawing.Size(53, 46);
            this.bSix.TabIndex = 8;
            this.bSix.Text = "6";
            this.bSix.UseVisualStyleBackColor = true;
            this.bSix.Click += new System.EventHandler(this.bSix_Click);
            // 
            // bOne
            // 
            this.bOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOne.Location = new System.Drawing.Point(13, 287);
            this.bOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bOne.Name = "bOne";
            this.bOne.Size = new System.Drawing.Size(53, 46);
            this.bOne.TabIndex = 9;
            this.bOne.Text = "1";
            this.bOne.UseVisualStyleBackColor = true;
            this.bOne.Click += new System.EventHandler(this.bOne_Click);
            // 
            // bTwo
            // 
            this.bTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTwo.Location = new System.Drawing.Point(73, 287);
            this.bTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bTwo.Name = "bTwo";
            this.bTwo.Size = new System.Drawing.Size(53, 46);
            this.bTwo.TabIndex = 10;
            this.bTwo.Text = "2";
            this.bTwo.UseVisualStyleBackColor = true;
            this.bTwo.Click += new System.EventHandler(this.bTwo_Click);
            // 
            // bThree
            // 
            this.bThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThree.Location = new System.Drawing.Point(133, 287);
            this.bThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bThree.Name = "bThree";
            this.bThree.Size = new System.Drawing.Size(53, 46);
            this.bThree.TabIndex = 11;
            this.bThree.Text = "3";
            this.bThree.UseVisualStyleBackColor = true;
            this.bThree.Click += new System.EventHandler(this.bThree_Click);
            // 
            // mMPlus
            // 
            this.mMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMPlus.Location = new System.Drawing.Point(13, 60);
            this.mMPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mMPlus.Name = "mMPlus";
            this.mMPlus.Size = new System.Drawing.Size(53, 46);
            this.mMPlus.TabIndex = 12;
            this.mMPlus.Text = "M+";
            this.mMPlus.UseVisualStyleBackColor = true;
            this.mMPlus.Click += new System.EventHandler(this.mMPlus_Click);
            // 
            // bMMinus
            // 
            this.bMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMMinus.Location = new System.Drawing.Point(73, 60);
            this.bMMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bMMinus.Name = "bMMinus";
            this.bMMinus.Size = new System.Drawing.Size(53, 46);
            this.bMMinus.TabIndex = 13;
            this.bMMinus.Text = "M-";
            this.bMMinus.UseVisualStyleBackColor = true;
            this.bMMinus.Click += new System.EventHandler(this.bMMinus_Click);
            // 
            // bMR
            // 
            this.bMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMR.Location = new System.Drawing.Point(133, 60);
            this.bMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bMR.Name = "bMR";
            this.bMR.Size = new System.Drawing.Size(53, 46);
            this.bMR.TabIndex = 14;
            this.bMR.Text = "MR";
            this.bMR.UseVisualStyleBackColor = true;
            this.bMR.Click += new System.EventHandler(this.bMR_Click);
            // 
            // bMC
            // 
            this.bMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMC.Location = new System.Drawing.Point(193, 60);
            this.bMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bMC.Name = "bMC";
            this.bMC.Size = new System.Drawing.Size(53, 46);
            this.bMC.TabIndex = 15;
            this.bMC.Text = "MC";
            this.bMC.UseVisualStyleBackColor = true;
            this.bMC.Click += new System.EventHandler(this.bMC_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(193, 185);
            this.bClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(53, 97);
            this.bClear.TabIndex = 16;
            this.bClear.Text = "CLR";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bZero
            // 
            this.bZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZero.Location = new System.Drawing.Point(13, 337);
            this.bZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bZero.Name = "bZero";
            this.bZero.Size = new System.Drawing.Size(115, 46);
            this.bZero.TabIndex = 17;
            this.bZero.Text = "0";
            this.bZero.UseVisualStyleBackColor = true;
            this.bZero.Click += new System.EventHandler(this.bZero_Click);
            // 
            // bRadix
            // 
            this.bRadix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRadix.Location = new System.Drawing.Point(133, 337);
            this.bRadix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRadix.Name = "bRadix";
            this.bRadix.Size = new System.Drawing.Size(53, 46);
            this.bRadix.TabIndex = 18;
            this.bRadix.Text = ".";
            this.bRadix.UseVisualStyleBackColor = true;
            this.bRadix.Click += new System.EventHandler(this.bRadix_Click);
            // 
            // bEquals
            // 
            this.bEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEquals.Location = new System.Drawing.Point(193, 287);
            this.bEquals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEquals.Name = "bEquals";
            this.bEquals.Size = new System.Drawing.Size(53, 96);
            this.bEquals.TabIndex = 20;
            this.bEquals.Text = "=";
            this.bEquals.UseVisualStyleBackColor = true;
            this.bEquals.Click += new System.EventHandler(this.bEquals_Click);
            // 
            // bMinus
            // 
            this.bMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMinus.Location = new System.Drawing.Point(73, 134);
            this.bMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(53, 46);
            this.bMinus.TabIndex = 21;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlus.Location = new System.Drawing.Point(13, 134);
            this.bPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(53, 46);
            this.bPlus.TabIndex = 22;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bTimes
            // 
            this.bTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTimes.Location = new System.Drawing.Point(133, 134);
            this.bTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bTimes.Name = "bTimes";
            this.bTimes.Size = new System.Drawing.Size(53, 46);
            this.bTimes.TabIndex = 23;
            this.bTimes.Text = "×";
            this.bTimes.UseVisualStyleBackColor = true;
            this.bTimes.Click += new System.EventHandler(this.bTimes_Click);
            // 
            // bDivide
            // 
            this.bDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDivide.Location = new System.Drawing.Point(193, 134);
            this.bDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(53, 46);
            this.bDivide.TabIndex = 24;
            this.bDivide.Text = "÷";
            this.bDivide.UseVisualStyleBackColor = true;
            this.bDivide.Click += new System.EventHandler(this.bDivide_Click);
            // 
            // lMemVal
            // 
            this.lMemVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lMemVal.Location = new System.Drawing.Point(73, 108);
            this.lMemVal.Name = "lMemVal";
            this.lMemVal.Size = new System.Drawing.Size(175, 23);
            this.lMemVal.TabIndex = 25;
            this.lMemVal.Text = "0";
            this.lMemVal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(263, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lMemVal);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.bTimes);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bEquals);
            this.Controls.Add(this.bRadix);
            this.Controls.Add(this.bZero);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bMC);
            this.Controls.Add(this.bMR);
            this.Controls.Add(this.bMMinus);
            this.Controls.Add(this.mMPlus);
            this.Controls.Add(this.bThree);
            this.Controls.Add(this.bTwo);
            this.Controls.Add(this.bOne);
            this.Controls.Add(this.bSix);
            this.Controls.Add(this.bFive);
            this.Controls.Add(this.bFour);
            this.Controls.Add(this.bNine);
            this.Controls.Add(this.bEight);
            this.Controls.Add(this.bSeven);
            this.Controls.Add(this.lOperator);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Basic Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lOperator;
        private System.Windows.Forms.Button bSeven;
        private System.Windows.Forms.Button bEight;
        private System.Windows.Forms.Button bNine;
        private System.Windows.Forms.Button bFour;
        private System.Windows.Forms.Button bFive;
        private System.Windows.Forms.Button bSix;
        private System.Windows.Forms.Button bOne;
        private System.Windows.Forms.Button bTwo;
        private System.Windows.Forms.Button bThree;
        private System.Windows.Forms.Button mMPlus;
        private System.Windows.Forms.Button bMMinus;
        private System.Windows.Forms.Button bMR;
        private System.Windows.Forms.Button bMC;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bZero;
        private System.Windows.Forms.Button bRadix;
        private System.Windows.Forms.Button bEquals;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bTimes;
        private System.Windows.Forms.Button bDivide;
        private System.Windows.Forms.Label lMemVal;
        private System.Windows.Forms.Label label2;
    }
}

