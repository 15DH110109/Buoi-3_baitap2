namespace Bai_2__oan_tu_xi__Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnBua = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your selection";
            // 
            // txtSelect
            // 
            this.txtSelect.Enabled = false;
            this.txtSelect.Location = new System.Drawing.Point(146, 40);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(163, 22);
            this.txtSelect.TabIndex = 1;
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(61, 113);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(98, 58);
            this.btnBua.TabIndex = 2;
            this.btnBua.Text = "Búa ";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(146, 214);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(163, 22);
            this.txtResult.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Result";
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(211, 113);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(98, 58);
            this.btnKeo.TabIndex = 7;
            this.btnKeo.Text = "Kéo ";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(354, 113);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(98, 58);
            this.btnBao.TabIndex = 8;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 296);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.TextBox textBox1;
    }
}

