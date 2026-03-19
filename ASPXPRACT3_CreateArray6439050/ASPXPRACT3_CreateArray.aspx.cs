using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXPRACT3_CreateArray6439050
{
    public partial class ASPXPRACT3_CreateArray : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCreateArray_Click(object sender, EventArgs e)
        {
            String[] strCategoryArray = new String[5];
            strCategoryArray[0] = "Footwear - Men's";
            strCategoryArray[1] = "Clothing - Men's";
            strCategoryArray[2] = "Racquets";
            strCategoryArray[3] = "Footwear - Women's";
            strCategoryArray[4] = "Clothing - Women's";

            // 02: Save the array in a session variable
            Session["strCategoryArray"] = strCategoryArray;

            // 03: Go to the next page
            Response.Redirect("ASPXPRACT3_CreateArrayparte2.aspx");
        }
    }
}