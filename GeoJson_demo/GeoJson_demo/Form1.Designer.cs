namespace GeoJson_demo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.geoinfoTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 134);
            this.button1.TabIndex = 1;
            this.button1.Text = "DO IT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(67, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "label2";
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Location = new System.Drawing.Point(67, 13);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(35, 13);
            this.idLable.TabIndex = 4;
            this.idLable.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Species";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(67, 66);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(35, 13);
            this.speciesLabel.TabIndex = 7;
            this.speciesLabel.Text = "label6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "GeoInfo";
            // 
            // geoinfoTextbox
            // 
            this.geoinfoTextbox.Location = new System.Drawing.Point(229, 10);
            this.geoinfoTextbox.Multiline = true;
            this.geoinfoTextbox.Name = "geoinfoTextbox";
            this.geoinfoTextbox.Size = new System.Drawing.Size(151, 69);
            this.geoinfoTextbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 229);
            this.Controls.Add(this.geoinfoTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idLable);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox geoinfoTextbox;
    }
}

