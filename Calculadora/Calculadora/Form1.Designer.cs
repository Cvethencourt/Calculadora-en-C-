namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnMultiplicacion = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(12, 12);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(258, 43);
            this.Resultado.TabIndex = 0;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(12, 54);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(45, 33);
            this.Btn7.TabIndex = 1;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(63, 54);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(45, 33);
            this.Btn8.TabIndex = 2;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(114, 93);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(45, 33);
            this.Btn6.TabIndex = 3;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(63, 93);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(45, 33);
            this.Btn5.TabIndex = 4;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(12, 93);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(45, 33);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(114, 54);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(45, 33);
            this.Btn9.TabIndex = 6;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(114, 132);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(45, 33);
            this.Btn3.TabIndex = 7;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(63, 132);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(45, 33);
            this.Btn2.TabIndex = 8;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(12, 132);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(45, 33);
            this.Btn1.TabIndex = 9;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(12, 171);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(147, 33);
            this.Btn0.TabIndex = 10;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(185, 93);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(55, 33);
            this.BtnSuma.TabIndex = 11;
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.Location = new System.Drawing.Point(185, 132);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(55, 33);
            this.BtnResta.TabIndex = 12;
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = true;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Location = new System.Drawing.Point(185, 210);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(55, 33);
            this.BtnDivision.TabIndex = 13;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnMultiplicacion
            // 
            this.BtnMultiplicacion.Location = new System.Drawing.Point(185, 171);
            this.BtnMultiplicacion.Name = "BtnMultiplicacion";
            this.BtnMultiplicacion.Size = new System.Drawing.Size(55, 33);
            this.BtnMultiplicacion.TabIndex = 14;
            this.BtnMultiplicacion.Text = "*";
            this.BtnMultiplicacion.UseVisualStyleBackColor = true;
            this.BtnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacion_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.Location = new System.Drawing.Point(12, 210);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(147, 33);
            this.BtnIgual.TabIndex = 16;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnAC
            // 
            this.BtnAC.Location = new System.Drawing.Point(185, 54);
            this.BtnAC.Name = "BtnAC";
            this.BtnAC.Size = new System.Drawing.Size(55, 33);
            this.BtnAC.TabIndex = 17;
            this.BtnAC.Text = "C";
            this.BtnAC.UseVisualStyleBackColor = true;
            this.BtnAC.Click += new System.EventHandler(this.BtnAC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.BtnAC);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.BtnMultiplicacion);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Resultado);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnMultiplicacion;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnAC;
    }
}

