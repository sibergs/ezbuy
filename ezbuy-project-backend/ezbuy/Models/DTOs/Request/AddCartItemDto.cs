﻿namespace ezbuy.Models.DTOs.Request
{
    public class AddCartItemDto
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
