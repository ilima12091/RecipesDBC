//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description {
            get
            {
                return this.Description;
            }
            set
            {   // Precondition {P}
                if (value==null)
                {
                    throw new NullValueException("La descripción no puede ser nula");
                    
                }   // Precondition {P}
                else if(value=="")
                {
                    throw new EmptyValueException("La descripción no puede estar vacía");
                }
                // Operation A
                this.Description=value;
                // Postcondition {Q}
                if (this.Description==null)
                {
                    throw new NullValueException("La descripcion no puede ser nula");
                }
                // Postcondition {Q}
                if (this.Description=="")
                {
                    throw new EmptyValueException("La descripcion no puede estar vacía");
                }
            }
        } 

        public double HourlyCost {
            get
            {
                return this.HourlyCost;
            } 
            set
            {   // Precondition {P}
                if (value<=0)
                {   
                    throw new LessThanZeroException("El costo de hora tiene que ser mayor a cero");
                }
                // Operation A
                this.HourlyCost = value;
                // Postcondition {Q}
                if(this.HourlyCost<=0)
                {
                    throw new LessThanZeroException("El costo de hora tiene que ser mayor a cero");
                }
            }
        }
    }
}