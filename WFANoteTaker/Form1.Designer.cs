
namespace WFANoteTaker
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(40, 58);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(70, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            //this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(40, 224);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(130, 32);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Message";
            //this.labelMessage.Click += new System.EventHandler(this.labelMessage_Click);
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(46, 293);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(491, 184);
            this.messageText.TabIndex = 2;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(46, 121);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(500, 38);
            this.titleText.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(626, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(491, 419);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(55, 588);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(207, 46);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(339, 588);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(207, 46);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(626, 588);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(207, 46);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDelete.Location = new System.Drawing.Point(910, 588);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(207, 46);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 728);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonDelete;
    }
}

