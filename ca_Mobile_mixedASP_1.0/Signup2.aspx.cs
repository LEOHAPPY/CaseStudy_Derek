using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signup2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        string username = CreateUserWizard1.UserName;
        ////string password = CreateUserWizard1.Password;
        
        Roles.AddUserToRole(username, "staff");

        ProfileCommon profile = Profile.GetProfile(User.Identity.Name);
        //profile.Telphone = CreateUserWizard1.Email;  //Email can attrive but new one cannot 

        profile.Telphone = "10293049";
        profile.QQ = "1013423966";
        //profile.Fond = "fish";
        profile.Save();

        CreateUserWizard1.FinishDestinationPageUrl = "~/Prv/AddPage.aspx";


        //CreateUserWizardStep step1 = (CreateUserWizardStep)CreateUserWizard1.FindControl("CreateUserWizard1");
        //TextBox k1 = (TextBox)step1.ContentTemplateContainer.FindControl("Telphone");
        //step1.ContentTemplateContainer.
        //profile.Telphone = k1.Text;
        //profile.Save();
        ////TextBox k1 = (TextBox)CreateUserWizard1.FindControl("Telphone");
        //CreateUserWizardStep step1 = (CreateUserWizardStep)CreateUserWizard1.FindControl("CreateUserWizard1");

        //TextBox k1 = (TextBox)step1.ContentTemplateContainer.FindControl("Telphone");
        //profile.Telphone = k1.Text;
        //profile.Save();

        //profile.Telphone = (TextBox)CreateUserWizard1.FindControl("Telphone");
        //profile.QQ = "1013423966";
        //profile.Fond = "fish";
        //profile.Save();

        //CreateUserWizardStep step1 = (CreateUserWizardStep)CreateUserWizard1.FindControl("CreateUserWizard1");

        //TextBox k1 = (TextBox)step1.ContentTemplateContainer.FindControl("Telphone");
        //TextBox k2 = (TextBox)step1.ContentTemplateContainer.FindControl("QQ");

    }

    protected void Email_TextChanged(object sender, EventArgs e)
    {

    }
}