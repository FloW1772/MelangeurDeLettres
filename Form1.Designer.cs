namespace MelangeurDeLettres
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonMelanger = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.checkBoxShuffleWords = new System.Windows.Forms.CheckBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez un mot ou une phrase :";
            //
            // textBoxInput
            //
            this.textBoxInput.Location = new System.Drawing.Point(15, 34);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(360, 100);
            this.textBoxInput.TabIndex = 1;
            //
            // buttonMelanger
            //
            this.buttonMelanger.Location = new System.Drawing.Point(15, 140);
            this.buttonMelanger.Name = "buttonMelanger";
            this.buttonMelanger.Size = new System.Drawing.Size(100, 30);
            this.buttonMelanger.TabIndex = 2;
            this.buttonMelanger.Text = "Mélanger";
            this.buttonMelanger.UseVisualStyleBackColor = true;
            this.buttonMelanger.Click += new System.EventHandler(this.buttonMelanger_Click);
            //
            // labelResult
            //
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(15, 180);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 16);
            this.labelResult.TabIndex = 3;
            //
            // checkBoxShuffleWords
            //
            this.checkBoxShuffleWords.AutoSize = true;
            this.checkBoxShuffleWords.Location = new System.Drawing.Point(15, 210);
            this.checkBoxShuffleWords.Name = "checkBoxShuffleWords";
            this.checkBoxShuffleWords.Size = new System.Drawing.Size(180, 20);
            this.checkBoxShuffleWords.TabIndex = 4;
            this.checkBoxShuffleWords.Text = "Mélanger chaque mot séparément";
            this.checkBoxShuffleWords.UseVisualStyleBackColor = true;
            //
            // buttonCopy
            //
            this.buttonCopy.Location = new System.Drawing.Point(120, 140);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 30);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Copier";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 240);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.checkBoxShuffleWords);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonMelanger);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mélangeur de Lettres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonMelanger;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.CheckBox checkBoxShuffleWords;
        private System.Windows.Forms.Button buttonCopy;
    }
}
