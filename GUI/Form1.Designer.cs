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
            generateGroupButton = new Button();
            restoreButton = new Button();
            swapButton = new Button();
            transposeButton = new Button();
            plusBorderButton = new Button();
            minusBorderButton = new Button();
            panel = new Panel();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // generateSimpleButton
            // 
            generateSimpleButton.Location = new Point(39, 45);
            generateSimpleButton.Name = "generateSimpleButton";
            generateSimpleButton.Size = new Size(227, 31);
            generateSimpleButton.TabIndex = 0;
            generateSimpleButton.Text = "Генерация обычной матрицы";
            generateSimpleButton.UseVisualStyleBackColor = true;
            generateSimpleButton.Click += generateSimpleButton_Click;
            // 
            // generateScatterButton
            // 
            generateScatterButton.Location = new Point(39, 86);
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
            borderCheckBox.Location = new Point(53, 179);
            borderCheckBox.Name = "borderCheckBox";
            borderCheckBox.Size = new Size(113, 19);
            borderCheckBox.TabIndex = 2;
            borderCheckBox.Text = "Рисовать рамку";
            borderCheckBox.UseVisualStyleBackColor = true;
            borderCheckBox.CheckedChanged += borderCheckBox_CheckedChanged;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(generateGroupButton);
            groupBox.Controls.Add(restoreButton);
            groupBox.Controls.Add(swapButton);
            groupBox.Controls.Add(transposeButton);
            groupBox.Controls.Add(plusBorderButton);
            groupBox.Controls.Add(minusBorderButton);
            groupBox.Controls.Add(generateSimpleButton);
            groupBox.Controls.Add(borderCheckBox);
            groupBox.Controls.Add(generateScatterButton);
            groupBox.Location = new Point(48, 32);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(305, 380);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "Управление";
            // 
            // generateGroupButton
            // 
            generateGroupButton.Location = new Point(39, 127);
            generateGroupButton.Name = "generateGroupButton";
            generateGroupButton.Size = new Size(227, 31);
            generateGroupButton.TabIndex = 8;
            generateGroupButton.Text = "Генерация группы матриц";
            generateGroupButton.UseVisualStyleBackColor = true;
            generateGroupButton.Click += generateGroupButton_Click;
            // 
            // restoreButton
            // 
            restoreButton.Location = new Point(39, 310);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(227, 31);
            restoreButton.TabIndex = 7;
            restoreButton.Text = "Восстановить";
            restoreButton.UseVisualStyleBackColor = true;
            restoreButton.Click += restoreButton_Click;
            // 
            // swapButton
            // 
            swapButton.Location = new Point(39, 269);
            swapButton.Name = "swapButton";
            swapButton.Size = new Size(227, 31);
            swapButton.TabIndex = 6;
            swapButton.Text = "Перенумеровать";
            swapButton.UseVisualStyleBackColor = true;
            swapButton.Click += swapButton_Click;
            // 
            // transposeButton
            // 
            transposeButton.Location = new Point(39, 228);
            transposeButton.Name = "transposeButton";
            transposeButton.Size = new Size(227, 31);
            transposeButton.TabIndex = 5;
            transposeButton.Text = "Транспонировать";
            transposeButton.UseVisualStyleBackColor = true;
            transposeButton.Click += transposeButton_Click;
            // 
            // plusBorderButton
            // 
            plusBorderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            plusBorderButton.Location = new Point(233, 175);
            plusBorderButton.Name = "plusBorderButton";
            plusBorderButton.Size = new Size(32, 28);
            plusBorderButton.TabIndex = 4;
            plusBorderButton.Text = "+1";
            plusBorderButton.UseVisualStyleBackColor = true;
            plusBorderButton.Click += plusBorderButton_Click;
            // 
            // minusBorderButton
            // 
            minusBorderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            minusBorderButton.Location = new Point(185, 175);
            minusBorderButton.Name = "minusBorderButton";
            minusBorderButton.Size = new Size(32, 28);
            minusBorderButton.TabIndex = 3;
            minusBorderButton.Text = "-1";
            minusBorderButton.UseVisualStyleBackColor = true;
            minusBorderButton.Click += minusBorderButton_Click;
            // 
            // panel
            // 
            panel.Location = new Point(410, 54);
            panel.Name = "panel";
            panel.Size = new Size(572, 442);
            panel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 508);
            Controls.Add(panel);
            Controls.Add(groupBox);
            Name = "Form1";
            Text = "Генератор матриц 5000";
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
        private Button minusBorderButton;
        private Button plusBorderButton;
        private Button transposeButton;
        private Button restoreButton;
        private Button swapButton;
        private Button generateGroupButton;
    }
}