namespace LabOOP16
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelResult = new Label();
            buttonCreate = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Заповніть поля:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 31);
            textBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 4;
            label2.Text = "Вкажіть ваше місто:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(193, 25);
            label3.TabIndex = 5;
            label3.Text = "Вкажіть вашу вулицю:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(246, 25);
            label4.TabIndex = 6;
            label4.Text = "Вкажіть ваш номер будинку:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(12, 256);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 7;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(93, 322);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(210, 34);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Створити об'єкт";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(475, 322);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(214, 34);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Видалити об'єкт";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Controls.Add(labelResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Лаб № 16 Талашов Богдан";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelResult;
        private Button buttonCreate;
        private Button buttonDelete;
    }
}