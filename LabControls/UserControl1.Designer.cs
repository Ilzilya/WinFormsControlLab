
namespace LabControls
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.DecBut = new System.Windows.Forms.RadioButton();
            this.HexBut = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rgBtextBox3 = new LabControls.RGBtextBox(this.components);
            this.rgBtextBox2 = new LabControls.RGBtextBox(this.components);
            this.rgBtextBox1 = new LabControls.RGBtextBox(this.components);
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.colorBox.Enabled = false;
            this.colorBox.Location = new System.Drawing.Point(166, 3);
            this.colorBox.Multiline = true;
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(131, 131);
            this.colorBox.TabIndex = 3;
            this.colorBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // DecBut
            // 
            this.DecBut.AutoSize = true;
            this.DecBut.Checked = true;
            this.DecBut.Location = new System.Drawing.Point(22, 110);
            this.DecBut.Name = "DecBut";
            this.DecBut.Size = new System.Drawing.Size(63, 24);
            this.DecBut.TabIndex = 4;
            this.DecBut.TabStop = true;
            this.DecBut.Text = "Dec";
            this.DecBut.UseVisualStyleBackColor = true;
            this.DecBut.CheckedChanged += new System.EventHandler(this.DecBut_CheckedChanged);
            // 
            // HexBut
            // 
            this.HexBut.AutoSize = true;
            this.HexBut.Location = new System.Drawing.Point(98, 110);
            this.HexBut.Name = "HexBut";
            this.HexBut.Size = new System.Drawing.Size(62, 24);
            this.HexBut.TabIndex = 5;
            this.HexBut.Text = "Hex";
            this.HexBut.UseVisualStyleBackColor = true;
            this.HexBut.CheckedChanged += new System.EventHandler(this.HexBut_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Зеленый";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Синий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Красный";
            // 
            // rgBtextBox3
            // 
            this.rgBtextBox3.Location = new System.Drawing.Point(98, 70);
            this.rgBtextBox3.Name = "rgBtextBox3";
            this.rgBtextBox3.Size = new System.Drawing.Size(62, 26);
            this.rgBtextBox3.TabIndex = 12;
            this.rgBtextBox3.Text = "0";
            this.rgBtextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rgBtextBox3_KeyPress);
            this.rgBtextBox3.Leave += new System.EventHandler(this.rgBtextBox3_Leave);
            // 
            // rgBtextBox2
            // 
            this.rgBtextBox2.Location = new System.Drawing.Point(98, 38);
            this.rgBtextBox2.Name = "rgBtextBox2";
            this.rgBtextBox2.Size = new System.Drawing.Size(62, 26);
            this.rgBtextBox2.TabIndex = 11;
            this.rgBtextBox2.Text = "0";
            this.rgBtextBox2.TextChanged += new System.EventHandler(this.rgBtextBox2_TextChanged);
            this.rgBtextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rgBtextBox2_KeyPress);
            this.rgBtextBox2.Leave += new System.EventHandler(this.rgBtextBox2_Leave);
            // 
            // rgBtextBox1
            // 
            this.rgBtextBox1.Location = new System.Drawing.Point(98, 6);
            this.rgBtextBox1.Name = "rgBtextBox1";
            this.rgBtextBox1.Size = new System.Drawing.Size(62, 26);
            this.rgBtextBox1.TabIndex = 10;
            this.rgBtextBox1.Text = "0";
            this.rgBtextBox1.TextChanged += new System.EventHandler(this.rgBtextBox1_TextChanged);
            this.rgBtextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rgBtextBox1_KeyPress);
            this.rgBtextBox1.Leave += new System.EventHandler(this.rgBtextBox1_Leave);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rgBtextBox3);
            this.Controls.Add(this.rgBtextBox2);
            this.Controls.Add(this.rgBtextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HexBut);
            this.Controls.Add(this.DecBut);
            this.Controls.Add(this.colorBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(303, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.RadioButton DecBut;
        private System.Windows.Forms.RadioButton HexBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private RGBtextBox rgBtextBox3;
        private RGBtextBox rgBtextBox2;
        private RGBtextBox rgBtextBox1;
    }
}
