namespace Translation_Number_Systems
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
            this.input_number = new System.Windows.Forms.TextBox();
            this.input_number_system = new System.Windows.Forms.TextBox();
            this.to_number_system = new System.Windows.Forms.TextBox();
            this.input_number_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_translate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_number
            // 
            this.input_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_number.Location = new System.Drawing.Point(87, 105);
            this.input_number.Name = "input_number";
            this.input_number.Size = new System.Drawing.Size(127, 20);
            this.input_number.TabIndex = 0;
            // 
            // input_number_system
            // 
            this.input_number_system.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_number_system.Location = new System.Drawing.Point(87, 155);
            this.input_number_system.Name = "input_number_system";
            this.input_number_system.Size = new System.Drawing.Size(127, 20);
            this.input_number_system.TabIndex = 1;
            this.input_number_system.TextChanged += new System.EventHandler(this.input_number_system_TextChanged);
            // 
            // to_number_system
            // 
            this.to_number_system.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.to_number_system.Location = new System.Drawing.Point(234, 105);
            this.to_number_system.Name = "to_number_system";
            this.to_number_system.Size = new System.Drawing.Size(127, 20);
            this.to_number_system.TabIndex = 2;
            // 
            // input_number_label
            // 
            this.input_number_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input_number_label.AutoSize = true;
            this.input_number_label.Location = new System.Drawing.Point(87, 89);
            this.input_number_label.Name = "input_number_label";
            this.input_number_label.Size = new System.Drawing.Size(66, 13);
            this.input_number_label.TabIndex = 4;
            this.input_number_label.Text = "Ваше число";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Его система счисления";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Нужная система счисления";
            // 
            // button_translate
            // 
            this.button_translate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_translate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_translate.Location = new System.Drawing.Point(234, 150);
            this.button_translate.Name = "button_translate";
            this.button_translate.Size = new System.Drawing.Size(127, 29);
            this.button_translate.TabIndex = 8;
            this.button_translate.Text = "Перевести";
            this.button_translate.UseVisualStyleBackColor = true;
            this.button_translate.Click += new System.EventHandler(this.button_translate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_number_label);
            this.Controls.Add(this.to_number_system);
            this.Controls.Add(this.input_number_system);
            this.Controls.Add(this.input_number);
            this.Controls.Add(this.button_translate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_number;
        private System.Windows.Forms.TextBox input_number_system;
        private System.Windows.Forms.TextBox to_number_system;
        private System.Windows.Forms.Label input_number_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_translate;
    }
}

