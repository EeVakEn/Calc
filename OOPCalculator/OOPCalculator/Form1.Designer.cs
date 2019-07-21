namespace OOPCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.Arcctg = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.XInY = new System.Windows.Forms.Button();
            this.XInReverseY = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.AMean = new System.Windows.Forms.Button();
            this.GMean = new System.Windows.Forms.Button();
            this.ExpInX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Plum;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Add.Location = new System.Drawing.Point(11, 86);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(70, 38);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(9, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.Color.Plum;
            this.Subtraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Subtraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Subtraction.Location = new System.Drawing.Point(87, 86);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(70, 38);
            this.Subtraction.TabIndex = 0;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Plum;
            this.Divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Divide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Divide.Location = new System.Drawing.Point(163, 86);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(70, 38);
            this.Divide.TabIndex = 0;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.Color.Plum;
            this.Multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Multiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Multiply.Location = new System.Drawing.Point(239, 86);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(70, 38);
            this.Multiply.TabIndex = 0;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Plum;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(9, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат:";
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.BackColor = System.Drawing.Color.Plum;
            this.resultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.resultLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resultLable.Location = new System.Drawing.Point(126, 312);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(20, 24);
            this.resultLable.TabIndex = 2;
            this.resultLable.Text = "0";
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.Color.Plum;
            this.Sin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Sin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Sin.Location = new System.Drawing.Point(11, 130);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(70, 38);
            this.Sin.TabIndex = 0;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = false;
            this.Sin.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Cos
            // 
            this.Cos.AutoEllipsis = true;
            this.Cos.BackColor = System.Drawing.Color.Plum;
            this.Cos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Cos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Cos.Location = new System.Drawing.Point(87, 130);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(70, 38);
            this.Cos.TabIndex = 0;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Tan
            // 
            this.Tan.BackColor = System.Drawing.Color.Plum;
            this.Tan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Tan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Tan.Location = new System.Drawing.Point(163, 130);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(70, 38);
            this.Tan.TabIndex = 0;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = false;
            this.Tan.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Ctg
            // 
            this.Ctg.BackColor = System.Drawing.Color.Plum;
            this.Ctg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ctg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Ctg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Ctg.Location = new System.Drawing.Point(239, 130);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(70, 38);
            this.Ctg.TabIndex = 0;
            this.Ctg.Text = "ctg";
            this.Ctg.UseVisualStyleBackColor = false;
            this.Ctg.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Arcsin
            // 
            this.Arcsin.BackColor = System.Drawing.Color.Plum;
            this.Arcsin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arcsin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arcsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Arcsin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Arcsin.Location = new System.Drawing.Point(11, 174);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(70, 38);
            this.Arcsin.TabIndex = 0;
            this.Arcsin.Text = "arcsin";
            this.Arcsin.UseVisualStyleBackColor = false;
            this.Arcsin.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Arccos
            // 
            this.Arccos.BackColor = System.Drawing.Color.Plum;
            this.Arccos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arccos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arccos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Arccos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Arccos.Location = new System.Drawing.Point(87, 174);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(70, 38);
            this.Arccos.TabIndex = 0;
            this.Arccos.Text = "arccos";
            this.Arccos.UseVisualStyleBackColor = false;
            this.Arccos.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Arctan
            // 
            this.Arctan.BackColor = System.Drawing.Color.Plum;
            this.Arctan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arctan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arctan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Arctan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Arctan.Location = new System.Drawing.Point(163, 174);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(70, 38);
            this.Arctan.TabIndex = 0;
            this.Arctan.Text = "arctan";
            this.Arctan.UseVisualStyleBackColor = false;
            this.Arctan.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Arcctg
            // 
            this.Arcctg.BackColor = System.Drawing.Color.Plum;
            this.Arcctg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arcctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arcctg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Arcctg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Arcctg.Location = new System.Drawing.Point(239, 174);
            this.Arcctg.Name = "Arcctg";
            this.Arcctg.Size = new System.Drawing.Size(70, 38);
            this.Arcctg.TabIndex = 0;
            this.Arcctg.Text = "arcctg";
            this.Arcctg.UseVisualStyleBackColor = false;
            this.Arcctg.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Ln
            // 
            this.Ln.BackColor = System.Drawing.Color.Plum;
            this.Ln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Ln.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Ln.Location = new System.Drawing.Point(11, 218);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(70, 38);
            this.Ln.TabIndex = 0;
            this.Ln.Text = "ln";
            this.Ln.UseVisualStyleBackColor = false;
            this.Ln.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // XInY
            // 
            this.XInY.BackColor = System.Drawing.Color.Plum;
            this.XInY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XInY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XInY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.XInY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.XInY.Location = new System.Drawing.Point(87, 218);
            this.XInY.Name = "XInY";
            this.XInY.Size = new System.Drawing.Size(70, 38);
            this.XInY.TabIndex = 0;
            this.XInY.Text = "x^y";
            this.XInY.UseVisualStyleBackColor = false;
            this.XInY.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // XInReverseY
            // 
            this.XInReverseY.BackColor = System.Drawing.Color.Plum;
            this.XInReverseY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XInReverseY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XInReverseY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.XInReverseY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.XInReverseY.Location = new System.Drawing.Point(163, 218);
            this.XInReverseY.Name = "XInReverseY";
            this.XInReverseY.Size = new System.Drawing.Size(70, 38);
            this.XInReverseY.TabIndex = 0;
            this.XInReverseY.Text = "x^(1/y)";
            this.XInReverseY.UseVisualStyleBackColor = false;
            this.XInReverseY.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // Log10
            // 
            this.Log10.BackColor = System.Drawing.Color.Plum;
            this.Log10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Log10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Log10.Location = new System.Drawing.Point(239, 218);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(70, 38);
            this.Log10.TabIndex = 0;
            this.Log10.Text = "log10";
            this.Log10.UseVisualStyleBackColor = false;
            this.Log10.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // AMean
            // 
            this.AMean.BackColor = System.Drawing.Color.Plum;
            this.AMean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AMean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AMean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AMean.Location = new System.Drawing.Point(11, 262);
            this.AMean.Name = "AMean";
            this.AMean.Size = new System.Drawing.Size(70, 38);
            this.AMean.TabIndex = 0;
            this.AMean.Text = "A mean";
            this.AMean.UseVisualStyleBackColor = false;
            this.AMean.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // GMean
            // 
            this.GMean.BackColor = System.Drawing.Color.Plum;
            this.GMean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GMean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.GMean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GMean.Location = new System.Drawing.Point(87, 262);
            this.GMean.Name = "GMean";
            this.GMean.Size = new System.Drawing.Size(70, 38);
            this.GMean.TabIndex = 0;
            this.GMean.Text = "G mean";
            this.GMean.UseVisualStyleBackColor = false;
            this.GMean.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // ExpInX
            // 
            this.ExpInX.BackColor = System.Drawing.Color.Plum;
            this.ExpInX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpInX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpInX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ExpInX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ExpInX.Location = new System.Drawing.Point(163, 262);
            this.ExpInX.Name = "ExpInX";
            this.ExpInX.Size = new System.Drawing.Size(70, 38);
            this.ExpInX.TabIndex = 0;
            this.ExpInX.Text = "e^x";
            this.ExpInX.UseVisualStyleBackColor = false;
            this.ExpInX.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(464, 345);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExpInX);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.XInReverseY);
            this.Controls.Add(this.Arcctg);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.GMean);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.XInY);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.AMean);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Add);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Ctg;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button Arcctg;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button XInY;
        private System.Windows.Forms.Button XInReverseY;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button AMean;
        private System.Windows.Forms.Button GMean;
        private System.Windows.Forms.Button ExpInX;
    }
}

