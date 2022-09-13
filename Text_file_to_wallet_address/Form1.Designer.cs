
namespace Text_file_to_wallet_address
{
    partial class main
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
            this.results = new System.Windows.Forms.RichTextBox();
            this.load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wallets = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.breaker = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(33, 163);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(402, 269);
            this.results.TabIndex = 0;
            this.results.Text = "";
            // 
            // load
            // 
            this.load.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.load.FlatAppearance.BorderSize = 2;
            this.load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.Color.Crimson;
            this.load.Location = new System.Drawing.Point(33, 34);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(224, 53);
            this.load.TabIndex = 1;
            this.load.Text = "Load Text File";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wallets :";
            // 
            // wallets
            // 
            this.wallets.AutoSize = true;
            this.wallets.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallets.ForeColor = System.Drawing.Color.Green;
            this.wallets.Location = new System.Drawing.Point(412, 49);
            this.wallets.Name = "wallets";
            this.wallets.Size = new System.Drawing.Size(23, 23);
            this.wallets.TabIndex = 3;
            this.wallets.Text = "0";
            // 
            // start
            // 
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.start.FlatAppearance.BorderSize = 2;
            this.start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Crimson;
            this.start.Location = new System.Drawing.Point(33, 451);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(185, 53);
            this.start.TabIndex = 4;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // copy
            // 
            this.copy.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.copy.FlatAppearance.BorderSize = 2;
            this.copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.ForeColor = System.Drawing.Color.Crimson;
            this.copy.Location = new System.Drawing.Point(254, 451);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(181, 53);
            this.copy.TabIndex = 5;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Break character :";
            // 
            // breaker
            // 
            this.breaker.Location = new System.Drawing.Point(277, 114);
            this.breaker.Name = "breaker";
            this.breaker.Size = new System.Drawing.Size(158, 20);
            this.breaker.TabIndex = 7;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(465, 540);
            this.Controls.Add(this.breaker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.start);
            this.Controls.Add(this.wallets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.results);
            this.Name = "main";
            this.Text = "Text File to wallet address";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wallets;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox breaker;
    }
}

