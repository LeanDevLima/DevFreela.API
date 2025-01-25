﻿namespace DevFreela.API.Models
{
    public class CreateProjectInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdCliente { get; set; }
        public int IdFrelancer {  get; set; }
        public decimal TotalCost { get; set; }
    }
}
