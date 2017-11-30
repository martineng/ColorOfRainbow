namespace ColorOfRainbow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelColor = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbHexadecimal = new System.Windows.Forms.Label();
            this.lbRGBA = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxHexadecimal = new System.Windows.Forms.TextBox();
            this.tboxRGBA = new System.Windows.Forms.TextBox();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.btnSaveColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(71, 44);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(200, 144);
            this.panelColor.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(68, 226);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name :";
            // 
            // lbHexadecimal
            // 
            this.lbHexadecimal.AutoSize = true;
            this.lbHexadecimal.Location = new System.Drawing.Point(37, 253);
            this.lbHexadecimal.Name = "lbHexadecimal";
            this.lbHexadecimal.Size = new System.Drawing.Size(74, 13);
            this.lbHexadecimal.TabIndex = 2;
            this.lbHexadecimal.Text = "Hexadecimal :";
            // 
            // lbRGBA
            // 
            this.lbRGBA.AutoSize = true;
            this.lbRGBA.Location = new System.Drawing.Point(68, 282);
            this.lbRGBA.Name = "lbRGBA";
            this.lbRGBA.Size = new System.Drawing.Size(43, 13);
            this.lbRGBA.TabIndex = 3;
            this.lbRGBA.Text = "RGBA :";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(116, 226);
            this.tboxName.Name = "tboxName";
            this.tboxName.ReadOnly = true;
            this.tboxName.Size = new System.Drawing.Size(151, 20);
            this.tboxName.TabIndex = 4;
            // 
            // tboxHexadecimal
            // 
            this.tboxHexadecimal.Location = new System.Drawing.Point(117, 252);
            this.tboxHexadecimal.Name = "tboxHexadecimal";
            this.tboxHexadecimal.ReadOnly = true;
            this.tboxHexadecimal.Size = new System.Drawing.Size(150, 20);
            this.tboxHexadecimal.TabIndex = 5;
            // 
            // tboxRGBA
            // 
            this.tboxRGBA.Location = new System.Drawing.Point(117, 278);
            this.tboxRGBA.Name = "tboxRGBA";
            this.tboxRGBA.ReadOnly = true;
            this.tboxRGBA.Size = new System.Drawing.Size(150, 20);
            this.tboxRGBA.TabIndex = 6;
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Location = new System.Drawing.Point(135, 194);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(75, 23);
            this.btnColorPicker.TabIndex = 7;
            this.btnColorPicker.Text = "Color Picker";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // btnSaveColor
            // 
            this.btnSaveColor.Location = new System.Drawing.Point(135, 319);
            this.btnSaveColor.Name = "btnSaveColor";
            this.btnSaveColor.Size = new System.Drawing.Size(75, 23);
            this.btnSaveColor.TabIndex = 8;
            this.btnSaveColor.Text = "Save Color";
            this.btnSaveColor.UseVisualStyleBackColor = true;
            this.btnSaveColor.Click += new System.EventHandler(this.btnSaveColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 374);
            this.Controls.Add(this.btnSaveColor);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.tboxRGBA);
            this.Controls.Add(this.tboxHexadecimal);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lbRGBA);
            this.Controls.Add(this.lbHexadecimal);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.panelColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbHexadecimal;
        private System.Windows.Forms.Label lbRGBA;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxHexadecimal;
        private System.Windows.Forms.TextBox tboxRGBA;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.Button btnSaveColor;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

