namespace Memoria_Dinamica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            BtnAddData = new Button();
            TexBoxSizeVector = new TextBox();
            TexBoxAdd = new TextBox();
            BtnSizeAdd = new Button();
            label2 = new Label();
            LstViewDataofVector = new ListView();
            LblSizeVector = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 63);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Tamaño del Vector:";
            // 
            // BtnAddData
            // 
            BtnAddData.Location = new Point(98, 288);
            BtnAddData.Name = "BtnAddData";
            BtnAddData.Size = new Size(75, 23);
            BtnAddData.TabIndex = 1;
            BtnAddData.Text = "Add";
            BtnAddData.UseVisualStyleBackColor = true;
            BtnAddData.Click += BtnAddData_Click;
            // 
            // TexBoxSizeVector
            // 
            TexBoxSizeVector.Location = new Point(46, 81);
            TexBoxSizeVector.Name = "TexBoxSizeVector";
            TexBoxSizeVector.Size = new Size(182, 23);
            TexBoxSizeVector.TabIndex = 2;
            // 
            // TexBoxAdd
            // 
            TexBoxAdd.Location = new Point(46, 244);
            TexBoxAdd.Name = "TexBoxAdd";
            TexBoxAdd.Size = new Size(182, 23);
            TexBoxAdd.TabIndex = 3;
            // 
            // BtnSizeAdd
            // 
            BtnSizeAdd.Location = new Point(98, 135);
            BtnSizeAdd.Name = "BtnSizeAdd";
            BtnSizeAdd.Size = new Size(75, 23);
            BtnSizeAdd.TabIndex = 4;
            BtnSizeAdd.Text = "Size";
            BtnSizeAdd.UseVisualStyleBackColor = true;
            BtnSizeAdd.Click += BtnSizeAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 226);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Datlo a incertar";
            // 
            // LstViewDataofVector
            // 
            LstViewDataofVector.Location = new Point(377, 35);
            LstViewDataofVector.Name = "LstViewDataofVector";
            LstViewDataofVector.Size = new Size(148, 402);
            LstViewDataofVector.TabIndex = 6;
            LstViewDataofVector.UseCompatibleStateImageBehavior = false;
            // 
            // LblSizeVector
            // 
            LblSizeVector.AutoSize = true;
            LblSizeVector.Location = new Point(156, 63);
            LblSizeVector.Name = "LblSizeVector";
            LblSizeVector.Size = new Size(0, 15);
            LblSizeVector.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 514);
            Controls.Add(LblSizeVector);
            Controls.Add(LstViewDataofVector);
            Controls.Add(label2);
            Controls.Add(BtnSizeAdd);
            Controls.Add(TexBoxAdd);
            Controls.Add(TexBoxSizeVector);
            Controls.Add(BtnAddData);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnAddData;
        private TextBox TexBoxSizeVector;
        private TextBox TexBoxAdd;
        private Button BtnSizeAdd;
        private Label label2;
        private ListView LstViewDataofVector;
        private Label LblSizeVector;
    }
}
