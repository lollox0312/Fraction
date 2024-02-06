namespace Fraction
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.List1 = new System.Windows.Forms.ListBox();
            this.Tx1 = new System.Windows.Forms.TextBox();
            this.bta = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx2 = new System.Windows.Forms.TextBox();
            this.Tx3 = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.Location = new System.Drawing.Point(436, 187);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(120, 95);
            this.List1.TabIndex = 0;
            this.List1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Tx1
            // 
            this.Tx1.Location = new System.Drawing.Point(436, 152);
            this.Tx1.Name = "Tx1";
            this.Tx1.Size = new System.Drawing.Size(100, 20);
            this.Tx1.TabIndex = 1;
            // 
            // bta
            // 
            this.bta.Location = new System.Drawing.Point(580, 187);
            this.bta.Name = "bta";
            this.bta.Size = new System.Drawing.Size(75, 23);
            this.bta.TabIndex = 2;
            this.bta.Text = "Aggiungi";
            this.bta.UseVisualStyleBackColor = true;
            this.bta.Click += new System.EventHandler(this.bta_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(580, 217);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 3;
            this.btnP.Text = "Pulisci";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(580, 247);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "Somma";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Tx2
            // 
            this.Tx2.Location = new System.Drawing.Point(12, 39);
            this.Tx2.Name = "Tx2";
            this.Tx2.Size = new System.Drawing.Size(100, 20);
            this.Tx2.TabIndex = 6;
            // 
            // Tx3
            // 
            this.Tx3.Location = new System.Drawing.Point(13, 66);
            this.Tx3.Name = "Tx3";
            this.Tx3.Size = new System.Drawing.Size(100, 20);
            this.Tx3.TabIndex = 7;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(13, 93);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 23);
            this.Btn1.TabIndex = 8;
            this.Btn1.Text = "Somma";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Tx3);
            this.Controls.Add(this.Tx2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.bta);
            this.Controls.Add(this.Tx1);
            this.Controls.Add(this.List1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List1;
        private System.Windows.Forms.TextBox Tx1;
        private System.Windows.Forms.Button bta;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx2;
        private System.Windows.Forms.TextBox Tx3;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Label label2;
    }
}

