using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXPRACT3_CreateArray6439050
{
    public partial class ASPXPRACT3_CreateArrayparte2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLookup_Click(object sender, EventArgs e)
        {
            String[] strCategoryArray = new String[5];

            // 03: Get the array from the session variable (Usando el 'as String[]' de la foto 1.2)
            strCategoryArray = Session["strCategoryArray"] as String[];

            // Verificamos que no sea nulo antes de usarlo
            if (strCategoryArray != null)
            {
                // 04: Use the array as normal
                Int32 i32Index = Convert.ToInt32(txtIndex.Text);
                lblCategory.Text = strCategoryArray[i32Index];
            }
            else
            {
                lblCategory.Text = "Error: Arreglo no encontrado.";
            }
        }
    }

}