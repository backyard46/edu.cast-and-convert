namespace CastDoubleToInt
{
    partial class CastDoubleToInt
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextResult1 = new System.Windows.Forms.TextBox();
            this.TextResult2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TextResult3 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TextResult4 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TextResult5 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ButtonCast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "2.1";
            // 
            // TextResult1
            // 
            this.TextResult1.Location = new System.Drawing.Point(112, 8);
            this.TextResult1.Name = "TextResult1";
            this.TextResult1.Size = new System.Drawing.Size(96, 27);
            this.TextResult1.TabIndex = 1;
            // 
            // TextResult2
            // 
            this.TextResult2.Location = new System.Drawing.Point(112, 40);
            this.TextResult2.Name = "TextResult2";
            this.TextResult2.Size = new System.Drawing.Size(96, 27);
            this.TextResult2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "2.6";
            // 
            // TextResult3
            // 
            this.TextResult3.Location = new System.Drawing.Point(112, 72);
            this.TextResult3.Name = "TextResult3";
            this.TextResult3.Size = new System.Drawing.Size(96, 27);
            this.TextResult3.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 27);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "2.9";
            // 
            // TextResult4
            // 
            this.TextResult4.Location = new System.Drawing.Point(112, 104);
            this.TextResult4.Name = "TextResult4";
            this.TextResult4.Size = new System.Drawing.Size(96, 27);
            this.TextResult4.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 27);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "-2.1";
            // 
            // TextResult5
            // 
            this.TextResult5.Location = new System.Drawing.Point(112, 136);
            this.TextResult5.Name = "TextResult5";
            this.TextResult5.Size = new System.Drawing.Size(96, 27);
            this.TextResult5.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 27);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "-2.9";
            // 
            // ButtonCast
            // 
            this.ButtonCast.Location = new System.Drawing.Point(224, 132);
            this.ButtonCast.Name = "ButtonCast";
            this.ButtonCast.Size = new System.Drawing.Size(112, 32);
            this.ButtonCast.TabIndex = 10;
            this.ButtonCast.Text = "変換実施";
            this.ButtonCast.UseVisualStyleBackColor = true;
            this.ButtonCast.Click += new System.EventHandler(this.ButtonCast_Click);
            // 
            // CastDoubleToInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 174);
            this.Controls.Add(this.ButtonCast);
            this.Controls.Add(this.TextResult5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.TextResult4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TextResult3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TextResult2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextResult1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CastDoubleToInt";
            this.Text = "ParseでIntにキャストする";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextResult1;
        private System.Windows.Forms.TextBox TextResult2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TextResult3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TextResult4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TextResult5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button ButtonCast;
    }
}

