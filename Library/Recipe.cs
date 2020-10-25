//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            // Precondition {P}
            if(!this.steps.Contains(step))
            {
                throw new UnknownStepException("Este paso no pertenece a la receta", step);
            }

            // Operation A
            this.steps.Remove(step);

            // Postcondition {Q}
            if(this.steps.Contains(step))
            {
                throw new RemoveStepException("No se pudo remover el paso de la receta", step);
            }
        }

        public void PrintRecipe()
        {
            // Precondition {P}
            if(this.steps.Count == 0)
            {
                throw new EmptyStepsListException("La lista de pasos está vacía");
            }

            // Operation A
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            int stepsRecorridos = 0;
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
                stepsRecorridos++;
            }
            
            // Postcondition {Q}
            if(stepsRecorridos != this.steps.Count)
            {
                throw new StepsPrintException("Se imprimió una cantidad de pasos distinta a la cantidad de los que estaban definidos");
            }
        }
    }
}