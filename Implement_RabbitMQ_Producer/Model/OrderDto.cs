﻿namespace Implement_RabbitMQ_Producer.Model
{
    public class OrderDto
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
