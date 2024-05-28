using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ejemplo1
{
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] {
                    new DataColumn("Id"),
                    new DataColumn("Name"),
                    new DataColumn("Country") });
                        dt.Rows.Add(1, "John Hammond", "United States");
                        dt.Rows.Add(2, "Mudassar Khan", "India");
                        dt.Rows.Add(3, "Suzanne Mathews", "France");
                        dt.Rows.Add(4, "Robert Schidner", "Russia");
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
            }
        }

        protected void OnGet(object sender, EventArgs e)
        {
            //Determine el RowIndex of the Row whose Button was clicked.
            int rowIndex = ((sender as Button).NamingContainer as GridViewRow).RowIndex;

            //Get the value of column from the DataKeys using the RowIndex.
            int id = Convert.ToInt32(GridView1.DataKeys[rowIndex].Values[0]);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('DataKey: " + id + "');", true);
        }
    }
}