using EmployeeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayrollGUI
{
    public partial class frmEmployees : Form
    {
        const int RRSP_LIMIT = 50; // at most 50% deduction

        // list of employees
        List<Employee> employees = new List<Employee>(); // empty list
        decimal totalPayroll = 0;
        public frmEmployees()
        {
            InitializeComponent();
        }

        // Regular select - hide the panel
        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermanent.Visible = false;   
        }
        // Permanent select - show the panel
        private void rdoPermanent_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermanent.Visible = true;
        }

        // at the start - Regular employee selected
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            rdoRegular.Checked = true;
        }

        // add a new employee
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // input data
            string name;
            decimal hours;
            decimal rate;
            decimal rrspPct;
            Employee newEmp = null;
            decimal payAmount;
            decimal rrspAmount;
            if( Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtHours) &&
                Validator.IsNonNegativeDecimal(txtHours) &&
                Validator.IsPresent(txtRate) &&
                Validator.IsNonNegativeDecimal(txtRate)
              ) // validate and collect common data
            {
                name = txtName.Text;
                hours = Convert.ToDecimal(txtHours.Text);
                rate = Convert.ToDecimal(txtRate.Text);

                if(rdoRegular.Checked)
                {
                    newEmp = new Employee(name, hours, rate);                    
                }
                else // Permanent
                {
                    if(Validator.IsPresent(txtRrsp) &&
                       Validator.IsDecimalInRange(txtRrsp, 0, RRSP_LIMIT))
                    {
                        rrspPct = Convert.ToDecimal(txtRrsp.Text)/ 100;
                        newEmp = new PermanentEmployee(name, hours, rate, rrspPct);                        
                    }
                }
                if(newEmp != null)
                {
                    employees.Add(newEmp);
                    totalPayroll += newEmp.CalculatePay();
                    DisplayEmployees();
                    ClearEntries();
                }
            }
        } // Add

        // prepare for next entry
        private void ClearEntries()
        {
            txtName.Clear();
            txtHours.Clear();
            txtRate.Clear();
            txtRrsp.Clear();
            txtName.Focus();
        }

        // add to the list box and display stats
        private void DisplayEmployees()
        {
            lstEmployees.Items.Clear();
            foreach(Employee e in employees)
            {
                lstEmployees.Items.Add(e);
            }
            txtCount.Text = employees.Count.ToString();
            txtPayroll.Text = totalPayroll.ToString("c");
        }
    }// class
}// namespace
