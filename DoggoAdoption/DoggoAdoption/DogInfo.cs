using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoggoAdoption
{
    public class DogInfo
    {
        [PrimaryKey, AutoIncrement]
        public int DogId { get; set; }
        public string DogName { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
        public string DogType { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
