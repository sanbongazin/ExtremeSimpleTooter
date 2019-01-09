namespace WindowsFormsApplication1
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.HashTagOption = new System.Windows.Forms.TextBox();
            this.Toot_Input = new System.Windows.Forms.RichTextBox();
            this.Toot_Mode = new System.Windows.Forms.ComboBox();
            this.HashTag_Info = new System.Windows.Forms.Label();
            this.Last_Text = new System.Windows.Forms.Label();
            this.LastTextNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Location = new System.Drawing.Point(516, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "トゥート";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Toot_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(22, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 9;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(23, 326);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(0, 18);
            this.link.TabIndex = 10;
            // 
            // HashTagOption
            // 
            this.HashTagOption.Location = new System.Drawing.Point(25, 193);
            this.HashTagOption.Name = "HashTagOption";
            this.HashTagOption.Size = new System.Drawing.Size(477, 25);
            this.HashTagOption.TabIndex = 11;
            // 
            // Toot_Input
            // 
            this.Toot_Input.Location = new System.Drawing.Point(26, 13);
            this.Toot_Input.Name = "Toot_Input";
            this.Toot_Input.Size = new System.Drawing.Size(476, 143);
            this.Toot_Input.TabIndex = 12;
            this.Toot_Input.Text = "";
            this.Toot_Input.TextChanged += new System.EventHandler(this.Toot_Input_TextChanged);
            this.Toot_Input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Toot_Input_KeyUp);
            // 
            // Toot_Mode
            // 
            this.Toot_Mode.FormattingEnabled = true;
            this.Toot_Mode.Location = new System.Drawing.Point(509, 34);
            this.Toot_Mode.Name = "Toot_Mode";
            this.Toot_Mode.Size = new System.Drawing.Size(121, 26);
            this.Toot_Mode.TabIndex = 13;
            // 
            // HashTag_Info
            // 
            this.HashTag_Info.AutoSize = true;
            this.HashTag_Info.Location = new System.Drawing.Point(23, 172);
            this.HashTag_Info.Name = "HashTag_Info";
            this.HashTag_Info.Size = new System.Drawing.Size(444, 18);
            this.HashTag_Info.TabIndex = 14;
            this.HashTag_Info.Text = "ハッシュタグオプション（追跡可能な個人用タグを作成できます）";
            // 
            // Last_Text
            // 
            this.Last_Text.AutoSize = true;
            this.Last_Text.Location = new System.Drawing.Point(526, 133);
            this.Last_Text.Name = "Last_Text";
            this.Last_Text.Size = new System.Drawing.Size(37, 18);
            this.Last_Text.TabIndex = 15;
            this.Last_Text.Text = "残り";
            // 
            // LastTextNumber
            // 
            this.LastTextNumber.AutoSize = true;
            this.LastTextNumber.Location = new System.Drawing.Point(526, 151);
            this.LastTextNumber.Name = "LastTextNumber";
            this.LastTextNumber.Size = new System.Drawing.Size(35, 18);
            this.LastTextNumber.TabIndex = 16;
            this.LastTextNumber.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "文字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "公開範囲";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "フォントサイズ";
            // 
            // FontSize
            // 
            this.FontSize.FormattingEnabled = true;
            this.FontSize.Location = new System.Drawing.Point(508, 94);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(121, 26);
            this.FontSize.TabIndex = 20;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(654, 225);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastTextNumber);
            this.Controls.Add(this.Last_Text);
            this.Controls.Add(this.HashTag_Info);
            this.Controls.Add(this.Toot_Mode);
            this.Controls.Add(this.Toot_Input);
            this.Controls.Add(this.HashTagOption);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Name = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.TextBox HashTagOption;
        private System.Windows.Forms.RichTextBox Toot_Input;
        private System.Windows.Forms.ComboBox Toot_Mode;
        private System.Windows.Forms.Label HashTag_Info;
        private System.Windows.Forms.Label Last_Text;
        private System.Windows.Forms.Label LastTextNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FontSize;
    }
}

