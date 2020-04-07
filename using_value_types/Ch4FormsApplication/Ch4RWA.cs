using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4FormsApplication
{
    public partial class Ch4RWA : Form
    {
        private bool Row1IsValid { get; set; }
        private bool Row2IsValid { get; set; }
        private bool Row3IsValid { get; set; }
        private bool Row4IsValid { get; set; }

        public Ch4RWA()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ItemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Row1FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.QuantityTextBox1 = new System.Windows.Forms.TextBox();
            this.PriceTextBox1 = new System.Windows.Forms.TextBox();
            this.TotalTextBox1 = new System.Windows.Forms.TextBox();
            this.Row2FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.QuantityTextBox2 = new System.Windows.Forms.TextBox();
            this.PriceTextBox2 = new System.Windows.Forms.TextBox();
            this.TotalTextBox2 = new System.Windows.Forms.TextBox();
            this.Row3FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionTextBox3 = new System.Windows.Forms.TextBox();
            this.QuantityTextBox3 = new System.Windows.Forms.TextBox();
            this.PriceTextBox3 = new System.Windows.Forms.TextBox();
            this.TotalTextBox3 = new System.Windows.Forms.TextBox();
            this.Row4FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionTextBox4 = new System.Windows.Forms.TextBox();
            this.QuantityTextBox4 = new System.Windows.Forms.TextBox();
            this.PriceTextBox4 = new System.Windows.Forms.TextBox();
            this.TotalTextBox4 = new System.Windows.Forms.TextBox();
            this.TotalsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.TaxRateTextBox = new System.Windows.Forms.TextBox();
            this.TotalTaxesTextBox = new System.Windows.Forms.TextBox();
            this.OrderTotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubmitFormButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ItemsFlowLayoutPanel.SuspendLayout();
            this.Row1FLP.SuspendLayout();
            this.Row2FLP.SuspendLayout();
            this.Row3FLP.SuspendLayout();
            this.Row4FLP.SuspendLayout();
            this.TotalsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsFlowLayoutPanel
            // 
            this.ItemsFlowLayoutPanel.Controls.Add(this.Row1FLP);
            this.ItemsFlowLayoutPanel.Controls.Add(this.TotalTextBox1);
            this.ItemsFlowLayoutPanel.Controls.Add(this.Row2FLP);
            this.ItemsFlowLayoutPanel.Controls.Add(this.TotalTextBox2);
            this.ItemsFlowLayoutPanel.Controls.Add(this.Row3FLP);
            this.ItemsFlowLayoutPanel.Controls.Add(this.TotalTextBox3);
            this.ItemsFlowLayoutPanel.Controls.Add(this.Row4FLP);
            this.ItemsFlowLayoutPanel.Controls.Add(this.TotalTextBox4);
            this.ItemsFlowLayoutPanel.Location = new System.Drawing.Point(62, 88);
            this.ItemsFlowLayoutPanel.Name = "ItemsFlowLayoutPanel";
            this.ItemsFlowLayoutPanel.Size = new System.Drawing.Size(895, 162);
            this.ItemsFlowLayoutPanel.TabIndex = 0;
            // 
            // Row1FLP
            // 
            this.Row1FLP.Controls.Add(this.DescriptionTextBox1);
            this.Row1FLP.Controls.Add(this.QuantityTextBox1);
            this.Row1FLP.Controls.Add(this.PriceTextBox1);
            this.Row1FLP.Location = new System.Drawing.Point(3, 3);
            this.Row1FLP.Name = "Row1FLP";
            this.Row1FLP.Size = new System.Drawing.Size(735, 34);
            this.Row1FLP.TabIndex = 36;
            // 
            // DescriptionTextBox1
            // 
            this.DescriptionTextBox1.Location = new System.Drawing.Point(3, 3);
            this.DescriptionTextBox1.Name = "DescriptionTextBox1";
            this.DescriptionTextBox1.Size = new System.Drawing.Size(418, 31);
            this.DescriptionTextBox1.TabIndex = 4;
            // 
            // QuantityTextBox1
            // 
            this.QuantityTextBox1.Location = new System.Drawing.Point(427, 3);
            this.QuantityTextBox1.Name = "QuantityTextBox1";
            this.QuantityTextBox1.Size = new System.Drawing.Size(146, 31);
            this.QuantityTextBox1.TabIndex = 10;
            this.QuantityTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PriceTextBox1
            // 
            this.PriceTextBox1.Location = new System.Drawing.Point(579, 3);
            this.PriceTextBox1.Name = "PriceTextBox1";
            this.PriceTextBox1.Size = new System.Drawing.Size(146, 31);
            this.PriceTextBox1.TabIndex = 11;
            this.PriceTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalTextBox1
            // 
            this.TotalTextBox1.Location = new System.Drawing.Point(744, 3);
            this.TotalTextBox1.Name = "TotalTextBox1";
            this.TotalTextBox1.ReadOnly = true;
            this.TotalTextBox1.Size = new System.Drawing.Size(146, 31);
            this.TotalTextBox1.TabIndex = 12;
            this.TotalTextBox1.TabStop = false;
            this.TotalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Row2FLP
            // 
            this.Row2FLP.Controls.Add(this.DescriptionTextBox2);
            this.Row2FLP.Controls.Add(this.QuantityTextBox2);
            this.Row2FLP.Controls.Add(this.PriceTextBox2);
            this.Row2FLP.Location = new System.Drawing.Point(3, 43);
            this.Row2FLP.Name = "Row2FLP";
            this.Row2FLP.Size = new System.Drawing.Size(735, 34);
            this.Row2FLP.TabIndex = 37;
            // 
            // DescriptionTextBox2
            // 
            this.DescriptionTextBox2.Location = new System.Drawing.Point(3, 3);
            this.DescriptionTextBox2.Name = "DescriptionTextBox2";
            this.DescriptionTextBox2.Size = new System.Drawing.Size(418, 31);
            this.DescriptionTextBox2.TabIndex = 13;
            // 
            // QuantityTextBox2
            // 
            this.QuantityTextBox2.Location = new System.Drawing.Point(427, 3);
            this.QuantityTextBox2.Name = "QuantityTextBox2";
            this.QuantityTextBox2.Size = new System.Drawing.Size(146, 31);
            this.QuantityTextBox2.TabIndex = 14;
            this.QuantityTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PriceTextBox2
            // 
            this.PriceTextBox2.Location = new System.Drawing.Point(579, 3);
            this.PriceTextBox2.Name = "PriceTextBox2";
            this.PriceTextBox2.Size = new System.Drawing.Size(146, 31);
            this.PriceTextBox2.TabIndex = 15;
            this.PriceTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalTextBox2
            // 
            this.TotalTextBox2.Location = new System.Drawing.Point(744, 43);
            this.TotalTextBox2.Name = "TotalTextBox2";
            this.TotalTextBox2.ReadOnly = true;
            this.TotalTextBox2.Size = new System.Drawing.Size(146, 31);
            this.TotalTextBox2.TabIndex = 16;
            this.TotalTextBox2.TabStop = false;
            this.TotalTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Row3FLP
            // 
            this.Row3FLP.Controls.Add(this.DescriptionTextBox3);
            this.Row3FLP.Controls.Add(this.QuantityTextBox3);
            this.Row3FLP.Controls.Add(this.PriceTextBox3);
            this.Row3FLP.Location = new System.Drawing.Point(3, 83);
            this.Row3FLP.Name = "Row3FLP";
            this.Row3FLP.Size = new System.Drawing.Size(735, 34);
            this.Row3FLP.TabIndex = 38;
            // 
            // DescriptionTextBox3
            // 
            this.DescriptionTextBox3.Location = new System.Drawing.Point(3, 3);
            this.DescriptionTextBox3.Name = "DescriptionTextBox3";
            this.DescriptionTextBox3.Size = new System.Drawing.Size(418, 31);
            this.DescriptionTextBox3.TabIndex = 17;
            // 
            // QuantityTextBox3
            // 
            this.QuantityTextBox3.Location = new System.Drawing.Point(427, 3);
            this.QuantityTextBox3.Name = "QuantityTextBox3";
            this.QuantityTextBox3.Size = new System.Drawing.Size(146, 31);
            this.QuantityTextBox3.TabIndex = 18;
            this.QuantityTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PriceTextBox3
            // 
            this.PriceTextBox3.Location = new System.Drawing.Point(579, 3);
            this.PriceTextBox3.Name = "PriceTextBox3";
            this.PriceTextBox3.Size = new System.Drawing.Size(146, 31);
            this.PriceTextBox3.TabIndex = 19;
            this.PriceTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalTextBox3
            // 
            this.TotalTextBox3.Location = new System.Drawing.Point(744, 83);
            this.TotalTextBox3.Name = "TotalTextBox3";
            this.TotalTextBox3.ReadOnly = true;
            this.TotalTextBox3.Size = new System.Drawing.Size(146, 31);
            this.TotalTextBox3.TabIndex = 20;
            this.TotalTextBox3.TabStop = false;
            this.TotalTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Row4FLP
            // 
            this.Row4FLP.Controls.Add(this.DescriptionTextBox4);
            this.Row4FLP.Controls.Add(this.QuantityTextBox4);
            this.Row4FLP.Controls.Add(this.PriceTextBox4);
            this.Row4FLP.Location = new System.Drawing.Point(3, 123);
            this.Row4FLP.Name = "Row4FLP";
            this.Row4FLP.Size = new System.Drawing.Size(735, 34);
            this.Row4FLP.TabIndex = 38;
            // 
            // DescriptionTextBox4
            // 
            this.DescriptionTextBox4.Location = new System.Drawing.Point(3, 3);
            this.DescriptionTextBox4.Name = "DescriptionTextBox4";
            this.DescriptionTextBox4.Size = new System.Drawing.Size(418, 31);
            this.DescriptionTextBox4.TabIndex = 21;
            // 
            // QuantityTextBox4
            // 
            this.QuantityTextBox4.Location = new System.Drawing.Point(427, 3);
            this.QuantityTextBox4.Name = "QuantityTextBox4";
            this.QuantityTextBox4.Size = new System.Drawing.Size(146, 31);
            this.QuantityTextBox4.TabIndex = 22;
            this.QuantityTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PriceTextBox4
            // 
            this.PriceTextBox4.Location = new System.Drawing.Point(579, 3);
            this.PriceTextBox4.Name = "PriceTextBox4";
            this.PriceTextBox4.Size = new System.Drawing.Size(146, 31);
            this.PriceTextBox4.TabIndex = 23;
            this.PriceTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalTextBox4
            // 
            this.TotalTextBox4.Location = new System.Drawing.Point(744, 123);
            this.TotalTextBox4.Name = "TotalTextBox4";
            this.TotalTextBox4.ReadOnly = true;
            this.TotalTextBox4.Size = new System.Drawing.Size(146, 31);
            this.TotalTextBox4.TabIndex = 24;
            this.TotalTextBox4.TabStop = false;
            this.TotalTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalsFlowLayoutPanel
            // 
            this.TotalsFlowLayoutPanel.Controls.Add(this.SubtotalTextBox);
            this.TotalsFlowLayoutPanel.Controls.Add(this.TaxRateTextBox);
            this.TotalsFlowLayoutPanel.Controls.Add(this.TotalTaxesTextBox);
            this.TotalsFlowLayoutPanel.Controls.Add(this.OrderTotalTextBox);
            this.TotalsFlowLayoutPanel.Location = new System.Drawing.Point(806, 293);
            this.TotalsFlowLayoutPanel.Name = "TotalsFlowLayoutPanel";
            this.TotalsFlowLayoutPanel.Size = new System.Drawing.Size(155, 152);
            this.TotalsFlowLayoutPanel.TabIndex = 25;
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Location = new System.Drawing.Point(3, 3);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(146, 31);
            this.SubtotalTextBox.TabIndex = 22;
            this.SubtotalTextBox.TabStop = false;
            this.SubtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TaxRateTextBox
            // 
            this.TaxRateTextBox.Location = new System.Drawing.Point(3, 40);
            this.TaxRateTextBox.Name = "TaxRateTextBox";
            this.TaxRateTextBox.Size = new System.Drawing.Size(146, 31);
            this.TaxRateTextBox.TabIndex = 23;
            this.TaxRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalTaxesTextBox
            // 
            this.TotalTaxesTextBox.Location = new System.Drawing.Point(3, 77);
            this.TotalTaxesTextBox.Name = "TotalTaxesTextBox";
            this.TotalTaxesTextBox.ReadOnly = true;
            this.TotalTaxesTextBox.Size = new System.Drawing.Size(146, 31);
            this.TotalTaxesTextBox.TabIndex = 24;
            this.TotalTaxesTextBox.TabStop = false;
            this.TotalTaxesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OrderTotalTextBox
            // 
            this.OrderTotalTextBox.Location = new System.Drawing.Point(3, 114);
            this.OrderTotalTextBox.Name = "OrderTotalTextBox";
            this.OrderTotalTextBox.ReadOnly = true;
            this.OrderTotalTextBox.Size = new System.Drawing.Size(146, 31);
            this.OrderTotalTextBox.TabIndex = 25;
            this.OrderTotalTextBox.TabStop = false;
            this.OrderTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tax Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Order Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Total Taxes";
            // 
            // SubmitFormButton
            // 
            this.SubmitFormButton.Location = new System.Drawing.Point(654, 486);
            this.SubmitFormButton.Name = "SubmitFormButton";
            this.SubmitFormButton.Size = new System.Drawing.Size(146, 41);
            this.SubmitFormButton.TabIndex = 34;
            this.SubmitFormButton.Text = "Ok";
            this.SubmitFormButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(815, 486);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(146, 41);
            this.CancelButton.TabIndex = 35;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Ch4RWA
            // 
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitFormButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsFlowLayoutPanel);
            this.Controls.Add(this.TotalsFlowLayoutPanel);
            this.Name = "Ch4RWA";
            this.Text = "Mother Fuckin\' Order Form Application";
            this.Load += new System.EventHandler(this.Ch4RWA_Load);
            this.ItemsFlowLayoutPanel.ResumeLayout(false);
            this.ItemsFlowLayoutPanel.PerformLayout();
            this.Row1FLP.ResumeLayout(false);
            this.Row1FLP.PerformLayout();
            this.Row2FLP.ResumeLayout(false);
            this.Row2FLP.PerformLayout();
            this.Row3FLP.ResumeLayout(false);
            this.Row3FLP.PerformLayout();
            this.Row4FLP.ResumeLayout(false);
            this.Row4FLP.PerformLayout();
            this.TotalsFlowLayoutPanel.ResumeLayout(false);
            this.TotalsFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Ch4RWA_Load(object sender, EventArgs e)
        {
            QuantityTextBoxDelegate();
            PriceTextBoxDelegate();
            RowValidationDelegate();
            TotalValidationDelegate();
            TotalOrderDelegate();
        }

        private void TotalOrderDelegate()
        {
            SubtotalTextBox.TextChanged += UpdateOrderTotal;
            TotalTaxesTextBox.TextChanged += UpdateOrderTotal;
        }

        private void UpdateOrderTotal(object sender, EventArgs e)
        {
            decimal subtotal, totaltaxes;
            decimal.TryParse(SubtotalTextBox.Text, out subtotal);
            decimal.TryParse(TotalTaxesTextBox.Text, out totaltaxes);
            OrderTotalTextBox.Text = (subtotal + totaltaxes).ToString();
        }

        private void TotalValidationDelegate()
        {
            TotalsFlowLayoutPanel.Validating += TotalsFlowLayoutPanel_Validating;
            TaxRateTextBox.TextChanged += UpdateTaxes;
        }

        private void TotalsFlowLayoutPanel_Validating(object sender, CancelEventArgs e)
        {
            if (sender is FlowLayoutPanel)
            {
                //TaxRateTextBox.Validating += TaxRateTextBox_Validating;
            }
        }

        private void UpdateTaxes(object sender, EventArgs e)
        {
            string tr = TaxRateTextBox.Text;
            tr = tr.Trim('%');
            decimal subtotal, taxrate;
            decimal.TryParse(SubtotalTextBox.Text, out subtotal);
            decimal.TryParse(tr,
                NumberStyles.AllowDecimalPoint,
                null, out taxrate);
            TotalTaxesTextBox.Text = (taxrate * subtotal).ToString();
        }

        private void RowValidationDelegate()
        {
            foreach (var fp in ItemsFlowLayoutPanel.Controls)
            {
                if (fp is FlowLayoutPanel)
                {
                    ((FlowLayoutPanel)fp).Validating += Row_Validating;
                    ((FlowLayoutPanel)fp).Validated += Row_Validated;
                    ((FlowLayoutPanel)fp).MouseDoubleClick += Ch4RWA_MouseDoubleClick;
                    //((FlowLayoutPanel)fp).Controls[3].TextChanged += UpdateSubtotal;
                }
            }
        }

        private void UpdateSubtotal()
        {
            decimal one, two, three, four;
            decimal.TryParse(TotalTextBox1?.Text, out one);
            decimal.TryParse(TotalTextBox2?.Text, out two);
            decimal.TryParse(TotalTextBox3?.Text, out three);
            decimal.TryParse(TotalTextBox4?.Text, out four);
            SubtotalTextBox.Text = (one + two + three + four).ToString();
        }

        private void Ch4RWA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Row_Validated(object sender, EventArgs e)
        {
            decimal quantity, price;
            if (sender is FlowLayoutPanel)
            {
                decimal.TryParse(((FlowLayoutPanel)sender).Controls[1].Text, out quantity);
                decimal.TryParse(((FlowLayoutPanel)sender).Controls[2].Text,                NumberStyles.AllowCurrencySymbol |
                    NumberStyles.AllowThousands |
                    NumberStyles.AllowDecimalPoint,
                    null, out price);

                CalculateItemTotal((FlowLayoutPanel)sender, quantity, price);
                UpdateSubtotal();
            }
        }

        private void CalculateItemTotal(FlowLayoutPanel sender, decimal quantity, decimal price)
        {            
            switch (sender.Name)
            {
                case "Row1FLP":
                    TotalTextBox1.Text = (quantity * price).ToString();
                    break;
                case "Row2FLP":
                    TotalTextBox2.Text = (quantity * price).ToString();
                    break;
                case "Row3FLP":
                    TotalTextBox3.Text = (quantity * price).ToString();
                    break;
                case "Row4FLP":
                    TotalTextBox4.Text = (quantity * price).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Row_Validating(object sender, CancelEventArgs e)
        {
            bool rowIsValid = false;
            if (sender is FlowLayoutPanel)
            {
                rowIsValid = ValidateRow(((FlowLayoutPanel)sender));
            }

            if (!rowIsValid)
            {
                e.Cancel = true;
            }
        }

        private bool ValidateRow(FlowLayoutPanel sender)
        {
            Control.ControlCollection collection = sender.Controls;
            return AllTextBoxesAreEmpty(collection) || AllTextBoxesAreNotEmpty(collection);
        }

        private bool AllTextBoxesAreNotEmpty(Control.ControlCollection collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (string.IsNullOrEmpty(collection[i].Text))
                {
                    return false;
                }
            }
            return true;
        }

        private bool AllTextBoxesAreEmpty(Control.ControlCollection collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (!string.IsNullOrEmpty(collection[i].Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void PriceTextBoxDelegate()
        {
            foreach (var c in ItemsFlowLayoutPanel.Controls)
            {
                if (c is FlowLayoutPanel)
                {
                    foreach (Control tb in ((FlowLayoutPanel)c).Controls)
                    {
                        if (tb.Name.Contains("PriceTextBox"))
                        {
                            tb.Validating += PriceTextBox_Validating;
                            tb.MouseClick += QuantityTextBox_MouseClick;
                        }
                    }
                }
            }
        }

        private void PriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool priceIsValid = false;
            if (sender is TextBox)
            {
                priceIsValid = ValidatePriceTextBox((TextBox)sender);
            }

            if (!priceIsValid)
            {
                ((TextBox)sender).Text = "Must be $0.01 to $100k";
                ((TextBox)sender).ForeColor = Color.Red;
            }
            else
            {
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private bool ValidatePriceTextBox(TextBox sender)
        {
            decimal price;
            if (!decimal.TryParse(sender.Text,
                NumberStyles.AllowCurrencySymbol |
                NumberStyles.AllowThousands |
                NumberStyles.AllowDecimalPoint,
                null, out price))
            {
                return string.IsNullOrEmpty(sender.Text);
            }
            return price > 0 && price <= 100000;
        }

        private void QuantityTextBoxDelegate()
        {
            foreach (var c in ItemsFlowLayoutPanel.Controls)
            {
                if (c is FlowLayoutPanel)
                {
                    foreach (Control tb in ((FlowLayoutPanel)c).Controls)
                    {
                        if (tb.Name.Contains("Quantity"))
                        {
                            tb.Validating += QuantityTextBox_Validating;
                            tb.MouseClick += QuantityTextBox_MouseClick;
                        }
                    }
                }
            }
        }

        private void QuantityTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void QuantityTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool validQuantity = false;
            if(sender is TextBox)
            {
                validQuantity = ValidateQuantity(((TextBox)sender));
            }

            if (!validQuantity)
            {
                ((TextBox)sender).Text = "Quantity 1-10 only";
                ((TextBox)sender).ForeColor = Color.Red;
                e.Cancel = true;
            }
            else
            {
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private bool ValidateQuantity(TextBox sender)
        {
            decimal quantity;

            if (!decimal.TryParse(sender.Text, NumberStyles.Currency, null, out quantity))
            {
                return string.IsNullOrEmpty(sender.Text);
            }
            return quantity > 0 && quantity < 11;
        }

        private void TotalTextBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void TotalTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
