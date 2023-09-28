namespace Cleaner
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
            clearButton = new Button();
            label1 = new Label();
            directoryLabel = new Label();
            label2 = new Label();
            openDirectoryButton = new Button();
            label3 = new Label();
            extensionLabel = new Label();
            textBoxExtension = new TextBox();
            changeExtensionButton = new Button();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Location = new Point(430, 9);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(82, 45);
            clearButton.TabIndex = 0;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearFolder;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            // 
            // directoryLabel
            // 
            directoryLabel.AutoSize = true;
            directoryLabel.Location = new Point(6, 39);
            directoryLabel.Name = "directoryLabel";
            directoryLabel.Size = new Size(82, 15);
            directoryLabel.TabIndex = 1;
            directoryLabel.Text = "directoryLabel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 2;
            label2.Text = "Current Directory:";
            // 
            // openDirectoryButton
            // 
            openDirectoryButton.Location = new Point(304, 9);
            openDirectoryButton.Name = "openDirectoryButton";
            openDirectoryButton.Size = new Size(120, 45);
            openDirectoryButton.TabIndex = 3;
            openDirectoryButton.Text = "Change Direcotry";
            openDirectoryButton.UseVisualStyleBackColor = true;
            openDirectoryButton.Click += OpenDirectory;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 64);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 4;
            label3.Text = "Current Extension:";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Location = new Point(6, 96);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new Size(86, 15);
            extensionLabel.TabIndex = 5;
            extensionLabel.Text = "extensionLabel";
            // 
            // textBoxExtension
            // 
            textBoxExtension.Location = new Point(148, 93);
            textBoxExtension.Name = "textBoxExtension";
            textBoxExtension.Size = new Size(100, 23);
            textBoxExtension.TabIndex = 6;
            // 
            // changeExtensionButton
            // 
            changeExtensionButton.Location = new Point(304, 71);
            changeExtensionButton.Name = "changeExtensionButton";
            changeExtensionButton.Size = new Size(120, 45);
            changeExtensionButton.TabIndex = 7;
            changeExtensionButton.Text = "Change Extension";
            changeExtensionButton.UseVisualStyleBackColor = true;
            changeExtensionButton.Click += ChangeExtension;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 151);
            Controls.Add(changeExtensionButton);
            Controls.Add(textBoxExtension);
            Controls.Add(extensionLabel);
            Controls.Add(label3);
            Controls.Add(openDirectoryButton);
            Controls.Add(label2);
            Controls.Add(directoryLabel);
            Controls.Add(label1);
            Controls.Add(clearButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cleaner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearButton;
        private Label label1;
        private Label directoryLabel;
        private Label label2;
        private Button openDirectoryButton;
        private Label label3;
        private Label extensionLabel;
        private TextBox textBoxExtension;
        private Button changeExtensionButton;
    }
}