using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Mapping
{
   public class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            //Primary key
            this.HasKey(o => o.Id);


            //TableName
            this.ToTable("Orders");


            //
            this.Property(o => o.Id).HasColumnName("Id");

            this.Property(o => o.CustomerId).HasColumnName("CustomerId");

            this.Property(o => o.OrderDate).HasColumnName("OrderDate");


           
            
        }
    }
}
