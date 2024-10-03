namespace VoteStatistic
{
    partial class Votes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtAParty = new System.Windows.Forms.Label();
            this.txtBParty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCParty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDParty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEParty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbnGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(91, 12);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(169, 26);
            this.txtCity.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 26);
            this.textBox2.TabIndex = 4;
            // 
            // txtAParty
            // 
            this.txtAParty.AutoSize = true;
            this.txtAParty.Location = new System.Drawing.Point(12, 47);
            this.txtAParty.Name = "txtAParty";
            this.txtAParty.Size = new System.Drawing.Size(56, 20);
            this.txtAParty.TabIndex = 3;
            this.txtAParty.Text = "AParty";
            // 
            // txtBParty
            // 
            this.txtBParty.Location = new System.Drawing.Point(91, 76);
            this.txtBParty.Name = "txtBParty";
            this.txtBParty.Size = new System.Drawing.Size(169, 26);
            this.txtBParty.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "BParty";
            // 
            // txtCParty
            // 
            this.txtCParty.Location = new System.Drawing.Point(91, 108);
            this.txtCParty.Name = "txtCParty";
            this.txtCParty.Size = new System.Drawing.Size(169, 26);
            this.txtCParty.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CParty";
            // 
            // txtDParty
            // 
            this.txtDParty.Location = new System.Drawing.Point(91, 140);
            this.txtDParty.Name = "txtDParty";
            this.txtDParty.Size = new System.Drawing.Size(169, 26);
            this.txtDParty.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "DParty";
            // 
            // txtEParty
            // 
            this.txtEParty.Location = new System.Drawing.Point(91, 172);
            this.txtEParty.Name = "txtEParty";
            this.txtEParty.Size = new System.Drawing.Size(169, 26);
            this.txtEParty.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "EParty";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 41);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Votes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbnGraph
            // 
            this.tbnGraph.Location = new System.Drawing.Point(16, 251);
            this.tbnGraph.Name = "tbnGraph";
            this.tbnGraph.Size = new System.Drawing.Size(244, 41);
            this.tbnGraph.TabIndex = 14;
            this.tbnGraph.Text = "Graphics";
            this.tbnGraph.UseVisualStyleBackColor = true;
            this.tbnGraph.Click += new System.EventHandler(this.tbnGraph_Click);
            // 
            // Votes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 299);
            this.Controls.Add(this.tbnGraph);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEParty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDParty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCParty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBParty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtAParty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Votes";
            this.Text = "Vote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtAParty;
        private System.Windows.Forms.TextBox txtBParty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDParty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEParty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button tbnGraph;
    }
}

