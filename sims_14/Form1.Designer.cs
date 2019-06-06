namespace sims_13
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.Queue = new System.Windows.Forms.Label();
            this.Busy = new System.Windows.Forms.Label();
            this.Arrive = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(18, 39);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(293, 13);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(63, 13);
            this.Time.TabIndex = 17;
            this.Time.Text = "Current time";
            // 
            // Queue
            // 
            this.Queue.AutoSize = true;
            this.Queue.Location = new System.Drawing.Point(293, 49);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(39, 13);
            this.Queue.TabIndex = 18;
            this.Queue.Text = "Queue";
            // 
            // Busy
            // 
            this.Busy.AutoSize = true;
            this.Busy.Location = new System.Drawing.Point(292, 76);
            this.Busy.Name = "Busy";
            this.Busy.Size = new System.Drawing.Size(77, 13);
            this.Busy.TabIndex = 19;
            this.Busy.Text = "Busy operators";
            // 
            // Arrive
            // 
            this.Arrive.AutoSize = true;
            this.Arrive.Location = new System.Drawing.Point(291, 103);
            this.Arrive.Name = "Arrive";
            this.Arrive.Size = new System.Drawing.Size(65, 13);
            this.Arrive.TabIndex = 20;
            this.Arrive.Text = "Next event: ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 223);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 100);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 346);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Arrive);
            this.Controls.Add(this.Busy);
            this.Controls.Add(this.Queue);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Queue;
        private System.Windows.Forms.Label Busy;
        private System.Windows.Forms.Label Arrive;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

