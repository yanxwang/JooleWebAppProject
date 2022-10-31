//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joole_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProduct()
        {
            this.tblProjToProds = new HashSet<tblProjToProd>();
        }
    
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Image { get; set; }
        public string Manufacturer_Name { get; set; }
        public string SubCategory_Name { get; set; }
        public string Category_Name { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public Nullable<int> ModeL_Year { get; set; }
        public string Type { get; set; }
        public string Application { get; set; }
        public string Mounting_Location { get; set; }
        public string Accessories { get; set; }
        public Nullable<int> Air_Flow { get; set; }
        public Nullable<int> Power_Min { get; set; }
        public Nullable<int> Power_Max { get; set; }
        public Nullable<int> Operating_Voltage_Min { get; set; }
        public Nullable<int> Operating_Voltage_Max { get; set; }
        public Nullable<int> Fan_Speed_Min { get; set; }
        public Nullable<int> Fan_Speed_Max { get; set; }
        public Nullable<int> Number_Of_Fan_Speed { get; set; }
        public Nullable<int> Sound_At_Max_Speed { get; set; }
        public Nullable<int> Fan_Sweep_Diameter { get; set; }
        public Nullable<int> Height_Min { get; set; }
        public Nullable<int> Height_Max { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Document_Path { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProjToProd> tblProjToProds { get; set; }
    }
}
