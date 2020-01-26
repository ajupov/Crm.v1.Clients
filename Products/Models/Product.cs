using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Products.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid? ParentProductId { get; set; }

        public ProductType Type { get; set; }

        public Guid StatusId { get; set; }

        public string Name { get; set; }

        public string VendorCode { get; set; }

        public decimal Price { get; set; }

        public byte[] Image { get; set; }

        public bool IsHidden { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public ProductStatus Status { get; set; }

        public List<ProductAttributeLink> AttributeLinks { get; set; }

        public List<ProductCategoryLink> CategoryLinks { get; set; }
    }
}