namespace WindowsFormsApp1
{
    partial class admin_rooms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rooms_clearBtn = new System.Windows.Forms.Button();
            this.rooms_deleteBtn = new System.Windows.Forms.Button();
            this.rooms_updateBtn = new System.Windows.Forms.Button();
            this.rooms_addBtn = new System.Windows.Forms.Button();
            this.rooms_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rooms_picture = new System.Windows.Forms.PictureBox();
            this.rooms_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rooms_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rooms_roomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rooms_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rooms_roomID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(24, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 332);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room\'s Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(995, 262);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rooms_clearBtn);
            this.panel2.Controls.Add(this.rooms_deleteBtn);
            this.panel2.Controls.Add(this.rooms_updateBtn);
            this.panel2.Controls.Add(this.rooms_addBtn);
            this.panel2.Controls.Add(this.rooms_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rooms_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rooms_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rooms_roomName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rooms_type);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rooms_roomID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 228);
            this.panel2.TabIndex = 1;
            // 
            // rooms_clearBtn
            // 
            this.rooms_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_clearBtn.FlatAppearance.BorderSize = 0;
            this.rooms_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_clearBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_clearBtn.ForeColor = System.Drawing.Color.White;
            this.rooms_clearBtn.Location = new System.Drawing.Point(521, 180);
            this.rooms_clearBtn.Name = "rooms_clearBtn";
            this.rooms_clearBtn.Size = new System.Drawing.Size(105, 33);
            this.rooms_clearBtn.TabIndex = 16;
            this.rooms_clearBtn.Text = "Clear";
            this.rooms_clearBtn.UseVisualStyleBackColor = false;
            this.rooms_clearBtn.Click += new System.EventHandler(this.rooms_clearBtn_Click);
            // 
            // rooms_deleteBtn
            // 
            this.rooms_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            this.rooms_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_deleteBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.rooms_deleteBtn.Location = new System.Drawing.Point(389, 180);
            this.rooms_deleteBtn.Name = "rooms_deleteBtn";
            this.rooms_deleteBtn.Size = new System.Drawing.Size(105, 33);
            this.rooms_deleteBtn.TabIndex = 15;
            this.rooms_deleteBtn.Text = "Delete";
            this.rooms_deleteBtn.UseVisualStyleBackColor = false;
            this.rooms_deleteBtn.Click += new System.EventHandler(this.rooms_deleteBtn_Click);
            // 
            // rooms_updateBtn
            // 
            this.rooms_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_updateBtn.FlatAppearance.BorderSize = 0;
            this.rooms_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_updateBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_updateBtn.ForeColor = System.Drawing.Color.White;
            this.rooms_updateBtn.Location = new System.Drawing.Point(256, 180);
            this.rooms_updateBtn.Name = "rooms_updateBtn";
            this.rooms_updateBtn.Size = new System.Drawing.Size(105, 33);
            this.rooms_updateBtn.TabIndex = 14;
            this.rooms_updateBtn.Text = "Update";
            this.rooms_updateBtn.UseVisualStyleBackColor = false;
            this.rooms_updateBtn.Click += new System.EventHandler(this.rooms_updateBtn_Click);
            // 
            // rooms_addBtn
            // 
            this.rooms_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_addBtn.FlatAppearance.BorderSize = 0;
            this.rooms_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_addBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_addBtn.ForeColor = System.Drawing.Color.White;
            this.rooms_addBtn.Location = new System.Drawing.Point(124, 180);
            this.rooms_addBtn.Name = "rooms_addBtn";
            this.rooms_addBtn.Size = new System.Drawing.Size(105, 33);
            this.rooms_addBtn.TabIndex = 13;
            this.rooms_addBtn.Text = "Add";
            this.rooms_addBtn.UseVisualStyleBackColor = false;
            this.rooms_addBtn.Click += new System.EventHandler(this.rooms_addBtn_Click);
            // 
            // rooms_importBtn
            // 
            this.rooms_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.rooms_importBtn.FlatAppearance.BorderSize = 0;
            this.rooms_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_importBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_importBtn.ForeColor = System.Drawing.Color.White;
            this.rooms_importBtn.Location = new System.Drawing.Point(906, 152);
            this.rooms_importBtn.Name = "rooms_importBtn";
            this.rooms_importBtn.Size = new System.Drawing.Size(105, 33);
            this.rooms_importBtn.TabIndex = 12;
            this.rooms_importBtn.Text = "Import";
            this.rooms_importBtn.UseVisualStyleBackColor = false;
            this.rooms_importBtn.Click += new System.EventHandler(this.rooms_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.rooms_picture);
            this.panel3.Location = new System.Drawing.Point(906, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 117);
            this.panel3.TabIndex = 11;
            // 
            // rooms_picture
            // 
            this.rooms_picture.Location = new System.Drawing.Point(0, 0);
            this.rooms_picture.Name = "rooms_picture";
            this.rooms_picture.Size = new System.Drawing.Size(105, 117);
            this.rooms_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rooms_picture.TabIndex = 0;
            this.rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            this.rooms_status.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_status.FormattingEnabled = true;
            this.rooms_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Occupied"});
            this.rooms_status.Location = new System.Drawing.Point(440, 79);
            this.rooms_status.Name = "rooms_status";
            this.rooms_status.Size = new System.Drawing.Size(186, 29);
            this.rooms_status.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status:";
            // 
            // rooms_price
            // 
            this.rooms_price.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_price.Location = new System.Drawing.Point(440, 28);
            this.rooms_price.Name = "rooms_price";
            this.rooms_price.Size = new System.Drawing.Size(186, 29);
            this.rooms_price.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price ($):";
            // 
            // rooms_roomName
            // 
            this.rooms_roomName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_roomName.Location = new System.Drawing.Point(124, 126);
            this.rooms_roomName.Name = "rooms_roomName";
            this.rooms_roomName.Size = new System.Drawing.Size(186, 29);
            this.rooms_roomName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Name:";
            // 
            // rooms_type
            // 
            this.rooms_type.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_type.FormattingEnabled = true;
            this.rooms_type.Items.AddRange(new object[] {
            "Single Room",
            "Double Room"});
            this.rooms_type.Location = new System.Drawing.Point(124, 79);
            this.rooms_type.Name = "rooms_type";
            this.rooms_type.Size = new System.Drawing.Size(186, 29);
            this.rooms_type.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // rooms_roomID
            // 
            this.rooms_roomID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_roomID.Location = new System.Drawing.Point(124, 28);
            this.rooms_roomID.Name = "rooms_roomID";
            this.rooms_roomID.Size = new System.Drawing.Size(186, 29);
            this.rooms_roomID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room ID:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // admin_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "admin_rooms";
            this.Size = new System.Drawing.Size(1087, 605);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rooms_clearBtn;
        private System.Windows.Forms.Button rooms_deleteBtn;
        private System.Windows.Forms.Button rooms_updateBtn;
        private System.Windows.Forms.Button rooms_addBtn;
        private System.Windows.Forms.Button rooms_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox rooms_picture;
        private System.Windows.Forms.ComboBox rooms_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rooms_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rooms_roomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rooms_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rooms_roomID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
