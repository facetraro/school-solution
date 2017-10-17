﻿using Domain;
using Exceptions;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module
{
    public class SchoolVanModule : ModuleClass
    {
        public void AddNewSchoolVan(int capacity)
        {
            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Capacity = capacity;
            newSchoolVan.Id = logic.GetNextIdFree();
            logic.Add(newSchoolVan);
        }
        public void LoadAllSchoolVans(ListBox list)
        {
            SchoolVanLogic logic = new SchoolVanLogic();
            List<SchoolVan> allObjects = new List<SchoolVan>();
            allObjects = logic.GetSchoolVansSortedByCapacity();
            if (allObjects.Count == 0)
            {
                throw new NoSchoolVanInSystemException("No hay Camionetas ingresadas en el sistema");
            }
            foreach (SchoolVan item in allObjects)
            {
                list.Items.Add(item);
            }
        }

        public void LoadFields(object selectedObject, TextBox textId, NumericUpDown numericCapacity)
        {
            if (!(selectedObject is SchoolVan))
            {
                throw new WrongObjectException("Se esperaba un objeto del tipo [SchoolVan]");
            }
            SchoolVan theSchoolVan = selectedObject as SchoolVan;
            textId.Text = theSchoolVan.Id + "";
            numericCapacity.Value = theSchoolVan.Capacity;
        }

        public void ModifySchoolVan(object selectedObject, TextBox textName, NumericUpDown numericCapacity)
        {
            if (!(selectedObject is SchoolVan))
            {
                throw new WrongObjectException("Se esperaba un objeto del tipo [SchoolVan]");
            }
            SchoolVan oldSchoolVan = selectedObject as SchoolVan;
            SchoolVanLogic logic = new SchoolVanLogic();
            SchoolVan newSchoolVan = new SchoolVan();
            newSchoolVan.Id = oldSchoolVan.Id;
            newSchoolVan.Capacity = (int)numericCapacity.Value;
            logic.Modify(oldSchoolVan, newSchoolVan);
        }

        public void LoadRoutesBySchoolVan(object selectedItem, RichTextBox list)
        {
            SchoolVanLogic logic = new SchoolVanLogic();
            List<Route> routes = logic.GetBestRoutes();
            foreach (Route item in routes)
            {
                if (item.TheSchoolVan.Equals(selectedItem))
                {
                    list.Text=item.ToStringRoute();
                }
            }
        }

        public void RemoveSchoolVan(object selectedObject)
        {
            if (!(selectedObject is SchoolVan))
            {
                throw new WrongObjectException("Se esperaba un objeto del tipo [SchoolVan]");
            }
            SchoolVan toDelete = selectedObject as SchoolVan;
            SchoolVanLogic logic = new SchoolVanLogic();
            logic.Remove(toDelete);
        }
    }
}
