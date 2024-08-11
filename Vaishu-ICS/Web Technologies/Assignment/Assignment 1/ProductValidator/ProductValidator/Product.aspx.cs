using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace ProductValidator
{
    public partial class Product : System.Web.UI.Page
    {
        Dictionary<string, (string ImageUrl, decimal Price)> products = new Dictionary<string, (string ImageUrl, decimal Price)>
    {
        { "Kettle", ("~/Images/Kettle.jpg", 999.99m) },
        { "Microwave oven", ("~/Images/Microwave oven.jpg", 499.99m) },
        { "Tava", ("~/Images/Tava.jpg", 199.99m) }
    };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProducts.DataSource = products.Keys;
                ddlProducts.DataBind();
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = ddlProducts.SelectedValue;
            imgProduct.ImageUrl = products[selectedProduct].ImageUrl;
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            string selectedProduct = ddlProducts.SelectedValue;
            lblPrice.Text = "Price: $" + products[selectedProduct].Price.ToString("F2");
        }

        protected void btnValidate_Click(object sender, EventArgs e)
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

            lblValidationMessage.Text = "All inputs are valid.";
            lblValidationMessage.ForeColor = System.Drawing.Color.Green;
        }
    }
    
}