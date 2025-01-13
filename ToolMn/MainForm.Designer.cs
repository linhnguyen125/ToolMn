namespace ToolMn
{
    partial class MainForm
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
            Test = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Test
            // 
            Test.Location = new Point(12, 12);
            Test.Name = "Test";
            Test.Size = new Size(75, 23);
            Test.TabIndex = 0;
            Test.Text = "Lunch";
            Test.UseVisualStyleBackColor = true;
            Test.Click += Test_click;
            // 
            // button1
            // 
            button1.Location = new Point(93, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Resize";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 94);
            Controls.Add(button1);
            Controls.Add(Test);
            Name = "MainForm";
            Text = "MainForm";
            Click += Test_click;
            ResumeLayout(false);
        }

        #endregion

        private Button Test;
        private Button button1;
    }
}
