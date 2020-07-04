namespace School
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenTeachers = new System.Windows.Forms.Button();
            this.buttonOpenLessons = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenTeachers
            // 
            this.buttonOpenTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonOpenTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenTeachers.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTeachers.ForeColor = System.Drawing.Color.White;
            this.buttonOpenTeachers.Location = new System.Drawing.Point(12, 147);
            this.buttonOpenTeachers.Name = "buttonOpenTeachers";
            this.buttonOpenTeachers.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenTeachers.TabIndex = 2;
            this.buttonOpenTeachers.Text = "Учителя";
            this.buttonOpenTeachers.UseVisualStyleBackColor = false;
            this.buttonOpenTeachers.Click += new System.EventHandler(this.buttonOpenTeachers_Click);
            // 
            // buttonOpenLessons
            // 
            this.buttonOpenLessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonOpenLessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenLessons.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenLessons.ForeColor = System.Drawing.Color.White;
            this.buttonOpenLessons.Location = new System.Drawing.Point(12, 189);
            this.buttonOpenLessons.Name = "buttonOpenLessons";
            this.buttonOpenLessons.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenLessons.TabIndex = 3;
            this.buttonOpenLessons.Text = "Предметы";
            this.buttonOpenLessons.UseVisualStyleBackColor = false;
            this.buttonOpenLessons.Click += new System.EventHandler(this.buttonOpenLessons_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Администраторы";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::School.Properties.Resources.лого;
            this.Logo.Location = new System.Drawing.Point(87, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(132, 112);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 45;
            this.Logo.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 302);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOpenLessons);
            this.Controls.Add(this.buttonOpenTeachers);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenTeachers;
        private System.Windows.Forms.Button buttonOpenLessons;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox Logo;
    }
}

