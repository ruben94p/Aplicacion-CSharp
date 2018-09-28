namespace CalculoReferencia
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
            this.lb_ref = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lb_res = new System.Windows.Forms.Label();
            this.tb_reference = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_ref
            // 
            this.lb_ref.AutoSize = true;
            this.lb_ref.Location = new System.Drawing.Point(12, 9);
            this.lb_ref.Name = "lb_ref";
            this.lb_ref.Size = new System.Drawing.Size(59, 13);
            this.lb_ref.TabIndex = 0;
            this.lb_ref.Text = "Referencia";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calculate.Location = new System.Drawing.Point(12, 51);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(409, 23);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Calcular";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lb_res
            // 
            this.lb_res.AutoSize = true;
            this.lb_res.Location = new System.Drawing.Point(12, 84);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(109, 13);
            this.lb_res.TabIndex = 3;
            this.lb_res.Text = "Referencia Completa:";
            this.lb_res.Visible = false;
            // 
            // tb_reference
            // 
            this.tb_reference.Location = new System.Drawing.Point(12, 25);
            this.tb_reference.MaxLength = 19;
            this.tb_reference.Name = "tb_reference";
            this.tb_reference.Size = new System.Drawing.Size(409, 20);
            this.tb_reference.TabIndex = 4;
            this.tb_reference.Text = "0";
            this.tb_reference.TextChanged += new System.EventHandler(this.tb_reference_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 106);
            this.Controls.Add(this.tb_reference);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lb_ref);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculo Referencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ref;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lb_res;
        private System.Windows.Forms.TextBox tb_reference;
    }
}

