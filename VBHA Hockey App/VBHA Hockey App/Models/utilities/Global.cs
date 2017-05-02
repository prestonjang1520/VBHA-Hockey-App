using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ODG.Core.Data.Abstract;
using ODG.Core4;
using VBHA_Hockey_App.Models;

public class Global
{
    public static Repository Repository
    {
        get
        {
            return new Repository(ContextManager.Create<prestonjang_VBHA_HockeyAppEntities>());
        }
    }
}
