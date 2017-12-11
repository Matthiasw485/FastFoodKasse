namespace FastFoodKasse
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_customerpays = new System.Windows.Forms.Label();
            this.lbl_cashback = new System.Windows.Forms.Label();
            this.btn_rm_all = new MaterialSkin.Controls.MaterialFlatButton();
            this.calc_btn_0 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_checkout = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_rm_selected = new MaterialSkin.Controls.MaterialFlatButton();
            this.calc_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.calc_del = new MaterialSkin.Controls.MaterialRaisedButton();
            this.calc_btn_dot = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_costumer_pays = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // list_items
            // 
            this.list_items.FormattingEnabled = true;
            this.list_items.Location = new System.Drawing.Point(969, 94);
            this.list_items.Name = "list_items";
            this.list_items.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
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
            // btn_rm_all
            // 
            this.btn_rm_all.AutoSize = true;
            this.btn_rm_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_rm_all.Depth = 0;
            this.btn_rm_all.Location = new System.Drawing.Point(820, 361);
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
            this.calc_btn_0.Location = new System.Drawing.Point(973, 766);
            this.calc_btn_0.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_0.Name = "calc_btn_0";
            this.calc_btn_0.Primary = true;
            this.calc_btn_0.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_0.TabIndex = 13;
            this.calc_btn_0.Text = "0";
            this.calc_btn_0.UseVisualStyleBackColor = true;
            this.calc_btn_0.Click += new System.EventHandler(this.calc_btn_0_Click);
            // 
            // calc_btn_1
            // 
            this.calc_btn_1.Depth = 0;
            this.calc_btn_1.Location = new System.Drawing.Point(973, 710);
            this.calc_btn_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_1.Name = "calc_btn_1";
            this.calc_btn_1.Primary = true;
            this.calc_btn_1.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_1.TabIndex = 14;
            this.calc_btn_1.Text = "1";
            this.calc_btn_1.UseVisualStyleBackColor = true;
            this.calc_btn_1.Click += new System.EventHandler(this.calc_btn_1_Click);
            // 
            // calc_btn_4
            // 
            this.calc_btn_4.Depth = 0;
            this.calc_btn_4.Location = new System.Drawing.Point(973, 654);
            this.calc_btn_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_4.Name = "calc_btn_4";
            this.calc_btn_4.Primary = true;
            this.calc_btn_4.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_4.TabIndex = 15;
            this.calc_btn_4.Text = "4";
            this.calc_btn_4.UseVisualStyleBackColor = true;
            this.calc_btn_4.Click += new System.EventHandler(this.calc_btn_4_Click);
            // 
            // calc_btn_7
            // 
            this.calc_btn_7.Depth = 0;
            this.calc_btn_7.Location = new System.Drawing.Point(973, 598);
            this.calc_btn_7.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_7.Name = "calc_btn_7";
            this.calc_btn_7.Primary = true;
            this.calc_btn_7.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_7.TabIndex = 16;
            this.calc_btn_7.Text = "7";
            this.calc_btn_7.UseVisualStyleBackColor = true;
            this.calc_btn_7.Click += new System.EventHandler(this.calc_btn_7_Click);
            // 
            // calc_btn_8
            // 
            this.calc_btn_8.Depth = 0;
            this.calc_btn_8.Location = new System.Drawing.Point(1029, 598);
            this.calc_btn_8.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_8.Name = "calc_btn_8";
            this.calc_btn_8.Primary = true;
            this.calc_btn_8.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_8.TabIndex = 17;
            this.calc_btn_8.Text = "8";
            this.calc_btn_8.UseVisualStyleBackColor = true;
            this.calc_btn_8.Click += new System.EventHandler(this.calc_btn_8_Click);
            // 
            // calc_btn_9
            // 
            this.calc_btn_9.Depth = 0;
            this.calc_btn_9.Location = new System.Drawing.Point(1085, 598);
            this.calc_btn_9.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_9.Name = "calc_btn_9";
            this.calc_btn_9.Primary = true;
            this.calc_btn_9.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_9.TabIndex = 18;
            this.calc_btn_9.Text = "9";
            this.calc_btn_9.UseVisualStyleBackColor = true;
            this.calc_btn_9.Click += new System.EventHandler(this.calc_btn_9_Click);
            // 
            // calc_btn_5
            // 
            this.calc_btn_5.Depth = 0;
            this.calc_btn_5.Location = new System.Drawing.Point(1029, 654);
            this.calc_btn_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_5.Name = "calc_btn_5";
            this.calc_btn_5.Primary = true;
            this.calc_btn_5.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_5.TabIndex = 19;
            this.calc_btn_5.Text = "5";
            this.calc_btn_5.UseVisualStyleBackColor = true;
            this.calc_btn_5.Click += new System.EventHandler(this.calc_btn_5_Click);
            // 
            // calc_btn_6
            // 
            this.calc_btn_6.Depth = 0;
            this.calc_btn_6.Location = new System.Drawing.Point(1085, 654);
            this.calc_btn_6.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_6.Name = "calc_btn_6";
            this.calc_btn_6.Primary = true;
            this.calc_btn_6.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_6.TabIndex = 20;
            this.calc_btn_6.Text = "6";
            this.calc_btn_6.UseVisualStyleBackColor = true;
            this.calc_btn_6.Click += new System.EventHandler(this.calc_btn_6_Click);
            // 
            // calc_btn_2
            // 
            this.calc_btn_2.Depth = 0;
            this.calc_btn_2.Location = new System.Drawing.Point(1029, 710);
            this.calc_btn_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_2.Name = "calc_btn_2";
            this.calc_btn_2.Primary = true;
            this.calc_btn_2.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_2.TabIndex = 21;
            this.calc_btn_2.Text = "2";
            this.calc_btn_2.UseVisualStyleBackColor = true;
            this.calc_btn_2.Click += new System.EventHandler(this.calc_btn_2_Click);
            // 
            // calc_btn_3
            // 
            this.calc_btn_3.Depth = 0;
            this.calc_btn_3.Location = new System.Drawing.Point(1085, 710);
            this.calc_btn_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_3.Name = "calc_btn_3";
            this.calc_btn_3.Primary = true;
            this.calc_btn_3.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_3.TabIndex = 22;
            this.calc_btn_3.Text = "3";
            this.calc_btn_3.UseVisualStyleBackColor = true;
            this.calc_btn_3.Click += new System.EventHandler(this.calc_btn_3_Click);
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
            this.btn_checkout.Primary = true;
            this.btn_checkout.Size = new System.Drawing.Size(189, 36);
            this.btn_checkout.TabIndex = 24;
            this.btn_checkout.Text = "Bestellung abschließen";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_rm_selected
            // 
            this.btn_rm_selected.AutoSize = true;
            this.btn_rm_selected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_rm_selected.Depth = 0;
            this.btn_rm_selected.Location = new System.Drawing.Point(820, 313);
            this.btn_rm_selected.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_rm_selected.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_rm_selected.Name = "btn_rm_selected";
            this.btn_rm_selected.Primary = false;
            this.btn_rm_selected.Size = new System.Drawing.Size(142, 36);
            this.btn_rm_selected.TabIndex = 25;
            this.btn_rm_selected.Text = "Auswahl löschen";
            this.btn_rm_selected.UseVisualStyleBackColor = true;
            this.btn_rm_selected.Click += new System.EventHandler(this.btn_rm_selected_Click);
            // 
            // calc_txt
            // 
            this.calc_txt.Depth = 0;
            this.calc_txt.Hint = "";
            this.calc_txt.Location = new System.Drawing.Point(973, 569);
            this.calc_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_txt.Name = "calc_txt";
            this.calc_txt.PasswordChar = '\0';
            this.calc_txt.SelectedText = "";
            this.calc_txt.SelectionLength = 0;
            this.calc_txt.SelectionStart = 0;
            this.calc_txt.Size = new System.Drawing.Size(162, 23);
            this.calc_txt.TabIndex = 26;
            this.calc_txt.UseSystemPasswordChar = false;
            // 
            // calc_del
            // 
            this.calc_del.Depth = 0;
            this.calc_del.Location = new System.Drawing.Point(1085, 766);
            this.calc_del.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_del.Name = "calc_del";
            this.calc_del.Primary = true;
            this.calc_del.Size = new System.Drawing.Size(50, 50);
            this.calc_del.TabIndex = 27;
            this.calc_del.Text = "DEL";
            this.calc_del.UseVisualStyleBackColor = true;
            this.calc_del.Click += new System.EventHandler(this.calc_del_Click);
            // 
            // calc_btn_dot
            // 
            this.calc_btn_dot.Depth = 0;
            this.calc_btn_dot.Location = new System.Drawing.Point(1029, 766);
            this.calc_btn_dot.MouseState = MaterialSkin.MouseState.HOVER;
            this.calc_btn_dot.Name = "calc_btn_dot";
            this.calc_btn_dot.Primary = true;
            this.calc_btn_dot.Size = new System.Drawing.Size(50, 50);
            this.calc_btn_dot.TabIndex = 28;
            this.calc_btn_dot.Text = ".";
            this.calc_btn_dot.UseVisualStyleBackColor = true;
            this.calc_btn_dot.Click += new System.EventHandler(this.calc_btn_dot_Click);
            // 
            // btn_costumer_pays
            // 
            this.btn_costumer_pays.AutoSize = true;
            this.btn_costumer_pays.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_costumer_pays.Depth = 0;
            this.btn_costumer_pays.Location = new System.Drawing.Point(995, 519);
            this.btn_costumer_pays.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_costumer_pays.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_costumer_pays.Name = "btn_costumer_pays";
            this.btn_costumer_pays.Primary = false;
            this.btn_costumer_pays.Size = new System.Drawing.Size(119, 36);
            this.btn_costumer_pays.TabIndex = 29;
            this.btn_costumer_pays.Text = "Kunde bezahlt";
            this.btn_costumer_pays.UseVisualStyleBackColor = true;
            this.btn_costumer_pays.Click += new System.EventHandler(this.btn_costumer_pays_Click);
            // 
            // FastFoodKasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 826);
            this.Controls.Add(this.btn_costumer_pays);
            this.Controls.Add(this.calc_btn_dot);
            this.Controls.Add(this.calc_del);
            this.Controls.Add(this.calc_txt);
            this.Controls.Add(this.btn_rm_selected);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.calc_btn_3);
            this.Controls.Add(this.calc_btn_2);
            this.Controls.Add(this.calc_btn_6);
            this.Controls.Add(this.calc_btn_5);
            this.Controls.Add(this.calc_btn_9);
            this.Controls.Add(this.calc_btn_8);
            this.Controls.Add(this.calc_btn_7);
            this.Controls.Add(this.calc_btn_4);
            this.Controls.Add(this.calc_btn_1);
            this.Controls.Add(this.calc_btn_0);
            this.Controls.Add(this.btn_rm_all);
            this.Controls.Add(this.lbl_cashback);
            this.Controls.Add(this.lbl_customerpays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_customerpays;
        private System.Windows.Forms.Label lbl_cashback;
        private MaterialSkin.Controls.MaterialFlatButton btn_rm_all;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_0;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_1;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_4;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_7;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_8;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_9;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_5;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_6;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_2;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_3;
        private MaterialSkin.Controls.MaterialFlatButton btn_checkout;
        private MaterialSkin.Controls.MaterialFlatButton btn_rm_selected;
        private MaterialSkin.Controls.MaterialSingleLineTextField calc_txt;
        private MaterialSkin.Controls.MaterialRaisedButton calc_del;
        private MaterialSkin.Controls.MaterialRaisedButton calc_btn_dot;
        private MaterialSkin.Controls.MaterialFlatButton btn_costumer_pays;
    }
}

