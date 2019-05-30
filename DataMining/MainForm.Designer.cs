namespace DataMining
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.KMeansReset = new System.Windows.Forms.Button();
            this.KMeansShowClusters = new System.Windows.Forms.Button();
            this.KMeansFindNewCenters = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KMeansPicture = new System.Windows.Forms.PictureBox();
            this.KMeansClusters = new System.Windows.Forms.NumericUpDown();
            this.KMeansClustersLabel = new System.Windows.Forms.Label();
            this.KMeansRun = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PCAComponent3 = new System.Windows.Forms.Button();
            this.PCAComponent23 = new System.Windows.Forms.Button();
            this.PCAComponent13 = new System.Windows.Forms.Button();
            this.PCAComponent12 = new System.Windows.Forms.Button();
            this.PCAComponent1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PCAPicture = new System.Windows.Forms.PictureBox();
            this.PCAReset = new System.Windows.Forms.Button();
            this.PCAOpenImage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.KMeansShowOriginal = new System.Windows.Forms.Button();
            this.KMeansShowPoints = new System.Windows.Forms.Button();
            this.KMeansClearPoints = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KMeansPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMeansClusters)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCAPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.numericUpDown2);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(924, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bayes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 27);
            this.button6.TabIndex = 16;
            this.button6.Text = "Show Original";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 27);
            this.button7.TabIndex = 15;
            this.button7.Text = "Show Clusters";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(10, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 27);
            this.button8.TabIndex = 14;
            this.button8.Text = "Find New Centers";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(126, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(791, 410);
            this.panel4.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(760, 382);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(10, 73);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clusters";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 201);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 38);
            this.button9.TabIndex = 10;
            this.button9.Text = "Reset to Origin";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(10, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 38);
            this.button10.TabIndex = 9;
            this.button10.Text = "Open Image";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.numericUpDown3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(924, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "EM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(10, 112);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown3.TabIndex = 18;
            this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Iterations";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Find Segments";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(126, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 410);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(10, 73);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Segments";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "Open Image";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.KMeansClearPoints);
            this.tabPage2.Controls.Add(this.KMeansShowPoints);
            this.tabPage2.Controls.Add(this.KMeansShowOriginal);
            this.tabPage2.Controls.Add(this.KMeansReset);
            this.tabPage2.Controls.Add(this.KMeansShowClusters);
            this.tabPage2.Controls.Add(this.KMeansFindNewCenters);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.KMeansClusters);
            this.tabPage2.Controls.Add(this.KMeansClustersLabel);
            this.tabPage2.Controls.Add(this.KMeansRun);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 424);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "K-Means (RGB)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // KMeansReset
            // 
            this.KMeansReset.Location = new System.Drawing.Point(9, 275);
            this.KMeansReset.Name = "KMeansReset";
            this.KMeansReset.Size = new System.Drawing.Size(110, 38);
            this.KMeansReset.TabIndex = 8;
            this.KMeansReset.Text = "Reset to Original";
            this.KMeansReset.UseVisualStyleBackColor = true;
            this.KMeansReset.Click += new System.EventHandler(this.KMeansReset_Click);
            // 
            // KMeansShowClusters
            // 
            this.KMeansShowClusters.Location = new System.Drawing.Point(9, 131);
            this.KMeansShowClusters.Name = "KMeansShowClusters";
            this.KMeansShowClusters.Size = new System.Drawing.Size(110, 27);
            this.KMeansShowClusters.TabIndex = 7;
            this.KMeansShowClusters.Text = "Show Clusters";
            this.KMeansShowClusters.UseVisualStyleBackColor = true;
            this.KMeansShowClusters.Click += new System.EventHandler(this.KMeansShowClusters_Click);
            // 
            // KMeansFindNewCenters
            // 
            this.KMeansFindNewCenters.Location = new System.Drawing.Point(9, 98);
            this.KMeansFindNewCenters.Name = "KMeansFindNewCenters";
            this.KMeansFindNewCenters.Size = new System.Drawing.Size(110, 27);
            this.KMeansFindNewCenters.TabIndex = 6;
            this.KMeansFindNewCenters.Text = "Find New Centers";
            this.KMeansFindNewCenters.UseVisualStyleBackColor = true;
            this.KMeansFindNewCenters.Click += new System.EventHandler(this.KMeansFindNewCenters_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.KMeansPicture);
            this.panel1.Location = new System.Drawing.Point(125, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 410);
            this.panel1.TabIndex = 5;
            // 
            // KMeansPicture
            // 
            this.KMeansPicture.Location = new System.Drawing.Point(3, 3);
            this.KMeansPicture.Name = "KMeansPicture";
            this.KMeansPicture.Size = new System.Drawing.Size(760, 382);
            this.KMeansPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.KMeansPicture.TabIndex = 0;
            this.KMeansPicture.TabStop = false;
            this.KMeansPicture.Click += new System.EventHandler(this.KMeansPicture_Click);
            // 
            // KMeansClusters
            // 
            this.KMeansClusters.Location = new System.Drawing.Point(9, 72);
            this.KMeansClusters.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KMeansClusters.Name = "KMeansClusters";
            this.KMeansClusters.Size = new System.Drawing.Size(110, 20);
            this.KMeansClusters.TabIndex = 4;
            this.KMeansClusters.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // KMeansClustersLabel
            // 
            this.KMeansClustersLabel.AutoSize = true;
            this.KMeansClustersLabel.Location = new System.Drawing.Point(6, 56);
            this.KMeansClustersLabel.Name = "KMeansClustersLabel";
            this.KMeansClustersLabel.Size = new System.Drawing.Size(44, 13);
            this.KMeansClustersLabel.TabIndex = 3;
            this.KMeansClustersLabel.Text = "Clusters";
            // 
            // KMeansRun
            // 
            this.KMeansRun.Location = new System.Drawing.Point(9, 6);
            this.KMeansRun.Name = "KMeansRun";
            this.KMeansRun.Size = new System.Drawing.Size(110, 38);
            this.KMeansRun.TabIndex = 1;
            this.KMeansRun.Text = "Open Image";
            this.KMeansRun.UseVisualStyleBackColor = true;
            this.KMeansRun.Click += new System.EventHandler(this.KMeansRun_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PCAComponent3);
            this.tabPage1.Controls.Add(this.PCAComponent23);
            this.tabPage1.Controls.Add(this.PCAComponent13);
            this.tabPage1.Controls.Add(this.PCAComponent12);
            this.tabPage1.Controls.Add(this.PCAComponent1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.PCAReset);
            this.tabPage1.Controls.Add(this.PCAOpenImage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 424);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "PCA (RGB)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PCAComponent3
            // 
            this.PCAComponent3.Location = new System.Drawing.Point(10, 193);
            this.PCAComponent3.Name = "PCAComponent3";
            this.PCAComponent3.Size = new System.Drawing.Size(110, 26);
            this.PCAComponent3.TabIndex = 15;
            this.PCAComponent3.Text = "3 Component";
            this.PCAComponent3.UseVisualStyleBackColor = true;
            this.PCAComponent3.Click += new System.EventHandler(this.PCAComponent3_Click);
            // 
            // PCAComponent23
            // 
            this.PCAComponent23.Location = new System.Drawing.Point(10, 161);
            this.PCAComponent23.Name = "PCAComponent23";
            this.PCAComponent23.Size = new System.Drawing.Size(110, 26);
            this.PCAComponent23.TabIndex = 14;
            this.PCAComponent23.Text = "2 and 3 Component";
            this.PCAComponent23.UseVisualStyleBackColor = true;
            this.PCAComponent23.Click += new System.EventHandler(this.PCAComponent23_Click);
            // 
            // PCAComponent13
            // 
            this.PCAComponent13.Location = new System.Drawing.Point(10, 129);
            this.PCAComponent13.Name = "PCAComponent13";
            this.PCAComponent13.Size = new System.Drawing.Size(110, 26);
            this.PCAComponent13.TabIndex = 13;
            this.PCAComponent13.Text = "1 and 3 Component";
            this.PCAComponent13.UseVisualStyleBackColor = true;
            this.PCAComponent13.Click += new System.EventHandler(this.PCAComponent13_Click);
            // 
            // PCAComponent12
            // 
            this.PCAComponent12.Location = new System.Drawing.Point(10, 97);
            this.PCAComponent12.Name = "PCAComponent12";
            this.PCAComponent12.Size = new System.Drawing.Size(110, 26);
            this.PCAComponent12.TabIndex = 12;
            this.PCAComponent12.Text = "1 and 2 Component";
            this.PCAComponent12.UseVisualStyleBackColor = true;
            this.PCAComponent12.Click += new System.EventHandler(this.PCAComponent12_Click);
            // 
            // PCAComponent1
            // 
            this.PCAComponent1.Location = new System.Drawing.Point(10, 65);
            this.PCAComponent1.Name = "PCAComponent1";
            this.PCAComponent1.Size = new System.Drawing.Size(110, 26);
            this.PCAComponent1.TabIndex = 11;
            this.PCAComponent1.Text = "1 Component";
            this.PCAComponent1.UseVisualStyleBackColor = true;
            this.PCAComponent1.Click += new System.EventHandler(this.PCAComponent1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.PCAPicture);
            this.panel2.Location = new System.Drawing.Point(126, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 410);
            this.panel2.TabIndex = 10;
            // 
            // PCAPicture
            // 
            this.PCAPicture.Location = new System.Drawing.Point(3, 3);
            this.PCAPicture.Name = "PCAPicture";
            this.PCAPicture.Size = new System.Drawing.Size(760, 382);
            this.PCAPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PCAPicture.TabIndex = 0;
            this.PCAPicture.TabStop = false;
            // 
            // PCAReset
            // 
            this.PCAReset.Location = new System.Drawing.Point(10, 240);
            this.PCAReset.Name = "PCAReset";
            this.PCAReset.Size = new System.Drawing.Size(110, 38);
            this.PCAReset.TabIndex = 7;
            this.PCAReset.Text = "Reset to Original";
            this.PCAReset.UseVisualStyleBackColor = true;
            this.PCAReset.Click += new System.EventHandler(this.PCAReset_Click);
            // 
            // PCAOpenImage
            // 
            this.PCAOpenImage.Location = new System.Drawing.Point(10, 6);
            this.PCAOpenImage.Name = "PCAOpenImage";
            this.PCAOpenImage.Size = new System.Drawing.Size(110, 38);
            this.PCAOpenImage.TabIndex = 6;
            this.PCAOpenImage.Text = "Open Image";
            this.PCAOpenImage.UseVisualStyleBackColor = true;
            this.PCAOpenImage.Click += new System.EventHandler(this.PCAOpenImage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // KMeansShowOriginal
            // 
            this.KMeansShowOriginal.Location = new System.Drawing.Point(9, 164);
            this.KMeansShowOriginal.Name = "KMeansShowOriginal";
            this.KMeansShowOriginal.Size = new System.Drawing.Size(110, 27);
            this.KMeansShowOriginal.TabIndex = 9;
            this.KMeansShowOriginal.Text = "Show Original";
            this.KMeansShowOriginal.UseVisualStyleBackColor = true;
            this.KMeansShowOriginal.Click += new System.EventHandler(this.KMeansShowOriginal_Click);
            // 
            // KMeansShowPoints
            // 
            this.KMeansShowPoints.Location = new System.Drawing.Point(9, 197);
            this.KMeansShowPoints.Name = "KMeansShowPoints";
            this.KMeansShowPoints.Size = new System.Drawing.Size(110, 27);
            this.KMeansShowPoints.TabIndex = 10;
            this.KMeansShowPoints.Text = "Show Points";
            this.KMeansShowPoints.UseVisualStyleBackColor = true;
            this.KMeansShowPoints.Click += new System.EventHandler(this.KMeansShowPoints_Click);
            // 
            // KMeansClearPoints
            // 
            this.KMeansClearPoints.Location = new System.Drawing.Point(9, 230);
            this.KMeansClearPoints.Name = "KMeansClearPoints";
            this.KMeansClearPoints.Size = new System.Drawing.Size(110, 27);
            this.KMeansClearPoints.TabIndex = 11;
            this.KMeansClearPoints.Text = "Clear Points";
            this.KMeansClearPoints.UseVisualStyleBackColor = true;
            this.KMeansClearPoints.Click += new System.EventHandler(this.KMeansClearPoints_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "DataMining";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KMeansPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KMeansClusters)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCAPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button KMeansReset;
        private System.Windows.Forms.Button KMeansShowClusters;
        private System.Windows.Forms.Button KMeansFindNewCenters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox KMeansPicture;
        private System.Windows.Forms.NumericUpDown KMeansClusters;
        private System.Windows.Forms.Label KMeansClustersLabel;
        private System.Windows.Forms.Button KMeansRun;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button PCAComponent3;
        private System.Windows.Forms.Button PCAComponent23;
        private System.Windows.Forms.Button PCAComponent13;
        private System.Windows.Forms.Button PCAComponent12;
        private System.Windows.Forms.Button PCAComponent1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PCAPicture;
        private System.Windows.Forms.Button PCAReset;
        private System.Windows.Forms.Button PCAOpenImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button KMeansClearPoints;
        private System.Windows.Forms.Button KMeansShowPoints;
        private System.Windows.Forms.Button KMeansShowOriginal;
    }
}

