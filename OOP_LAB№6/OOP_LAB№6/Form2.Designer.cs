
namespace OOP_LAB_6
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxWeightSize = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.textBoxKkalMaterial = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.textBox1.Location = new System.Drawing.Point(11, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "COST";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.textBox2.Location = new System.Drawing.Point(237, 84);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 24);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "NAME";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // textBoxWeightSize
            // 
            this.textBoxWeightSize.Enabled = false;
            this.textBoxWeightSize.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.textBoxWeightSize.Location = new System.Drawing.Point(11, 89);
            this.textBoxWeightSize.Multiline = true;
            this.textBoxWeightSize.Name = "textBoxWeightSize";
            this.textBoxWeightSize.Size = new System.Drawing.Size(119, 24);
            this.textBoxWeightSize.TabIndex = 2;
            this.textBoxWeightSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWeightSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxWeightSize_MouseClick);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Clothes",
            "Greens",
            "Laptop"});
            this.comboBoxType.Location = new System.Drawing.Point(44, 84);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHOOSE PARAMENTR OF NEW PRODUCT";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(30, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOOSE TYPE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRAM);
            this.groupBox2.Controls.Add(this.textBoxKkalMaterial);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBoxWeightSize);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(226, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 181);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENTER ITEMS";
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Enabled = false;
            this.textBoxRAM.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.textBoxRAM.Location = new System.Drawing.Point(11, 149);
            this.textBoxRAM.Multiline = true;
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.Size = new System.Drawing.Size(119, 24);
            this.textBoxRAM.TabIndex = 4;
            this.textBoxRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRAM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRAM_MouseClick);
            // 
            // textBoxKkalMaterial
            // 
            this.textBoxKkalMaterial.Enabled = false;
            this.textBoxKkalMaterial.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.textBoxKkalMaterial.Location = new System.Drawing.Point(11, 119);
            this.textBoxKkalMaterial.Multiline = true;
            this.textBoxKkalMaterial.Name = "textBoxKkalMaterial";
            this.textBoxKkalMaterial.Size = new System.Drawing.Size(119, 24);
            this.textBoxKkalMaterial.TabIndex = 3;
            this.textBoxKkalMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKkalMaterial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxKkalMaterial_MouseClick);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(212)))), ((int)(((byte)(48)))));
            this.buttonDone.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.ForeColor = System.Drawing.Color.MintCream;
            this.buttonDone.Location = new System.Drawing.Point(89, 267);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(231, 58);
            this.buttonDone.TabIndex = 7;
            this.buttonDone.Text = "DONE";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(411, 359);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Adding product";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxWeightSize;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.TextBox textBoxKkalMaterial;
        private System.Windows.Forms.Button buttonDone;
    }
}