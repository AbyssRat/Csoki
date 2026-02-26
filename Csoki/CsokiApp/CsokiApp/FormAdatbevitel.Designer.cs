namespace CsokiApp
{
    partial class FormAdatbevitel
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
            this.comboBoxKateg = new System.Windows.Forms.ComboBox();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxIz = new System.Windows.Forms.TextBox();
            this.numericUpDownTomeg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAr = new System.Windows.Forms.NumericUpDown();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelIz = new System.Windows.Forms.Label();
            this.labelKateg = new System.Windows.Forms.Label();
            this.labelTomeg = new System.Windows.Forms.Label();
            this.labelAr = new System.Windows.Forms.Label();
            this.checkBoxAlkoholos = new System.Windows.Forms.CheckBox();
            this.checkBoxVegan = new System.Windows.Forms.CheckBox();
            this.labelEgyeb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTomeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAr)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKateg
            // 
            this.comboBoxKateg.FormattingEnabled = true;
            this.comboBoxKateg.Location = new System.Drawing.Point(100, 122);
            this.comboBoxKateg.Name = "comboBoxKateg";
            this.comboBoxKateg.Size = new System.Drawing.Size(228, 21);
            this.comboBoxKateg.TabIndex = 0;
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(35, 340);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 1;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(100, 33);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(228, 20);
            this.textBoxNev.TabIndex = 2;
            this.textBoxNev.TextChanged += new System.EventHandler(this.textBoxNev_TextChanged);
            // 
            // textBoxIz
            // 
            this.textBoxIz.Location = new System.Drawing.Point(100, 78);
            this.textBoxIz.Name = "textBoxIz";
            this.textBoxIz.Size = new System.Drawing.Size(228, 20);
            this.textBoxIz.TabIndex = 3;
            this.textBoxIz.TextChanged += new System.EventHandler(this.textBoxIz_TextChanged);
            // 
            // numericUpDownTomeg
            // 
            this.numericUpDownTomeg.Location = new System.Drawing.Point(100, 168);
            this.numericUpDownTomeg.Name = "numericUpDownTomeg";
            this.numericUpDownTomeg.Size = new System.Drawing.Size(228, 20);
            this.numericUpDownTomeg.TabIndex = 4;
            // 
            // numericUpDownAr
            // 
            this.numericUpDownAr.Location = new System.Drawing.Point(100, 213);
            this.numericUpDownAr.Name = "numericUpDownAr";
            this.numericUpDownAr.Size = new System.Drawing.Size(228, 20);
            this.numericUpDownAr.TabIndex = 5;
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(35, 40);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(27, 13);
            this.labelNev.TabIndex = 6;
            this.labelNev.Text = "Név";
            // 
            // labelIz
            // 
            this.labelIz.AutoSize = true;
            this.labelIz.Location = new System.Drawing.Point(35, 85);
            this.labelIz.Name = "labelIz";
            this.labelIz.Size = new System.Drawing.Size(15, 13);
            this.labelIz.TabIndex = 7;
            this.labelIz.Text = "Íz";
            // 
            // labelKateg
            // 
            this.labelKateg.AutoSize = true;
            this.labelKateg.Location = new System.Drawing.Point(35, 130);
            this.labelKateg.Name = "labelKateg";
            this.labelKateg.Size = new System.Drawing.Size(52, 13);
            this.labelKateg.TabIndex = 8;
            this.labelKateg.Text = "Kategória";
            // 
            // labelTomeg
            // 
            this.labelTomeg.AutoSize = true;
            this.labelTomeg.Location = new System.Drawing.Point(35, 175);
            this.labelTomeg.Name = "labelTomeg";
            this.labelTomeg.Size = new System.Drawing.Size(40, 13);
            this.labelTomeg.TabIndex = 9;
            this.labelTomeg.Text = "Tömeg";
            // 
            // labelAr
            // 
            this.labelAr.AutoSize = true;
            this.labelAr.Location = new System.Drawing.Point(35, 220);
            this.labelAr.Name = "labelAr";
            this.labelAr.Size = new System.Drawing.Size(17, 13);
            this.labelAr.TabIndex = 10;
            this.labelAr.Text = "Ár";
            // 
            // checkBoxAlkoholos
            // 
            this.checkBoxAlkoholos.AutoSize = true;
            this.checkBoxAlkoholos.Location = new System.Drawing.Point(100, 261);
            this.checkBoxAlkoholos.Name = "checkBoxAlkoholos";
            this.checkBoxAlkoholos.Size = new System.Drawing.Size(72, 17);
            this.checkBoxAlkoholos.TabIndex = 11;
            this.checkBoxAlkoholos.Text = "Alkoholos";
            this.checkBoxAlkoholos.UseVisualStyleBackColor = true;
            this.checkBoxAlkoholos.CheckedChanged += new System.EventHandler(this.checkBoxAlkoholos_CheckedChanged);
            // 
            // checkBoxVegan
            // 
            this.checkBoxVegan.AutoSize = true;
            this.checkBoxVegan.Location = new System.Drawing.Point(271, 261);
            this.checkBoxVegan.Name = "checkBoxVegan";
            this.checkBoxVegan.Size = new System.Drawing.Size(57, 17);
            this.checkBoxVegan.TabIndex = 12;
            this.checkBoxVegan.Text = "Vegán";
            this.checkBoxVegan.UseVisualStyleBackColor = true;
            this.checkBoxVegan.CheckedChanged += new System.EventHandler(this.checkBoxVegan_CheckedChanged);
            // 
            // labelEgyeb
            // 
            this.labelEgyeb.AutoSize = true;
            this.labelEgyeb.Location = new System.Drawing.Point(35, 265);
            this.labelEgyeb.Name = "labelEgyeb";
            this.labelEgyeb.Size = new System.Drawing.Size(37, 13);
            this.labelEgyeb.TabIndex = 13;
            this.labelEgyeb.Text = "Egyéb";
            // 
            // FormAdatbevitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEgyeb);
            this.Controls.Add(this.checkBoxVegan);
            this.Controls.Add(this.checkBoxAlkoholos);
            this.Controls.Add(this.labelAr);
            this.Controls.Add(this.labelTomeg);
            this.Controls.Add(this.labelKateg);
            this.Controls.Add(this.labelIz);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.numericUpDownAr);
            this.Controls.Add(this.numericUpDownTomeg);
            this.Controls.Add(this.textBoxIz);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.comboBoxKateg);
            this.Name = "FormAdatbevitel";
            this.Text = "Kerek csokoládé, szögletes csokoláde";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTomeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKateg;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxIz;
        private System.Windows.Forms.NumericUpDown numericUpDownTomeg;
        private System.Windows.Forms.NumericUpDown numericUpDownAr;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelIz;
        private System.Windows.Forms.Label labelKateg;
        private System.Windows.Forms.Label labelTomeg;
        private System.Windows.Forms.Label labelAr;
        private System.Windows.Forms.CheckBox checkBoxAlkoholos;
        private System.Windows.Forms.CheckBox checkBoxVegan;
        private System.Windows.Forms.Label labelEgyeb;
    }
}