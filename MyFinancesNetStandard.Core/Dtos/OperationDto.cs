﻿using System;

namespace MyFinances.Core.Dtos
{
    public class OperationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }

    }
}
