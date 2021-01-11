using FurnitureSofiya.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FurnitureSofiya.ViewModel
{
    class FurnitureViewModel : BaseViewModel
    {
        public ObservableCollection<IFurniture> Furnitures { get; set; } //Список мебели, который будет показываться в вкладке AddOrder

        public FurnitureViewModel()
        {
            Furnitures = new ObservableCollection<IFurniture>
            {   new Furniture("https://img.icons8.com/ios-filled/452/sofa.png", "Диван"),
                new Furniture("https://img.icons8.com/ios-filled/452/sofa.png", "Кресло"),
                new Furniture("https://img.icons8.com/ios-filled/452/sofa.png", "Кухонный уголок"),
                new Furniture("https://img.icons8.com/ios-filled/452/sofa.png", "Стул"),
                new Furniture("https://img.icons8.com/ios-filled/452/sofa.png", "Кровать"),
            };
            
            
            NotifyPropertyChanged(nameof(Furnitures));  
        }

    }
}
