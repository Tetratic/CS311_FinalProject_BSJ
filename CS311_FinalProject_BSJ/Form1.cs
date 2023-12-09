namespace CS311_FinalProject_BSJ
{
    public partial class Form1 : Form
    {
        //code run to get the form in its initial state
        public Form1()
        {
            InitializeComponent();
            txtLeft.Text = "0";
            txtRight.Text = "0";
            addListenCtrls();
            updateForm(getConvBtn(), getLR());
            cmbFormat.SelectedIndex = 2;
        }
        //variable declaration, including String arrays to hold Label text
        public int chkBtn;
        public String[,] lblVals = new String[,] {
            { "Meters", "Feet" },
            { "Kilometers", "Miles" },
            { "Celsius", "Farenheit" },
            { "Kilograms", "Pounds" },
            { "Grams", "Ounces" }
        };
        public String[] convEqns1 = new String[]
        {
            "1 Meter ≈ 3.28084 Feet",
            "1 Kilometer ≈ 0.621371 Miles",
            "°C * (9/5) +32 = °F",
            "1 Kilogram ≈ 2.20462 Pounds",
            "1 Gram ≈ 0.035274 Ounces"
        };
        public String[] convEqns2 = new String[]
        {
            "0.3048 Meters ≈ 1 Foot",
            "1.60934 Kilometers ≈ 1 Mile",
            "°C = (°F − 32) * 5/9",
            "0.453592 Kilograms ≈ 1 Pound",
            "28.3495 Grams ≈ 1 Ounce"
        };

        //adds custom event handling on specific events
        private void addListenCtrls()
        {
            rdoMFt.CheckedChanged += new EventHandler(checks_CheckedChanged);
            rdoKmMiles.CheckedChanged += new EventHandler(checks_CheckedChanged);
            rdoCF.CheckedChanged += new EventHandler(checks_CheckedChanged);
            rdoKgLb.CheckedChanged += new EventHandler(checks_CheckedChanged);
            rdoGOz.CheckedChanged += new EventHandler(checks_CheckedChanged);
            chkLR.CheckedChanged += new EventHandler(checks_CheckedChanged);

            txtLeft.TextChanged += new EventHandler(txtLR_TextChanged);
            txtRight.TextChanged += new EventHandler(txtLR_TextChanged);
        }

        //when a different conversion is requested, update the form to show that
        //includes labels for textboxes, changing formulas for conversions and the conversion formula displayed
        private void checks_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton || sender is CheckBox)
            {
                updateForm(getConvBtn(), getLR());
            }
        }

        //when text is changed within the textbox, send the new value to be converted and updated in the other textbox
        private void txtLR_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.TabIndex == 0)
                {
                    updateTxtR(getConvBtn(), textBox.Text);
                }
                else
                {
                    updateTxtL(getConvBtn(), textBox.Text);
                }
            }
        }

        //discovers which radio button is selected to know which conversion to perform
        private int getConvBtn()
        {
            foreach (var item in pnlConvSelect.Controls.OfType<RadioButton>())
            {
                if (item.Checked == true)
                {
                    chkBtn = item.TabIndex;
                    break;//leaves loop early when this condition is satisfied
                }
                else
                {
                    chkBtn = 0;
                }
            }
            return chkBtn;
        }

        //displays the correct conversion formula depending on which side is preferred
        private bool getLR()
        {
            if (chkLR.Checked == true)
            {
                return true;
            }
            else { return false; }
        }

        //number format Strings decided by a combobox control
        private String getFmt()
        {
            switch (cmbFormat.SelectedIndex)
            {
                case 0: return "#.";
                case 1: return "#.#";
                case 2: return "#.##";
                case 3: return "#.###";
                case 4: return "#.####";
                case 5: return "#.#####";
                default: return "#.";
            }
        }

        //updates the labels on the form, as well as the conversion equation
        private void updateForm(int rdoTInd, bool chkLR)
        {
            lblLeft.Text = lblVals[rdoTInd, 0];
            lblRight.Text = lblVals[rdoTInd, 1];

            if (chkLR == true)
                lblConvEqn.Text = convEqns1[rdoTInd];
            else
            {
                lblConvEqn.Text = convEqns2[rdoTInd];
            }
        }

        //attempts to parse the value of text in the left textbox, and then converts it
        //uses both proper conversion formula and proper formatting based on combobox selection
        private void updateTxtR(int rdoBtn, String val)
        {
            double dVal;
            try
            {
                dVal = Double.Parse(val);
            }
            catch (FormatException)
            {
                dVal = 0;
            }

            switch (rdoBtn)
            {
                case 0: txtRight.Text = convMFt(true, dVal, getFmt()); break;
                case 1: txtRight.Text = convKmMiles(true, dVal, getFmt()); break;
                case 2: txtRight.Text = convCF(true, dVal, getFmt()); break;
                case 3: txtRight.Text = convKgLb(true, dVal, getFmt()); break;
                case 4: txtRight.Text = convGOz(true, dVal, getFmt()); break;
                default: txtRight.Text = "0"; break;
            }
        }

        //attempts to parse the value of text in the right textbox, and then converts it
        //uses both proper conversion formula and proper formatting based on combobox selection
        private void updateTxtL(int rdoBtn, String val)
        {
            double dVal;
            try
            {
                dVal = Double.Parse(val);
            }
            catch (FormatException)
            {
                dVal = 0;
            }

            switch (rdoBtn)
            {
                case 0: txtLeft.Text = convMFt(false, dVal, getFmt()); break;
                case 1: txtLeft.Text = convKmMiles(false, dVal, getFmt()); break;
                case 2: txtLeft.Text = convCF(false, dVal, getFmt()); break;
                case 3: txtLeft.Text = convKgLb(false, dVal, getFmt()); break;
                case 4: txtLeft.Text = convGOz(false, dVal, getFmt()); break;
                default: txtLeft.Text = "0"; break;
            }
        }

        //conversion formula for meters to feet or vice versa, decided by boolean value
        private String convMFt(bool LR, double dVal, String fmt)
        {
            if (LR)
            {
                dVal = dVal * 3.28084;
            }
            else
            {
                dVal = dVal / 3.28084;
            }
            return dVal.ToString(fmt);
        }

        //conversion formula for kilometers to miles or vice versa, decided by boolean value
        private String convKmMiles(bool LR, double dVal, String fmt)
        {
            if (LR)
            {
                dVal = dVal * 0.621371;
            }
            else
            {
                dVal = dVal / 0.621371;
            }
            return dVal.ToString(fmt);
        }

        //conversion formula for Celsius to Farenheit or vice versa, decided by boolean value
        private String convCF(bool LR, double dVal, String fmt)
        {
            if (LR)
            {
                dVal = (dVal * 9 / 5) + 32;
            }
            else
            {
                dVal = (dVal - 32) * 5 / 9;
            }
            return dVal.ToString(fmt);
        }

        //conversion formula for kilograms to pounds or vice versa, decided by boolean value
        private String convKgLb(bool LR, double dVal, String fmt)
        {
            if (LR)
            {
                dVal = dVal * 2.20462;
            }
            else
            {
                dVal = dVal / 2.20462;
            }
            return dVal.ToString(fmt);
        }

        //conversion formula for grams to ounces or vice versa, decided by boolean value
        private String convGOz(bool LR, double dVal, String fmt)
        {
            if (LR)
            {
                dVal = dVal * 0.035274;
            }
            else
            {
                dVal = dVal / 0.035274;
            }
            return dVal.ToString(fmt);
        }

        //help button with instructions on how to use the app
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Getting Started:\n\n" +
                "The textboxes below are the places where you will enter values to be converted. " +
                "You can enter on both the left and right, and the opposite side will update with a converted value. " +
                "\n\nIf you want to convert between one of the other types of conversions, choose the conversion " +
                "at the bottom of the page, and then enter your values. \n\nUnderneath the text boxes there are " +
                "two sections: on the left there is a conversion equation, which will tell you how the calculations to convert " +
                "your values were done, and a checkbox to swap which side is evaluated to 1. The right " +
                "holds a dropdown menu where you can select how many decimal places you need in your conversion.");

        }
    }
}