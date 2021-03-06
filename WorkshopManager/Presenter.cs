﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManager
{
    class Presenter
    {
        ImainView view;
        Model model;
        
        public Presenter(Model model, ImainView view)
        {
            this.model = model;
            this.view = view;
            view.loadData += _loadData;
            view.saveData += _saveData;
            view.getAllCars += _getAllCars;
            view.addNewCar += View_addNewCar;
            view.editCar += View_editCar;
            view.deleteCar += View_deleteCar;
        }

        private bool View_deleteCar(Car arg)
        {
            try
            { model.DeleteCar(arg); return true; }
            catch { MessageBox.Show("Nie udało się usunąć pojazdu"); return false; }
        }

        private bool View_editCar(Car source, Car dest)
        {
            try
            { model.EditCar(source,dest); return true; }
            catch { MessageBox.Show("Nie udało się edytować pojazdu"); return false; }
        }

        private bool View_addNewCar(Car arg)
        {
            try
            { model.AddNewCar(arg); return true; }
            catch { MessageBox.Show("Nie udało się dodać pojazdu"); return false; }
        }

        private void _saveData(bool obj)
        {
            try
            { model.SaveDataToFiles(); }
            catch { MessageBox.Show("Nie udało się zapisać danych do plików"); }
        }

        private void _loadData(bool obj)
        {
            try
            { model.LoadDataFromFiles(); }
            catch { MessageBox.Show("Nie udało się wczytać danych z pliku"); }
        }

        private List<Car> _getAllCars()
        {
            return model.Cars;
        }
    }
}
