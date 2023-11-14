namespace GUI
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
            generateSimpleButton = new Button();
            generateScatterButton = new Button();
            borderCheckBox = new CheckBox();
            groupBox = new GroupBox();
            panel = new Panel();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // generateSimpleButton
            // 
            generateSimpleButton.Location = new Point(39, 55);
            generateSimpleButton.Name = "generateSimpleButton";
            generateSimpleButton.Size = new Size(227, 31);
            generateSimpleButton.TabIndex = 0;
            generateSimpleButton.Text = "Генерация обычной матрицы";
            generateSimpleButton.UseVisualStyleBackColor = true;
            generateSimpleButton.Click += generateSimpleButton_Click;
            // 
            // generateScatterButton
            // 
            generateScatterButton.Location = new Point(39, 121);
            generateScatterButton.Name = "generateScatterButton";
            generateScatterButton.Size = new Size(227, 31);
            generateScatterButton.TabIndex = 1;
            generateScatterButton.Text = "Генерация разреженной матрицы";
            generateScatterButton.UseVisualStyleBackColor = true;
            generateScatterButton.Click += generateScatterButton_Click;
            // 
            // borderCheckBox
            // 
            borderCheckBox.AutoSize = true;
            borderCheckBox.Location = new Point(93, 192);
            borderCheckBox.Name = "borderCheckBox";
            borderCheckBox.Size = new Size(115, 19);
            borderCheckBox.TabIndex = 2;
            borderCheckBox.Text = "Добавить рамку";
            borderCheckBox.UseVisualStyleBackColor = true;
            borderCheckBox.CheckedChanged += borderCheckBox_CheckedChanged;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(generateSimpleButton);
            groupBox.Controls.Add(borderCheckBox);
            groupBox.Controls.Add(generateScatterButton);
            groupBox.Location = new Point(48, 32);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(305, 257);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "Управление";
            // 
            // panel
            // 
            panel.Location = new Point(410, 83);
            panel.Name = "panel";
            panel.Size = new Size(296, 160);
            panel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 330);
            Controls.Add(panel);
            Controls.Add(groupBox);
            Name = "Form1";
            Text = "Генератор матриц 5000";
            Load += Form1_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button generateSimpleButton;
        private Button generateScatterButton;
        private CheckBox borderCheckBox;
        private GroupBox groupBox;
        private Panel panel;
    }
}