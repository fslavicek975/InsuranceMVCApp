﻿namespace DataLibrary.Models
{
    public class Policy
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public decimal PolicyAmount { get; set; }
        public int PartnerId { get; set; }
        public Partner Partner { get; set; }
    }
}
