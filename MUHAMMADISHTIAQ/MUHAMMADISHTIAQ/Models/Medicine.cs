using System;
using System.Data.Entity;

namespace MUHAMMADISHTIAQ.Models
{
    public class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string StoreBox { get; set; }
        public int PurchasePrice { get; set; }
        public int SellingPrice{ get; set; }
        public int Quantity { get; set; }
        public string CompanyName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
    public class MedcineDBContext : DbContext
    {
        public DbSet<Medicine> Medicines { get; set; }
    }
}