//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input {
            get
            {
                return this.Input;
            }
            set
            {   // Precondition {P}
                if (value==null)
                {
                    throw new NullValueException("El producto no puede ser nulo");
                    
                }
                // Operation A
                this.Input=value;
                // Postcondition {Q}
                if (this.Equipment==null)
                {
                    throw new NullValueException("El producto no puede ser nulo");
                }
            }
        }
        public double Quantity {
            get
            {
                return this.Quantity;
            } 
            set
            {   // Precondition {P}
                if (value<=0)
                {
                    throw new LessThanZeroException("La cantidad tiene que ser mayor a cero");
                }
                // Operation A
                this.Quantity = value;
                // Postcondition {Q}
                if(this.Quantity<=0)
                {
                    throw new LessThanZeroException("La cantidad tiene que ser mayor a cero");
                }
            }
        }
        public int Time {
            get
            {
                return this.Time;
            } 
            set
            {   // Precondition {P}
                if (value<=0)
                {
                    throw new LessThanZeroException("El tiempo tiene que ser mayor a cero");
                }
                // Operation A
                this.Time = value;
                // Postcondition {Q}
                if(this.Time<=0)
                {
                    throw new LessThanZeroException("El tiempo tiene que ser mayor a cero");
                }
            }
        }
        public Equipment Equipment {
            get
            {
                return this.Equipment;
            }
            set
            {   // Precondition {P}
                if (value==null)
                {
                    throw new NullValueException("El equipo no puede ser nulo");
                    
                }
                // Operation A
                this.Equipment=value;
                // Postcondition {Q}
                if (this.Equipment==null)
                {
                    throw new NullValueException("El equipo no puede ser nulo");
                }
            }
        }
    }
}