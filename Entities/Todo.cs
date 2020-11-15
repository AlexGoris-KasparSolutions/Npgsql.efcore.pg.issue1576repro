using System;

namespace Npgsql.efcore.pg.issue1576repro.Entities
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}