
namespace WindowsFormsApp2
{
    partial class FormDrawBezier
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startPX = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.startPY = new System.Windows.Forms.NumericUpDown();
            this.ctrlP1X = new System.Windows.Forms.NumericUpDown();
            this.ctrlP1Y = new System.Windows.Forms.NumericUpDown();
            this.ctrlP2X = new System.Windows.Forms.NumericUpDown();
            this.ctrlP2Y = new System.Windows.Forms.NumericUpDown();
            this.endPX = new System.Windows.Forms.NumericUpDown();
            this.endPY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlP1X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlP1Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlP2X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlP2Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPY)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Изчертаване на Крива, Крива на Безие, Затворена крива";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "X\r\nМакс:510\r\n";
            // 
            // startPX
            // 
            this.startPX.Location = new System.Drawing.Point(612, 141);
            this.startPX.Name = "startPX";
            this.startPX.Size = new System.Drawing.Size(43, 20);
            this.startPX.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 352);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(611, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Крива на Безие";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startPY
            // 
            this.startPY.Location = new System.Drawing.Point(679, 141);
            this.startPY.Name = "startPY";
            this.startPY.Size = new System.Drawing.Size(46, 20);
            this.startPY.TabIndex = 10;
            // 
            // ctrlP1X
            // 
            this.ctrlP1X.Location = new System.Drawing.Point(612, 177);
            this.ctrlP1X.Name = "ctrlP1X";
            this.ctrlP1X.Size = new System.Drawing.Size(43, 20);
            this.ctrlP1X.TabIndex = 11;
            // 
            // ctrlP1Y
            // 
            this.ctrlP1Y.Location = new System.Drawing.Point(679, 177);
            this.ctrlP1Y.Name = "ctrlP1Y";
            this.ctrlP1Y.Size = new System.Drawing.Size(46, 20);
            this.ctrlP1Y.TabIndex = 12;
            // 
            // ctrlP2X
            // 
            this.ctrlP2X.Location = new System.Drawing.Point(612, 223);
            this.ctrlP2X.Name = "ctrlP2X";
            this.ctrlP2X.Size = new System.Drawing.Size(43, 20);
            this.ctrlP2X.TabIndex = 13;
            // 
            // ctrlP2Y
            // 
            this.ctrlP2Y.Location = new System.Drawing.Point(679, 223);
            this.ctrlP2Y.Name = "ctrlP2Y";
            this.ctrlP2Y.Size = new System.Drawing.Size(46, 20);
            this.ctrlP2Y.TabIndex = 14;
            // 
            // endPX
            // 
            this.endPX.Location = new System.Drawing.Point(612, 268);
            this.endPX.Name = "endPX";
            this.endPX.Size = new System.Drawing.Size(43, 20);
            this.endPX.TabIndex = 15;
            // 
            // endPY
            // 
            this.endPY.Location = new System.Drawing.Point(679, 268);
            this.endPY.Name = "endPY";
            this.endPY.Size = new System.Drawing.Size(46, 20);
            this.endPY.TabIndex = 16;
            this.endPY.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Y\r\nМакс: 350\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Начална точка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Контролна точка 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Контролна точка 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(609, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Крайна точка";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(611, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 25);
            this.button2.TabIndex = 22;
            this.button2.Text = "Крива";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(611, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 31);
            this.button3.TabIndex = 23;
            this.button3.Text = "Затворена крива";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormDrawBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endPY);
            this.Controls.Add(this.endPX);
            this.Controls.Add(this.ctrlP2Y);
            this.Controls.Add(this.ctrlP2X);
            this.Controls.Add(this.ctrlP1Y);
            this.Controls.Add(this.ctrlP1X);
            this.Controls.Add(this.startPY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startPX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormDrawBezier";
            this.Text = "Изчертаване на Криви";
            ((System.ComponentModel.ISupportInitialize)(this.startPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlP1X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlP1Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlP2X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlP2Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown startPX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown startPY;
        private System.Windows.Forms.NumericUpDown ctrlP1X;
        private System.Windows.Forms.NumericUpDown ctrlP1Y;
        private System.Windows.Forms.NumericUpDown ctrlP2X;
        private System.Windows.Forms.NumericUpDown ctrlP2Y;
        private System.Windows.Forms.NumericUpDown endPX;
        private System.Windows.Forms.NumericUpDown endPY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}