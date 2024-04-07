namespace Cafeteria.App
{
    partial class UsersAuthForm
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
            this.labelTextAuth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelTextPassword = new System.Windows.Forms.Label();
            this.labelTextLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTextAuth
            // 
            this.labelTextAuth.BackColor = System.Drawing.Color.SeaShell;
            this.labelTextAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTextAuth.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextAuth.Location = new System.Drawing.Point(0, 0);
            this.labelTextAuth.Name = "labelTextAuth";
            this.labelTextAuth.Size = new System.Drawing.Size(482, 89);
            this.labelTextAuth.TabIndex = 0;
            this.labelTextAuth.Text = "Авторизация пользователя";
            this.labelTextAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.labelTextPassword);
            this.panel1.Controls.Add(this.labelTextLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 361);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Dubai Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Войти в систему";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAuthUser);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(212, 112);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(178, 45);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(212, 29);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(178, 45);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelTextPassword
            // 
            this.labelTextPassword.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextPassword.Location = new System.Drawing.Point(23, 112);
            this.labelTextPassword.Name = "labelTextPassword";
            this.labelTextPassword.Size = new System.Drawing.Size(183, 45);
            this.labelTextPassword.TabIndex = 0;
            this.labelTextPassword.Text = "Пароль";
            this.labelTextPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextLogin
            // 
            this.labelTextLogin.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextLogin.Location = new System.Drawing.Point(23, 29);
            this.labelTextLogin.Name = "labelTextLogin";
            this.labelTextLogin.Size = new System.Drawing.Size(183, 45);
            this.labelTextLogin.TabIndex = 0;
            this.labelTextLogin.Text = "Логин";
            this.labelTextLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTextAuth);
            this.Name = "UsersAuthForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма авторизации пользователей";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTextAuth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTextLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelTextPassword;
        private System.Windows.Forms.Button button1;
    }
}

