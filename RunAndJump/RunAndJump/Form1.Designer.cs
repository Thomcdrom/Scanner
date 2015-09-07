namespace RunAndJump
{
    partial class RunAndJump
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunAndJump));
            this.lbwoorden = new System.Windows.Forms.Label();
            this.lbtext = new System.Windows.Forms.Label();
            this.lbpoints = new System.Windows.Forms.Label();
            this.lbtext2 = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.tmJump = new System.Windows.Forms.Timer(this.components);
            this.tmRunToRight = new System.Windows.Forms.Timer(this.components);
            this.tmSeconds = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbwoorden
            // 
            this.lbwoorden.AutoSize = true;
            this.lbwoorden.BackColor = System.Drawing.Color.Transparent;
            this.lbwoorden.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwoorden.Location = new System.Drawing.Point(0, 250);
            this.lbwoorden.Name = "lbwoorden";
            this.lbwoorden.Size = new System.Drawing.Size(54, 19);
            this.lbwoorden.TabIndex = 0;
            this.lbwoorden.Text = "label1";
            this.lbwoorden.Click += new System.EventHandler(this.lbwoorden_Click);
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.BackColor = System.Drawing.Color.Transparent;
            this.lbtext.Location = new System.Drawing.Point(12, 539);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(36, 13);
            this.lbtext.TabIndex = 1;
            this.lbtext.Text = "Points";
            // 
            // lbpoints
            // 
            this.lbpoints.AutoSize = true;
            this.lbpoints.BackColor = System.Drawing.Color.Transparent;
            this.lbpoints.Location = new System.Drawing.Point(65, 539);
            this.lbpoints.Name = "lbpoints";
            this.lbpoints.Size = new System.Drawing.Size(35, 13);
            this.lbpoints.TabIndex = 2;
            this.lbpoints.Text = "label3";
            // 
            // lbtext2
            // 
            this.lbtext2.AutoSize = true;
            this.lbtext2.BackColor = System.Drawing.Color.Transparent;
            this.lbtext2.Location = new System.Drawing.Point(498, 539);
            this.lbtext2.Name = "lbtext2";
            this.lbtext2.Size = new System.Drawing.Size(33, 13);
            this.lbtext2.TabIndex = 3;
            this.lbtext2.Text = "Time:";
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.BackColor = System.Drawing.Color.Transparent;
            this.lbtime.Location = new System.Drawing.Point(537, 539);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(35, 13);
            this.lbtime.TabIndex = 4;
            this.lbtime.Text = "label5";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(106, 536);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(386, 20);
            this.txtinput.TabIndex = 5;
            this.txtinput.TextChanged += new System.EventHandler(this.txtinput_TextChanged);
            // 
            // tmJump
            // 
            this.tmJump.Interval = 1000;
            this.tmJump.Tick += new System.EventHandler(this.tmJump_Tick);
            // 
            // tmRunToRight
            // 
            this.tmRunToRight.Interval = 1;
            this.tmRunToRight.Tick += new System.EventHandler(this.tmRunToRight_Tick);
            // 
            // tmSeconds
            // 
            this.tmSeconds.Interval = 1000;
            this.tmSeconds.Tick += new System.EventHandler(this.tmSeconds_Tick);
            // 
            // RunAndJump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.lbtext2);
            this.Controls.Add(this.lbpoints);
            this.Controls.Add(this.lbtext);
            this.Controls.Add(this.lbwoorden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunAndJump";
            this.Text = "Gaby Gabbai, AO1a3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbwoorden;
        private System.Windows.Forms.Label lbtext;
        private System.Windows.Forms.Label lbpoints;
        private System.Windows.Forms.Label lbtext2;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Timer tmJump;
        private System.Windows.Forms.Timer tmRunToRight;
        private System.Windows.Forms.Timer tmSeconds;
    }
}

