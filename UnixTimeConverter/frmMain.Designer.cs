namespace UnixTimeConvertor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnok = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.lbresult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbnow = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNowEpoch = new System.Windows.Forms.Label();
            this.btnCopyInput = new System.Windows.Forms.Button();
            this.btnPasteInput = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(117, 145);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(164, 95);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "Convert";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtinput
            // 
            this.txtinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinput.Location = new System.Drawing.Point(12, 50);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(395, 40);
            this.txtinput.TabIndex = 1;
            this.txtinput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtinput_KeyDown);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.Location = new System.Drawing.Point(37, 93);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(332, 39);
            this.lbresult.TabIndex = 6;
            this.lbresult.Text = "01/01/1970 00:00:01";
            this.toolTip1.SetToolTip(this.lbresult, "Click to Copy to clipboard");
            this.lbresult.Click += new System.EventHandler(this.lbresult_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbnow
            // 
            this.lbnow.AutoSize = true;
            this.lbnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnow.Location = new System.Drawing.Point(-1, 267);
            this.lbnow.Name = "lbnow";
            this.lbnow.Size = new System.Drawing.Size(123, 16);
            this.lbnow.TabIndex = 7;
            this.lbnow.Text = "01/01/1970 00:00:01";
            this.toolTip1.SetToolTip(this.lbnow, "Click to Copy to clipboard");
            this.lbnow.Click += new System.EventHandler(this.lbnow_Click);
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(292, 267);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(157, 16);
            this.lbstatus.TabIndex = 8;
            this.lbstatus.Text = "(Copied to Clipboard)";
            this.lbstatus.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "dd/mm/yyyy hh:mm:ss";
            // 
            // lbNowEpoch
            // 
            this.lbNowEpoch.AutoSize = true;
            this.lbNowEpoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNowEpoch.Location = new System.Drawing.Point(170, 267);
            this.lbNowEpoch.Name = "lbNowEpoch";
            this.lbNowEpoch.Size = new System.Drawing.Size(23, 16);
            this.lbNowEpoch.TabIndex = 10;
            this.lbNowEpoch.Text = "(1)";
            this.toolTip1.SetToolTip(this.lbNowEpoch, "Click to Copy to clipboard");
            this.lbNowEpoch.Click += new System.EventHandler(this.lbNowEpoch_Click);
            // 
            // btnCopyInput
            // 
            this.btnCopyInput.BackgroundImage = global::UnixTimeConverter.Properties.Resources.copy_icon__3;
            this.btnCopyInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyInput.Location = new System.Drawing.Point(12, 4);
            this.btnCopyInput.Name = "btnCopyInput";
            this.btnCopyInput.Size = new System.Drawing.Size(36, 40);
            this.btnCopyInput.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnCopyInput, "Copy");
            this.btnCopyInput.UseVisualStyleBackColor = true;
            this.btnCopyInput.Click += new System.EventHandler(this.btnCopyInput_Click);
            // 
            // btnPasteInput
            // 
            this.btnPasteInput.BackgroundImage = global::UnixTimeConverter.Properties.Resources.SoftwareIcons_59_128;
            this.btnPasteInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasteInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteInput.Location = new System.Drawing.Point(54, 4);
            this.btnPasteInput.Name = "btnPasteInput";
            this.btnPasteInput.Size = new System.Drawing.Size(36, 40);
            this.btnPasteInput.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnPasteInput, "Paste");
            this.btnPasteInput.UseVisualStyleBackColor = true;
            this.btnPasteInput.Click += new System.EventHandler(this.btnPasteInput_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::UnixTimeConverter.Properties.Resources.icon_disable;
            this.button1.Location = new System.Drawing.Point(413, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 40);
            this.button1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.button1, "Clear");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 283);
            this.Controls.Add(this.btnPasteInput);
            this.Controls.Add(this.btnCopyInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNowEpoch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.lbnow);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btnok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unix Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbnow;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNowEpoch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCopyInput;
        private System.Windows.Forms.Button btnPasteInput;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

