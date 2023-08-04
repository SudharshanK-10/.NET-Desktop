namespace CalculatorWindowsForms
{
    partial class Calculator
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
			this.LblNo1 = new System.Windows.Forms.Label();
			this.TxtNo1 = new System.Windows.Forms.TextBox();
			this.LblNo2 = new System.Windows.Forms.Label();
			this.TxtNo2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnSub = new System.Windows.Forms.Button();
			this.BtnMul = new System.Windows.Forms.Button();
			this.BtnDiv = new System.Windows.Forms.Button();
			this.LblResult = new System.Windows.Forms.Label();
			this.TxtResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// LblNo1
			// 
			this.LblNo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.LblNo1.AutoSize = true;
			this.LblNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNo1.Location = new System.Drawing.Point(90, 64);
			this.LblNo1.Name = "LblNo1";
			this.LblNo1.Size = new System.Drawing.Size(119, 29);
			this.LblNo1.TabIndex = 0;
			this.LblNo1.Text = "Number 1";
			// 
			// TxtNo1
			// 
			this.TxtNo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNo1.Location = new System.Drawing.Point(251, 63);
			this.TxtNo1.Name = "TxtNo1";
			this.TxtNo1.Size = new System.Drawing.Size(382, 34);
			this.TxtNo1.TabIndex = 1;
			// 
			// LblNo2
			// 
			this.LblNo2.AutoSize = true;
			this.LblNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNo2.Location = new System.Drawing.Point(90, 132);
			this.LblNo2.Name = "LblNo2";
			this.LblNo2.Size = new System.Drawing.Size(119, 29);
			this.LblNo2.TabIndex = 2;
			this.LblNo2.Text = "Number 2";
			// 
			// TxtNo2
			// 
			this.TxtNo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNo2.Location = new System.Drawing.Point(251, 129);
			this.TxtNo2.Name = "TxtNo2";
			this.TxtNo2.Size = new System.Drawing.Size(382, 34);
			this.TxtNo2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(90, 205);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 29);
			this.label1.TabIndex = 4;
			this.label1.Text = "Operations";
			// 
			// BtnAdd
			// 
			this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAdd.Location = new System.Drawing.Point(251, 205);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(75, 32);
			this.BtnAdd.TabIndex = 5;
			this.BtnAdd.Text = "+";
			this.BtnAdd.UseVisualStyleBackColor = true;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnSub
			// 
			this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSub.Location = new System.Drawing.Point(343, 205);
			this.BtnSub.Name = "BtnSub";
			this.BtnSub.Size = new System.Drawing.Size(75, 32);
			this.BtnSub.TabIndex = 6;
			this.BtnSub.Text = "-";
			this.BtnSub.UseVisualStyleBackColor = true;
			this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
			// 
			// BtnMul
			// 
			this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnMul.Location = new System.Drawing.Point(437, 205);
			this.BtnMul.Name = "BtnMul";
			this.BtnMul.Size = new System.Drawing.Size(75, 32);
			this.BtnMul.TabIndex = 7;
			this.BtnMul.Text = "x";
			this.BtnMul.UseVisualStyleBackColor = true;
			this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
			// 
			// BtnDiv
			// 
			this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnDiv.Location = new System.Drawing.Point(528, 206);
			this.BtnDiv.Name = "BtnDiv";
			this.BtnDiv.Size = new System.Drawing.Size(75, 32);
			this.BtnDiv.TabIndex = 8;
			this.BtnDiv.Text = "/";
			this.BtnDiv.UseVisualStyleBackColor = true;
			this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
			// 
			// LblResult
			// 
			this.LblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblResult.AutoSize = true;
			this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblResult.Location = new System.Drawing.Point(105, 273);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(81, 29);
			this.LblResult.TabIndex = 9;
			this.LblResult.Text = "Result";
			// 
			// TxtResult
			// 
			this.TxtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtResult.Location = new System.Drawing.Point(251, 269);
			this.TxtResult.Name = "TxtResult";
			this.TxtResult.Size = new System.Drawing.Size(382, 34);
			this.TxtResult.TabIndex = 10;
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 453);
			this.Controls.Add(this.TxtResult);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.BtnDiv);
			this.Controls.Add(this.BtnMul);
			this.Controls.Add(this.BtnSub);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtNo2);
			this.Controls.Add(this.LblNo2);
			this.Controls.Add(this.TxtNo1);
			this.Controls.Add(this.LblNo1);
			this.Name = "Calculator";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNo1;
        private System.Windows.Forms.TextBox TxtNo1;
        private System.Windows.Forms.Label LblNo2;
        private System.Windows.Forms.TextBox TxtNo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtResult;
    }
}