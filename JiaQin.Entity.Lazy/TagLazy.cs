using System;
using System.Collections.Generic;
using System.Text;
using JiaQin.Entity;
namespace JiaQin.Entity.Lazy
{
    /// <summary>
    /// 
    /// </summary>
    public class TagLazy:Tag
    {
       public Func<int, School> SchoolInfoLazy = null;
		public override School SchoolInfo{
              get{
                     if (base.SchoolInfo == null && this.SchoolInfoLazy!= null)
                    {
                        return this.SchoolInfoLazy(base.SchoolId);
                    }
                    return base.SchoolInfo;
              }
              set
              {
                   base.SchoolInfo= value;
              }
        }
    }
}