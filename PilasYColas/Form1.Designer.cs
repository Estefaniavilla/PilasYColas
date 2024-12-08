namespace PilasyColas
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
            txtPila = new TextBox();
            label2 = new Label();
            btnPush = new Button();
            btnPop = new Button();
            btnPeekPila = new Button();
            lstPila = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCola = new TextBox();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnPeekCola = new Button();
            label6 = new Label();
            lstCola = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 60);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Pilas";
            // 
            // txtPila
            // 
            txtPila.Location = new Point(50, 124);
            txtPila.Name = "txtPila";
            txtPila.Size = new Size(168, 23);
            txtPila.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 91);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingresa un valor:";
            // 
            // btnPush
            // 
            btnPush.Location = new Point(50, 185);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(75, 23);
            btnPush.TabIndex = 3;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(143, 185);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(75, 23);
            btnPop.TabIndex = 4;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            // 
            // btnPeekPila
            // 
            btnPeekPila.Location = new Point(94, 226);
            btnPeekPila.Name = "btnPeekPila";
            btnPeekPila.Size = new Size(75, 23);
            btnPeekPila.TabIndex = 5;
            btnPeekPila.Text = "Peek";
            btnPeekPila.UseVisualStyleBackColor = true;
            // 
            // lstPila
            // 
            lstPila.FormattingEnabled = true;
            lstPila.ItemHeight = 15;
            lstPila.Location = new Point(50, 289);
            lstPila.Name = "lstPila";
            lstPila.Size = new Size(187, 94);
            lstPila.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 262);
            label3.Name = "label3";
            label3.Size = new Size(187, 15);
            label3.TabIndex = 7;
            label3.Text = "Se muestra el contenido de la pila:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 60);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Colas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 91);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 9;
            label5.Text = "Ingresa un valor:";
            // 
            // txtCola
            // 
            txtCola.Location = new Point(460, 124);
            txtCola.Name = "txtCola";
            txtCola.Size = new Size(168, 23);
            txtCola.TabIndex = 10;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(460, 185);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(75, 23);
            btnEnqueue.TabIndex = 11;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(553, 185);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(75, 23);
            btnDequeue.TabIndex = 12;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            // 
            // btnPeekCola
            // 
            btnPeekCola.Location = new Point(508, 226);
            btnPeekCola.Name = "btnPeekCola";
            btnPeekCola.Size = new Size(75, 23);
            btnPeekCola.TabIndex = 13;
            btnPeekCola.Text = "Peek";
            btnPeekCola.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 262);
            label6.Name = "label6";
            label6.Size = new Size(200, 15);
            label6.TabIndex = 14;
            label6.Text = "Se muestra el contenido de las colas:";
            // 
            // lstCola
            // 
            lstCola.FormattingEnabled = true;
            lstCola.ItemHeight = 15;
            lstCola.Location = new Point(450, 289);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(200, 94);
            lstCola.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCola);
            Controls.Add(label6);
            Controls.Add(btnPeekCola);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(txtCola);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstPila);
            Controls.Add(btnPeekPila);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(label2);
            Controls.Add(txtPila);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPila;
        private Label label2;
        private Button btnPush;
        private Button btnPop;
        private Button btnPeekPila;
        private ListBox lstPila;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCola;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnPeekCola;
        private Label label6;
        private ListBox lstCola;
    }
}
