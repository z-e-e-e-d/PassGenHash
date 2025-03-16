namespace passwordGenerater
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
            this.inputTxb = new System.Windows.Forms.TextBox();
            this.secondInputTxb = new System.Windows.Forms.TextBox();
            this.passwordTxb = new System.Windows.Forms.TextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.lengthTxb = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hidePanel = new System.Windows.Forms.Panel();
            this.hidePnlBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTxb
            // 
            this.inputTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTxb.Location = new System.Drawing.Point(22, 49);
            this.inputTxb.Name = "inputTxb";
            this.inputTxb.Size = new System.Drawing.Size(269, 31);
            this.inputTxb.TabIndex = 0;
            this.inputTxb.TextChanged += new System.EventHandler(this.inputTxb_TextChanged);
            // 
            // secondInputTxb
            // 
            this.secondInputTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondInputTxb.Location = new System.Drawing.Point(314, 49);
            this.secondInputTxb.Name = "secondInputTxb";
            this.secondInputTxb.Size = new System.Drawing.Size(102, 31);
            this.secondInputTxb.TabIndex = 1;
            this.secondInputTxb.TextChanged += new System.EventHandler(this.secondInputTxb_TextChanged);
            // 
            // passwordTxb
            // 
            this.passwordTxb.Location = new System.Drawing.Point(114, 115);
            this.passwordTxb.Name = "passwordTxb";
            this.passwordTxb.Size = new System.Drawing.Size(362, 20);
            this.passwordTxb.TabIndex = 2;
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Location = new System.Drawing.Point(22, 114);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 4;
            this.copyBtn.Text = "copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // lengthTxb
            // 
            this.lengthTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTxb.Location = new System.Drawing.Point(441, 49);
            this.lengthTxb.Name = "lengthTxb";
            this.lengthTxb.Size = new System.Drawing.Size(74, 31);
            this.lengthTxb.TabIndex = 5;
            this.lengthTxb.TextChanged += new System.EventHandler(this.lengthTxb_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(525, -1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(22, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hidePanel
            // 
            this.hidePanel.BackColor = System.Drawing.Color.White;
            this.hidePanel.Location = new System.Drawing.Point(114, 115);
            this.hidePanel.Name = "hidePanel";
            this.hidePanel.Size = new System.Drawing.Size(362, 20);
            this.hidePanel.TabIndex = 7;
            // 
            // hidePnlBtn
            // 
            this.hidePnlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidePnlBtn.Location = new System.Drawing.Point(493, 113);
            this.hidePnlBtn.Name = "hidePnlBtn";
            this.hidePnlBtn.Size = new System.Drawing.Size(22, 23);
            this.hidePnlBtn.TabIndex = 8;
            this.hidePnlBtn.Text = "/";
            this.hidePnlBtn.UseVisualStyleBackColor = true;
            this.hidePnlBtn.Click += new System.EventHandler(this.hidePnlBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Platform";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Random";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(436, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Length";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(547, 180);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hidePnlBtn);
            this.Controls.Add(this.hidePanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lengthTxb);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.passwordTxb);
            this.Controls.Add(this.secondInputTxb);
            this.Controls.Add(this.inputTxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTxb;
        private System.Windows.Forms.TextBox secondInputTxb;
        private System.Windows.Forms.TextBox passwordTxb;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.TextBox lengthTxb;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel hidePanel;
        private System.Windows.Forms.Button hidePnlBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

