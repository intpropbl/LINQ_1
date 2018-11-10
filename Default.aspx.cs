using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LINQORNEKDataContext dc = new LINQORNEKDataContext();

        var ogrenciler = from ogrenci in dc.OGRENCIs select ogrenci;
		string test;

        foreach (var tekkayit in ogrenciler)
		{
            ListBox1.Items.Add(tekkayit.AD.ToString()+" "+tekkayit.SOYAD.ToString());
		}
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        LINQORNEKDataContext dc = new LINQORNEKDataContext();

        OGRENCI ogr = new OGRENCI()
        {
            AD = txtAd.Text,
            SOYAD = txtSoyad.Text
        };

        dc.OGRENCIs.InsertOnSubmit(ogr);
        dc.SubmitChanges();
    }
}
