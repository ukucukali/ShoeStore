﻿using ApplicationCore.Entities;
using Ardalis.Specification;
using System.Linq;

namespace ApplicationCore.Specifications
{
    public class ProductFilterSpecification : Specification<Product>
    {
        public ProductFilterSpecification(int? categoryId, int? brandId)
        {
            if (categoryId.HasValue)
                Query.Where(x => x.CategoryId == categoryId);
            if (brandId.HasValue)
                Query.Where(x => x.BrandId == brandId);


        }
        public ProductFilterSpecification(int? categoryId, int? brandId, int skip, int take) : this(categoryId, brandId)
        {
            Query.Skip(skip).Take(take);
        }


    }
}
