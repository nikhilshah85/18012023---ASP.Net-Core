using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DI_and_DataAnnotation_Demo.Models.EF;

public partial class ProductDetail
{


    [DisplayName("Product ID")]
    public int PId { get; set; }

    [DisplayName("Product")]
    [Required(AllowEmptyStrings = false,ErrorMessage ="Prodct Name cannot be left blank")]
    [StringLength(10,MinimumLength =3,ErrorMessage ="Invalid Product Name")]
    public string? PName { get; set; }

    [DisplayName("Category")]
    public string? PCategory { get; set; }

    [DisplayName("Offer price")]
    [System.ComponentModel.DataAnnotations.Range(100,5000,ErrorMessage ="Please enter between 100 and 5000 only")]
    public int? PPrice { get; set; }

    [DisplayName("Is Available ?")]
    public bool? PIsInStock { get; set; }

    [DisplayName("Manufactured By")]
    public string? PManufacturer { get; set; }
}
