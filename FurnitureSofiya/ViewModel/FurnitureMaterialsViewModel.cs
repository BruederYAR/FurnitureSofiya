using FurnitureSofiya.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FurnitureSofiya.ViewModel
{
    class FurnitureMaterialsViewModel : BaseViewModel
    {
        public ICommand ClickWorkCommand { get; private set; }
        public ICommand ClickClothCommand { get; private set; }
        public ICommand ClickMaterialCommand { get; private set; }

        public ObservableCollection<IFurniture> Items { get; set; }

        public FurnitureMaterialsViewModel()
        {
            ClickWorkCommand = new Command(OnClickWork);
            ClickClothCommand = new Command(OnClickCloth);
            ClickMaterialCommand = new Command(OnClickMaterial);
        }

        void OnClickWork()
        {
            Items = new ObservableCollection<IFurniture>
            {
                new FurnitureMaterials("Замена паралона"),
                new FurnitureMaterials("Замена механизма"),
                new FurnitureMaterials("Перетяжка"),
                new FurnitureMaterials("Ремонт"),
            };
            NotifyPropertyChanged(nameof(Items));
        }
        void OnClickCloth() 
        {
            Items = new ObservableCollection<IFurniture>
            {
                new FurnitureMaterials("Ткань 1"),
                new FurnitureMaterials("Ткань 2"),
                new FurnitureMaterials("Ткань 3"),
                new FurnitureMaterials("Ткань 4"),
            };
            NotifyPropertyChanged(nameof(Items));
        }

        void OnClickMaterial()
        {
            Items = new ObservableCollection<IFurniture>
            {
                new FurnitureMaterials("Материал 1"),
                new FurnitureMaterials("Материал 2"),
                new FurnitureMaterials("Материал 3"),
                new FurnitureMaterials("Материал 4"),
            };

            NotifyPropertyChanged(nameof(Items));
        }

    }
}
