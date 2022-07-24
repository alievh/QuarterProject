﻿using DAL.Base;
using DAL.Entity;
using DAL.Identity;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    public class Product : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int BedroomCount { get; set; }
        public int BathroomCount { get; set; }
        public int SquareFt { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int ProductDetailId { get; set; }
        public ProductDetail ProductDetail { get; set; }

        [NotMapped]
        public IFormFile MainImage { get; set; }
        [NotMapped]
        public List<IFormFile> ImageFile { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Wishlist> Wishlists { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Basket> Baskets { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
