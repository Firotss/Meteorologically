
namespace Meteorologically
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.celsius = new System.Windows.Forms.Button();
            this.fahrenheit = new System.Windows.Forms.Button();
            this.kelvin = new System.Windows.Forms.Button();
            this.kph = new System.Windows.Forms.Button();
            this.mph = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.check = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(205, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "e.g London, Burgas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SUPPORT";
            // 
            // celsius
            // 
            this.celsius.BackColor = System.Drawing.Color.Black;
            this.celsius.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.celsius.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.celsius.ForeColor = System.Drawing.Color.White;
            this.celsius.Location = new System.Drawing.Point(12, 101);
            this.celsius.Name = "celsius";
            this.celsius.Size = new System.Drawing.Size(29, 29);
            this.celsius.TabIndex = 4;
            this.celsius.Text = "°C";
            this.celsius.UseVisualStyleBackColor = false;
            this.celsius.Click += new System.EventHandler(this.celsius_Click);
            // 
            // fahrenheit
            // 
            this.fahrenheit.BackColor = System.Drawing.Color.Black;
            this.fahrenheit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fahrenheit.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fahrenheit.ForeColor = System.Drawing.Color.White;
            this.fahrenheit.Location = new System.Drawing.Point(47, 101);
            this.fahrenheit.Name = "fahrenheit";
            this.fahrenheit.Size = new System.Drawing.Size(29, 29);
            this.fahrenheit.TabIndex = 5;
            this.fahrenheit.Text = "°F";
            this.fahrenheit.UseVisualStyleBackColor = false;
            this.fahrenheit.Click += new System.EventHandler(this.fahrenheit_Click);
            // 
            // kelvin
            // 
            this.kelvin.BackColor = System.Drawing.Color.Black;
            this.kelvin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kelvin.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kelvin.ForeColor = System.Drawing.Color.White;
            this.kelvin.Location = new System.Drawing.Point(82, 101);
            this.kelvin.Name = "kelvin";
            this.kelvin.Size = new System.Drawing.Size(29, 29);
            this.kelvin.TabIndex = 6;
            this.kelvin.Text = "K";
            this.kelvin.UseVisualStyleBackColor = false;
            this.kelvin.Click += new System.EventHandler(this.kelvin_Click);
            // 
            // kph
            // 
            this.kph.BackColor = System.Drawing.Color.Black;
            this.kph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kph.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kph.ForeColor = System.Drawing.Color.White;
            this.kph.Location = new System.Drawing.Point(12, 168);
            this.kph.Name = "kph";
            this.kph.Size = new System.Drawing.Size(99, 29);
            this.kph.TabIndex = 7;
            this.kph.Text = "km/hour";
            this.kph.UseVisualStyleBackColor = false;
            this.kph.Click += new System.EventHandler(this.kph_Click);
            // 
            // mph
            // 
            this.mph.BackColor = System.Drawing.Color.Black;
            this.mph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mph.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mph.ForeColor = System.Drawing.Color.White;
            this.mph.Location = new System.Drawing.Point(12, 203);
            this.mph.Name = "mph";
            this.mph.Size = new System.Drawing.Size(99, 29);
            this.mph.TabIndex = 8;
            this.mph.Text = "miles/hour";
            this.mph.UseVisualStyleBackColor = false;
            this.mph.Click += new System.EventHandler(this.mph_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "SPEED UNIT";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 29);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "Burgas";
            // 
            // check
            // 
            this.check.Enabled = true;
            this.check.Interval = 1;
            this.check.Tick += new System.EventHandler(this.check_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(241, 242);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mph);
            this.Controls.Add(this.kph);
            this.Controls.Add(this.kelvin);
            this.Controls.Add(this.fahrenheit);
            this.Controls.Add(this.celsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WEATHER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button celsius;
        private System.Windows.Forms.Button fahrenheit;
        private System.Windows.Forms.Button kelvin;
        private System.Windows.Forms.Button kph;
        private System.Windows.Forms.Button mph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer check;
    }
}

