namespace WindowsFormsApp1
{
    partial class staff_bookRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bookRoom_regPrice = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.bookRoom_clearBtn = new System.Windows.Forms.Button();
            this.bookRoom_bookBtn = new System.Windows.Forms.Button();
            this.bookRoom_total = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bookRoom_scheduleBtn = new System.Windows.Forms.Button();
            this.bookRoom_to = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.bookRoom_from = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.bookRoom_roomType = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bookRoom_roomName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bookRoom_status = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookRoom_roomID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bookRoom_imageView = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookRoom_imageView)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.bookRoom_regPrice);
            this.panel7.Controls.Add(this.label);
            this.panel7.Controls.Add(this.bookRoom_clearBtn);
            this.panel7.Controls.Add(this.bookRoom_bookBtn);
            this.panel7.Controls.Add(this.bookRoom_total);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.bookRoom_scheduleBtn);
            this.panel7.Controls.Add(this.bookRoom_to);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.bookRoom_from);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.bookRoom_roomType);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.bookRoom_roomName);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.bookRoom_status);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.bookRoom_roomID);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(740, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 556);
            this.panel7.TabIndex = 4;
            // 
            // bookRoom_regPrice
            // 
            this.bookRoom_regPrice.AutoSize = true;
            this.bookRoom_regPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_regPrice.Location = new System.Drawing.Point(104, 146);
            this.bookRoom_regPrice.Name = "bookRoom_regPrice";
            this.bookRoom_regPrice.Size = new System.Drawing.Size(32, 13);
            this.bookRoom_regPrice.TabIndex = 22;
            this.bookRoom_regPrice.Text = "0.00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 146);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 13);
            this.label.TabIndex = 21;
            this.label.Text = "Regular Price ($):";
            // 
            // bookRoom_clearBtn
            // 
            this.bookRoom_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.bookRoom_clearBtn.FlatAppearance.BorderSize = 0;
            this.bookRoom_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookRoom_clearBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_clearBtn.ForeColor = System.Drawing.Color.White;
            this.bookRoom_clearBtn.Location = new System.Drawing.Point(19, 500);
            this.bookRoom_clearBtn.Name = "bookRoom_clearBtn";
            this.bookRoom_clearBtn.Size = new System.Drawing.Size(282, 41);
            this.bookRoom_clearBtn.TabIndex = 20;
            this.bookRoom_clearBtn.Text = "Clear";
            this.bookRoom_clearBtn.UseVisualStyleBackColor = false;
            this.bookRoom_clearBtn.Click += new System.EventHandler(this.bookRoom_clearBtn_Click_1);
            // 
            // bookRoom_bookBtn
            // 
            this.bookRoom_bookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.bookRoom_bookBtn.FlatAppearance.BorderSize = 0;
            this.bookRoom_bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookRoom_bookBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_bookBtn.ForeColor = System.Drawing.Color.White;
            this.bookRoom_bookBtn.Location = new System.Drawing.Point(19, 379);
            this.bookRoom_bookBtn.Name = "bookRoom_bookBtn";
            this.bookRoom_bookBtn.Size = new System.Drawing.Size(282, 41);
            this.bookRoom_bookBtn.TabIndex = 18;
            this.bookRoom_bookBtn.Text = "Book";
            this.bookRoom_bookBtn.UseVisualStyleBackColor = false;
            this.bookRoom_bookBtn.Click += new System.EventHandler(this.bookRoom_bookBtn_Click);
            // 
            // bookRoom_total
            // 
            this.bookRoom_total.AutoSize = true;
            this.bookRoom_total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_total.Location = new System.Drawing.Point(175, 338);
            this.bookRoom_total.Name = "bookRoom_total";
            this.bookRoom_total.Size = new System.Drawing.Size(40, 19);
            this.bookRoom_total.TabIndex = 17;
            this.bookRoom_total.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 18);
            this.label15.TabIndex = 16;
            this.label15.Text = "Total Price($):";
            // 
            // bookRoom_scheduleBtn
            // 
            this.bookRoom_scheduleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.bookRoom_scheduleBtn.FlatAppearance.BorderSize = 0;
            this.bookRoom_scheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookRoom_scheduleBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_scheduleBtn.ForeColor = System.Drawing.Color.White;
            this.bookRoom_scheduleBtn.Location = new System.Drawing.Point(19, 265);
            this.bookRoom_scheduleBtn.Name = "bookRoom_scheduleBtn";
            this.bookRoom_scheduleBtn.Size = new System.Drawing.Size(282, 41);
            this.bookRoom_scheduleBtn.TabIndex = 15;
            this.bookRoom_scheduleBtn.Text = "Schedule Now";
            this.bookRoom_scheduleBtn.UseVisualStyleBackColor = false;
            this.bookRoom_scheduleBtn.Click += new System.EventHandler(this.bookRoom_scheduleBtn_Click);
            // 
            // bookRoom_to
            // 
            this.bookRoom_to.Location = new System.Drawing.Point(101, 228);
            this.bookRoom_to.Name = "bookRoom_to";
            this.bookRoom_to.Size = new System.Drawing.Size(200, 20);
            this.bookRoom_to.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "To Schedule:";
            // 
            // bookRoom_from
            // 
            this.bookRoom_from.Location = new System.Drawing.Point(101, 187);
            this.bookRoom_from.Name = "bookRoom_from";
            this.bookRoom_from.Size = new System.Drawing.Size(200, 20);
            this.bookRoom_from.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "From Schedule:";
            // 
            // bookRoom_roomType
            // 
            this.bookRoom_roomType.AutoSize = true;
            this.bookRoom_roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_roomType.Location = new System.Drawing.Point(104, 49);
            this.bookRoom_roomType.Name = "bookRoom_roomType";
            this.bookRoom_roomType.Size = new System.Drawing.Size(47, 13);
            this.bookRoom_roomType.TabIndex = 7;
            this.bookRoom_roomType.Text = "----------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Room Type:";
            // 
            // bookRoom_roomName
            // 
            this.bookRoom_roomName.AutoSize = true;
            this.bookRoom_roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_roomName.Location = new System.Drawing.Point(104, 83);
            this.bookRoom_roomName.Name = "bookRoom_roomName";
            this.bookRoom_roomName.Size = new System.Drawing.Size(47, 13);
            this.bookRoom_roomName.TabIndex = 5;
            this.bookRoom_roomName.Text = "----------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Room Name:";
            // 
            // bookRoom_status
            // 
            this.bookRoom_status.AutoSize = true;
            this.bookRoom_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_status.Location = new System.Drawing.Point(104, 116);
            this.bookRoom_status.Name = "bookRoom_status";
            this.bookRoom_status.Size = new System.Drawing.Size(47, 13);
            this.bookRoom_status.TabIndex = 3;
            this.bookRoom_status.Text = "----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Status:";
            // 
            // bookRoom_roomID
            // 
            this.bookRoom_roomID.AutoSize = true;
            this.bookRoom_roomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRoom_roomID.Location = new System.Drawing.Point(104, 16);
            this.bookRoom_roomID.Name = "bookRoom_roomID";
            this.bookRoom_roomID.Size = new System.Drawing.Size(47, 13);
            this.bookRoom_roomID.TabIndex = 1;
            this.bookRoom_roomID.Text = "----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room ID:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(24, 363);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(697, 218);
            this.panel6.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Controls.Add(this.bookRoom_imageView);
            this.panel8.Location = new System.Drawing.Point(16, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(652, 184);
            this.panel8.TabIndex = 0;
            // 
            // bookRoom_imageView
            // 
            this.bookRoom_imageView.Location = new System.Drawing.Point(0, 0);
            this.bookRoom_imageView.Name = "bookRoom_imageView";
            this.bookRoom_imageView.Size = new System.Drawing.Size(652, 184);
            this.bookRoom_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookRoom_imageView.TabIndex = 0;
            this.bookRoom_imageView.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(24, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(697, 317);
            this.panel5.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(652, 229);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Available Rooms";
            // 
            // staff_bookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "staff_bookRoom";
            this.Size = new System.Drawing.Size(1087, 605);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookRoom_imageView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bookRoom_clearBtn;
        private System.Windows.Forms.Button bookRoom_bookBtn;
        private System.Windows.Forms.Label bookRoom_total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bookRoom_scheduleBtn;
        private System.Windows.Forms.DateTimePicker bookRoom_to;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker bookRoom_from;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label bookRoom_roomType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label bookRoom_roomName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bookRoom_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bookRoom_roomID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox bookRoom_imageView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bookRoom_regPrice;
        private System.Windows.Forms.Label label;
    }
}
