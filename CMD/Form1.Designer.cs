namespace CMD
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
            editButton = new Button();
            groupBox = new GroupBox();
            undoButton = new Button();
            panel = new Panel();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.Location = new Point(40, 38);
            editButton.Name = "editButton";
            editButton.Size = new Size(152, 33);
            editButton.TabIndex = 0;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(undoButton);
            groupBox.Controls.Add(editButton);
            groupBox.Location = new Point(42, 35);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(234, 151);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Управление";
            // 
            // undoButton
            // 
            undoButton.Location = new Point(40, 85);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(152, 33);
            undoButton.TabIndex = 1;
            undoButton.Text = "Отменить";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // panel
            // 
            panel.Location = new Point(332, 53);
            panel.Name = "panel";
            panel.Size = new Size(243, 151);
            panel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 235);
            Controls.Add(panel);
            Controls.Add(groupBox);
            Name = "Form1";
            Text = "Паттерн команда";
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button editButton;
        private GroupBox groupBox;
        private Button undoButton;
        private Panel panel;
    }
}
