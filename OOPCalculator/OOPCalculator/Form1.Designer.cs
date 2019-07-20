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
            this.log10 = new System.Windows.Forms.Button();
            this.AMean = new System.Windows.Forms.Button();
            this.GMean = new System.Windows.Forms.Button();
            this.ExpInX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(4, 73);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(66, 38);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Subtraction
            // 
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtraction.Location = new System.Drawing.Point(76, 73);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(66, 38);
            this.Subtraction.TabIndex = 0;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // Divide
            // 
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Location = new System.Drawing.Point(148, 73);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(66, 38);
            this.Divide.TabIndex = 0;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // Multiply
            // 
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiply.Location = new System.Drawing.Point(218, 73);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(66, 38);
            this.Multiply.TabIndex = 0;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 269);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат:";
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(27, 323);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(13, 13);
            this.resultLable.TabIndex = 2;
            this.resultLable.Text = "0";
            // 
            // Sin
            // 
            this.Sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sin.Location = new System.Drawing.Point(4, 109);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(66, 38);
            this.Sin.TabIndex = 0;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Cos
            // 
            this.Cos.AutoEllipsis = true;
            this.Cos.BackColor = System.Drawing.SystemColors.Control;
            this.Cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cos.Location = new System.Drawing.Point(76, 109);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(66, 38);
            this.Cos.TabIndex = 0;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Tan
            // 
            this.Tan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tan.Location = new System.Drawing.Point(148, 109);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(66, 38);
            this.Tan.TabIndex = 0;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Ctg
            // 
            this.Ctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ctg.Location = new System.Drawing.Point(218, 109);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(66, 38);
            this.Ctg.TabIndex = 0;
            this.Ctg.Text = "ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Arcsin
            // 
            this.Arcsin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arcsin.Location = new System.Drawing.Point(4, 145);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(66, 38);
            this.Arcsin.TabIndex = 0;
            this.Arcsin.Text = "arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Arccos
            // 
            this.Arccos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arccos.Location = new System.Drawing.Point(76, 145);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(66, 38);
            this.Arccos.TabIndex = 0;
            this.Arccos.Text = "arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Arctan
            // 
            this.Arctan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arctan.Location = new System.Drawing.Point(148, 145);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(66, 38);
            this.Arctan.TabIndex = 0;
            this.Arctan.Text = "arctan";
            this.Arctan.UseVisualStyleBackColor = true;
            this.Arctan.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Arcctg
            // 
            this.Arcctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arcctg.Location = new System.Drawing.Point(218, 145);
            this.Arcctg.Name = "Arcctg";
            this.Arcctg.Size = new System.Drawing.Size(66, 38);
            this.Arcctg.TabIndex = 0;
            this.Arcctg.Text = "arcctg";
            this.Arcctg.UseVisualStyleBackColor = true;
            this.Arcctg.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Ln
            // 
            this.Ln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ln.Location = new System.Drawing.Point(4, 181);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(66, 38);
            this.Ln.TabIndex = 0;
            this.Ln.Text = "ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // XInY
            // 
            this.XInY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XInY.Location = new System.Drawing.Point(76, 181);
            this.XInY.Name = "XInY";
            this.XInY.Size = new System.Drawing.Size(66, 38);
            this.XInY.TabIndex = 0;
            this.XInY.Text = "x^y";
            this.XInY.UseVisualStyleBackColor = true;
            this.XInY.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // XInReverseY
            // 
            this.XInReverseY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XInReverseY.Location = new System.Drawing.Point(148, 181);
            this.XInReverseY.Name = "XInReverseY";
            this.XInReverseY.Size = new System.Drawing.Size(66, 38);
            this.XInReverseY.TabIndex = 0;
            this.XInReverseY.Text = "x^(1/y)";
            this.XInReverseY.UseVisualStyleBackColor = true;
            this.XInReverseY.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // log10
            // 
            this.log10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log10.Location = new System.Drawing.Point(218, 181);
            this.log10.Name = "log10";
            this.log10.Size = new System.Drawing.Size(66, 38);
            this.log10.TabIndex = 0;
            this.log10.Text = "log10";
            this.log10.UseVisualStyleBackColor = true;
            this.log10.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // AMean
            // 
            this.AMean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AMean.Location = new System.Drawing.Point(5, 225);
            this.AMean.Name = "AMean";
            this.AMean.Size = new System.Drawing.Size(66, 38);
            this.AMean.TabIndex = 0;
            this.AMean.Text = "A mean";
            this.AMean.UseVisualStyleBackColor = true;
            this.AMean.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // GMean
            // 
            this.GMean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GMean.Location = new System.Drawing.Point(77, 225);
            this.GMean.Name = "GMean";
            this.GMean.Size = new System.Drawing.Size(66, 38);
            this.GMean.TabIndex = 0;
            this.GMean.Text = "G mean";
            this.GMean.UseVisualStyleBackColor = true;
            this.GMean.Click += new System.EventHandler(this.TwoArgumentClick);
            // 
            // ExpInX
            // 
            this.ExpInX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpInX.Location = new System.Drawing.Point(149, 225);
            this.ExpInX.Name = "ExpInX";
            this.ExpInX.Size = new System.Drawing.Size(66, 38);
            this.ExpInX.TabIndex = 0;
            this.ExpInX.Text = "e^x";
            this.ExpInX.UseVisualStyleBackColor = true;
            this.ExpInX.Click += new System.EventHandler(this.OneArgumentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(297, 372);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExpInX);
            this.Controls.Add(this.log10);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button log10;
        private System.Windows.Forms.Button AMean;
        private System.Windows.Forms.Button GMean;
        private System.Windows.Forms.Button ExpInX;
    }
}

