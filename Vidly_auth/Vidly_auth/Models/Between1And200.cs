using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly_auth.Models
{
    public class Between1And200 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;

            return (movie.NumberInStock >= Movie.MinInStock && movie.NumberInStock <= Movie.MaxInStock)
                ? ValidationResult.Success
                : new ValidationResult("Number in Stock must be between 1 - 200.");
        }
    }
}