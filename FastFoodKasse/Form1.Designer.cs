﻿namespace FastFoodKasse
{
    partial class FastFoodKasse
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
            this.list_items = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.btn_showprice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_customerpays = new System.Windows.Forms.Label();
            this.lbl_cashback = new System.Windows.Forms.Label();
            this.btn_rm_selected = new System.Windows.Forms.Button();
            this.btn_rm_all = new MaterialSkin.Controls.MaterialFlatButton();
            this.calc_btn_0 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_checkout = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // list_items
            // 
            this.list_items.FormattingEnabled = true;
            this.list_items.Location = new System.Drawing.Point(969, 94);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(180, 303);
            this.list_items.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(970, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aktuelle Bestellung:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(970, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zu zahlender Betrag:";
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(1082, 413);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(10, 13);
            this.lbl_sum.TabIndex = 4;
            this.lbl_sum.Text = "-";
            // 
            // btn_showprice
            // 
            this.btn_showprice.Location = new System.Drawing.Point(969, 516);
            this.btn_showprice.Name = "btn_showprice";
            this.btn_showprice.Size = new System.Drawing.Size(180, 47);
            this.btn_showprice.TabIndex = 6;
            this.btn_showprice.Text = "Kunde bezahlt";
            this.btn_showprice.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(970, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kunde gibt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(970, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rückgeld:";
            // 
            // lbl_customerpays
            // 
            this.lbl_customerpays.AutoSize = true;
            this.lbl_customerpays.Location = new System.Drawing.Point(1082, 432);
            this.lbl_customerpays.Name = "lbl_customerpays";
            this.lbl_customerpays.Size = new System.Drawing.Size(10, 13);
            this.lbl_customerpays.TabIndex = 9;
            this.lbl_customerpays.Text = "-";
            // 
            // lbl_cashback
            // 
            this.lbl_cashback.AutoSize = true;
            this.lbl_cashback.Location = new System.Drawing.Point(1082, 452);
            this.lbl_cashback.Name = "lbl_cashback";
            this.lbl_cashback.Size = new System.Drawing.Size(10, 13);
            this.lbl_cashback.TabIndex = 10;
            this.lbl_cashback.Text = "-";
            // 
            // btn_rm_selected
            // 
            this.btn_rm_selected.Location = new System.Drawing.Point(856, 133);
            this.btn_rm_selected.Name = "btn_rm_selected";
            this.btn_rm_selected.Size = new System.Drawing.Size(107, 51);
            this.btn_rm_selected.TabIndex = 11;
            this.btn_rm_selected.Text = "Ausgewählten löschen";
            this.btn_rm_selected.UseVisualStyleBackColor = true;
            this.btn_rm_selected.Click += new System.EventHandler(this.btn_rm_selected_Click);
            // 
            // btn_rm_all
            // 
            this.btn_rm_all.AutoSize = true;
            this.btn_rm_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_rm_all.Depth = 0;
            this.btn_rm_all.Location = new System.Drawing.Point(845, 361);
            this.btn_rm_all.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_rm_all.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_rm_all.Name = "btn_rm_all";
            this.btn_rm_all.Primary = false;
            this.btn_rm_all.Size = new System.Drawing.Size(117, 36);
            this.btn_rm_all.TabIndex = 12;
            this.btn_rm_all.Text = "Alles Löschen";
            this.btn_rm_all.UseVisualStyleBackColor = true;
            this.btn_rm_all.Click += new System.EventHandler(this.btn_rm_all_Click);
            // 
            // calc_btn_0
            // 
            this.calc_btn_0.Depth = 0;
            this.calc_btn_0.Location = new System.Drawing.Point(846, 753);
            this.calc_btn_0.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_0.Name = "calc_btn_0";
            this.calc_btn_0.Primary = true;
            this.calc_btn_0.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_0.TabIndex = 13;
            this.calc_btn_0.Text = "0";
            this.calc_btn_0.UseVisualStyleBackColor = true;
            // 
            // calc_btn_1
            // 
            this.calc_btn_1.Depth = 0;
            this.calc_btn_1.Location = new System.Drawing.Point(846, 697);
            this.calc_btn_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_1.Name = "calc_btn_1";
            this.calc_btn_1.Primary = true;
            this.calc_btn_1.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_1.TabIndex = 14;
            this.calc_btn_1.Text = "1";
            this.calc_btn_1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(846, 641);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(50, 50);
            this.materialRaisedButton2.TabIndex = 15;
            this.materialRaisedButton2.Text = "4";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(846, 585);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(50, 50);
            this.materialRaisedButton3.TabIndex = 16;
            this.materialRaisedButton3.Text = "7";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(902, 585);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(50, 50);
            this.materialRaisedButton4.TabIndex = 17;
            this.materialRaisedButton4.Text = "8";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(958, 585);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(50, 50);
            this.materialRaisedButton5.TabIndex = 18;
            this.materialRaisedButton5.Text = "9";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Location = new System.Drawing.Point(902, 641);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(50, 50);
            this.materialRaisedButton6.TabIndex = 19;
            this.materialRaisedButton6.Text = "5";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Location = new System.Drawing.Point(958, 641);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(50, 50);
            this.materialRaisedButton7.TabIndex = 20;
            this.materialRaisedButton7.Text = "6";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Location = new System.Drawing.Point(902, 697);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(50, 50);
            this.materialRaisedButton8.TabIndex = 21;
            this.materialRaisedButton8.Text = "2";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton9
            // 
            this.materialRaisedButton9.Depth = 0;
            this.materialRaisedButton9.Location = new System.Drawing.Point(958, 697);
            this.materialRaisedButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton9.Name = "materialRaisedButton9";
            this.materialRaisedButton9.Primary = true;
            this.materialRaisedButton9.Size = new System.Drawing.Size(50, 50);
            this.materialRaisedButton9.TabIndex = 22;
            this.materialRaisedButton9.Text = "3";
            this.materialRaisedButton9.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(842, 563);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Rechner";
            // 
            // btn_checkout
            // 
            this.btn_checkout.AutoSize = true;
            this.btn_checkout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_checkout.Depth = 0;
            this.btn_checkout.Location = new System.Drawing.Point(960, 471);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_checkout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Primary = false;
            this.btn_checkout.Size = new System.Drawing.Size(189, 36);
            this.btn_checkout.TabIndex = 24;
            this.btn_checkout.Text = "Bestellung abschließen";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // FastFoodKasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 811);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton9);
            this.Controls.Add(this.materialRaisedButton8);
            this.Controls.Add(this.materialRaisedButton7);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.calc_btn_1);
            this.Controls.Add(this.calc_btn_0);
            this.Controls.Add(this.btn_rm_all);
            this.Controls.Add(this.btn_rm_selected);
            this.Controls.Add(this.lbl_cashback);
            this.Controls.Add(this.lbl_customerpays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_showprice);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_items);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FastFoodKasse";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kassensystem";
            this.Load += new System.EventHandler(this.FastFoodKasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox list_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Button btn_showprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_customerpays;
        private System.Windows.Forms.Label lbl_cashback;
        private System.Windows.Forms.Button btn_rm_selected;
        private MaterialSkin.Controls.MaterialFlatButton btn_rm_all;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_0;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton9;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btn_checkout;
    }
}

