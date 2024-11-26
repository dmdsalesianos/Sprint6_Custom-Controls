
namespace WindowsFormsApp
{
    partial class FormPrueba
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llencaApps1 = new ControlsLibrary.LlencaApps();
            this.swCodi1 = new ControlsLibrary.SWCodi();
            this.swTextbox1 = new ControlsLibrary.SWTextbox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(310, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(206, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SWTextbox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "SWCodi";
            // 
            // llencaApps1
            // 
            this.llencaApps1.Classe = "WindowsFormsApp";
            this.llencaApps1.Descripcio = "TU PADRE";
            this.llencaApps1.Form = "FormColor";
            this.llencaApps1.Location = new System.Drawing.Point(58, 256);
            this.llencaApps1.Name = "llencaApps1";
            this.llencaApps1.Size = new System.Drawing.Size(1097, 474);
            this.llencaApps1.TabIndex = 6;
            // 
            // swCodi1
            // 
            this.swCodi1.Location = new System.Drawing.Point(39, 159);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.Nivell = ControlsLibrary.SWCodi.NivellEnum.GS;
            this.swCodi1.Requerit = true;
            this.swCodi1.Size = new System.Drawing.Size(497, 70);
            this.swCodi1.TabIndex = 3;
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowEmpty = false;
            this.swTextbox1.BackColor = System.Drawing.Color.White;
            this.swTextbox1.DadaPermesa = ControlsLibrary.SWTextbox.ContentType.Text;
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.LinkedControlName = "textBox1";
            this.swTextbox1.Location = new System.Drawing.Point(58, 97);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(229, 26);
            this.swTextbox1.TabIndex = 2;
            // 
            // FormPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 763);
            this.Controls.Add(this.llencaApps1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormPrueba";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private ControlsLibrary.SWTextbox swTextbox1;
        private ControlsLibrary.SWCodi swCodi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ControlsLibrary.LlencaApps llencaApps1;
    }
}