﻿
namespace InteropTest10
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7_struct_demo = new System.Windows.Forms.Button();
            this.button_test_array_ints = new System.Windows.Forms.Button();
            this.button_array_of_structs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "10";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Register FPtr";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 196);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Register and Invoke";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 249);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Create CTestClass";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 321);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 28);
            this.button5.TabIndex = 7;
            this.button5.Text = "Delete CTestClass";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(41, 286);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 28);
            this.button6.TabIndex = 8;
            this.button6.Text = "Do Something on CTestClass";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7_struct_demo
            // 
            this.button7_struct_demo.Location = new System.Drawing.Point(41, 401);
            this.button7_struct_demo.Name = "button7_struct_demo";
            this.button7_struct_demo.Size = new System.Drawing.Size(213, 41);
            this.button7_struct_demo.TabIndex = 9;
            this.button7_struct_demo.Text = "Struct Sample";
            this.button7_struct_demo.UseVisualStyleBackColor = true;
            this.button7_struct_demo.Click += new System.EventHandler(this.button7_struct_demo_Click);
            // 
            // button_test_array_ints
            // 
            this.button_test_array_ints.Location = new System.Drawing.Point(41, 459);
            this.button_test_array_ints.Name = "button_test_array_ints";
            this.button_test_array_ints.Size = new System.Drawing.Size(213, 35);
            this.button_test_array_ints.TabIndex = 10;
            this.button_test_array_ints.Text = "Test array of ints";
            this.button_test_array_ints.UseVisualStyleBackColor = true;
            this.button_test_array_ints.Click += new System.EventHandler(this.button_test_array_ints_Click);
            // 
            // button_array_of_structs
            // 
            this.button_array_of_structs.Location = new System.Drawing.Point(297, 401);
            this.button_array_of_structs.Name = "button_array_of_structs";
            this.button_array_of_structs.Size = new System.Drawing.Size(208, 41);
            this.button_array_of_structs.TabIndex = 11;
            this.button_array_of_structs.Text = "Array of Structs";
            this.button_array_of_structs.UseVisualStyleBackColor = true;
            this.button_array_of_structs.Click += new System.EventHandler(this.button_array_of_structs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 655);
            this.Controls.Add(this.button_array_of_structs);
            this.Controls.Add(this.button_test_array_ints);
            this.Controls.Add(this.button7_struct_demo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7_struct_demo;
        private System.Windows.Forms.Button button_test_array_ints;
        private System.Windows.Forms.Button button_array_of_structs;
    }
}

