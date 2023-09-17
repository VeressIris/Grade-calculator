namespace GradeCalcPlusWindows
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
            this.calculate_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentGrades_box = new System.Windows.Forms.TextBox();
            this.targetAverage_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.neededGrades_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate_bttn
            // 
            this.calculate_bttn.BackColor = System.Drawing.Color.SlateBlue;
            this.calculate_bttn.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_bttn.ForeColor = System.Drawing.Color.White;
            this.calculate_bttn.Location = new System.Drawing.Point(365, 284);
            this.calculate_bttn.Name = "calculate_bttn";
            this.calculate_bttn.Size = new System.Drawing.Size(137, 39);
            this.calculate_bttn.TabIndex = 1;
            this.calculate_bttn.Text = "Calculate";
            this.calculate_bttn.UseVisualStyleBackColor = false;
            this.calculate_bttn.Click += new System.EventHandler(this.calculate_bttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "What are your current grades?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "What\'s your target average?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentGrades_box
            // 
            this.currentGrades_box.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGrades_box.Location = new System.Drawing.Point(295, 139);
            this.currentGrades_box.Name = "currentGrades_box";
            this.currentGrades_box.Size = new System.Drawing.Size(295, 27);
            this.currentGrades_box.TabIndex = 4;
            this.currentGrades_box.TextChanged += new System.EventHandler(this.currentGrades_box_TextChanged);
            // 
            // targetAverage_box
            // 
            this.targetAverage_box.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetAverage_box.Location = new System.Drawing.Point(295, 225);
            this.targetAverage_box.Name = "targetAverage_box";
            this.targetAverage_box.Size = new System.Drawing.Size(295, 27);
            this.targetAverage_box.TabIndex = 5;
            this.targetAverage_box.TextChanged += new System.EventHandler(this.targetAverage_box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grades you need:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // neededGrades_lbl
            // 
            this.neededGrades_lbl.AutoSize = true;
            this.neededGrades_lbl.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neededGrades_lbl.Location = new System.Drawing.Point(387, 376);
            this.neededGrades_lbl.Name = "neededGrades_lbl";
            this.neededGrades_lbl.Size = new System.Drawing.Size(89, 20);
            this.neededGrades_lbl.TabIndex = 3;
            this.neededGrades_lbl.Text = "10 10 10";
            this.neededGrades_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.neededGrades_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 518);
            this.Controls.Add(this.targetAverage_box);
            this.Controls.Add(this.currentGrades_box);
            this.Controls.Add(this.neededGrades_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate_bttn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GradeCalc+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculate_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentGrades_box;
        private System.Windows.Forms.TextBox targetAverage_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label neededGrades_lbl;
    }
}

