//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class SurveyAnswer
    {
        public int SurveyId { get; set; }
        public byte Answer { get; set; }
    
        public virtual Survey Survey { get; set; }
    }
}