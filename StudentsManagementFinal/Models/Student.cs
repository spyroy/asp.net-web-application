//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsManagementFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentlId { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        public string StudentFirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        public string StudentLastName { get; set; }
        [Required(ErrorMessage = "Please enter age")]
        public Nullable<int> StudentAge { get; set; }
        [Required(ErrorMessage = "Please enter average")]
        [Range(0,100,ErrorMessage = "Please enter average between 0-100")]
        public Nullable<double> StudentAverage { get; set; }
        public Nullable<System.DateTime> CreateDateStudent { get; set; }
        public Nullable<int> SchoolId { get; set; }
    
        public virtual School School { get; set; }
    }
}
