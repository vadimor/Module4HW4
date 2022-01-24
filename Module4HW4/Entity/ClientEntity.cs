using System;
using System.Collections.Generic;

namespace Module4HW4.Entity
{
    public class ClientEntity
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Birthday { get; set; }
        public string Language { get; set; }
        public List<ProjectEntity> Projects { get; set; } = new List<ProjectEntity>();
    }
}
