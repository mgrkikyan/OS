partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button StartButton;
    private System.Windows.Forms.TextBox txtWriter1Input;
    private System.Windows.Forms.TextBox txtWriter2Input;
    private System.Windows.Forms.TextBox txtWriter1Log;
    private System.Windows.Forms.TextBox txtWriter2Log;
    private System.Windows.Forms.TextBox txtReader1Log;
    private System.Windows.Forms.TextBox txtReader2Log;

    private void InitializeComponent()
    {
        this.StartButton = new System.Windows.Forms.Button();
        this.txtWriter1Input = new System.Windows.Forms.TextBox();
        this.txtWriter2Input = new System.Windows.Forms.TextBox();
        this.txtWriter1Log = new System.Windows.Forms.TextBox();
        this.txtWriter2Log = new System.Windows.Forms.TextBox();
        this.txtReader1Log = new System.Windows.Forms.TextBox();
        this.txtReader2Log = new System.Windows.Forms.TextBox();
        this.SuspendLayout();

        // StartButton
        this.StartButton.Location = new System.Drawing.Point(12, 12);
        this.StartButton.Name = "StartButton";
        this.StartButton.Size = new System.Drawing.Size(75, 23);
        this.StartButton.TabIndex = 0;
        this.StartButton.Text = "Start";
        this.StartButton.UseVisualStyleBackColor = true;
        this.StartButton.Click += new System.EventHandler(this.StartButton_Click);

        // txtWriter1Input
        this.txtWriter1Input.Location = new System.Drawing.Point(12, 50);
        this.txtWriter1Input.Name = "txtWriter1Input";
        this.txtWriter1Input.Size = new System.Drawing.Size(200, 20);
        this.txtWriter1Input.TabIndex = 1;

        // txtWriter2Input
        this.txtWriter2Input.Location = new System.Drawing.Point(12, 90);
        this.txtWriter2Input.Name = "txtWriter2Input";
        this.txtWriter2Input.Size = new System.Drawing.Size(200, 20);
        this.txtWriter2Input.TabIndex = 2;

        // txtWriter1Log
        this.txtWriter1Log.Location = new System.Drawing.Point(12, 130);
        this.txtWriter1Log.Multiline = true;
        this.txtWriter1Log.Name = "txtWriter1Log";
        this.txtWriter1Log.ReadOnly = true;
        this.txtWriter1Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtWriter1Log.Size = new System.Drawing.Size(200, 100);
        this.txtWriter1Log.TabIndex = 3;

        // txtWriter2Log
        this.txtWriter2Log.Location = new System.Drawing.Point(12, 240);
        this.txtWriter2Log.Multiline = true;
        this.txtWriter2Log.Name = "txtWriter2Log";
        this.txtWriter2Log.ReadOnly = true;
        this.txtWriter2Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtWriter2Log.Size = new System.Drawing.Size(200, 100);
        this.txtWriter2Log.TabIndex = 4;

        // txtReader1Log
        this.txtReader1Log.Location = new System.Drawing.Point(230, 130);
        this.txtReader1Log.Multiline = true;
        this.txtReader1Log.Name = "txtReader1Log";
        this.txtReader1Log.ReadOnly = true;
        this.txtReader1Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtReader1Log.Size = new System.Drawing.Size(200, 100);
        this.txtReader1Log.TabIndex = 5;

        // txtReader2Log
        this.txtReader2Log.Location = new System.Drawing.Point(230, 240);
        this.txtReader2Log.Multiline = true;
        this.txtReader2Log.Name = "txtReader2Log";
        this.txtReader2Log.ReadOnly = true;
        this.txtReader2Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtReader2Log.Size = new System.Drawing.Size(200, 100);
        this.txtReader2Log.TabIndex = 6;

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(450, 360);
        this.Controls.Add(this.txtReader2Log);
        this.Controls.Add(this.txtReader1Log);
        this.Controls.Add(this.txtWriter2Log);
        this.Controls.Add(this.txtWriter1Log);
        this.Controls.Add(this.txtWriter2Input);
        this.Controls.Add(this.txtWriter1Input);
        this.Controls.Add(this.StartButton);
        this.Name = "Form1";
        this.Text = "Thread Synchronization";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}