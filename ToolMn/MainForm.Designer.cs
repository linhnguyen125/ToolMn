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
            SuspendLayout();
            // 
            // Test
            // 
            Test.Location = new Point(341, 222);
            Test.Name = "Test";
            Test.Size = new Size(75, 23);
            Test.TabIndex = 0;
            Test.Text = "Click me";
            Test.UseVisualStyleBackColor = true;
            Test.Click += this.Test_click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Test);
            Name = "MainForm";
            Text = "MainForm";
            Click += this.Test_click;
            ResumeLayout(false);
        }

        #endregion

        private Button Test;
    }
}
