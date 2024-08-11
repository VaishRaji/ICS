using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace ValidatorApp
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == txtFamilyName.Text.Trim())
            {
                lblValidationMessage.Text = "Family Name.";
                return;
            }

            if (txtAddress.Text.Trim().Length < 2)
            {
                lblValidationMessage.Text = "Address must have at least 7 letters.";
                return;
            }

            if (txtCity.Text.Trim().Length < 2)
            {
                lblValidationMessage.Text = "City must have at least 7 letters.";
                return;
            }

            if (!Regex.IsMatch(txtZipCode.Text, @"^\d{6}$"))
            {
                lblValidationMessage.Text = "Zip Code must be 6 digits.";
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^\d{2}-\d{7}$") && !Regex.IsMatch(txtPhone.Text, @"^\d{3}-\d{7}$"))
            {
                lblValidationMessage.Text = "Phone number must be in the format XX-XXXXXXX or XXX-XXXXXXX.";
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblValidationMessage.Text = "Invalid Email Address.";
                return;
            }

            Response.Redirect("UserDetails.aspx?Name=" + txtName.Text.Trim() +
                              "&FamilyName=" + txtFamilyName.Text.Trim() +
                              "&Address=" + txtAddress.Text.Trim() +
                              "&City=" + txtCity.Text.Trim() +
                              "&ZipCode=" + txtZipCode.Text.Trim() +
                              "&Phone=" + txtPhone.Text.Trim() +
                              "&Email=" + txtEmail.Text.Trim());
        }
    }

}
