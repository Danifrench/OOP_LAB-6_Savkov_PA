
namespace OOP_LAB_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addElementButton = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxCost = new System.Windows.Forms.ComboBox();
            this.comboBoxKkal = new System.Windows.Forms.ComboBox();
            this.comboBoxWeight = new System.Windows.Forms.ComboBox();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxRAM = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxProducts.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // addElementButton
            // 
            this.addElementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(212)))), ((int)(((byte)(48)))));
            this.addElementButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addElementButton.ForeColor = System.Drawing.Color.MintCream;
            this.addElementButton.Location = new System.Drawing.Point(537, 362);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(262, 78);
            this.addElementButton.TabIndex = 0;
            this.addElementButton.Text = "ADD PRODUCT";
            this.addElementButton.UseVisualStyleBackColor = false;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProducts.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F);
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 24;
            this.listBoxProducts.Location = new System.Drawing.Point(6, 21);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(502, 312);
            this.listBoxProducts.TabIndex = 1;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))));
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.MintCream;
            this.buttonDelete.Location = new System.Drawing.Point(537, 446);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(262, 50);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxCost
            // 
            this.comboBoxCost.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCost.FormattingEnabled = true;
            this.comboBoxCost.Location = new System.Drawing.Point(18, 362);
            this.comboBoxCost.Name = "comboBoxCost";
            this.comboBoxCost.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCost.TabIndex = 5;
            this.comboBoxCost.Text = "COST";
            this.comboBoxCost.SelectedIndexChanged += new System.EventHandler(this.comboBoxCost_SelectedIndexChanged);
            // 
            // comboBoxKkal
            // 
            this.comboBoxKkal.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.comboBoxKkal.FormattingEnabled = true;
            this.comboBoxKkal.Location = new System.Drawing.Point(145, 362);
            this.comboBoxKkal.Name = "comboBoxKkal";
            this.comboBoxKkal.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKkal.TabIndex = 6;
            this.comboBoxKkal.Text = "KKAL";
            this.comboBoxKkal.SelectedIndexChanged += new System.EventHandler(this.comboBoxKkal_SelectedIndexChanged);
            // 
            // comboBoxWeight
            // 
            this.comboBoxWeight.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.comboBoxWeight.FormattingEnabled = true;
            this.comboBoxWeight.Location = new System.Drawing.Point(272, 362);
            this.comboBoxWeight.Name = "comboBoxWeight";
            this.comboBoxWeight.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWeight.TabIndex = 7;
            this.comboBoxWeight.Text = "WEIGHT";
            this.comboBoxWeight.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeight_SelectedIndexChanged);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.listBoxProducts);
            this.groupBoxProducts.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.groupBoxProducts.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(514, 340);
            this.groupBoxProducts.TabIndex = 8;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "PRODUCTS";
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.richTextBox1);
            this.groupBoxItems.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.groupBoxItems.Location = new System.Drawing.Point(537, 12);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(262, 340);
            this.groupBoxItems.TabIndex = 9;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "ITEMS";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(0, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(256, 312);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(399, 362);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSize.TabIndex = 10;
            this.comboBoxSize.Text = "SIZE";
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(18, 392);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaterial.TabIndex = 11;
            this.comboBoxMaterial.Text = "MATERIAL";
            this.comboBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterial_SelectedIndexChanged);
            // 
            // comboBoxRAM
            // 
            this.comboBoxRAM.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 7.8F);
            this.comboBoxRAM.FormattingEnabled = true;
            this.comboBoxRAM.Location = new System.Drawing.Point(145, 392);
            this.comboBoxRAM.Name = "comboBoxRAM";
            this.comboBoxRAM.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRAM.TabIndex = 12;
            this.comboBoxRAM.Text = "RAM";
            this.comboBoxRAM.SelectedIndexChanged += new System.EventHandler(this.comboBoxRAM_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(18, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(811, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxRAM);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxWeight);
            this.Controls.Add(this.comboBoxKkal);
            this.Controls.Add(this.comboBoxCost);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.addElementButton);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBoxItems);
            this.Name = "Form1";
            this.Text = "Store of products";
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addElementButton;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxCost;
        private System.Windows.Forms.ComboBox comboBoxKkal;
        private System.Windows.Forms.ComboBox comboBoxWeight;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.ComboBox comboBoxRAM;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

