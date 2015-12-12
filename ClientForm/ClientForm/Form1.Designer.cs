namespace ClientForm
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
            this.Txt_FriendAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_BitDepth = new System.Windows.Forms.ComboBox();
            this.Cmb_BitRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_CallFriend = new System.Windows.Forms.Button();
            this.Cmb_InputDevices = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Friend IP Address";
            // 
            // Txt_FriendAddress
            // 
            this.Txt_FriendAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_FriendAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FriendAddress.Location = new System.Drawing.Point(135, 5);
            this.Txt_FriendAddress.Name = "Txt_FriendAddress";
            this.Txt_FriendAddress.Size = new System.Drawing.Size(137, 22);
            this.Txt_FriendAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bit Depth";
            // 
            // Cmb_BitDepth
            // 
            this.Cmb_BitDepth.FormattingEnabled = true;
            this.Cmb_BitDepth.Items.AddRange(new object[] {
            "16",
            "24"});
            this.Cmb_BitDepth.Location = new System.Drawing.Point(135, 33);
            this.Cmb_BitDepth.Name = "Cmb_BitDepth";
            this.Cmb_BitDepth.Size = new System.Drawing.Size(137, 21);
            this.Cmb_BitDepth.TabIndex = 3;
            // 
            // Cmb_BitRate
            // 
            this.Cmb_BitRate.FormattingEnabled = true;
            this.Cmb_BitRate.Items.AddRange(new object[] {
            "1000",
            "2000",
            "4000",
            "8000",
            "11025",
            "22050",
            "32000",
            "44100",
            "48000",
            "64000",
            "88200",
            "96000"});
            this.Cmb_BitRate.Location = new System.Drawing.Point(135, 60);
            this.Cmb_BitRate.Name = "Cmb_BitRate";
            this.Cmb_BitRate.Size = new System.Drawing.Size(137, 21);
            this.Cmb_BitRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bit Rate";
            // 
            // Btn_CallFriend
            // 
            this.Btn_CallFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CallFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CallFriend.Location = new System.Drawing.Point(12, 114);
            this.Btn_CallFriend.Name = "Btn_CallFriend";
            this.Btn_CallFriend.Size = new System.Drawing.Size(260, 23);
            this.Btn_CallFriend.TabIndex = 6;
            this.Btn_CallFriend.Text = "Call Friend";
            this.Btn_CallFriend.UseVisualStyleBackColor = true;
            this.Btn_CallFriend.Click += new System.EventHandler(this.Btn_CallFriend_Click);
            // 
            // Cmb_InputDevices
            // 
            this.Cmb_InputDevices.FormattingEnabled = true;
            this.Cmb_InputDevices.Location = new System.Drawing.Point(135, 87);
            this.Cmb_InputDevices.Name = "Cmb_InputDevices";
            this.Cmb_InputDevices.Size = new System.Drawing.Size(137, 21);
            this.Cmb_InputDevices.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Microphone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_InputDevices);
            this.Controls.Add(this.Btn_CallFriend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cmb_BitRate);
            this.Controls.Add(this.Cmb_BitDepth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_FriendAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_FriendAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_BitDepth;
        private System.Windows.Forms.ComboBox Cmb_BitRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_CallFriend;
        private System.Windows.Forms.ComboBox Cmb_InputDevices;
        private System.Windows.Forms.Label label4;
    }
}

