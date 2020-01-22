namespace Weatherday
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lbxCity = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnMetric = new System.Windows.Forms.RadioButton();
            this.btnImperial = new System.Windows.Forms.RadioButton();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.grpBoxData = new System.Windows.Forms.GroupBox();
            this.checkBoxSset = new System.Windows.Forms.CheckBox();
            this.checkBoxSrise = new System.Windows.Forms.CheckBox();
            this.checkBoxClouds = new System.Windows.Forms.CheckBox();
            this.checkBoxPressure = new System.Windows.Forms.CheckBox();
            this.checkBoxWind = new System.Windows.Forms.CheckBox();
            this.checkBoxTemp = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkCapitol = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.grpBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(478, 219);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(397, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(478, 190);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnChk
            // 
            this.btnChk.Location = new System.Drawing.Point(397, 161);
            this.btnChk.Name = "btnChk";
            this.btnChk.Size = new System.Drawing.Size(156, 23);
            this.btnChk.TabIndex = 4;
            this.btnChk.Text = "Check Weather";
            this.btnChk.UseVisualStyleBackColor = true;
            this.btnChk.Click += new System.EventHandler(this.BtnChk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "City";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(353, 49);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(100, 20);
            this.tbxCountry.TabIndex = 9;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(353, 11);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(100, 20);
            this.tbxCity.TabIndex = 10;
            // 
            // lbxCity
            // 
            this.lbxCity.FormattingEnabled = true;
            this.lbxCity.Location = new System.Drawing.Point(12, 12);
            this.lbxCity.Name = "lbxCity";
            this.lbxCity.Size = new System.Drawing.Size(275, 264);
            this.lbxCity.TabIndex = 11;
            this.lbxCity.Click += new System.EventHandler(this.LbxCity_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(397, 249);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(156, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnMetric
            // 
            this.btnMetric.AutoSize = true;
            this.btnMetric.Checked = true;
            this.btnMetric.Location = new System.Drawing.Point(6, 18);
            this.btnMetric.Name = "btnMetric";
            this.btnMetric.Size = new System.Drawing.Size(54, 17);
            this.btnMetric.TabIndex = 13;
            this.btnMetric.TabStop = true;
            this.btnMetric.Text = "Metric";
            this.btnMetric.UseVisualStyleBackColor = true;
            // 
            // btnImperial
            // 
            this.btnImperial.AutoSize = true;
            this.btnImperial.Location = new System.Drawing.Point(6, 42);
            this.btnImperial.Name = "btnImperial";
            this.btnImperial.Size = new System.Drawing.Size(61, 17);
            this.btnImperial.TabIndex = 14;
            this.btnImperial.Text = "Imperial";
            this.btnImperial.UseVisualStyleBackColor = true;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.btnImperial);
            this.grpBox.Controls.Add(this.btnMetric);
            this.grpBox.Location = new System.Drawing.Point(464, 80);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(89, 74);
            this.grpBox.TabIndex = 15;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Units";
            // 
            // grpBoxData
            // 
            this.grpBoxData.Controls.Add(this.checkBoxSset);
            this.grpBoxData.Controls.Add(this.checkBoxSrise);
            this.grpBoxData.Controls.Add(this.checkBoxClouds);
            this.grpBoxData.Controls.Add(this.checkBoxPressure);
            this.grpBoxData.Controls.Add(this.checkBoxWind);
            this.grpBoxData.Controls.Add(this.checkBoxTemp);
            this.grpBoxData.Location = new System.Drawing.Point(293, 118);
            this.grpBoxData.Name = "grpBoxData";
            this.grpBoxData.Size = new System.Drawing.Size(98, 158);
            this.grpBoxData.TabIndex = 16;
            this.grpBoxData.TabStop = false;
            this.grpBoxData.Text = "Select Data";
            // 
            // checkBoxSset
            // 
            this.checkBoxSset.AutoSize = true;
            this.checkBoxSset.Location = new System.Drawing.Point(12, 135);
            this.checkBoxSset.Name = "checkBoxSset";
            this.checkBoxSset.Size = new System.Drawing.Size(59, 17);
            this.checkBoxSset.TabIndex = 5;
            this.checkBoxSset.Text = "Sunset";
            this.checkBoxSset.UseVisualStyleBackColor = true;
            // 
            // checkBoxSrise
            // 
            this.checkBoxSrise.AutoSize = true;
            this.checkBoxSrise.Location = new System.Drawing.Point(12, 112);
            this.checkBoxSrise.Name = "checkBoxSrise";
            this.checkBoxSrise.Size = new System.Drawing.Size(61, 17);
            this.checkBoxSrise.TabIndex = 4;
            this.checkBoxSrise.Text = "Sunrise";
            this.checkBoxSrise.UseVisualStyleBackColor = true;
            // 
            // checkBoxClouds
            // 
            this.checkBoxClouds.AutoSize = true;
            this.checkBoxClouds.Location = new System.Drawing.Point(12, 89);
            this.checkBoxClouds.Name = "checkBoxClouds";
            this.checkBoxClouds.Size = new System.Drawing.Size(58, 17);
            this.checkBoxClouds.TabIndex = 3;
            this.checkBoxClouds.Text = "Clouds";
            this.checkBoxClouds.UseVisualStyleBackColor = true;
            // 
            // checkBoxPressure
            // 
            this.checkBoxPressure.AutoSize = true;
            this.checkBoxPressure.Location = new System.Drawing.Point(12, 66);
            this.checkBoxPressure.Name = "checkBoxPressure";
            this.checkBoxPressure.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPressure.TabIndex = 2;
            this.checkBoxPressure.Text = "Pressure";
            this.checkBoxPressure.UseVisualStyleBackColor = true;
            // 
            // checkBoxWind
            // 
            this.checkBoxWind.AutoSize = true;
            this.checkBoxWind.Location = new System.Drawing.Point(12, 43);
            this.checkBoxWind.Name = "checkBoxWind";
            this.checkBoxWind.Size = new System.Drawing.Size(51, 17);
            this.checkBoxWind.TabIndex = 1;
            this.checkBoxWind.Text = "Wind";
            this.checkBoxWind.UseVisualStyleBackColor = true;
            // 
            // checkBoxTemp
            // 
            this.checkBoxTemp.AutoSize = true;
            this.checkBoxTemp.Checked = true;
            this.checkBoxTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTemp.Location = new System.Drawing.Point(12, 19);
            this.checkBoxTemp.Name = "checkBoxTemp";
            this.checkBoxTemp.Size = new System.Drawing.Size(86, 17);
            this.checkBoxTemp.TabIndex = 0;
            this.checkBoxTemp.Text = "Temperature";
            this.checkBoxTemp.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(397, 138);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(70, 17);
            this.chkAll.TabIndex = 17;
            this.chkAll.Text = "Select All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // chkCapitol
            // 
            this.chkCapitol.AutoSize = true;
            this.chkCapitol.Location = new System.Drawing.Point(470, 14);
            this.chkCapitol.Name = "chkCapitol";
            this.chkCapitol.Size = new System.Drawing.Size(78, 17);
            this.chkCapitol.TabIndex = 18;
            this.chkCapitol.Text = "Capitol City";
            this.chkCapitol.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(353, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 288);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkCapitol);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.grpBoxData);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbxCity);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChk);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Weatherday";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.grpBoxData.ResumeLayout(false);
            this.grpBoxData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnChk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.ListBox lbxCity;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton btnMetric;
        private System.Windows.Forms.RadioButton btnImperial;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.GroupBox grpBoxData;
        private System.Windows.Forms.CheckBox checkBoxSset;
        private System.Windows.Forms.CheckBox checkBoxSrise;
        private System.Windows.Forms.CheckBox checkBoxClouds;
        private System.Windows.Forms.CheckBox checkBoxPressure;
        private System.Windows.Forms.CheckBox checkBoxWind;
        private System.Windows.Forms.CheckBox checkBoxTemp;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkCapitol;
        private System.Windows.Forms.Button btnClear;
    }
}

