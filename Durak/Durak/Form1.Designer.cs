namespace Durak
{
    partial class frmDurakGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDurakGame));
            this.cBoxDeckSelect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPlayer1 = new System.Windows.Forms.Panel();
            this.CBoxPlayers = new System.Windows.Forms.ComboBox();
            this.panelPlayer2 = new System.Windows.Forms.Panel();
            this.panelPlayZone = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxDeckSelect
            // 
            this.cBoxDeckSelect.FormattingEnabled = true;
            this.cBoxDeckSelect.Items.AddRange(new object[] {
            "20 Cards,",
            "36 Cards,",
            "52 Cards"});
            this.cBoxDeckSelect.Location = new System.Drawing.Point(30, 238);
            this.cBoxDeckSelect.Name = "cBoxDeckSelect";
            this.cBoxDeckSelect.Size = new System.Drawing.Size(121, 24);
            this.cBoxDeckSelect.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelPlayer1
            // 
            this.panelPlayer1.Location = new System.Drawing.Point(30, 425);
            this.panelPlayer1.Name = "panelPlayer1";
            this.panelPlayer1.Size = new System.Drawing.Size(879, 177);
            this.panelPlayer1.TabIndex = 2;
            // 
            // CBoxPlayers
            // 
            this.CBoxPlayers.FormattingEnabled = true;
            this.CBoxPlayers.Items.AddRange(new object[] {
            "1 Player ",
            "2 Player",
            "3 Player",
            "4 Player"});
            this.CBoxPlayers.Location = new System.Drawing.Point(185, 236);
            this.CBoxPlayers.Name = "CBoxPlayers";
            this.CBoxPlayers.Size = new System.Drawing.Size(121, 24);
            this.CBoxPlayers.TabIndex = 3;
            // 
            // panelPlayer2
            // 
            this.panelPlayer2.Location = new System.Drawing.Point(30, 12);
            this.panelPlayer2.Name = "panelPlayer2";
            this.panelPlayer2.Size = new System.Drawing.Size(879, 166);
            this.panelPlayer2.TabIndex = 4;
            // 
            // panelPlayZone
            // 
            this.panelPlayZone.Location = new System.Drawing.Point(326, 202);
            this.panelPlayZone.Name = "panelPlayZone";
            this.panelPlayZone.Size = new System.Drawing.Size(370, 198);
            this.panelPlayZone.TabIndex = 5;
            // 
            // btnDraw
            // 
            this.btnDraw.Image = ((System.Drawing.Image)(resources.GetObject("btnDraw.Image")));
            this.btnDraw.Location = new System.Drawing.Point(754, 184);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(155, 217);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // frmDurakGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(955, 631);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.panelPlayZone);
            this.Controls.Add(this.panelPlayer2);
            this.Controls.Add(this.CBoxPlayers);
            this.Controls.Add(this.panelPlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBoxDeckSelect);
            this.Name = "frmDurakGame";
            this.Text = "Durak";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxDeckSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPlayer1;
        private System.Windows.Forms.ComboBox CBoxPlayers;
        private System.Windows.Forms.Panel panelPlayer2;
        private System.Windows.Forms.Panel panelPlayZone;
        private System.Windows.Forms.Button btnDraw;
    }
}

