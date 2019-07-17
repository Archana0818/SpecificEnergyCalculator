using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpecificEnergyCalculator
{
    public partial class formCalculator : Form
    {
        const string MACHINE1 = "27 Max";
        const string MACHINE2 = "27 Micro";
        const string MACHINE3 = "LabTech26mm";
        const string MACHINE4 = "40 Max";

        double rateInLb = 0;
        double rateInKg = 0;
        double runningRPM = 0;
        double maxRPM = 0;
        double ratedMotor = 0;
        double runningTorque = 0;
        double specificEnergy = 0;
        
        public bool formValidation()
        {
            bool formValid = true;
            bool rateValidate = validateTxtRate();
            bool runningRpmValidate = validateRunningRPM();
            bool torqueValidate = validateTxtTorque();

            if (rateValidate && runningRpmValidate && torqueValidate)
            {
                formValid = true;
            }

            else
            {
                formValid = false;
            }
            return formValid;

        }
        //depending on the machince selected by user this function will show the values
        public void machineSelected()
        {
            pnlInput.Show();
            txtEnergy.Visible = false;
            lblSpecificEnergy.Visible = false;
            txtMaxRPM.ReadOnly = true;
            txtRatedMotor.ReadOnly = true;
            txtRate.Clear();
            txtRunningRPM.Clear();
            txtTorque.Clear();
            errorProvider1.SetError(txtRate, "");
            errorProvider1.SetError(txtRunningRPM, "");
            errorProvider1.SetError(txtTorque, "");


            if (cbChooseMachine.SelectedItem.ToString() == MACHINE1)
            {
                txtMaxRPM.Text = "1200";
                txtRatedMotor.Text = "25";
            }
            if (cbChooseMachine.SelectedItem.ToString() == MACHINE2)
            {
                txtMaxRPM.Text = "500";
                txtRatedMotor.Text = "12";
            }
            if (cbChooseMachine.SelectedItem.ToString() == MACHINE3)
            {
                txtMaxRPM.Text = "1200";
                txtRatedMotor.Text = "17";
            }
            if (cbChooseMachine.SelectedItem.ToString() == MACHINE4)
            {
                txtMaxRPM.Text = "1200";
                txtRatedMotor.Text = "104";
            }
        }

        //this will change the value entered by user in lb to kg 
        public double conversionLbToKg(double valueInLb)
        {
            double ConvertedToKg = valueInLb/2.2;
          
           return ConvertedToKg;
            
        }

        //this will change the values of text boxes into double for calculation purpose
        public void convertTextValueToNumber()
        {
            rateInLb = double.Parse(txtRate.Text);
            runningRPM = double.Parse(txtRunningRPM.Text);
            maxRPM = double.Parse(txtMaxRPM.Text);
            ratedMotor = double.Parse(txtRatedMotor.Text);
            runningTorque = double.Parse(txtTorque.Text);                       
        }

        //this is to calculate specific energy
        public double calculateSpecificEnergy(double ratedMotor, double runningTorque, double runningRPM, double maxRPM, double rateInKg)
       
        {
            double calculatedSpecificEnergy = (ratedMotor * (runningTorque / 100) * (runningRPM / maxRPM) * 0.97) / rateInKg;
            calculatedSpecificEnergy = Math.Round(calculatedSpecificEnergy, 3);
            return calculatedSpecificEnergy;  
        }
        
        public formCalculator()
        {
            InitializeComponent();
            pnlInput.Hide();//this will hide the panel when form loads 
            this.StartPosition = FormStartPosition.CenterScreen; //This will load the screen to the center

            //dynamically added textchange event for text field, so that after clicking calculate if anyone changes the text, it will hide the calculated specific energy
            txtRate.TextChanged += TxtRate_TextChanged; 
            txtRunningRPM.TextChanged += TxtRunningRPM_TextChanged;
            txtTorque.TextChanged += TxtTorque_TextChanged;
        }

        private void TxtTorque_TextChanged(object sender, EventArgs e)
        {
            lblSpecificEnergy.Hide();
            txtEnergy.Hide();
        }

        private void TxtRunningRPM_TextChanged(object sender, EventArgs e)
        {
            lblSpecificEnergy.Hide();
            txtEnergy.Hide();
        }

        private void TxtRate_TextChanged(object sender, EventArgs e)
        {
            lblSpecificEnergy.Hide();
            txtEnergy.Hide();
        }

        //this will be executed when user selected the machine from drop down 
        private void cbChooseMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            machineSelected();            
        }

        //this will be executed when calculate button will be clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool inputValid = formValidation();
            if (inputValid)
            {
                convertTextValueToNumber();

                rateInKg = conversionLbToKg(rateInLb);
                lblSpecificEnergy.Visible = true;
                txtEnergy.Visible = true;

                specificEnergy = calculateSpecificEnergy(ratedMotor, runningTorque, runningRPM, maxRPM, rateInKg);

                specificEnergy = Math.Round(specificEnergy, 3);
                txtEnergy.Text = specificEnergy.ToString();

            }

            else
            {
                MessageBox.Show("Please Check Errors", "ERROR");
            }
           
        }

        //this will execute when close sign will be clicked
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtRate_Validating(object sender,CancelEventArgs e)
        {
            validateTxtRate();                      
        }
        private bool validateTxtRate()
        {
            bool validate = true;

            if (txtRate.Text == "")
            {
                errorProvider1.SetError(txtRate, "Please enter Rate in Lb ");
                validate = false;
            }
            //else if (System.Text.RegularExpressions.Regex.IsMatch(txtRate.Text, "[^0-9]"))
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtRate.Text, @"^\d*\.?\d+$"))
            {
                errorProvider1.SetError(txtRate, "Please enter positive numbers ");
                validate = false;
            }
            else if (double.Parse(txtRate.Text)<= 0)
            {
                errorProvider1.SetError(txtRate, "Please enter number more than zero ");
                validate = false;
            }
            else
                errorProvider1.SetError(txtRate, "");
            return validate;
        }       

        private void txtRunningRPM_Validating(object sender, CancelEventArgs e)
        {
            validateRunningRPM();
        }

        private bool validateRunningRPM()
        {
            bool validate = true;
            if (txtRunningRPM.Text == "")
            {
                errorProvider1.SetError(txtRunningRPM, "Please enter Running RPM ");
                validate = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtRunningRPM.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtRunningRPM, "Please enter Only positive numbers ");
                validate = false;
            }
            else if (double.Parse(txtRunningRPM.Text) <= 0)
            {
                errorProvider1.SetError(txtRunningRPM, "Please enter number more than zero ");
                validate = false;
            }
            else if (double.Parse(txtRunningRPM.Text) > double.Parse(txtMaxRPM.Text))
            {
                errorProvider1.SetError(txtRunningRPM, "Running RPM can not be more than Maximum RPM ");
                validate = false;
            }
            else
                errorProvider1.SetError(txtRunningRPM, "");
            return validate;
        }

        private void txtTorque_Validating(object sender, CancelEventArgs e)
        {
            validateTxtTorque();
        }

        private bool validateTxtTorque()
        {
            
            bool validate = true;
            if (txtTorque.Text == "")
            {
                errorProvider1.SetError(txtTorque, "Please enter Torque ");
                validate = false;
            }
            else if (!double.TryParse(txtTorque.Text,out runningTorque))
            {
                errorProvider1.SetError(txtTorque, "Please enter positive numbers. Decimals allowed");
                validate = false;
            }
            else if (double.Parse(txtTorque.Text) <= 0 || double.Parse(txtTorque.Text) > 100)
            {
                errorProvider1.SetError(txtTorque, "Please enter number more than zero and less than 100 ");
                validate = false;
            }
           
            else
                errorProvider1.SetError(txtTorque, "");
            return validate;
        }

        private void lbMinScreen_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRate.Text = "";
            txtRunningRPM.Text = "";
            txtTorque.Text = "";
        }
    }
}
