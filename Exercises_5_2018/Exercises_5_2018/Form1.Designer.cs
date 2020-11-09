namespace Exercises_5_2018
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
            this.listBoxExerciseResults = new System.Windows.Forms.ListBox();
            this.buttonExerciseResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxExerciseResults
            // 
            this.listBoxExerciseResults.FormattingEnabled = true;
            this.listBoxExerciseResults.ItemHeight = 20;
            this.listBoxExerciseResults.Location = new System.Drawing.Point(121, 72);
            this.listBoxExerciseResults.Name = "listBoxExerciseResults";
            this.listBoxExerciseResults.Size = new System.Drawing.Size(571, 344);
            this.listBoxExerciseResults.TabIndex = 0;
            // 
            // buttonExerciseResults
            // 
            this.buttonExerciseResults.Location = new System.Drawing.Point(301, 452);
            this.buttonExerciseResults.Name = "buttonExerciseResults";
            this.buttonExerciseResults.Size = new System.Drawing.Size(116, 33);
            this.buttonExerciseResults.TabIndex = 1;
            this.buttonExerciseResults.Text = "ExerciseResults";
            this.buttonExerciseResults.UseVisualStyleBackColor = true;
            this.buttonExerciseResults.Click += new System.EventHandler(this.buttonExerciseResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 525);
            this.Controls.Add(this.buttonExerciseResults);
            this.Controls.Add(this.listBoxExerciseResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExerciseResults;
        private System.Windows.Forms.Button buttonExerciseResults;
    }
}

