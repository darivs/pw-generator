namespace Password_Generator
{
    partial class ePassGen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ePassGen));
            this.bt_gen = new System.Windows.Forms.Button();
            this.cB_nums = new System.Windows.Forms.CheckBox();
            this.cB_scs = new System.Windows.Forms.CheckBox();
            this.cB_cc = new System.Windows.Forms.CheckBox();
            this.lB = new System.Windows.Forms.ListBox();
            this.bt_copy = new System.Windows.Forms.Button();
            this.tB_length = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_gen
            // 
            this.bt_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_gen.Location = new System.Drawing.Point(12, 197);
            this.bt_gen.Name = "bt_gen";
            this.bt_gen.Size = new System.Drawing.Size(161, 57);
            this.bt_gen.TabIndex = 0;
            this.bt_gen.Text = "Generate";
            this.bt_gen.UseVisualStyleBackColor = true;
            this.bt_gen.Click += new System.EventHandler(this.bt_gen_Click);
            // 
            // cB_nums
            // 
            this.cB_nums.AutoSize = true;
            this.cB_nums.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_nums.ForeColor = System.Drawing.Color.White;
            this.cB_nums.Location = new System.Drawing.Point(12, 82);
            this.cB_nums.Name = "cB_nums";
            this.cB_nums.Size = new System.Drawing.Size(119, 27);
            this.cB_nums.TabIndex = 2;
            this.cB_nums.Text = "Numbers";
            this.cB_nums.UseVisualStyleBackColor = true;
            // 
            // cB_scs
            // 
            this.cB_scs.AutoSize = true;
            this.cB_scs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_scs.ForeColor = System.Drawing.Color.White;
            this.cB_scs.Location = new System.Drawing.Point(12, 114);
            this.cB_scs.Name = "cB_scs";
            this.cB_scs.Size = new System.Drawing.Size(163, 27);
            this.cB_scs.TabIndex = 3;
            this.cB_scs.Text = "Special chars";
            this.cB_scs.UseVisualStyleBackColor = true;
            // 
            // cB_cc
            // 
            this.cB_cc.AutoSize = true;
            this.cB_cc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_cc.ForeColor = System.Drawing.Color.White;
            this.cB_cc.Location = new System.Drawing.Point(12, 146);
            this.cB_cc.Name = "cB_cc";
            this.cB_cc.Size = new System.Drawing.Size(156, 27);
            this.cB_cc.TabIndex = 4;
            this.cB_cc.Text = "Camel Case";
            this.cB_cc.UseVisualStyleBackColor = true;
            // 
            // lB
            // 
            this.lB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB.FormattingEnabled = true;
            this.lB.HorizontalScrollbar = true;
            this.lB.ItemHeight = 20;
            this.lB.Location = new System.Drawing.Point(184, 18);
            this.lB.Name = "lB";
            this.lB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lB.Size = new System.Drawing.Size(224, 304);
            this.lB.TabIndex = 5;
            // 
            // bt_copy
            // 
            this.bt_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_copy.Location = new System.Drawing.Point(94, 260);
            this.bt_copy.Name = "bt_copy";
            this.bt_copy.Size = new System.Drawing.Size(79, 57);
            this.bt_copy.TabIndex = 6;
            this.bt_copy.Text = "Copy";
            this.bt_copy.UseVisualStyleBackColor = true;
            this.bt_copy.Click += new System.EventHandler(this.bt_copy_Click);
            // 
            // tB_length
            // 
            this.tB_length.Location = new System.Drawing.Point(12, 41);
            this.tB_length.Name = "tB_length";
            this.tB_length.Size = new System.Drawing.Size(160, 22);
            this.tB_length.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Length";
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.Location = new System.Drawing.Point(13, 260);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 57);
            this.bt_clear.TabIndex = 9;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // ePassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(420, 332);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_length);
            this.Controls.Add(this.bt_copy);
            this.Controls.Add(this.lB);
            this.Controls.Add(this.cB_cc);
            this.Controls.Add(this.cB_scs);
            this.Controls.Add(this.cB_nums);
            this.Controls.Add(this.bt_gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ePassGen";
            this.Text = "ePassGen by exceble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_gen;
        private System.Windows.Forms.CheckBox cB_nums;
        private System.Windows.Forms.CheckBox cB_scs;
        private System.Windows.Forms.CheckBox cB_cc;
        private System.Windows.Forms.ListBox lB;
        private System.Windows.Forms.Button bt_copy;
        private System.Windows.Forms.TextBox tB_length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_clear;
    }
}

