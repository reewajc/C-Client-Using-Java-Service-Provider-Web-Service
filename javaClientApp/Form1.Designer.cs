namespace javaClientApp
{
    partial class frmServiceClient
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
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.Location = new System.Drawing.Point(122, 296);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(188, 69);
            this.btnFindProduct.TabIndex = 0;
            this.btnFindProduct.Text = "Product Details";
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(273, 46);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(148, 22);
            this.txtProductCode.TabIndex = 1;
            // 
            // lblProduct
            // 
            this.lblProduct.Location = new System.Drawing.Point(34, 46);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(211, 45);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Please Enter Product Code:";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(51, 123);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(397, 130);
            this.lblMessage.TabIndex = 3;
            // 
            // frmServiceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 403);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.btnFindProduct);
            this.Name = "frmServiceClient";
            this.Text = "Java Service Client App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblMessage;
    }
}

