﻿using System.ComponentModel.DataAnnotations;

namespace API.Domain.Dtos
{
    public class ProductDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
    }
}