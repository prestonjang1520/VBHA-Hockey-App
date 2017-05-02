using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ODG.Core.Data.Abstract;
using System.Web.UI.WebControls;
using ODG.Core;
using ODG.Core4;
using ODG.Core45;
using VBHA_Hockey_App.Models;

public class Repository : EntityFramework6Repository
{
    //Constructor
    public Repository(prestonjang_VBHA_HockeyAppEntities context) : base(context)
    {
        context.Configuration.ProxyCreationEnabled = false;
    }


    //-----------------------------------------------------------
    //Example of an IQueryable 
    //-----------------------------------------------------------

    public IQueryable<coach> All_Coaches()
    {
        return (from v in GetAll<coach>()
                select v).Where(x => x.Deleted == null);
    }

    public IQueryable<team> All_Teams()
    {
        return (from v in GetAll<team>()
                select v).Where(x=>x.Deleted == null);
    }

    public IQueryable<player> All_Players()
    {
        return (from v in GetAll<player>()
                select v).Where(x => x.Deleted == null);
    }
}