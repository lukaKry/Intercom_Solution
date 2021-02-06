
namespace Domofon_WinForms
{
    partial class MainForm
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
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_Hash = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Star = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bsResidents = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResidents)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Display
            // 
            this.txt_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_Display.Location = new System.Drawing.Point(27, 28);
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.ReadOnly = true;
            this.txt_Display.Size = new System.Drawing.Size(212, 45);
            this.txt_Display.TabIndex = 0;
            this.txt_Display.TextChanged += new System.EventHandler(this.txt_Display_TextChanged);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_Hash);
            this.pnl_buttons.Controls.Add(this.btn_0);
            this.pnl_buttons.Controls.Add(this.btn_Star);
            this.pnl_buttons.Controls.Add(this.btn_9);
            this.pnl_buttons.Controls.Add(this.btn_8);
            this.pnl_buttons.Controls.Add(this.btn_7);
            this.pnl_buttons.Controls.Add(this.btn_6);
            this.pnl_buttons.Controls.Add(this.btn_5);
            this.pnl_buttons.Controls.Add(this.btn_4);
            this.pnl_buttons.Controls.Add(this.btn_3);
            this.pnl_buttons.Controls.Add(this.btn_2);
            this.pnl_buttons.Controls.Add(this.btn_1);
            this.pnl_buttons.Location = new System.Drawing.Point(28, 123);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(211, 281);
            this.pnl_buttons.TabIndex = 1;
            // 
            // btn_Hash
            // 
            this.btn_Hash.BackColor = System.Drawing.Color.White;
            this.btn_Hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Hash.Location = new System.Drawing.Point(141, 210);
            this.btn_Hash.Name = "btn_Hash";
            this.btn_Hash.Size = new System.Drawing.Size(63, 63);
            this.btn_Hash.TabIndex = 11;
            this.btn_Hash.Text = "#";
            this.btn_Hash.UseVisualStyleBackColor = false;
            this.btn_Hash.Click += new System.EventHandler(this.btn_Hash_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.White;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_0.Location = new System.Drawing.Point(72, 210);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(63, 63);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_Star
            // 
            this.btn_Star.BackColor = System.Drawing.Color.White;
            this.btn_Star.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Star.Location = new System.Drawing.Point(3, 210);
            this.btn_Star.Name = "btn_Star";
            this.btn_Star.Size = new System.Drawing.Size(63, 63);
            this.btn_Star.TabIndex = 9;
            this.btn_Star.Text = "*";
            this.btn_Star.UseVisualStyleBackColor = false;
            this.btn_Star.Click += new System.EventHandler(this.btn_Star_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.White;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_9.Location = new System.Drawing.Point(141, 141);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(63, 63);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.White;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_8.Location = new System.Drawing.Point(72, 141);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(63, 63);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.White;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_7.Location = new System.Drawing.Point(3, 141);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(63, 63);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.White;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_6.Location = new System.Drawing.Point(141, 72);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(63, 63);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.White;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_5.Location = new System.Drawing.Point(72, 72);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(63, 63);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.White;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_4.Location = new System.Drawing.Point(3, 72);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(63, 63);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.White;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_3.Location = new System.Drawing.Point(141, 3);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(63, 63);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.White;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_2.Location = new System.Drawing.Point(72, 3);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(63, 63);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_1.Location = new System.Drawing.Point(3, 3);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(63, 63);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.Location = new System.Drawing.Point(331, 418);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(139, 27);
            this.btn_Config.TabIndex = 3;
            this.btn_Config.Text = "Konfiguracja";
            this.btn_Config.UseVisualStyleBackColor = true;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(269, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 372);
            this.listBox1.TabIndex = 4;
            // 
            // bsResidents
            // 
            this.bsResidents.DataSource = typeof(Domofon_ClassLibrary.Apartment);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 456);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.txt_Display);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domofon";
            this.pnl_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsResidents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_Hash;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Star;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource bsResidents;
    }
}

