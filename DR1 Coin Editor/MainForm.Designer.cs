namespace DR1_Coin_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileLocationTextBox = new System.Windows.Forms.TextBox();
            this.selectSaveFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modifySaveFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.coinsAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.coinsAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save File Location";
            // 
            // saveFileLocationTextBox
            // 
            this.saveFileLocationTextBox.AllowDrop = true;
            this.saveFileLocationTextBox.Location = new System.Drawing.Point(11, 65);
            this.saveFileLocationTextBox.Name = "saveFileLocationTextBox";
            this.saveFileLocationTextBox.Size = new System.Drawing.Size(482, 23);
            this.saveFileLocationTextBox.TabIndex = 1;
            this.saveFileLocationTextBox.TabStop = false;
            this.saveFileLocationTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.saveFileLocationTextBox_DragDrop);
            this.saveFileLocationTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.saveFileLocationTextBox_DragEnter);
            // 
            // selectSaveFileButton
            // 
            this.selectSaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectSaveFileButton.Location = new System.Drawing.Point(501, 64);
            this.selectSaveFileButton.Name = "selectSaveFileButton";
            this.selectSaveFileButton.Size = new System.Drawing.Size(68, 25);
            this.selectSaveFileButton.TabIndex = 2;
            this.selectSaveFileButton.TabStop = false;
            this.selectSaveFileButton.Text = "...";
            this.selectSaveFileButton.UseVisualStyleBackColor = true;
            this.selectSaveFileButton.Click += new System.EventHandler(this.selectSaveFileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Options";
            // 
            // modifySaveFileButton
            // 
            this.modifySaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modifySaveFileButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifySaveFileButton.Location = new System.Drawing.Point(11, 213);
            this.modifySaveFileButton.Name = "modifySaveFileButton";
            this.modifySaveFileButton.Size = new System.Drawing.Size(558, 33);
            this.modifySaveFileButton.TabIndex = 4;
            this.modifySaveFileButton.TabStop = false;
            this.modifySaveFileButton.Text = "Modify save file!";
            this.modifySaveFileButton.UseVisualStyleBackColor = true;
            this.modifySaveFileButton.Click += new System.EventHandler(this.modifySaveFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coins:";
            // 
            // coinsAmountNumericUpDown
            // 
            this.coinsAmountNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coinsAmountNumericUpDown.Location = new System.Drawing.Point(86, 158);
            this.coinsAmountNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.coinsAmountNumericUpDown.Name = "coinsAmountNumericUpDown";
            this.coinsAmountNumericUpDown.Size = new System.Drawing.Size(481, 29);
            this.coinsAmountNumericUpDown.TabIndex = 6;
            this.coinsAmountNumericUpDown.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 262);
            this.Controls.Add(this.coinsAmountNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modifySaveFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectSaveFileButton);
            this.Controls.Add(this.saveFileLocationTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DR1 Coin Editor";
            ((System.ComponentModel.ISupportInitialize)(this.coinsAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox saveFileLocationTextBox;
        private Button selectSaveFileButton;
        private Label label2;
        private Button modifySaveFileButton;
        private Label label3;
        private NumericUpDown coinsAmountNumericUpDown;
    }
}