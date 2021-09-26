
namespace Week5Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.speedInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.limitInput = new System.Windows.Forms.TextBox();
            this.resultOutput = new System.Windows.Forms.Label();
            this.penaltyOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 128);
            this.button1.TabIndex = 0;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Speed (MPH) :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // speedInput
            // 
            this.speedInput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.speedInput.Location = new System.Drawing.Point(452, 44);
            this.speedInput.Name = "speedInput";
            this.speedInput.Size = new System.Drawing.Size(126, 50);
            this.speedInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed Limit (MPH) :";
            // 
            // limitInput
            // 
            this.limitInput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.limitInput.Location = new System.Drawing.Point(452, 123);
            this.limitInput.Name = "limitInput";
            this.limitInput.Size = new System.Drawing.Size(126, 50);
            this.limitInput.TabIndex = 4;
            // 
            // resultOutput
            // 
            this.resultOutput.AutoSize = true;
            this.resultOutput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultOutput.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.resultOutput.Location = new System.Drawing.Point(138, 375);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(0, 30);
            this.resultOutput.TabIndex = 5;
            this.resultOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // penaltyOutput
            // 
            this.penaltyOutput.AutoSize = true;
            this.penaltyOutput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.penaltyOutput.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.penaltyOutput.Location = new System.Drawing.Point(517, 375);
            this.penaltyOutput.Name = "penaltyOutput";
            this.penaltyOutput.Size = new System.Drawing.Size(0, 30);
            this.penaltyOutput.TabIndex = 6;
            this.penaltyOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.penaltyOutput);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.limitInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Speed Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox speedInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox limitInput;
        private System.Windows.Forms.Label resultOutput;
        private System.Windows.Forms.Label penaltyOutput;
    }
}

