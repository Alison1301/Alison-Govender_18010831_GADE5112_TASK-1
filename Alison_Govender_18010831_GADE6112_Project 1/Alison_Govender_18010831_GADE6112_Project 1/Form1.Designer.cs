namespace Alison_Govender_18010831_GADE6112_Project_1
{
    partial class GameEngineFrm
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
            this.UnitLbl = new System.Windows.Forms.Label();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.RoundLbl = new System.Windows.Forms.Label();
            this.Game_Rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UnitLbl
            // 
            this.UnitLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitLbl.Location = new System.Drawing.Point(12, 9);
            this.UnitLbl.Name = "UnitLbl";
            this.UnitLbl.Size = new System.Drawing.Size(299, 432);
            this.UnitLbl.TabIndex = 0;
            this.UnitLbl.Click += new System.EventHandler(this.UnitLbl_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(362, 37);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(178, 50);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Pause_btn
            // 
            this.Pause_btn.Location = new System.Drawing.Point(362, 107);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(176, 54);
            this.Pause_btn.TabIndex = 2;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = true;
            this.Pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
            // 
            // RoundLbl
            // 
            this.RoundLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoundLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLbl.Location = new System.Drawing.Point(575, 37);
            this.RoundLbl.Name = "RoundLbl";
            this.RoundLbl.Size = new System.Drawing.Size(178, 78);
            this.RoundLbl.TabIndex = 3;
            this.RoundLbl.Click += new System.EventHandler(this.RoundLbl_Click);
            // 
            // Game_Rtb
            // 
            this.Game_Rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Rtb.Location = new System.Drawing.Point(328, 215);
            this.Game_Rtb.Name = "Game_Rtb";
            this.Game_Rtb.Size = new System.Drawing.Size(460, 226);
            this.Game_Rtb.TabIndex = 4;
            this.Game_Rtb.Text = "";
            this.Game_Rtb.TextChanged += new System.EventHandler(this.Game_Rtb_TextChanged);
            // 
            // GameEngineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Game_Rtb);
            this.Controls.Add(this.RoundLbl);
            this.Controls.Add(this.Pause_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.UnitLbl);
            this.Name = "GameEngineFrm";
            this.Text = "Game engine";
            this.Load += new System.EventHandler(this.GameEngineFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UnitLbl;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.Windows.Forms.Label RoundLbl;
        private System.Windows.Forms.RichTextBox Game_Rtb;
    }
}

