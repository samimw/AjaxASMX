using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class ajaxpost : System.Web.Services.WebService {

    [WebMethod]
    public string Callback()
    {
        return "Hello World";
    }
    
}
