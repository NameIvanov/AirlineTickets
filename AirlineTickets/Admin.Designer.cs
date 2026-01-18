namespace AirlineTickets
{
    partial class Admin
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
            this.city = new System.Windows.Forms.TextBox();
            this.clock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Город вылета и прилета через -";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(34, 137);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(185, 22);
            this.city.TabIndex = 1;
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(34, 174);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(185, 22);
            this.clock.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время вылета и прилета";
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(34, 208);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(185, 22);
            this.company.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Авиа Компания";
            // 
            // clas
            // 
            this.clas.Location = new System.Drawing.Point(34, 249);
            this.clas.Name = "clas";
            this.clas.Size = new System.Drawing.Size(185, 22);
            this.clas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Класс";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(34, 287);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(185, 22);
            this.price.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена";
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.Location = new System.Drawing.Point(34, 333);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(159, 41);
            this.buttonAddTicket.TabIndex = 10;
            this.buttonAddTicket.Text = "Добавить билет";
            this.buttonAddTicket.UseVisualStyleBackColor = true;
            this.buttonAddTicket.Click += new System.EventHandler(this.buttonAddTicket_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(530, 16);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(123, 33);
            this.buttonUser.TabIndex = 11;
            this.buttonUser.Text = "Пользователь";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 516);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonAddTicket);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.company);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox clock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddTicket;
        private System.Windows.Forms.Button buttonUser;
    }
}