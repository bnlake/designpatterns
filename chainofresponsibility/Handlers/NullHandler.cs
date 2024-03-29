﻿using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal class NullHandler : BaseHandler
    {
        public NullHandler(IHandler? next = null) : base(next) { }

        public override async Task<IEnumerable<Content>?> HandleAsync(int identifier)
        {
            Console.WriteLine("-- Null Handler Invoked");
            return await Task.Run(() => new List<Content>());
        }
    }
}
