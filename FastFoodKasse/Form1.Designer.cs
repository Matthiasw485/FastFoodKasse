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
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_showprice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_customerpays = new System.Windows.Forms.Label();
            this.lbl_cashback = new System.Windows.Forms.Label();
            this.btn_rm_selected = new System.Windows.Forms.Button();
            this.btn_rm_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_items
            // 
            this.list_items.FormattingEnabled = true;
            this.list_items.Location = new System.Drawing.Point(826, 103);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(180, 316);
            this.list_items.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aktuelle Bestellung:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zu zahlender Betrag:";
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(939, 422);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(10, 13);
            this.lbl_sum.TabIndex = 4;
            this.lbl_sum.Text = "-";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(826, 481);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(180, 58);
            this.btn_checkout.TabIndex = 5;
            this.btn_checkout.Text = "Bestellung abschließen";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_showprice
            // 
            this.btn_showprice.Location = new System.Drawing.Point(640, 481);
            this.btn_showprice.Name = "btn_showprice";
            this.btn_showprice.Size = new System.Drawing.Size(180, 58);
            this.btn_showprice.TabIndex = 6;
            this.btn_showprice.Text = "Kunde bezahlt";
            this.btn_showprice.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kunde gibt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rückgeld:";
            // 
            // lbl_customerpays
            // 
            this.lbl_customerpays.AutoSize = true;
            this.lbl_customerpays.Location = new System.Drawing.Point(939, 441);
            this.lbl_customerpays.Name = "lbl_customerpays";
            this.lbl_customerpays.Size = new System.Drawing.Size(10, 13);
            this.lbl_customerpays.TabIndex = 9;
            this.lbl_customerpays.Text = "-";
            // 
            // lbl_cashback
            // 
            this.lbl_cashback.AutoSize = true;
            this.lbl_cashback.Location = new System.Drawing.Point(939, 461);
            this.lbl_cashback.Name = "lbl_cashback";
            this.lbl_cashback.Size = new System.Drawing.Size(10, 13);
            this.lbl_cashback.TabIndex = 10;
            this.lbl_cashback.Text = "-";
            // 
            // btn_rm_selected
            // 
            this.btn_rm_selected.Location = new System.Drawing.Point(713, 142);
            this.btn_rm_selected.Name = "btn_rm_selected";
            this.btn_rm_selected.Size = new System.Drawing.Size(107, 51);
            this.btn_rm_selected.TabIndex = 11;
            this.btn_rm_selected.Text = "Ausgewählten löschen";
            this.btn_rm_selected.UseVisualStyleBackColor = true;
            this.btn_rm_selected.Click += new System.EventHandler(this.btn_rm_selected_Click);
            // 
            // btn_rm_all
            // 
            this.btn_rm_all.Location = new System.Drawing.Point(713, 264);
            this.btn_rm_all.Name = "btn_rm_all";
            this.btn_rm_all.Size = new System.Drawing.Size(107, 51);
            this.btn_rm_all.TabIndex = 12;
            this.btn_rm_all.Text = "Alles löschen";
            this.btn_rm_all.UseVisualStyleBackColor = true;
            this.btn_rm_all.Click += new System.EventHandler(this.btn_rm_all_Click);
            // 
            // FastFoodKasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 551);
            this.Controls.Add(this.btn_rm_all);
            this.Controls.Add(this.btn_rm_selected);
            this.Controls.Add(this.lbl_cashback);
            this.Controls.Add(this.lbl_customerpays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_showprice);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_items);
            this.Name = "FastFoodKasse";
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
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_showprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_customerpays;
        private System.Windows.Forms.Label lbl_cashback;
        private System.Windows.Forms.Button btn_rm_selected;
        private System.Windows.Forms.Button btn_rm_all;
    }
}

