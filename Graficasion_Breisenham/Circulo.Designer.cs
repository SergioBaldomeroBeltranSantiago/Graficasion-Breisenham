
namespace Graficasion_Breisenham
{
    partial class Circulo
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
            this.Dibujasion = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.num_r = new System.Windows.Forms.NumericUpDown();
            this.num_y = new System.Windows.Forms.NumericUpDown();
            this.num_x = new System.Windows.Forms.NumericUpDown();
            this.btn_Dibujar = new System.Windows.Forms.Button();
            this.trb_Escala = new System.Windows.Forms.TrackBar();
            this.lb_Escala = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Escala)).BeginInit();
            this.SuspendLayout();
            // 
            // Dibujasion
            // 
            this.Dibujasion.AutoScroll = true;
            this.Dibujasion.AutoSize = true;
            this.Dibujasion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dibujasion.Location = new System.Drawing.Point(22, 22);
            this.Dibujasion.Margin = new System.Windows.Forms.Padding(6);
            this.Dibujasion.Name = "Dibujasion";
            this.Dibujasion.Size = new System.Drawing.Size(751, 395);
            this.Dibujasion.TabIndex = 0;
            this.Dibujasion.Paint += new System.Windows.Forms.PaintEventHandler(this.Dibujasion_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.num_r);
            this.groupBox1.Controls.Add(this.num_y);
            this.groupBox1.Controls.Add(this.num_x);
            this.groupBox1.Controls.Add(this.btn_Dibujar);
            this.groupBox1.Controls.Add(this.trb_Escala);
            this.groupBox1.Controls.Add(this.lb_Escala);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(785, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(442, 390);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control de circulo";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(9, 287);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(420, 37);
            this.btn_Limpiar.TabIndex = 24;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // num_r
            // 
            this.num_r.Location = new System.Drawing.Point(309, 83);
            this.num_r.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_r.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num_r.Name = "num_r";
            this.num_r.Size = new System.Drawing.Size(120, 29);
            this.num_r.TabIndex = 22;
            // 
            // num_y
            // 
            this.num_y.Location = new System.Drawing.Point(72, 136);
            this.num_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_y.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num_y.Name = "num_y";
            this.num_y.Size = new System.Drawing.Size(120, 29);
            this.num_y.TabIndex = 21;
            // 
            // num_x
            // 
            this.num_x.Location = new System.Drawing.Point(72, 80);
            this.num_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_x.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num_x.Name = "num_x";
            this.num_x.Size = new System.Drawing.Size(120, 29);
            this.num_x.TabIndex = 20;
            // 
            // btn_Dibujar
            // 
            this.btn_Dibujar.Location = new System.Drawing.Point(9, 330);
            this.btn_Dibujar.Name = "btn_Dibujar";
            this.btn_Dibujar.Size = new System.Drawing.Size(420, 37);
            this.btn_Dibujar.TabIndex = 19;
            this.btn_Dibujar.Text = "Dibujar";
            this.btn_Dibujar.UseVisualStyleBackColor = true;
            this.btn_Dibujar.Click += new System.EventHandler(this.btn_Dibujar_Click);
            // 
            // trb_Escala
            // 
            this.trb_Escala.Location = new System.Drawing.Point(25, 243);
            this.trb_Escala.Maximum = 5;
            this.trb_Escala.Minimum = 1;
            this.trb_Escala.Name = "trb_Escala";
            this.trb_Escala.Size = new System.Drawing.Size(404, 45);
            this.trb_Escala.TabIndex = 18;
            this.trb_Escala.Value = 1;
            this.trb_Escala.Scroll += new System.EventHandler(this.trb_Escala_Scroll);
            // 
            // lb_Escala
            // 
            this.lb_Escala.Location = new System.Drawing.Point(9, 206);
            this.lb_Escala.Name = "lb_Escala";
            this.lb_Escala.Size = new System.Drawing.Size(420, 34);
            this.lb_Escala.TabIndex = 17;
            this.lb_Escala.Text = "Escala";
            this.lb_Escala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "r = ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Coordenadas iniciales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "X = ";
            // 
            // Circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dibujasion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Circulo";
            this.Text = "Graficasion._.XD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Escala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Dibujasion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Escala;
        private System.Windows.Forms.TrackBar trb_Escala;
        private System.Windows.Forms.Button btn_Dibujar;
        private System.Windows.Forms.NumericUpDown num_x;
        private System.Windows.Forms.NumericUpDown num_r;
        private System.Windows.Forms.NumericUpDown num_y;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}

