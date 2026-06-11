namespace DVDL_System.People
{
    partial class frmFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindPerson));
            this.ctrlPersonCardWithFIlter1 = new DVDL_System.People.Controls.ctrlPersonCardWithFIlter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlPersonCardWithFIlter1
            // 
            this.ctrlPersonCardWithFIlter1.FilterEnabled = true;
            this.ctrlPersonCardWithFIlter1.Location = new System.Drawing.Point(12, 58);
            this.ctrlPersonCardWithFIlter1.Name = "ctrlPersonCardWithFIlter1";
            this.ctrlPersonCardWithFIlter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFIlter1.Size = new System.Drawing.Size(1012, 535);
            this.ctrlPersonCardWithFIlter1.TabIndex = 0;
            this.ctrlPersonCardWithFIlter1.Load += new System.EventHandler(this.ctrlPersonCardWithFIlter1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Person";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(826, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFindPerson
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonCardWithFIlter1);
            this.Name = "frmFindPerson";
            this.Text = "frmFindPerson";
            this.Load += new System.EventHandler(this.frmFindPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlPersonCardWithFIlter ctrlPersonCardWithFIlter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}