
namespace Domofon_WinForms
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_Add = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.numUpDown_Number = new System.Windows.Forms.NumericUpDown();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.txt_RepeatCode = new System.Windows.Forms.TextBox();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.lbl_RepeatCode = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tbp_Modify = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDown_EditNumber = new System.Windows.Forms.NumericUpDown();
            this.txt_EditLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EditRepeatCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EditCode = new System.Windows.Forms.TextBox();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.tbp_Remove = new System.Windows.Forms.TabPage();
            this.btn_SaveAndClose = new System.Windows.Forms.Button();
            this.lbl_NumberOfResidents = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsApartments = new System.Windows.Forms.BindingSource(this.components);
            this.er_CodeRepeat = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_MinLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_MantadoryField = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_RemoveLastName = new System.Windows.Forms.Label();
            this.lbl_RemoveNumber = new System.Windows.Forms.Label();
            this.lbl_RemoveCode = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tbp_Add.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Number)).BeginInit();
            this.tbp_Modify.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_EditNumber)).BeginInit();
            this.tbp_Remove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsApartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_CodeRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_MinLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_MantadoryField)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_Add);
            this.tabControl1.Controls.Add(this.tbp_Modify);
            this.tabControl1.Controls.Add(this.tbp_Remove);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(16, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 309);
            this.tabControl1.TabIndex = 1;
            // 
            // tbp_Add
            // 
            this.tbp_Add.Controls.Add(this.groupBox1);
            this.tbp_Add.Controls.Add(this.btn_Add);
            this.tbp_Add.Location = new System.Drawing.Point(4, 29);
            this.tbp_Add.Name = "tbp_Add";
            this.tbp_Add.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Add.Size = new System.Drawing.Size(364, 276);
            this.tbp_Add.TabIndex = 0;
            this.tbp_Add.Text = " Dodaj ";
            this.tbp_Add.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_LastName);
            this.groupBox1.Controls.Add(this.numUpDown_Number);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.lbl_Number);
            this.groupBox1.Controls.Add(this.txt_RepeatCode);
            this.groupBox1.Controls.Add(this.lbl_Code);
            this.groupBox1.Controls.Add(this.lbl_RepeatCode);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 202);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane mieszkania";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(11, 39);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(67, 17);
            this.lbl_LastName.TabIndex = 0;
            this.lbl_LastName.Text = "Nazwisko";
            // 
            // numUpDown_Number
            // 
            this.numUpDown_Number.Location = new System.Drawing.Point(144, 78);
            this.numUpDown_Number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_Number.Name = "numUpDown_Number";
            this.numUpDown_Number.Size = new System.Drawing.Size(159, 22);
            this.numUpDown_Number.TabIndex = 9;
            this.numUpDown_Number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(144, 36);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(159, 22);
            this.txt_LastName.TabIndex = 1;
            this.txt_LastName.TextChanged += new System.EventHandler(this.txt_LastName_TextChanged);
            this.txt_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LastName_KeyPress);
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(11, 78);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(124, 17);
            this.lbl_Number.TabIndex = 2;
            this.lbl_Number.Text = "Numer mieszkania";
            // 
            // txt_RepeatCode
            // 
            this.txt_RepeatCode.Location = new System.Drawing.Point(144, 153);
            this.txt_RepeatCode.MaxLength = 4;
            this.txt_RepeatCode.Name = "txt_RepeatCode";
            this.txt_RepeatCode.Size = new System.Drawing.Size(159, 22);
            this.txt_RepeatCode.TabIndex = 7;
            this.txt_RepeatCode.TextChanged += new System.EventHandler(this.txt_RepeatCode_TextChanged);
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Location = new System.Drawing.Point(11, 117);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(33, 17);
            this.lbl_Code.TabIndex = 4;
            this.lbl_Code.Text = "Kod";
            // 
            // lbl_RepeatCode
            // 
            this.lbl_RepeatCode.AutoSize = true;
            this.lbl_RepeatCode.Location = new System.Drawing.Point(11, 156);
            this.lbl_RepeatCode.Name = "lbl_RepeatCode";
            this.lbl_RepeatCode.Size = new System.Drawing.Size(87, 17);
            this.lbl_RepeatCode.TabIndex = 6;
            this.lbl_RepeatCode.Text = "Powtórz Kod";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(144, 114);
            this.txt_Code.MaxLength = 4;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(159, 22);
            this.txt_Code.TabIndex = 5;
            this.txt_Code.TextChanged += new System.EventHandler(this.txt_Code_TextChanged);
            this.txt_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Code_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(236, 226);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 32);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Dodaj";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tbp_Modify
            // 
            this.tbp_Modify.Controls.Add(this.groupBox2);
            this.tbp_Modify.Controls.Add(this.btn_Modify);
            this.tbp_Modify.Location = new System.Drawing.Point(4, 29);
            this.tbp_Modify.Name = "tbp_Modify";
            this.tbp_Modify.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Modify.Size = new System.Drawing.Size(364, 276);
            this.tbp_Modify.TabIndex = 1;
            this.tbp_Modify.Text = " Edytuj ";
            this.tbp_Modify.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numUpDown_EditNumber);
            this.groupBox2.Controls.Add(this.txt_EditLastName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_EditRepeatCode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_EditCode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 202);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane mieszkania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwisko";
            // 
            // numUpDown_EditNumber
            // 
            this.numUpDown_EditNumber.Location = new System.Drawing.Point(144, 78);
            this.numUpDown_EditNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_EditNumber.Name = "numUpDown_EditNumber";
            this.numUpDown_EditNumber.Size = new System.Drawing.Size(159, 22);
            this.numUpDown_EditNumber.TabIndex = 9;
            this.numUpDown_EditNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_EditLastName
            // 
            this.txt_EditLastName.Location = new System.Drawing.Point(144, 36);
            this.txt_EditLastName.Name = "txt_EditLastName";
            this.txt_EditLastName.Size = new System.Drawing.Size(159, 22);
            this.txt_EditLastName.TabIndex = 1;
            this.txt_EditLastName.TextChanged += new System.EventHandler(this.txt_EditLastName_TextChanged);
            this.txt_EditLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EditLastName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numer mieszkania";
            // 
            // txt_EditRepeatCode
            // 
            this.txt_EditRepeatCode.Location = new System.Drawing.Point(144, 153);
            this.txt_EditRepeatCode.MaxLength = 4;
            this.txt_EditRepeatCode.Name = "txt_EditRepeatCode";
            this.txt_EditRepeatCode.Size = new System.Drawing.Size(159, 22);
            this.txt_EditRepeatCode.TabIndex = 7;
            this.txt_EditRepeatCode.TextChanged += new System.EventHandler(this.txt_EditRepeatCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Powtórz Kod";
            // 
            // txt_EditCode
            // 
            this.txt_EditCode.Location = new System.Drawing.Point(144, 114);
            this.txt_EditCode.MaxLength = 4;
            this.txt_EditCode.Name = "txt_EditCode";
            this.txt_EditCode.Size = new System.Drawing.Size(159, 22);
            this.txt_EditCode.TabIndex = 5;
            this.txt_EditCode.TextChanged += new System.EventHandler(this.txt_EditCode_TextChanged);
            this.txt_EditCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EditCode_KeyPress);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(236, 226);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(99, 32);
            this.btn_Modify.TabIndex = 11;
            this.btn_Modify.Text = "Edytuj";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // tbp_Remove
            // 
            this.tbp_Remove.Controls.Add(this.groupBox3);
            this.tbp_Remove.Controls.Add(this.btn_Remove);
            this.tbp_Remove.Location = new System.Drawing.Point(4, 29);
            this.tbp_Remove.Name = "tbp_Remove";
            this.tbp_Remove.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Remove.Size = new System.Drawing.Size(364, 276);
            this.tbp_Remove.TabIndex = 2;
            this.tbp_Remove.Text = " Usuń ";
            this.tbp_Remove.UseVisualStyleBackColor = true;
            // 
            // btn_SaveAndClose
            // 
            this.btn_SaveAndClose.Location = new System.Drawing.Point(649, 358);
            this.btn_SaveAndClose.Name = "btn_SaveAndClose";
            this.btn_SaveAndClose.Size = new System.Drawing.Size(122, 42);
            this.btn_SaveAndClose.TabIndex = 2;
            this.btn_SaveAndClose.Text = "Zapisz i wyjdź";
            this.btn_SaveAndClose.UseVisualStyleBackColor = true;
            this.btn_SaveAndClose.Click += new System.EventHandler(this.btn_SaveAndClose_Click);
            // 
            // lbl_NumberOfResidents
            // 
            this.lbl_NumberOfResidents.AutoSize = true;
            this.lbl_NumberOfResidents.Location = new System.Drawing.Point(638, 322);
            this.lbl_NumberOfResidents.Name = "lbl_NumberOfResidents";
            this.lbl_NumberOfResidents.Size = new System.Drawing.Size(120, 17);
            this.lbl_NumberOfResidents.TabIndex = 3;
            this.lbl_NumberOfResidents.Text = "Liczba mieszkań: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Number,
            this.col_LastName,
            this.col_Code});
            this.dataGridView1.DataSource = this.bsApartments;
            this.dataGridView1.Location = new System.Drawing.Point(413, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(358, 276);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // col_Number
            // 
            this.col_Number.DataPropertyName = "Number";
            this.col_Number.HeaderText = "Numer ";
            this.col_Number.MinimumWidth = 6;
            this.col_Number.Name = "col_Number";
            this.col_Number.ReadOnly = true;
            this.col_Number.ToolTipText = "Numer mieszkania";
            this.col_Number.Width = 60;
            // 
            // col_LastName
            // 
            this.col_LastName.DataPropertyName = "Resident";
            this.col_LastName.HeaderText = "Rezydent";
            this.col_LastName.MinimumWidth = 6;
            this.col_LastName.Name = "col_LastName";
            this.col_LastName.ReadOnly = true;
            this.col_LastName.ToolTipText = "Nazwisko";
            this.col_LastName.Width = 150;
            // 
            // col_Code
            // 
            this.col_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Code.DataPropertyName = "Code";
            this.col_Code.HeaderText = "Kod";
            this.col_Code.MinimumWidth = 6;
            this.col_Code.Name = "col_Code";
            this.col_Code.ReadOnly = true;
            this.col_Code.ToolTipText = "Kod pin";
            // 
            // bsApartments
            // 
            this.bsApartments.DataSource = typeof(Domofon_ClassLibrary.Apartment);
            // 
            // er_CodeRepeat
            // 
            this.er_CodeRepeat.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.er_CodeRepeat.ContainerControl = this;
            // 
            // er_MinLength
            // 
            this.er_MinLength.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.er_MinLength.ContainerControl = this;
            // 
            // er_MantadoryField
            // 
            this.er_MantadoryField.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.er_MantadoryField.ContainerControl = this;
            // 
            // lbl_RemoveLastName
            // 
            this.lbl_RemoveLastName.AutoSize = true;
            this.lbl_RemoveLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_RemoveLastName.Location = new System.Drawing.Point(11, 39);
            this.lbl_RemoveLastName.Name = "lbl_RemoveLastName";
            this.lbl_RemoveLastName.Size = new System.Drawing.Size(71, 17);
            this.lbl_RemoveLastName.TabIndex = 7;
            this.lbl_RemoveLastName.Text = "Nazwisko:";
            // 
            // lbl_RemoveNumber
            // 
            this.lbl_RemoveNumber.AutoSize = true;
            this.lbl_RemoveNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_RemoveNumber.Location = new System.Drawing.Point(11, 78);
            this.lbl_RemoveNumber.Name = "lbl_RemoveNumber";
            this.lbl_RemoveNumber.Size = new System.Drawing.Size(128, 17);
            this.lbl_RemoveNumber.TabIndex = 8;
            this.lbl_RemoveNumber.Text = "Numer mieszkania:";
            // 
            // lbl_RemoveCode
            // 
            this.lbl_RemoveCode.AutoSize = true;
            this.lbl_RemoveCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_RemoveCode.Location = new System.Drawing.Point(11, 117);
            this.lbl_RemoveCode.Name = "lbl_RemoveCode";
            this.lbl_RemoveCode.Size = new System.Drawing.Size(37, 17);
            this.lbl_RemoveCode.TabIndex = 9;
            this.lbl_RemoveCode.Text = "Kod:";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(236, 226);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(99, 32);
            this.btn_Remove.TabIndex = 10;
            this.btn_Remove.Text = "Usuń";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_RemoveLastName);
            this.groupBox3.Controls.Add(this.lbl_RemoveCode);
            this.groupBox3.Controls.Add(this.lbl_RemoveNumber);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 202);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane mieszkania";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 409);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_NumberOfResidents);
            this.Controls.Add(this.btn_SaveAndClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel administratora";
            this.tabControl1.ResumeLayout(false);
            this.tbp_Add.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Number)).EndInit();
            this.tbp_Modify.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_EditNumber)).EndInit();
            this.tbp_Remove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsApartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_CodeRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_MinLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_MantadoryField)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_Add;
        private System.Windows.Forms.TabPage tbp_Modify;
        private System.Windows.Forms.TabPage tbp_Remove;
        private System.Windows.Forms.Button btn_SaveAndClose;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_RepeatCode;
        private System.Windows.Forms.Label lbl_RepeatCode;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.NumericUpDown numUpDown_Number;
        private System.Windows.Forms.Label lbl_NumberOfResidents;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsApartments;
        private System.Windows.Forms.ErrorProvider er_CodeRepeat;
        private System.Windows.Forms.ErrorProvider er_MinLength;
        private System.Windows.Forms.ErrorProvider er_MantadoryField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDown_EditNumber;
        private System.Windows.Forms.TextBox txt_EditLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EditRepeatCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EditCode;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Code;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label lbl_RemoveLastName;
        private System.Windows.Forms.Label lbl_RemoveNumber;
        private System.Windows.Forms.Label lbl_RemoveCode;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}