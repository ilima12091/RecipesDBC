//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        private static ArrayList productCatalog = new ArrayList();

        private static ArrayList equipmentCatalog = new ArrayList();

        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = GetProduct("Café con leche");
            try
            {
                recipe.AddStep(new Step(GetProduct("Café"), 100, GetEquipment("Cafetera"), 120));
                recipe.AddStep(new Step(GetProduct("Leche"), 200, GetEquipment("Hervidor"), 60));
                recipe.PrintRecipe();
            }
            catch (NullValueException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (LessThanZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(EmptyStepsListException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(StepsPrintException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void PopulateCatalogs()
        {
            AddProductToCatalog("Café", 100);
            AddProductToCatalog("Leche", 200);
            AddProductToCatalog("Café con leche", 300);

            AddEquipmentToCatalog("Cafetera", 1000);
            AddEquipmentToCatalog("Hervidor", 2000);
        }

        private static void AddProductToCatalog(string description, double unitCost)
        {
            try
            {
                productCatalog.Add(new Product(description, unitCost));
            }
            catch (NullValueException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (EmptyValueException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (LessThanZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            try
            {
                equipmentCatalog.Add(new Equipment(description, hourlyCost));
            }
            catch (NullValueException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (EmptyValueException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (LessThanZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        private static Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        private static Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        private static Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}
