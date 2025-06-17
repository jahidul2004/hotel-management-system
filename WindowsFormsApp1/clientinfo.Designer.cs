namespace WindowsFormsApp1
{
    partial class clientinfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.client_clearBtn = new System.Windows.Forms.Button();
            this.client_bookBtn = new System.Windows.Forms.Button();
            this.client_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.client_gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.client_contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.client_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.client_fullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.client_bookID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 38);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(786, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Client\'s Information";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1258, 10);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(17, 16);
            this.close.TabIndex = 11;
            this.close.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.client_clearBtn);
            this.panel2.Controls.Add(this.client_bookBtn);
            this.panel2.Controls.Add(this.client_address);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.client_gender);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.client_contact);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.client_email);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.client_fullName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.client_bookID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 459);
            this.panel2.TabIndex = 5;
            // 
            // client_clearBtn
            // 
            this.client_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.client_clearBtn.FlatAppearance.BorderSize = 0;
            this.client_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_clearBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_clearBtn.ForeColor = System.Drawing.Color.White;
            this.client_clearBtn.Location = new System.Drawing.Point(457, 364);
            this.client_clearBtn.Name = "client_clearBtn";
            this.client_clearBtn.Size = new System.Drawing.Size(253, 43);
            this.client_clearBtn.TabIndex = 15;
            this.client_clearBtn.Text = "Clear";
            this.client_clearBtn.UseVisualStyleBackColor = false;
            this.client_clearBtn.Click += new System.EventHandler(this.client_clearBtn_Click);
            // 
            // client_bookBtn
            // 
            this.client_bookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.client_bookBtn.FlatAppearance.BorderSize = 0;
            this.client_bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_bookBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_bookBtn.ForeColor = System.Drawing.Color.White;
            this.client_bookBtn.Location = new System.Drawing.Point(144, 364);
            this.client_bookBtn.Name = "client_bookBtn";
            this.client_bookBtn.Size = new System.Drawing.Size(253, 43);
            this.client_bookBtn.TabIndex = 14;
            this.client_bookBtn.Text = "Book Now";
            this.client_bookBtn.UseVisualStyleBackColor = false;
            this.client_bookBtn.Click += new System.EventHandler(this.client_bookBtn_Click);
            // 
            // client_address
            // 
            this.client_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_address.Location = new System.Drawing.Point(513, 182);
            this.client_address.Multiline = true;
            this.client_address.Name = "client_address";
            this.client_address.Size = new System.Drawing.Size(178, 72);
            this.client_address.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address:";
            // 
            // client_gender
            // 
            this.client_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_gender.FormattingEnabled = true;
            this.client_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.client_gender.Location = new System.Drawing.Point(513, 131);
            this.client_gender.Name = "client_gender";
            this.client_gender.Size = new System.Drawing.Size(178, 24);
            this.client_gender.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Gender:";
            // 
            // client_contact
            // 
            this.client_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_contact.Location = new System.Drawing.Point(210, 234);
            this.client_contact.Name = "client_contact";
            this.client_contact.Size = new System.Drawing.Size(171, 22);
            this.client_contact.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact Number:";
            // 
            // client_email
            // 
            this.client_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_email.Location = new System.Drawing.Point(210, 181);
            this.client_email.Name = "client_email";
            this.client_email.Size = new System.Drawing.Size(171, 22);
            this.client_email.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email Address:";
            // 
            // client_fullName
            // 
            this.client_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_fullName.Location = new System.Drawing.Point(210, 131);
            this.client_fullName.Name = "client_fullName";
            this.client_fullName.Size = new System.Drawing.Size(171, 22);
            this.client_fullName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Full Name:";
            // 
            // client_bookID
            // 
            this.client_bookID.AutoSize = true;
            this.client_bookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_bookID.Location = new System.Drawing.Point(208, 86);
            this.client_bookID.Name = "client_bookID";
            this.client_bookID.Size = new System.Drawing.Size(61, 15);
            this.client_bookID.TabIndex = 1;
            this.client_bookID.Text = "Book ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book ID:";
            // 
            // clientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientinfo";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox client_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox client_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox client_contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox client_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox client_fullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label client_bookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button client_clearBtn;
        private System.Windows.Forms.Button client_bookBtn;
    }
}