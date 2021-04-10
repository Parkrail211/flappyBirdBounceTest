
namespace flappyBirdBounceTest
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(183, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(387, 78);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Flappy Bird";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Red;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(281, 162);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(183, 54);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(281, 366);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(183, 54);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close Game";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // scoreOutput
            // 
            this.scoreOutput.BackColor = System.Drawing.Color.White;
            this.scoreOutput.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutput.ForeColor = System.Drawing.Color.Black;
            this.scoreOutput.Location = new System.Drawing.Point(190, 121);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(361, 283);
            this.scoreOutput.TabIndex = 3;
            this.scoreOutput.Visible = false;
            this.scoreOutput.Click += new System.EventHandler(this.scoreOutput_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.DarkOrange;
            this.scoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreButton.ForeColor = System.Drawing.Color.White;
            this.scoreButton.Location = new System.Drawing.Point(281, 267);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(183, 54);
            this.scoreButton.TabIndex = 4;
            this.scoreButton.Text = "Score Board";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(247, 178);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 5;
            this.nameBox.Visible = false;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameButton
            // 
            this.nameButton.BackColor = System.Drawing.Color.Red;
            this.nameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameButton.ForeColor = System.Drawing.Color.White;
            this.nameButton.Location = new System.Drawing.Point(401, 178);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 6;
            this.nameButton.Text = "Enter";
            this.nameButton.UseVisualStyleBackColor = false;
            this.nameButton.Visible = false;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(249, 203);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(98, 13);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Please enter name.";
            this.errorLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(589, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.spaceLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceLabel.ForeColor = System.Drawing.Color.White;
            this.spaceLabel.Location = new System.Drawing.Point(28, 97);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(705, 78);
            this.spaceLabel.TabIndex = 9;
            this.spaceLabel.Text = "Press Space To Begin";
            this.spaceLabel.Visible = false;
            this.spaceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::flappyBirdBounceTest.Properties.Resources.background_scene___flappy_bird_backround;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.scoreOutput);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(83)))), ((int)(((byte)(232)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label spaceLabel;
    }
}

