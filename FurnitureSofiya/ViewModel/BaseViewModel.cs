using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace FurnitureSofiya.ViewModel
{
    abstract class BaseViewModel : INotifyPropertyChanged //Этот класс нужен для того чтобы каждый раз не реализовывать интерфейс
    {
        public event PropertyChangedEventHandler PropertyChanged; //Интерфейс реализует это событие
                                                                    //Интерфейс ждет его для того чтобы узнать какие события изменились и перерисовать интерфейс

        protected void NotifyPropertyChanged(string propertyName) //Нужен для обновления графики из viewmodel
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
