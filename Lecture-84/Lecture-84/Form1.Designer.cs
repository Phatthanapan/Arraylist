namespace Lecture_84
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
            Add = new Button();
            remove = new Button();
            showall = new Button();
            namEtextBox = new TextBox();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Location = new Point(71, 295);
            Add.Name = "Add";
            Add.Size = new Size(155, 60);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // remove
            // 
            remove.Location = new Point(309, 295);
            remove.Name = "remove";
            remove.Size = new Size(155, 60);
            remove.TabIndex = 1;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // showall
            // 
            showall.Location = new Point(544, 295);
            showall.Name = "showall";
            showall.Size = new Size(155, 60);
            showall.TabIndex = 2;
            showall.Text = "Show all";
            showall.UseVisualStyleBackColor = true;
            showall.Click += showall_Click;
            // 
            // namEtextBox
            // 
            namEtextBox.Location = new Point(81, 113);
            namEtextBox.Name = "namEtextBox";
            namEtextBox.Size = new Size(507, 23);
            namEtextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(namEtextBox);
            Controls.Add(showall);
            Controls.Add(remove);
            Controls.Add(Add);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add;
        private Button remove;
        private Button showall;
        private TextBox namEtextBox;
    }
}
