namespace Pizza_Order
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            gbSize = new GroupBox();
            rdLarge = new RadioButton();
            rdMedum = new RadioButton();
            rdSmall = new RadioButton();
            gbCurst = new GroupBox();
            rdThinkCrust = new RadioButton();
            rdThinCrust = new RadioButton();
            gbToppings = new GroupBox();
            chkTomatoes = new CheckBox();
            chkOlives = new CheckBox();
            chkGreenPeppers = new CheckBox();
            chkMushrooms = new CheckBox();
            chkOnion = new CheckBox();
            chkExtraChees = new CheckBox();
            gbWhereToEat = new GroupBox();
            rdTakeOut = new RadioButton();
            rdEatIn = new RadioButton();
            gbOrderSummary = new GroupBox();
            LaPriceInNumber = new Label();
            LaPriceNumber = new Label();
            LaPrice = new Label();
            LaToppingsChoosen = new Label();
            LaToppings = new Label();
            LaWhereToEatChoosen = new Label();
            LaWhereToEat = new Label();
            LaCrustChoosen = new Label();
            LaCrustType = new Label();
            LaSizeChoosen = new Label();
            LaSize = new Label();
            btnOrder = new Button();
            btnReset = new Button();
            gbSize.SuspendLayout();
            gbCurst.SuspendLayout();
            gbToppings.SuspendLayout();
            gbWhereToEat.SuspendLayout();
            gbOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Red;
            label1.Name = "label1";
            // 
            // gbSize
            // 
            gbSize.Controls.Add(rdLarge);
            gbSize.Controls.Add(rdMedum);
            gbSize.Controls.Add(rdSmall);
            gbSize.FlatStyle = FlatStyle.Flat;
            resources.ApplyResources(gbSize, "gbSize");
            gbSize.ForeColor = SystemColors.ActiveCaptionText;
            gbSize.Name = "gbSize";
            gbSize.TabStop = false;
            // 
            // rdLarge
            // 
            resources.ApplyResources(rdLarge, "rdLarge");
            rdLarge.Name = "rdLarge";
            rdLarge.TabStop = true;
            rdLarge.Tag = "40";
            rdLarge.UseVisualStyleBackColor = true;
            rdLarge.CheckedChanged += rdLarge_CheckedChanged_1;
            // 
            // rdMedum
            // 
            resources.ApplyResources(rdMedum, "rdMedum");
            rdMedum.Name = "rdMedum";
            rdMedum.TabStop = true;
            rdMedum.Tag = "30";
            rdMedum.UseVisualStyleBackColor = true;
            rdMedum.CheckedChanged += rdMedum_CheckedChanged;
            // 
            // rdSmall
            // 
            resources.ApplyResources(rdSmall, "rdSmall");
            rdSmall.Name = "rdSmall";
            rdSmall.TabStop = true;
            rdSmall.Tag = "20";
            rdSmall.UseVisualStyleBackColor = true;
            rdSmall.CheckedChanged += rdSmall_CheckedChanged;
            // 
            // gbCurst
            // 
            gbCurst.Controls.Add(rdThinkCrust);
            gbCurst.Controls.Add(rdThinCrust);
            gbCurst.FlatStyle = FlatStyle.Flat;
            resources.ApplyResources(gbCurst, "gbCurst");
            gbCurst.ForeColor = SystemColors.ActiveCaptionText;
            gbCurst.Name = "gbCurst";
            gbCurst.TabStop = false;
            // 
            // rdThinkCrust
            // 
            resources.ApplyResources(rdThinkCrust, "rdThinkCrust");
            rdThinkCrust.Name = "rdThinkCrust";
            rdThinkCrust.TabStop = true;
            rdThinkCrust.Tag = "10";
            rdThinkCrust.UseVisualStyleBackColor = true;
            rdThinkCrust.CheckedChanged += rdThinkCrust_CheckedChanged;
            // 
            // rdThinCrust
            // 
            resources.ApplyResources(rdThinCrust, "rdThinCrust");
            rdThinCrust.Name = "rdThinCrust";
            rdThinCrust.TabStop = true;
            rdThinCrust.UseVisualStyleBackColor = true;
            rdThinCrust.CheckedChanged += rdThinCrust_CheckedChanged;
            // 
            // gbToppings
            // 
            gbToppings.Controls.Add(chkTomatoes);
            gbToppings.Controls.Add(chkOlives);
            gbToppings.Controls.Add(chkGreenPeppers);
            gbToppings.Controls.Add(chkMushrooms);
            gbToppings.Controls.Add(chkOnion);
            gbToppings.Controls.Add(chkExtraChees);
            gbToppings.FlatStyle = FlatStyle.Flat;
            resources.ApplyResources(gbToppings, "gbToppings");
            gbToppings.ForeColor = SystemColors.ActiveCaptionText;
            gbToppings.Name = "gbToppings";
            gbToppings.TabStop = false;
            // 
            // chkTomatoes
            // 
            resources.ApplyResources(chkTomatoes, "chkTomatoes");
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Tag = "5";
            chkTomatoes.UseVisualStyleBackColor = true;
            chkTomatoes.CheckedChanged += chkTomatoes_CheckedChanged;
            // 
            // chkOlives
            // 
            resources.ApplyResources(chkOlives, "chkOlives");
            chkOlives.Name = "chkOlives";
            chkOlives.Tag = "5";
            chkOlives.UseVisualStyleBackColor = true;
            chkOlives.CheckedChanged += chkOlives_CheckedChanged;
            // 
            // chkGreenPeppers
            // 
            resources.ApplyResources(chkGreenPeppers, "chkGreenPeppers");
            chkGreenPeppers.Name = "chkGreenPeppers";
            chkGreenPeppers.Tag = "5";
            chkGreenPeppers.UseVisualStyleBackColor = true;
            chkGreenPeppers.CheckedChanged += chkGreenPeppers_CheckedChanged;
            // 
            // chkMushrooms
            // 
            resources.ApplyResources(chkMushrooms, "chkMushrooms");
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Tag = "5";
            chkMushrooms.UseVisualStyleBackColor = true;
            chkMushrooms.CheckedChanged += chkMushrooms_CheckedChanged;
            // 
            // chkOnion
            // 
            resources.ApplyResources(chkOnion, "chkOnion");
            chkOnion.Name = "chkOnion";
            chkOnion.Tag = "5";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += chkOnion_CheckedChanged;
            // 
            // chkExtraChees
            // 
            resources.ApplyResources(chkExtraChees, "chkExtraChees");
            chkExtraChees.Name = "chkExtraChees";
            chkExtraChees.Tag = "5";
            chkExtraChees.UseVisualStyleBackColor = true;
            chkExtraChees.CheckedChanged += chkExtraChees_CheckedChanged;
            // 
            // gbWhereToEat
            // 
            gbWhereToEat.Controls.Add(rdTakeOut);
            gbWhereToEat.Controls.Add(rdEatIn);
            gbWhereToEat.FlatStyle = FlatStyle.Flat;
            resources.ApplyResources(gbWhereToEat, "gbWhereToEat");
            gbWhereToEat.ForeColor = SystemColors.ActiveCaptionText;
            gbWhereToEat.Name = "gbWhereToEat";
            gbWhereToEat.TabStop = false;
            // 
            // rdTakeOut
            // 
            resources.ApplyResources(rdTakeOut, "rdTakeOut");
            rdTakeOut.Name = "rdTakeOut";
            rdTakeOut.TabStop = true;
            rdTakeOut.UseVisualStyleBackColor = true;
            rdTakeOut.CheckedChanged += rdTakeOut_CheckedChanged;
            // 
            // rdEatIn
            // 
            resources.ApplyResources(rdEatIn, "rdEatIn");
            rdEatIn.Name = "rdEatIn";
            rdEatIn.TabStop = true;
            rdEatIn.UseVisualStyleBackColor = true;
            rdEatIn.CheckedChanged += rdEatIn_CheckedChanged;
            // 
            // gbOrderSummary
            // 
            gbOrderSummary.Controls.Add(LaPriceInNumber);
            gbOrderSummary.Controls.Add(LaPriceNumber);
            gbOrderSummary.Controls.Add(LaPrice);
            gbOrderSummary.Controls.Add(LaToppingsChoosen);
            gbOrderSummary.Controls.Add(LaToppings);
            gbOrderSummary.Controls.Add(LaWhereToEatChoosen);
            gbOrderSummary.Controls.Add(LaWhereToEat);
            gbOrderSummary.Controls.Add(LaCrustChoosen);
            gbOrderSummary.Controls.Add(LaCrustType);
            gbOrderSummary.Controls.Add(LaSizeChoosen);
            gbOrderSummary.Controls.Add(LaSize);
            resources.ApplyResources(gbOrderSummary, "gbOrderSummary");
            gbOrderSummary.Name = "gbOrderSummary";
            gbOrderSummary.TabStop = false;
            gbOrderSummary.Enter += gbOrderSummary_Enter;
            // 
            // LaPriceInNumber
            // 
            resources.ApplyResources(LaPriceInNumber, "LaPriceInNumber");
            LaPriceInNumber.ForeColor = Color.FromArgb(0, 192, 0);
            LaPriceInNumber.Name = "LaPriceInNumber";
            // 
            // LaPriceNumber
            // 
            resources.ApplyResources(LaPriceNumber, "LaPriceNumber");
            LaPriceNumber.Name = "LaPriceNumber";
            // 
            // LaPrice
            // 
            resources.ApplyResources(LaPrice, "LaPrice");
            LaPrice.Name = "LaPrice";
            LaPrice.Click += LaPrice_Click;
            // 
            // LaToppingsChoosen
            // 
            resources.ApplyResources(LaToppingsChoosen, "LaToppingsChoosen");
            LaToppingsChoosen.Name = "LaToppingsChoosen";
            // 
            // LaToppings
            // 
            resources.ApplyResources(LaToppings, "LaToppings");
            LaToppings.Name = "LaToppings";
            // 
            // LaWhereToEatChoosen
            // 
            resources.ApplyResources(LaWhereToEatChoosen, "LaWhereToEatChoosen");
            LaWhereToEatChoosen.Name = "LaWhereToEatChoosen";
            // 
            // LaWhereToEat
            // 
            resources.ApplyResources(LaWhereToEat, "LaWhereToEat");
            LaWhereToEat.Name = "LaWhereToEat";
            // 
            // LaCrustChoosen
            // 
            resources.ApplyResources(LaCrustChoosen, "LaCrustChoosen");
            LaCrustChoosen.Name = "LaCrustChoosen";
            // 
            // LaCrustType
            // 
            resources.ApplyResources(LaCrustType, "LaCrustType");
            LaCrustType.Name = "LaCrustType";
            // 
            // LaSizeChoosen
            // 
            resources.ApplyResources(LaSizeChoosen, "LaSizeChoosen");
            LaSizeChoosen.Name = "LaSizeChoosen";
            // 
            // LaSize
            // 
            resources.ApplyResources(LaSize, "LaSize");
            LaSize.Name = "LaSize";
            // 
            // btnOrder
            // 
            resources.ApplyResources(btnOrder, "btnOrder");
            btnOrder.Name = "btnOrder";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            resources.ApplyResources(btnReset, "btnReset");
            btnReset.Name = "btnReset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(gbOrderSummary);
            Controls.Add(gbWhereToEat);
            Controls.Add(gbToppings);
            Controls.Add(gbCurst);
            Controls.Add(gbSize);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Load += Form1_Load;
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbCurst.ResumeLayout(false);
            gbCurst.PerformLayout();
            gbToppings.ResumeLayout(false);
            gbToppings.PerformLayout();
            gbWhereToEat.ResumeLayout(false);
            gbWhereToEat.PerformLayout();
            gbOrderSummary.ResumeLayout(false);
            gbOrderSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbSize;
        private RadioButton rdSmall;
        private RadioButton rdLarge;
        private RadioButton rdMedum;
        private GroupBox gbCurst;
        private RadioButton rdThinCrust;
        private GroupBox gbToppings;
        private CheckBox chkTomatoes;
        private CheckBox chkOlives;
        private CheckBox chkGreenPeppers;
        private CheckBox chkMushrooms;
        private CheckBox chkOnion;
        private CheckBox chkExtraChees;
        private GroupBox gbWhereToEat;
        private RadioButton rdTakeOut;
        private RadioButton rdEatIn;
        private GroupBox gbOrderSummary;
        private Label LaSizeChoosen;
        private Label LaSize;
        private RadioButton rdThinkCrust;
        private Label LaCrustChoosen;
        private Label LaCrustType;
        private Label LaWhereToEatChoosen;
        private Label LaWhereToEat;
        private Label LaToppingsChoosen;
        private Label LaToppings;
        private Label LaPrice;
        private Label LaPriceInNumber;
        private Label LaPriceNumber;
        private Button btnOrder;
        private Button btnReset;
    }
}
