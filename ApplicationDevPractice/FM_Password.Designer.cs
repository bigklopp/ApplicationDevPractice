
namespace ApplicationDevPractice
{
    partial class FM_Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrevPW = new System.Windows.Forms.TextBox();
            this.txtChgedPW = new System.Windows.Forms.TextBox();
            this.btnPWreg = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "이전 비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "변경할 비밀번호";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(190, 83);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(332, 27);
            this.txtID.TabIndex = 3;
            // 
            // txtPrevPW
            // 
            this.txtPrevPW.Location = new System.Drawing.Point(193, 149);
            this.txtPrevPW.Name = "txtPrevPW";
            this.txtPrevPW.Size = new System.Drawing.Size(329, 27);
            this.txtPrevPW.TabIndex = 4;
            // 
            // txtChgedPW
            // 
            this.txtChgedPW.Location = new System.Drawing.Point(193, 217);
            this.txtChgedPW.Name = "txtChgedPW";
            this.txtChgedPW.Size = new System.Drawing.Size(331, 27);
            this.txtChgedPW.TabIndex = 5;
            // 
            // btnPWreg
            // 
            this.btnPWreg.Location = new System.Drawing.Point(250, 273);
            this.btnPWreg.Name = "btnPWreg";
            this.btnPWreg.Size = new System.Drawing.Size(135, 66);
            this.btnPWreg.TabIndex = 6;
            this.btnPWreg.Text = "비밀번호 등록";
            this.btnPWreg.UseVisualStyleBackColor = true;
            this.btnPWreg.Click += new System.EventHandler(this.btnPWreg_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(391, 273);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 66);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FM_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 373);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPWreg);
            this.Controls.Add(this.txtChgedPW);
            this.Controls.Add(this.txtPrevPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FM_Password";
            this.Text = "FM_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPrevPW;
        private System.Windows.Forms.TextBox txtChgedPW;
        private System.Windows.Forms.Button btnPWreg;
        private System.Windows.Forms.Button btnClose;
    }
}