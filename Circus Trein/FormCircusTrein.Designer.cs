namespace Circus_Trein
{
    partial class FormCircusTrein
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
            this.radioBtnMeat = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnPlants = new System.Windows.Forms.RadioButton();
            this.radioBtnSmall = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioBtnLarge = new System.Windows.Forms.RadioButton();
            this.radioBtnMedium = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAnimals = new System.Windows.Forms.Label();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.btnCalculateWagons = new System.Windows.Forms.Button();
            this.listBoxWagons = new System.Windows.Forms.ListBox();
            this.lblWagons = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnMeat
            // 
            this.radioBtnMeat.AutoSize = true;
            this.radioBtnMeat.Checked = true;
            this.radioBtnMeat.Location = new System.Drawing.Point(8, 16);
            this.radioBtnMeat.Name = "radioBtnMeat";
            this.radioBtnMeat.Size = new System.Drawing.Size(60, 21);
            this.radioBtnMeat.TabIndex = 1;
            this.radioBtnMeat.TabStop = true;
            this.radioBtnMeat.Text = "Meat";
            this.radioBtnMeat.UseVisualStyleBackColor = true;
            this.radioBtnMeat.CheckedChanged += new System.EventHandler(this.radioBtnMeat_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnPlants);
            this.panel1.Controls.Add(this.radioBtnMeat);
            this.panel1.Location = new System.Drawing.Point(40, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 80);
            this.panel1.TabIndex = 2;
            // 
            // radioBtnPlants
            // 
            this.radioBtnPlants.AutoSize = true;
            this.radioBtnPlants.Location = new System.Drawing.Point(8, 48);
            this.radioBtnPlants.Name = "radioBtnPlants";
            this.radioBtnPlants.Size = new System.Drawing.Size(68, 21);
            this.radioBtnPlants.TabIndex = 2;
            this.radioBtnPlants.Text = "Plants";
            this.radioBtnPlants.UseVisualStyleBackColor = true;
            this.radioBtnPlants.CheckedChanged += new System.EventHandler(this.radioBtnPlants_CheckedChanged);
            // 
            // radioBtnSmall
            // 
            this.radioBtnSmall.AutoSize = true;
            this.radioBtnSmall.Checked = true;
            this.radioBtnSmall.Location = new System.Drawing.Point(8, 8);
            this.radioBtnSmall.Name = "radioBtnSmall";
            this.radioBtnSmall.Size = new System.Drawing.Size(63, 21);
            this.radioBtnSmall.TabIndex = 3;
            this.radioBtnSmall.TabStop = true;
            this.radioBtnSmall.Text = "Small";
            this.radioBtnSmall.UseVisualStyleBackColor = true;
            this.radioBtnSmall.CheckedChanged += new System.EventHandler(this.radioBtnSmall_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioBtnLarge);
            this.panel2.Controls.Add(this.radioBtnMedium);
            this.panel2.Controls.Add(this.radioBtnSmall);
            this.panel2.Location = new System.Drawing.Point(40, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 100);
            this.panel2.TabIndex = 4;
            // 
            // radioBtnLarge
            // 
            this.radioBtnLarge.AutoSize = true;
            this.radioBtnLarge.Location = new System.Drawing.Point(8, 72);
            this.radioBtnLarge.Name = "radioBtnLarge";
            this.radioBtnLarge.Size = new System.Drawing.Size(66, 21);
            this.radioBtnLarge.TabIndex = 5;
            this.radioBtnLarge.Text = "Large";
            this.radioBtnLarge.UseVisualStyleBackColor = true;
            this.radioBtnLarge.CheckedChanged += new System.EventHandler(this.radioBtnLarge_CheckedChanged);
            // 
            // radioBtnMedium
            // 
            this.radioBtnMedium.AutoSize = true;
            this.radioBtnMedium.Location = new System.Drawing.Point(8, 40);
            this.radioBtnMedium.Name = "radioBtnMedium";
            this.radioBtnMedium.Size = new System.Drawing.Size(78, 21);
            this.radioBtnMedium.TabIndex = 4;
            this.radioBtnMedium.Text = "Medium";
            this.radioBtnMedium.UseVisualStyleBackColor = true;
            this.radioBtnMedium.CheckedChanged += new System.EventHandler(this.radioBtnMedium_CheckedChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(40, 152);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 17);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(40, 24);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(40, 17);
            this.lblFood.TabIndex = 6;
            this.lblFood.Text = "Food";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAnimals
            // 
            this.lblAnimals.AutoSize = true;
            this.lblAnimals.Location = new System.Drawing.Point(192, 24);
            this.lblAnimals.Name = "lblAnimals";
            this.lblAnimals.Size = new System.Drawing.Size(57, 17);
            this.lblAnimals.TabIndex = 8;
            this.lblAnimals.Text = "Animals";
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.ItemHeight = 16;
            this.listBoxAnimals.Location = new System.Drawing.Point(192, 48);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(136, 228);
            this.listBoxAnimals.TabIndex = 9;
            // 
            // btnCalculateWagons
            // 
            this.btnCalculateWagons.ForeColor = System.Drawing.Color.Black;
            this.btnCalculateWagons.Location = new System.Drawing.Point(192, 296);
            this.btnCalculateWagons.Name = "btnCalculateWagons";
            this.btnCalculateWagons.Size = new System.Drawing.Size(136, 32);
            this.btnCalculateWagons.TabIndex = 10;
            this.btnCalculateWagons.Text = "Calculate Wagons";
            this.btnCalculateWagons.UseVisualStyleBackColor = true;
            this.btnCalculateWagons.Click += new System.EventHandler(this.btnCalculateWagons_Click);
            // 
            // listBoxWagons
            // 
            this.listBoxWagons.FormattingEnabled = true;
            this.listBoxWagons.ItemHeight = 16;
            this.listBoxWagons.Location = new System.Drawing.Point(400, 48);
            this.listBoxWagons.Name = "listBoxWagons";
            this.listBoxWagons.Size = new System.Drawing.Size(616, 228);
            this.listBoxWagons.TabIndex = 11;
            // 
            // lblWagons
            // 
            this.lblWagons.AutoSize = true;
            this.lblWagons.Location = new System.Drawing.Point(400, 24);
            this.lblWagons.Name = "lblWagons";
            this.lblWagons.Size = new System.Drawing.Size(60, 17);
            this.lblWagons.TabIndex = 12;
            this.lblWagons.Text = "Wagons";
            // 
            // FormCircusTrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 353);
            this.Controls.Add(this.lblWagons);
            this.Controls.Add(this.listBoxWagons);
            this.Controls.Add(this.btnCalculateWagons);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.lblAnimals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCircusTrein";
            this.Text = "Circustrein";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioBtnMeat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnPlants;
        private System.Windows.Forms.RadioButton radioBtnSmall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioBtnLarge;
        private System.Windows.Forms.RadioButton radioBtnMedium;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAnimals;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Button btnCalculateWagons;
        private System.Windows.Forms.ListBox listBoxWagons;
        private System.Windows.Forms.Label lblWagons;
    }
}

