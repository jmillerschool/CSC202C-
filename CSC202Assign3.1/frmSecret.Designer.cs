namespace CSC202Assign3._1
{
    partial class frmSecret
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
            btnCloseForm = new Button();
            ptbDancing = new PictureBox();
            lblName = new Label();
            txbName = new TextBox();
            btnSaveToFile = new Button();
            btnReadFile = new Button();
            cbOverride = new CheckBox();
            lblContents = new Label();
            btnPressMe = new Button();
            lblDance = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbDancing).BeginInit();
            SuspendLayout();
            // 
            // btnCloseForm
            // 
            btnCloseForm.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseForm.Location = new Point(698, 415);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(90, 23);
            btnCloseForm.TabIndex = 0;
            btnCloseForm.Text = "Close Secret";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // ptbDancing
            // 
            ptbDancing.Location = new Point(450, 224);
            ptbDancing.Name = "ptbDancing";
            ptbDancing.Size = new Size(160, 174);
            ptbDancing.TabIndex = 1;
            ptbDancing.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(45, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(257, 27);
            lblName.TabIndex = 2;
            lblName.Text = "Please enter your name:";
            // 
            // txbName
            // 
            txbName.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbName.Location = new Point(337, 32);
            txbName.Name = "txbName";
            txbName.Size = new Size(162, 41);
            txbName.TabIndex = 3;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveToFile.Location = new Point(537, 24);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(179, 29);
            btnSaveToFile.TabIndex = 4;
            btnSaveToFile.Text = "Save/Write To File";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(547, 59);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(156, 31);
            btnReadFile.TabIndex = 5;
            btnReadFile.Text = "Read from file";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // cbOverride
            // 
            cbOverride.AutoSize = true;
            cbOverride.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbOverride.Location = new Point(575, 96);
            cbOverride.Name = "cbOverride";
            cbOverride.Size = new Size(96, 20);
            cbOverride.TabIndex = 6;
            cbOverride.Text = "Override file";
            cbOverride.UseVisualStyleBackColor = true;
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContents.Location = new Point(45, 96);
            lblContents.Name = "lblContents";
            lblContents.Size = new Size(27, 27);
            lblContents.TabIndex = 7;
            lblContents.Text = "...";
            // 
            // btnPressMe
            // 
            btnPressMe.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPressMe.Location = new Point(52, 260);
            btnPressMe.Name = "btnPressMe";
            btnPressMe.Size = new Size(91, 24);
            btnPressMe.TabIndex = 8;
            btnPressMe.Text = "Press me";
            btnPressMe.UseVisualStyleBackColor = true;
            btnPressMe.Click += btnPressMe_Click;
            // 
            // lblDance
            // 
            lblDance.AutoSize = true;
            lblDance.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDance.Location = new Point(49, 337);
            lblDance.Name = "lblDance";
            lblDance.Size = new Size(27, 27);
            lblDance.TabIndex = 9;
            lblDance.Text = "...";
            // 
            // frmSecret
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDance);
            Controls.Add(btnPressMe);
            Controls.Add(lblContents);
            Controls.Add(cbOverride);
            Controls.Add(btnReadFile);
            Controls.Add(btnSaveToFile);
            Controls.Add(txbName);
            Controls.Add(lblName);
            Controls.Add(ptbDancing);
            Controls.Add(btnCloseForm);
            Name = "frmSecret";
            Text = "frmSecret";
            ((System.ComponentModel.ISupportInitialize)ptbDancing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCloseForm;
        private PictureBox ptbDancing;
        private Label lblName;
        private TextBox txbName;
        private Button btnSaveToFile;
        private Button btnReadFile;
        private CheckBox cbOverride;
        private Label lblContents;
        private Button btnPressMe;
        private Label lblDance;
    }
}