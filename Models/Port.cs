using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galleass.Models
{
    public class Port
    {
        [Key]
        public int PortId {get;set;}
        public string PortName {get;set;}
        public string ImageURL {get;set;}
        public string Description{get;set;}
        //One to One(Port must have a GridSquareId)
        [Required]
        [Display(Name="Location:")]
        public int GridSquareId {get;set;}
        //Many to many(A port can many GridSquares)
        public List<PortPrice> PortPrices{get;set;}

        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}