namespace Concurrenncias._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnCharge = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LoadingGIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCharge
            // 
            this.BtnCharge.Location = new System.Drawing.Point(81, 50);
            this.BtnCharge.Name = "BtnCharge";
            this.BtnCharge.Size = new System.Drawing.Size(78, 23);
            this.BtnCharge.TabIndex = 6;
            this.BtnCharge.Text = "Login";
            this.BtnCharge.UseVisualStyleBackColor = true;
            this.BtnCharge.Click += new System.EventHandler(this.BtnCharge_Click_1);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(81, 256);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(78, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // LoadingGIF
            // 
            this.LoadingGIF.Image = ((System.Drawing.Image)(resources.GetObject("LoadingGIF.Image")));
            this.LoadingGIF.Location = new System.Drawing.Point(43, 100);
            this.LoadingGIF.Name = "LoadingGIF";
            this.LoadingGIF.Size = new System.Drawing.Size(161, 115);
            this.LoadingGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingGIF.TabIndex = 8;
            this.LoadingGIF.TabStop = false;
            this.LoadingGIF.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 323);
            this.ControlBox = false;
            this.Controls.Add(this.LoadingGIF);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCharge);
            this.Name = "Form1";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnCharge;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.PictureBox LoadingGIF;
    }
}

