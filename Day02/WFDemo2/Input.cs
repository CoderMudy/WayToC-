using System;
using System.Windows.Forms;
using System.Drawing;


namespace WFDemo2
{
     class Input:Form
    {
        private Button button1;
        private ProgressBar progressBar1;
        private TextBox textBox1;
     
        public Input()
        {
            Text = "输入框";
            Size = new Size(500, 500);
            /*
            TextBox input = new TextBox();
            input.Location = new Point(20, 20);
            input.TextChanged += new EventHandler(input_TextChanged);
            */
            InitializeComponent();
            CenterToScreen();
           
        }

        void input_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
            //throw new NotImplementedException();
        }

        void textChange(Object sender,Exception e)
        {
            Console.WriteLine(sender);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new EventHandler(input_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(324, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(151, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Input
            // 
            this.ClientSize = new System.Drawing.Size(487, 505);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
           

        }

        void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.textBox1.Text);
            //throw new NotImplementedException();
        }

    }


    class Tester
    {
        static public void Main()
        {
            Application.Run(new Input());
        }
    }

}
