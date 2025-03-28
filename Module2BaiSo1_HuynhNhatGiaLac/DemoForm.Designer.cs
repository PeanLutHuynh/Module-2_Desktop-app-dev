namespace Module2BaiSo1_HuynhNhatGiaLac
{
    partial class DemoForm
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
            clickme = new Button();
            SuspendLayout();
            // 
            // clickme
            // 
            clickme.Location = new Point(192, 127);
            clickme.Name = "clickme";
            clickme.Size = new Size(400, 178);
            clickme.TabIndex = 0;
            clickme.Text = "Click Me";
            clickme.UseVisualStyleBackColor = true;
            clickme.Click += clickme_Click;
            // 
            // DemoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clickme);
            Name = "DemoForm";
            Text = "Form1";
            Load += FormLoad;
            Click += ClickForm;
            ResumeLayout(false);
        }

        #endregion

        private Button clickme;
    }
}
