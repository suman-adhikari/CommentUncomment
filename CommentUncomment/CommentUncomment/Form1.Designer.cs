namespace CommentUncomment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnUncomment = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbUncomment = new System.Windows.Forms.RichTextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblMsg.Location = new System.Drawing.Point(7, 467);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(32, 18);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "___";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(12, 42);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(635, 158);
            this.tbComment.TabIndex = 4;
            this.tbComment.Text = "";
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(12, 206);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(157, 37);
            this.btnComment.TabIndex = 6;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnUncomment
            // 
            this.btnUncomment.Location = new System.Drawing.Point(12, 413);
            this.btnUncomment.Name = "btnUncomment";
            this.btnUncomment.Size = new System.Drawing.Size(137, 37);
            this.btnUncomment.TabIndex = 7;
            this.btnUncomment.Text = "Uncomment";
            this.btnUncomment.UseVisualStyleBackColor = true;
            this.btnUncomment.Click += new System.EventHandler(this.btnUncomment_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(44, 13);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(603, 20);
            this.tbPath.TabIndex = 8;
            // 
            // tbUncomment
            // 
            this.tbUncomment.Location = new System.Drawing.Point(12, 249);
            this.tbUncomment.Name = "tbUncomment";
            this.tbUncomment.Size = new System.Drawing.Size(635, 158);
            this.tbUncomment.TabIndex = 9;
            this.tbUncomment.Text = "";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(175, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 37);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(485, 206);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(162, 37);
            this.btnSwap.TabIndex = 11;
            this.btnSwap.Text = "SWAP";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 553);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbUncomment);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnUncomment);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnUncomment;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.RichTextBox tbUncomment;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSwap;
    }
}

