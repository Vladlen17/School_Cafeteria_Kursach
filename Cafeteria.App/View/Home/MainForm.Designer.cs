namespace Cafeteria.App
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnFoodByClass = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label1.Size = new System.Drawing.Size(474, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "Основное меню приложения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnFoodByClass);
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.btnManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 333);
            this.panel1.TabIndex = 1;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcel.Location = new System.Drawing.Point(3, 252);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(474, 50);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Вывод данных в Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnOutputInExcel);
            // 
            // btnFoodByClass
            // 
            this.btnFoodByClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFoodByClass.Location = new System.Drawing.Point(3, 178);
            this.btnFoodByClass.Name = "btnFoodByClass";
            this.btnFoodByClass.Size = new System.Drawing.Size(474, 50);
            this.btnFoodByClass.TabIndex = 4;
            this.btnFoodByClass.Text = "Открыть таблицу питания по классам";
            this.btnFoodByClass.UseVisualStyleBackColor = true;
            this.btnFoodByClass.Click += new System.EventHandler(this.btnOpenFoodByClass);
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFood.Location = new System.Drawing.Point(3, 103);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(474, 50);
            this.btnFood.TabIndex = 3;
            this.btnFood.Text = "Открыть таблицу питания";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnOpenFood);
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManager.Location = new System.Drawing.Point(3, 31);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(474, 50);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "Открыть таблицу заведующих";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnOpenManager);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основная форма для навигации";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnFoodByClass;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnExcel;
    }
}