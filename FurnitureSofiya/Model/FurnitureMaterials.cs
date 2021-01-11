using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureSofiya.Model
{
    class FurnitureMaterials : IFurniture
    {
        public string ImageUrl { get; private set; }
        public string Name { get; private set; }

        public FurnitureMaterials(string Name)
        {
            this.Name = Name;
        }
    }
}
