namespace MapViewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNodeCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBranching = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSeed = new System.Windows.Forms.NumericUpDown();
            this.buttonDjikstra = new System.Windows.Forms.Button();
            this.buttonAstar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRandomWeights = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nodes:";
            // 
            // numericUpDownNodeCount
            // 
            this.numericUpDownNodeCount.Location = new System.Drawing.Point(61, 2);
            this.numericUpDownNodeCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownNodeCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNodeCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNodeCount.Name = "numericUpDownNodeCount";
            this.numericUpDownNodeCount.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownNodeCount.TabIndex = 1;
            this.numericUpDownNodeCount.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branching:";
            // 
            // numericUpDownBranching
            // 
            this.numericUpDownBranching.Location = new System.Drawing.Point(229, 2);
            this.numericUpDownBranching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownBranching.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBranching.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBranching.Name = "numericUpDownBranching";
            this.numericUpDownBranching.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownBranching.TabIndex = 3;
            this.numericUpDownBranching.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seed:";
            // 
            // numericUpDownSeed
            // 
            this.numericUpDownSeed.Location = new System.Drawing.Point(391, 2);
            this.numericUpDownSeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownSeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSeed.Name = "numericUpDownSeed";
            this.numericUpDownSeed.Size = new System.Drawing.Size(71, 22);
            this.numericUpDownSeed.TabIndex = 5;
            this.numericUpDownSeed.Value = new decimal(new int[] {
            773,
            0,
            0,
            0});
            // 
            // buttonDjikstra
            // 
            this.buttonDjikstra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDjikstra.Location = new System.Drawing.Point(959, 4);
            this.buttonDjikstra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDjikstra.Name = "buttonDjikstra";
            this.buttonDjikstra.Size = new System.Drawing.Size(75, 23);
            this.buttonDjikstra.TabIndex = 6;
            this.buttonDjikstra.Text = "Dijkstra";
            this.buttonDjikstra.UseVisualStyleBackColor = true;
            this.buttonDjikstra.Click += new System.EventHandler(this.buttonDjikstra_Click);
            // 
            // buttonAstar
            // 
            this.buttonAstar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAstar.Location = new System.Drawing.Point(1039, 4);
            this.buttonAstar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAstar.Name = "buttonAstar";
            this.buttonAstar.Size = new System.Drawing.Size(75, 23);
            this.buttonAstar.TabIndex = 7;
            this.buttonAstar.Text = "A*";
            this.buttonAstar.UseVisualStyleBackColor = true;
            this.buttonAstar.Click += new System.EventHandler(this.buttonAstar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 851);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1236, 186);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 815);
            this.panel1.TabIndex = 9;
            // 
            // cbRandomWeights
            // 
            this.cbRandomWeights.AutoSize = true;
            this.cbRandomWeights.Checked = true;
            this.cbRandomWeights.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRandomWeights.Location = new System.Drawing.Point(496, 4);
            this.cbRandomWeights.Margin = new System.Windows.Forms.Padding(4);
            this.cbRandomWeights.Name = "cbRandomWeights";
            this.cbRandomWeights.Size = new System.Drawing.Size(122, 21);
            this.cbRandomWeights.TabIndex = 12;
            this.cbRandomWeights.Text = "Random Costs";
            this.cbRandomWeights.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 1037);
            this.Controls.Add(this.cbRandomWeights);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonAstar);
            this.Controls.Add(this.buttonDjikstra);
            this.Controls.Add(this.numericUpDownSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownBranching);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownNodeCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Random Map";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNodeCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBranching;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSeed;
        private System.Windows.Forms.Button buttonDjikstra;
        private System.Windows.Forms.Button buttonAstar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbRandomWeights;
    }
}

