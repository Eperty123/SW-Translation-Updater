
namespace SWTranslationUpdater
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
            this.inputTransBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.targetTransTextBox = new System.Windows.Forms.TextBox();
            this.targetTransBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTransTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTransBtn
            // 
            this.inputTransBtn.Location = new System.Drawing.Point(257, 42);
            this.inputTransBtn.Name = "inputTransBtn";
            this.inputTransBtn.Size = new System.Drawing.Size(39, 23);
            this.inputTransBtn.TabIndex = 3;
            this.inputTransBtn.Text = "...";
            this.inputTransBtn.UseVisualStyleBackColor = true;
            this.inputTransBtn.Click += new System.EventHandler(this.inputTransBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.targetTransTextBox);
            this.groupBox1.Controls.Add(this.targetTransBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputTransTextBox);
            this.groupBox1.Controls.Add(this.inputTransBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translation Updater";
            // 
            // targetTransTextBox
            // 
            this.targetTransTextBox.Location = new System.Drawing.Point(9, 86);
            this.targetTransTextBox.Name = "targetTransTextBox";
            this.targetTransTextBox.Size = new System.Drawing.Size(242, 21);
            this.targetTransTextBox.TabIndex = 5;
            // 
            // targetTransBtn
            // 
            this.targetTransBtn.Location = new System.Drawing.Point(257, 84);
            this.targetTransBtn.Name = "targetTransBtn";
            this.targetTransBtn.Size = new System.Drawing.Size(39, 23);
            this.targetTransBtn.TabIndex = 6;
            this.targetTransBtn.Text = "...";
            this.targetTransBtn.UseVisualStyleBackColor = true;
            this.targetTransBtn.Click += new System.EventHandler(this.targetTransBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target Translation";
            // 
            // inputTransTextBox
            // 
            this.inputTransTextBox.Location = new System.Drawing.Point(9, 44);
            this.inputTransTextBox.Name = "inputTransTextBox";
            this.inputTransTextBox.Size = new System.Drawing.Size(242, 21);
            this.inputTransTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Translation";
            // 
            // ImportBtn
            // 
            this.ImportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportBtn.Location = new System.Drawing.Point(233, 144);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(75, 23);
            this.ImportBtn.TabIndex = 8;
            this.ImportBtn.Text = "Update";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "By: Eperty123";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SW  Translation Updater";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputTransBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTransTextBox;
        private System.Windows.Forms.TextBox targetTransTextBox;
        private System.Windows.Forms.Button targetTransBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Label label3;
    }
}

