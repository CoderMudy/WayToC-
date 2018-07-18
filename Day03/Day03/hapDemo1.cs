 using System;
 using System.Collections.Generic;
 using System.ComponentModel;
 using System.Data;
 using System.Drawing;
 using System.Linq;
 using System.Text;
 using System.Windows.Forms;
 using HtmlAgilityPack;
 
 namespace HtmlAgilityPackDemo1
 {
     public partial class Form1 : Form
     {
         private Button button1;
     
         public Form1()
         {
             InitializeComponent();

         }
 
         private void Form1_Load(object sender, EventArgs e)
         {
 
         }
 
         private void button1_Click(object sender, EventArgs e)
         {
             HtmlWeb webClient = new HtmlWeb();
             HtmlAgilityPack.HtmlDocument doc = webClient.Load("http://www.cnblogs.com/lmei");
 
             HtmlNodeCollection hrefList = doc.DocumentNode.SelectNodes(".//a[@href]");
 
             if (hrefList != null)
             {
                 foreach (HtmlNode href in hrefList)
                 {
                     HtmlAttribute att = href.Attributes["href"];
                    Console.WriteLine(att.Value);
 
                 }
 
             }
 
         }

         private void InitializeComponent()
         {
             this.button1 = new System.Windows.Forms.Button();
             this.SuspendLayout();
             // 
             // button1
             // 
             this.button1.Location = new System.Drawing.Point(99, 52);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(75, 23);
             this.button1.TabIndex = 0;
             this.button1.Text = "button1";
             this.button1.UseVisualStyleBackColor = true;
             this.button1.Click +=new EventHandler(button1_Click);

             // 
             // Form1
             // 
             this.ClientSize = new System.Drawing.Size(284, 262);
             this.Controls.Add(this.button1);
             this.Name = "Form1";
             this.ResumeLayout(false);

         }
     }


     public class Tester
     {
         public static void Main()
         {
             Application.Run(new Form1());
         }
     }
 }