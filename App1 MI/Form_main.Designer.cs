namespace App1_MI
{
    partial class Form_main
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
            this.button_exit = new MaterialSkin.Controls.MaterialFlatButton();
            this.button_samochody = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_exit.Depth = 0;
            this.button_exit.Location = new System.Drawing.Point(625, 372);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_exit.Name = "button_exit";
            this.button_exit.Primary = false;
            this.button_exit.Size = new System.Drawing.Size(41, 36);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_samochody
            // 
            this.button_samochody.AutoSize = true;
            this.button_samochody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_samochody.Depth = 0;
            this.button_samochody.Location = new System.Drawing.Point(303, 209);
            this.button_samochody.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_samochody.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_samochody.Name = "button_samochody";
            this.button_samochody.Primary = false;
            this.button_samochody.Size = new System.Drawing.Size(96, 36);
            this.button_samochody.TabIndex = 5;
            this.button_samochody.Text = "Samochody";
            this.button_samochody.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_samochody.UseVisualStyleBackColor = true;
            this.button_samochody.Click += new System.EventHandler(this.button_samochody_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 448);
            this.Controls.Add(this.button_samochody);
            this.Controls.Add(this.button_exit);
            this.Name = "Form_main";
            this.Text = "WYPOŻYCZALNIA SAMOCHODÓW - IBROM & WOSKOWICZ - PANEL GŁÓWNY";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton button_exit;
        private MaterialSkin.Controls.MaterialFlatButton button_samochody;
    }
}