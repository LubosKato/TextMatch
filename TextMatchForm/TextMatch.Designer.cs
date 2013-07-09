namespace TextMatchForm
{
    partial class TextMatch
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
            this.components = new System.ComponentModel.Container();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubText = new System.Windows.Forms.TextBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.btnFindMatches = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 158);
            this.lblResult.MaximumSize = new System.Drawing.Size(380, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "SubText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Text";
            // 
            // txtSubText
            // 
            this.txtSubText.Location = new System.Drawing.Point(12, 77);
            this.txtSubText.Name = "txtSubText";
            this.txtSubText.Size = new System.Drawing.Size(355, 22);
            this.txtSubText.TabIndex = 9;
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(12, 31);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(355, 22);
            this.txtMain.TabIndex = 8;
            // 
            // btnFindMatches
            // 
            this.btnFindMatches.Location = new System.Drawing.Point(235, 114);
            this.btnFindMatches.Name = "btnFindMatches";
            this.btnFindMatches.Size = new System.Drawing.Size(132, 34);
            this.btnFindMatches.TabIndex = 7;
            this.btnFindMatches.Text = "Find Matches";
            this.btnFindMatches.UseVisualStyleBackColor = true;
            this.btnFindMatches.Click += new System.EventHandler(this.btnFindMatches_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TextMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 189);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubText);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnFindMatches);
            this.Name = "TextMatch";
            this.Text = "TextMatch";
            this.Load += new System.EventHandler(this.TextMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubText;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Button btnFindMatches;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

