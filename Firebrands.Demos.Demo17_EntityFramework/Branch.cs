//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Firebrands.Demos.Demo17_EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Branch
    {
        public Branch()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int BranchID { get; set; }
        public string BranchName { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
