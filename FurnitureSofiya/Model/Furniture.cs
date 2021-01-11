using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureSofiya.Model
{
    public class Furniture : IFurniture
    {
        public string ImageUrl { get; set; } //Ссылка на картинку
        public string Name { get; set; } //Имя мебели

        public Furniture(string ImageUrl, string Name)
        {
            this.ImageUrl = ImageUrl;
            this.Name = Name;
        }

    }
}
