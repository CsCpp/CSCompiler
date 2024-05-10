namespace CSCompiler
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
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            frameworkTBox = new TextBox();
            codBox = new RichTextBox();
            statusBox = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Выходной файл:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 29);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Framework:";
            label2.Click += label2_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(138, 25);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(262, 27);
            nameTextBox.TabIndex = 2;
            // 
            // frameworkTBox
            // 
            frameworkTBox.Location = new Point(497, 29);
            frameworkTBox.Name = "frameworkTBox";
            frameworkTBox.Size = new Size(125, 27);
            frameworkTBox.TabIndex = 3;
            frameworkTBox.TextChanged += textBox2_TextChanged;
            // 
            // codBox
            // 
            codBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            codBox.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            codBox.Location = new Point(29, 95);
            codBox.Name = "codBox";
            codBox.Size = new Size(584, 120);
            codBox.TabIndex = 4;
            codBox.Text = "";
            // 
            // statusBox
            // 
            statusBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            statusBox.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusBox.Location = new Point(29, 221);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(584, 120);
            statusBox.TabIndex = 5;
            statusBox.Text = "";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(519, 62);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 6;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 374);
            Controls.Add(button1);
            Controls.Add(statusBox);
            Controls.Add(codBox);
            Controls.Add(frameworkTBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CSCompiler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox frameworkTBox;
        private RichTextBox codBox;
        private RichTextBox statusBox;
        private Button button1;
    }
}
