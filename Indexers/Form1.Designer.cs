namespace Indexers
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
            this.components = new System.ComponentModel.Container();
            this.Indextxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Day = new System.Windows.Forms.Label();
            this.Get_ = new System.Windows.Forms.Button();
            this.Temptxt = new System.Windows.Forms.TextBox();
            this.medida = new System.Windows.Forms.Button();
            this.txtTry = new System.Windows.Forms.Button();
            this.textdate = new System.Windows.Forms.TextBox();
            this.textcity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Indextxt
            // 
            this.Indextxt.BackColor = System.Drawing.Color.White;
            this.Indextxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Indextxt.Location = new System.Drawing.Point(505, 109);
            this.Indextxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Indextxt.Multiline = true;
            this.Indextxt.Name = "Indextxt";
            this.Indextxt.Size = new System.Drawing.Size(206, 21);
            this.Indextxt.TabIndex = 1;
            this.Indextxt.TextChanged += new System.EventHandler(this.Daytxt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(752, 109);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(48, 20);
            this.Day.TabIndex = 5;
            this.Day.Text = "Index";
            this.Day.Click += new System.EventHandler(this.Day_Click);
            // 
            // Get_
            // 
            this.Get_.Location = new System.Drawing.Point(102, 66);
            this.Get_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Get_.Name = "Get_";
            this.Get_.Size = new System.Drawing.Size(141, 111);
            this.Get_.TabIndex = 7;
            this.Get_.Text = "Get Temp of  Mounth";
            this.Get_.UseVisualStyleBackColor = true;
            this.Get_.Click += new System.EventHandler(this.Get__Click);
            // 
            // Temptxt
            // 
            this.Temptxt.Location = new System.Drawing.Point(505, 150);
            this.Temptxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Temptxt.Multiline = true;
            this.Temptxt.Name = "Temptxt";
            this.Temptxt.Size = new System.Drawing.Size(205, 32);
            this.Temptxt.TabIndex = 8;
            this.Temptxt.TextChanged += new System.EventHandler(this.Temptxt_TextChanged);
            // 
            // medida
            // 
            this.medida.Location = new System.Drawing.Point(102, 198);
            this.medida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medida.Name = "medida";
            this.medida.Size = new System.Drawing.Size(140, 102);
            this.medida.TabIndex = 9;
            this.medida.Text = "Medida";
            this.medida.UseVisualStyleBackColor = true;
            this.medida.Click += new System.EventHandler(this.medida_Click);
            // 
            // txtTry
            // 
            this.txtTry.Location = new System.Drawing.Point(102, 319);
            this.txtTry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTry.Name = "txtTry";
            this.txtTry.Size = new System.Drawing.Size(125, 56);
            this.txtTry.TabIndex = 10;
            this.txtTry.Text = "True or False";
            this.txtTry.UseVisualStyleBackColor = true;
            this.txtTry.Click += new System.EventHandler(this.txtTry_Click);
            // 
            // textdate
            // 
            this.textdate.Location = new System.Drawing.Point(505, 198);
            this.textdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(205, 26);
            this.textdate.TabIndex = 11;
            // 
            // textcity
            // 
            this.textcity.Location = new System.Drawing.Point(505, 241);
            this.textcity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textcity.Name = "textcity";
            this.textcity.Size = new System.Drawing.Size(205, 26);
            this.textcity.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Temp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "City";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 332);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 566);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textcity);
            this.Controls.Add(this.textdate);
            this.Controls.Add(this.txtTry);
            this.Controls.Add(this.medida);
            this.Controls.Add(this.Temptxt);
            this.Controls.Add(this.Get_);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Indextxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "tttt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Indextxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Button Get_;
        private System.Windows.Forms.TextBox Temptxt;
        private System.Windows.Forms.Button medida;
        private System.Windows.Forms.Button txtTry;
        private System.Windows.Forms.TextBox textdate;
        private System.Windows.Forms.TextBox textcity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

