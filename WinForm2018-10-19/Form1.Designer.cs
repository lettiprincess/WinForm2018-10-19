namespace WinForm2018_10_19
{
    partial class Form1
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
            this.nevLabel = new System.Windows.Forms.Label();
            this.szulDatumLabel = new System.Windows.Forms.Label();
            this.nemLabel = new System.Windows.Forms.Label();
            this.noRB = new System.Windows.Forms.RadioButton();
            this.ferfiRB = new System.Windows.Forms.RadioButton();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.nevTB = new System.Windows.Forms.TextBox();
            this.kedvencekLabel = new System.Windows.Forms.Label();
            this.ujakLabel = new System.Windows.Forms.Label();
            this.ujakTB = new System.Windows.Forms.TextBox();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.mentesButton = new System.Windows.Forms.Button();
            this.betoltButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.kedvencekLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nevLabel
            // 
            this.nevLabel.AutoSize = true;
            this.nevLabel.Location = new System.Drawing.Point(13, 17);
            this.nevLabel.Name = "nevLabel";
            this.nevLabel.Size = new System.Drawing.Size(37, 17);
            this.nevLabel.TabIndex = 0;
            this.nevLabel.Text = "Név:";
            // 
            // szulDatumLabel
            // 
            this.szulDatumLabel.AutoSize = true;
            this.szulDatumLabel.Location = new System.Drawing.Point(13, 46);
            this.szulDatumLabel.Name = "szulDatumLabel";
            this.szulDatumLabel.Size = new System.Drawing.Size(86, 17);
            this.szulDatumLabel.TabIndex = 1;
            this.szulDatumLabel.Text = "Szül. dátum:";
            // 
            // nemLabel
            // 
            this.nemLabel.AutoSize = true;
            this.nemLabel.Location = new System.Drawing.Point(13, 76);
            this.nemLabel.Name = "nemLabel";
            this.nemLabel.Size = new System.Drawing.Size(45, 17);
            this.nemLabel.TabIndex = 2;
            this.nemLabel.Text = "Nem: ";
            // 
            // noRB
            // 
            this.noRB.AutoSize = true;
            this.noRB.Location = new System.Drawing.Point(113, 72);
            this.noRB.Name = "noRB";
            this.noRB.Size = new System.Drawing.Size(47, 21);
            this.noRB.TabIndex = 3;
            this.noRB.TabStop = true;
            this.noRB.Text = "Nő";
            this.noRB.UseVisualStyleBackColor = true;
            this.noRB.CheckedChanged += new System.EventHandler(this.noRB_CheckedChanged);
            // 
            // ferfiRB
            // 
            this.ferfiRB.AutoSize = true;
            this.ferfiRB.Location = new System.Drawing.Point(176, 72);
            this.ferfiRB.Name = "ferfiRB";
            this.ferfiRB.Size = new System.Drawing.Size(57, 21);
            this.ferfiRB.TabIndex = 4;
            this.ferfiRB.TabStop = true;
            this.ferfiRB.Text = "Férfi";
            this.ferfiRB.UseVisualStyleBackColor = true;
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(113, 44);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(209, 22);
            this.DTP.TabIndex = 5;
            // 
            // nevTB
            // 
            this.nevTB.Location = new System.Drawing.Point(113, 17);
            this.nevTB.Name = "nevTB";
            this.nevTB.Size = new System.Drawing.Size(209, 22);
            this.nevTB.TabIndex = 6;
            // 
            // kedvencekLabel
            // 
            this.kedvencekLabel.AutoSize = true;
            this.kedvencekLabel.Location = new System.Drawing.Point(347, 17);
            this.kedvencekLabel.Name = "kedvencekLabel";
            this.kedvencekLabel.Size = new System.Drawing.Size(106, 17);
            this.kedvencekLabel.TabIndex = 7;
            this.kedvencekLabel.Text = "Kedvenc hobbi:";
            // 
            // ujakLabel
            // 
            this.ujakLabel.AutoSize = true;
            this.ujakLabel.Location = new System.Drawing.Point(258, 173);
            this.ujakLabel.Name = "ujakLabel";
            this.ujakLabel.Size = new System.Drawing.Size(64, 17);
            this.ujakLabel.TabIndex = 9;
            this.ujakLabel.Text = "Új hobbi:";
            // 
            // ujakTB
            // 
            this.ujakTB.Location = new System.Drawing.Point(350, 170);
            this.ujakTB.Name = "ujakTB";
            this.ujakTB.Size = new System.Drawing.Size(129, 22);
            this.ujakTB.TabIndex = 10;
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Location = new System.Drawing.Point(404, 201);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(75, 23);
            this.hozzaadButton.TabIndex = 11;
            this.hozzaadButton.Text = "Hozzáad";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            this.hozzaadButton.Click += new System.EventHandler(this.hozzaadButton_Click);
            // 
            // mentesButton
            // 
            this.mentesButton.Location = new System.Drawing.Point(308, 245);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(75, 23);
            this.mentesButton.TabIndex = 12;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = true;
            // 
            // betoltButton
            // 
            this.betoltButton.Location = new System.Drawing.Point(404, 245);
            this.betoltButton.Name = "betoltButton";
            this.betoltButton.Size = new System.Drawing.Size(75, 23);
            this.betoltButton.TabIndex = 13;
            this.betoltButton.Text = "Betölt";
            this.betoltButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // kedvencekLB
            // 
            this.kedvencekLB.FormattingEnabled = true;
            this.kedvencekLB.ItemHeight = 16;
            this.kedvencekLB.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.kedvencekLB.Location = new System.Drawing.Point(350, 46);
            this.kedvencekLB.Name = "kedvencekLB";
            this.kedvencekLB.Size = new System.Drawing.Size(129, 116);
            this.kedvencekLB.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 280);
            this.Controls.Add(this.kedvencekLB);
            this.Controls.Add(this.betoltButton);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.hozzaadButton);
            this.Controls.Add(this.ujakTB);
            this.Controls.Add(this.ujakLabel);
            this.Controls.Add(this.kedvencekLabel);
            this.Controls.Add(this.nevTB);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.ferfiRB);
            this.Controls.Add(this.noRB);
            this.Controls.Add(this.nemLabel);
            this.Controls.Add(this.szulDatumLabel);
            this.Controls.Add(this.nevLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nevLabel;
        private System.Windows.Forms.Label szulDatumLabel;
        private System.Windows.Forms.Label nemLabel;
        private System.Windows.Forms.RadioButton noRB;
        private System.Windows.Forms.RadioButton ferfiRB;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.TextBox nevTB;
        private System.Windows.Forms.Label kedvencekLabel;
        private System.Windows.Forms.Label ujakLabel;
        private System.Windows.Forms.TextBox ujakTB;
        private System.Windows.Forms.Button hozzaadButton;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Button betoltButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox kedvencekLB;
    }
}

