
namespace InputFunDisp
{
    partial class InputFunForm
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
            this.pInLParent = new System.Windows.Forms.Panel();
            this.posInL = new System.Windows.Forms.Panel();
            this.panelDelay = new System.Windows.Forms.Panel();
            this.posOutL = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nmInputController = new System.Windows.Forms.NumericUpDown();
            this.lblOutputInd = new System.Windows.Forms.Label();
            this.lblInputInd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmDelay = new System.Windows.Forms.NumericUpDown();
            this.bConnect = new System.Windows.Forms.Button();
            this.bCreateVirt = new System.Windows.Forms.Button();
            this.bStartDelay = new System.Windows.Forms.Button();
            this.bPrintCtlrs = new System.Windows.Forms.Button();
            this.cbInA = new System.Windows.Forms.CheckBox();
            this.cbInB = new System.Windows.Forms.CheckBox();
            this.cbInX = new System.Windows.Forms.CheckBox();
            this.cbInY = new System.Windows.Forms.CheckBox();
            this.pInRParent = new System.Windows.Forms.Panel();
            this.posInR = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.posOutR = new System.Windows.Forms.Panel();
            this.cbOutY = new System.Windows.Forms.CheckBox();
            this.cbOutX = new System.Windows.Forms.CheckBox();
            this.cbOutB = new System.Windows.Forms.CheckBox();
            this.cbOutA = new System.Windows.Forms.CheckBox();
            this.bCountUp = new System.Windows.Forms.Button();
            this.bCountDownTo0 = new System.Windows.Forms.Button();
            this.bCancelDelayTick = new System.Windows.Forms.Button();
            this.nmCountWait = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmCountRate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmOutCtlr = new System.Windows.Forms.NumericUpDown();
            this.bInputDebug = new System.Windows.Forms.Button();
            this.bChangeOutput = new System.Windows.Forms.Button();
            this.bChangeInput = new System.Windows.Forms.Button();
            this.pInLParent.SuspendLayout();
            this.panelDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmInputController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelay)).BeginInit();
            this.pInRParent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutCtlr)).BeginInit();
            this.SuspendLayout();
            // 
            // pInLParent
            // 
            this.pInLParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pInLParent.BackColor = System.Drawing.Color.Black;
            this.pInLParent.Controls.Add(this.posInL);
            this.pInLParent.Location = new System.Drawing.Point(488, 12);
            this.pInLParent.Name = "pInLParent";
            this.pInLParent.Size = new System.Drawing.Size(100, 100);
            this.pInLParent.TabIndex = 13;
            // 
            // posInL
            // 
            this.posInL.BackColor = System.Drawing.Color.HotPink;
            this.posInL.Location = new System.Drawing.Point(41, 44);
            this.posInL.Name = "posInL";
            this.posInL.Size = new System.Drawing.Size(12, 12);
            this.posInL.TabIndex = 0;
            // 
            // panelDelay
            // 
            this.panelDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDelay.BackColor = System.Drawing.Color.Black;
            this.panelDelay.Controls.Add(this.posOutL);
            this.panelDelay.Location = new System.Drawing.Point(488, 260);
            this.panelDelay.Name = "panelDelay";
            this.panelDelay.Size = new System.Drawing.Size(100, 100);
            this.panelDelay.TabIndex = 14;
            // 
            // posOutL
            // 
            this.posOutL.BackColor = System.Drawing.Color.HotPink;
            this.posOutL.Location = new System.Drawing.Point(41, 47);
            this.posOutL.Name = "posOutL";
            this.posOutL.Size = new System.Drawing.Size(12, 12);
            this.posOutL.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Input";
            // 
            // nmInputController
            // 
            this.nmInputController.Location = new System.Drawing.Point(24, 52);
            this.nmInputController.Name = "nmInputController";
            this.nmInputController.Size = new System.Drawing.Size(109, 20);
            this.nmInputController.TabIndex = 18;
            // 
            // lblOutputInd
            // 
            this.lblOutputInd.AutoSize = true;
            this.lblOutputInd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputInd.ForeColor = System.Drawing.Color.White;
            this.lblOutputInd.Location = new System.Drawing.Point(302, 261);
            this.lblOutputInd.Name = "lblOutputInd";
            this.lblOutputInd.Size = new System.Drawing.Size(88, 13);
            this.lblOutputInd.TabIndex = 19;
            this.lblOutputInd.Text = "Output Index: 0";
            // 
            // lblInputInd
            // 
            this.lblInputInd.AutoSize = true;
            this.lblInputInd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputInd.ForeColor = System.Drawing.Color.White;
            this.lblInputInd.Location = new System.Drawing.Point(302, 12);
            this.lblInputInd.Name = "lblInputInd";
            this.lblInputInd.Size = new System.Drawing.Size(78, 13);
            this.lblInputInd.TabIndex = 20;
            this.lblInputInd.Text = "Input Index: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Connect To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Current Delay (Ms):";
            // 
            // nmDelay
            // 
            this.nmDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmDelay.Location = new System.Drawing.Point(24, 121);
            this.nmDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmDelay.Name = "nmDelay";
            this.nmDelay.Size = new System.Drawing.Size(109, 20);
            this.nmDelay.TabIndex = 23;
            this.nmDelay.ValueChanged += new System.EventHandler(this.nmDelay_ValueChanged);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(134, 48);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(85, 25);
            this.bConnect.TabIndex = 24;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bCreateVirt
            // 
            this.bCreateVirt.Location = new System.Drawing.Point(131, 81);
            this.bCreateVirt.Name = "bCreateVirt";
            this.bCreateVirt.Size = new System.Drawing.Size(85, 26);
            this.bCreateVirt.TabIndex = 25;
            this.bCreateVirt.Text = "Create Output";
            this.bCreateVirt.UseVisualStyleBackColor = true;
            this.bCreateVirt.Click += new System.EventHandler(this.bCreateVirt_Click);
            // 
            // bStartDelay
            // 
            this.bStartDelay.Location = new System.Drawing.Point(24, 149);
            this.bStartDelay.Name = "bStartDelay";
            this.bStartDelay.Size = new System.Drawing.Size(109, 47);
            this.bStartDelay.TabIndex = 26;
            this.bStartDelay.Text = "Test Delay";
            this.bStartDelay.UseVisualStyleBackColor = true;
            this.bStartDelay.Click += new System.EventHandler(this.bStartDelay_Click);
            // 
            // bPrintCtlrs
            // 
            this.bPrintCtlrs.Location = new System.Drawing.Point(139, 121);
            this.bPrintCtlrs.Name = "bPrintCtlrs";
            this.bPrintCtlrs.Size = new System.Drawing.Size(85, 47);
            this.bPrintCtlrs.TabIndex = 31;
            this.bPrintCtlrs.Text = "Debug Print Controllers";
            this.bPrintCtlrs.UseVisualStyleBackColor = true;
            this.bPrintCtlrs.Click += new System.EventHandler(this.bPrintCtlrs_Click);
            // 
            // cbInA
            // 
            this.cbInA.AutoSize = true;
            this.cbInA.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInA.ForeColor = System.Drawing.Color.White;
            this.cbInA.Location = new System.Drawing.Point(662, 70);
            this.cbInA.Name = "cbInA";
            this.cbInA.Size = new System.Drawing.Size(33, 17);
            this.cbInA.TabIndex = 32;
            this.cbInA.Text = "A";
            this.cbInA.UseVisualStyleBackColor = true;
            // 
            // cbInB
            // 
            this.cbInB.AutoSize = true;
            this.cbInB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInB.ForeColor = System.Drawing.Color.White;
            this.cbInB.Location = new System.Drawing.Point(693, 47);
            this.cbInB.Name = "cbInB";
            this.cbInB.Size = new System.Drawing.Size(32, 17);
            this.cbInB.TabIndex = 33;
            this.cbInB.Text = "B";
            this.cbInB.UseVisualStyleBackColor = true;
            // 
            // cbInX
            // 
            this.cbInX.AutoSize = true;
            this.cbInX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInX.ForeColor = System.Drawing.Color.White;
            this.cbInX.Location = new System.Drawing.Point(631, 47);
            this.cbInX.Name = "cbInX";
            this.cbInX.Size = new System.Drawing.Size(32, 17);
            this.cbInX.TabIndex = 34;
            this.cbInX.Text = "X";
            this.cbInX.UseVisualStyleBackColor = true;
            // 
            // cbInY
            // 
            this.cbInY.AutoSize = true;
            this.cbInY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInY.ForeColor = System.Drawing.Color.White;
            this.cbInY.Location = new System.Drawing.Point(664, 24);
            this.cbInY.Name = "cbInY";
            this.cbInY.Size = new System.Drawing.Size(31, 17);
            this.cbInY.TabIndex = 35;
            this.cbInY.Text = "Y";
            this.cbInY.UseVisualStyleBackColor = true;
            // 
            // pInRParent
            // 
            this.pInRParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pInRParent.BackColor = System.Drawing.Color.Black;
            this.pInRParent.Controls.Add(this.posInR);
            this.pInRParent.Location = new System.Drawing.Point(664, 105);
            this.pInRParent.Name = "pInRParent";
            this.pInRParent.Size = new System.Drawing.Size(100, 100);
            this.pInRParent.TabIndex = 14;
            // 
            // posInR
            // 
            this.posInR.BackColor = System.Drawing.Color.HotPink;
            this.posInR.Location = new System.Drawing.Point(41, 44);
            this.posInR.Name = "posInR";
            this.posInR.Size = new System.Drawing.Size(12, 12);
            this.posInR.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(421, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Output";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.posOutR);
            this.panel1.Location = new System.Drawing.Point(627, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 15;
            // 
            // posOutR
            // 
            this.posOutR.BackColor = System.Drawing.Color.HotPink;
            this.posOutR.Location = new System.Drawing.Point(41, 44);
            this.posOutR.Name = "posOutR";
            this.posOutR.Size = new System.Drawing.Size(12, 12);
            this.posOutR.TabIndex = 0;
            // 
            // cbOutY
            // 
            this.cbOutY.AutoSize = true;
            this.cbOutY.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOutY.ForeColor = System.Drawing.Color.White;
            this.cbOutY.Location = new System.Drawing.Point(664, 260);
            this.cbOutY.Name = "cbOutY";
            this.cbOutY.Size = new System.Drawing.Size(31, 17);
            this.cbOutY.TabIndex = 40;
            this.cbOutY.Text = "Y";
            this.cbOutY.UseVisualStyleBackColor = true;
            // 
            // cbOutX
            // 
            this.cbOutX.AutoSize = true;
            this.cbOutX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOutX.ForeColor = System.Drawing.Color.White;
            this.cbOutX.Location = new System.Drawing.Point(631, 283);
            this.cbOutX.Name = "cbOutX";
            this.cbOutX.Size = new System.Drawing.Size(32, 17);
            this.cbOutX.TabIndex = 39;
            this.cbOutX.Text = "X";
            this.cbOutX.UseVisualStyleBackColor = true;
            // 
            // cbOutB
            // 
            this.cbOutB.AutoSize = true;
            this.cbOutB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOutB.ForeColor = System.Drawing.Color.White;
            this.cbOutB.Location = new System.Drawing.Point(696, 283);
            this.cbOutB.Name = "cbOutB";
            this.cbOutB.Size = new System.Drawing.Size(32, 17);
            this.cbOutB.TabIndex = 38;
            this.cbOutB.Text = "B";
            this.cbOutB.UseVisualStyleBackColor = true;
            // 
            // cbOutA
            // 
            this.cbOutA.AutoSize = true;
            this.cbOutA.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOutA.ForeColor = System.Drawing.Color.White;
            this.cbOutA.Location = new System.Drawing.Point(664, 306);
            this.cbOutA.Name = "cbOutA";
            this.cbOutA.Size = new System.Drawing.Size(33, 17);
            this.cbOutA.TabIndex = 37;
            this.cbOutA.Text = "A";
            this.cbOutA.UseVisualStyleBackColor = true;
            // 
            // bCountUp
            // 
            this.bCountUp.Location = new System.Drawing.Point(24, 227);
            this.bCountUp.Name = "bCountUp";
            this.bCountUp.Size = new System.Drawing.Size(109, 47);
            this.bCountUp.TabIndex = 42;
            this.bCountUp.Text = "Count Up To 2000";
            this.bCountUp.UseVisualStyleBackColor = true;
            this.bCountUp.Click += new System.EventHandler(this.bCountUp_Click);
            // 
            // bCountDownTo0
            // 
            this.bCountDownTo0.Location = new System.Drawing.Point(24, 283);
            this.bCountDownTo0.Name = "bCountDownTo0";
            this.bCountDownTo0.Size = new System.Drawing.Size(109, 47);
            this.bCountDownTo0.TabIndex = 43;
            this.bCountDownTo0.Text = "Count Down To 0";
            this.bCountDownTo0.UseVisualStyleBackColor = true;
            this.bCountDownTo0.Click += new System.EventHandler(this.bCountDownTo0_Click);
            // 
            // bCancelDelayTick
            // 
            this.bCancelDelayTick.Location = new System.Drawing.Point(139, 253);
            this.bCancelDelayTick.Name = "bCancelDelayTick";
            this.bCancelDelayTick.Size = new System.Drawing.Size(71, 47);
            this.bCancelDelayTick.TabIndex = 44;
            this.bCancelDelayTick.Text = "Cancel";
            this.bCancelDelayTick.UseVisualStyleBackColor = true;
            this.bCancelDelayTick.Click += new System.EventHandler(this.bCancelDelayTick_Click);
            // 
            // nmCountWait
            // 
            this.nmCountWait.Location = new System.Drawing.Point(24, 355);
            this.nmCountWait.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCountWait.Name = "nmCountWait";
            this.nmCountWait.Size = new System.Drawing.Size(109, 20);
            this.nmCountWait.TabIndex = 45;
            this.nmCountWait.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Count Delay (Ms):";
            // 
            // nmCountRate
            // 
            this.nmCountRate.Location = new System.Drawing.Point(24, 395);
            this.nmCountRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCountRate.Name = "nmCountRate";
            this.nmCountRate.Size = new System.Drawing.Size(109, 20);
            this.nmCountRate.TabIndex = 47;
            this.nmCountRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Count Rate:";
            // 
            // nmOutCtlr
            // 
            this.nmOutCtlr.Location = new System.Drawing.Point(235, 47);
            this.nmOutCtlr.Name = "nmOutCtlr";
            this.nmOutCtlr.Size = new System.Drawing.Size(85, 20);
            this.nmOutCtlr.TabIndex = 49;
            this.nmOutCtlr.Visible = false;
            // 
            // bInputDebug
            // 
            this.bInputDebug.Location = new System.Drawing.Point(342, 71);
            this.bInputDebug.Name = "bInputDebug";
            this.bInputDebug.Size = new System.Drawing.Size(109, 47);
            this.bInputDebug.TabIndex = 50;
            this.bInputDebug.Text = "Run ControllerDebug";
            this.bInputDebug.UseVisualStyleBackColor = true;
            this.bInputDebug.Visible = false;
            this.bInputDebug.Click += new System.EventHandler(this.bInputDebug_Click);
            // 
            // bChangeOutput
            // 
            this.bChangeOutput.Location = new System.Drawing.Point(326, 38);
            this.bChangeOutput.Name = "bChangeOutput";
            this.bChangeOutput.Size = new System.Drawing.Size(85, 26);
            this.bChangeOutput.TabIndex = 52;
            this.bChangeOutput.Text = "Change Output";
            this.bChangeOutput.UseVisualStyleBackColor = true;
            this.bChangeOutput.Visible = false;
            this.bChangeOutput.Click += new System.EventHandler(this.bChangeOutput_Click);
            // 
            // bChangeInput
            // 
            this.bChangeInput.Location = new System.Drawing.Point(134, 12);
            this.bChangeInput.Name = "bChangeInput";
            this.bChangeInput.Size = new System.Drawing.Size(85, 26);
            this.bChangeInput.TabIndex = 53;
            this.bChangeInput.Text = "Change Input";
            this.bChangeInput.UseVisualStyleBackColor = true;
            this.bChangeInput.Visible = false;
            this.bChangeInput.Click += new System.EventHandler(this.bChangeInput_Click);
            // 
            // InputFunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bChangeInput);
            this.Controls.Add(this.bChangeOutput);
            this.Controls.Add(this.bInputDebug);
            this.Controls.Add(this.nmOutCtlr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmCountRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmCountWait);
            this.Controls.Add(this.bCancelDelayTick);
            this.Controls.Add(this.bCountDownTo0);
            this.Controls.Add(this.bCountUp);
            this.Controls.Add(this.cbOutY);
            this.Controls.Add(this.cbOutX);
            this.Controls.Add(this.cbOutB);
            this.Controls.Add(this.cbOutA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pInRParent);
            this.Controls.Add(this.cbInY);
            this.Controls.Add(this.cbInX);
            this.Controls.Add(this.cbInB);
            this.Controls.Add(this.cbInA);
            this.Controls.Add(this.bPrintCtlrs);
            this.Controls.Add(this.bStartDelay);
            this.Controls.Add(this.bCreateVirt);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.nmDelay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInputInd);
            this.Controls.Add(this.lblOutputInd);
            this.Controls.Add(this.nmInputController);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pInLParent);
            this.Controls.Add(this.panelDelay);
            this.Name = "InputFunForm";
            this.Text = "Input Debug";
            this.pInLParent.ResumeLayout(false);
            this.panelDelay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmInputController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelay)).EndInit();
            this.pInRParent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmCountWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutCtlr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pInLParent;
        private System.Windows.Forms.Panel posInL;
        private System.Windows.Forms.Panel panelDelay;
        private System.Windows.Forms.Panel posOutL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmInputController;
        private System.Windows.Forms.Label lblOutputInd;
        private System.Windows.Forms.Label lblInputInd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmDelay;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bCreateVirt;
        private System.Windows.Forms.Button bStartDelay;
        private System.Windows.Forms.Button bPrintCtlrs;
        private System.Windows.Forms.CheckBox cbInA;
        private System.Windows.Forms.CheckBox cbInB;
        private System.Windows.Forms.CheckBox cbInX;
        private System.Windows.Forms.CheckBox cbInY;
        private System.Windows.Forms.Panel pInRParent;
        private System.Windows.Forms.Panel posInR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel posOutR;
        private System.Windows.Forms.CheckBox cbOutY;
        private System.Windows.Forms.CheckBox cbOutX;
        private System.Windows.Forms.CheckBox cbOutB;
        private System.Windows.Forms.CheckBox cbOutA;
        private System.Windows.Forms.Button bCountUp;
        private System.Windows.Forms.Button bCountDownTo0;
        private System.Windows.Forms.Button bCancelDelayTick;
        private System.Windows.Forms.NumericUpDown nmCountWait;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmCountRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmOutCtlr;
        private System.Windows.Forms.Button bInputDebug;
        private System.Windows.Forms.Button bChangeOutput;
        private System.Windows.Forms.Button bChangeInput;
    }
}

