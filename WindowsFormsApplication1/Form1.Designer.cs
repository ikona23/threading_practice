namespace WindowsFormsApplication1
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
            this.btnRed = new System.Windows.Forms.Button();
            this.tbxRedHeight = new System.Windows.Forms.TextBox();
            this.pbxRed = new System.Windows.Forms.PictureBox();
            this.btnBlue = new System.Windows.Forms.Button();
            this.tbxBlueHeight = new System.Windows.Forms.TextBox();
            this.pbxBlue = new System.Windows.Forms.PictureBox();
            this.btnDoAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.lbxSavedItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(12, 10);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Grow Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // tbxRedHeight
            // 
            this.tbxRedHeight.Location = new System.Drawing.Point(12, 39);
            this.tbxRedHeight.Name = "tbxRedHeight";
            this.tbxRedHeight.Size = new System.Drawing.Size(100, 20);
            this.tbxRedHeight.TabIndex = 1;
            // 
            // pbxRed
            // 
            this.pbxRed.BackColor = System.Drawing.Color.Red;
            this.pbxRed.Location = new System.Drawing.Point(12, 94);
            this.pbxRed.Name = "pbxRed";
            this.pbxRed.Size = new System.Drawing.Size(100, 50);
            this.pbxRed.TabIndex = 2;
            this.pbxRed.TabStop = false;
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(122, 10);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 3;
            this.btnBlue.Text = "Grow Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // tbxBlueHeight
            // 
            this.tbxBlueHeight.Location = new System.Drawing.Point(122, 39);
            this.tbxBlueHeight.Name = "tbxBlueHeight";
            this.tbxBlueHeight.Size = new System.Drawing.Size(100, 20);
            this.tbxBlueHeight.TabIndex = 4;
            // 
            // pbxBlue
            // 
            this.pbxBlue.BackColor = System.Drawing.Color.Blue;
            this.pbxBlue.Location = new System.Drawing.Point(122, 94);
            this.pbxBlue.Name = "pbxBlue";
            this.pbxBlue.Size = new System.Drawing.Size(100, 50);
            this.pbxBlue.TabIndex = 5;
            this.pbxBlue.TabStop = false;
            // 
            // btnDoAll
            // 
            this.btnDoAll.Location = new System.Drawing.Point(39, 65);
            this.btnDoAll.Name = "btnDoAll";
            this.btnDoAll.Size = new System.Drawing.Size(149, 23);
            this.btnDoAll.TabIndex = 6;
            this.btnDoAll.Text = "Red and Blue";
            this.btnDoAll.UseVisualStyleBackColor = true;
            this.btnDoAll.Click += new System.EventHandler(this.btnDoAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(259, 39);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(259, 68);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 9;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // lbxSavedItems
            // 
            this.lbxSavedItems.FormattingEnabled = true;
            this.lbxSavedItems.Location = new System.Drawing.Point(259, 108);
            this.lbxSavedItems.Name = "lbxSavedItems";
            this.lbxSavedItems.Size = new System.Drawing.Size(120, 95);
            this.lbxSavedItems.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 441);
            this.Controls.Add(this.lbxSavedItems);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDoAll);
            this.Controls.Add(this.pbxBlue);
            this.Controls.Add(this.tbxBlueHeight);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.pbxRed);
            this.Controls.Add(this.tbxRedHeight);
            this.Controls.Add(this.btnRed);
            this.Name = "Form1";
            this.Text = "Peter Practice";
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.TextBox tbxRedHeight;
        private System.Windows.Forms.PictureBox pbxRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.TextBox tbxBlueHeight;
        private System.Windows.Forms.PictureBox pbxBlue;
        private System.Windows.Forms.Button btnDoAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.ListBox lbxSavedItems;
    }
}

