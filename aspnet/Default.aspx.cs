using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    static int i = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        Image1.ImageUrl = "~\\image\\Blue hills.jpg";
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            try
            {
                FileUpload1.PostedFile.SaveAs("e:\\date\\" + FileUpload1.FileName);
                Label1.Text = "上传成功";
            }
            catch (Exception ex)
            {
                Label1.Text = "上传失败";
            }
        }
      
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (i == 1)
        {
            Image1.ImageUrl = "~\\image\\Blue hills.jpg";
            i=2;
        }
        else if (i ==2)
        {
            Image1.ImageUrl = "~\\image\\Sunset.jpg";
            i=3;
        }
        else if (i == 3)
        {
            Image1.ImageUrl = "~\\image\\Water lilies.jpg";
            i=4;
        }
       else if(i==4)
        {
            Image1.ImageUrl = "~\\image\\Winter.jpg";
            i=1;

        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
            Label2.Text = "heeh";
        else if(RadioButtonList1.SelectedIndex == 1)
             Label2.Text = "haha";
            else if(RadioButtonList1.SelectedIndex == 2)
             Label2.Text = "heihei";
    }
}
