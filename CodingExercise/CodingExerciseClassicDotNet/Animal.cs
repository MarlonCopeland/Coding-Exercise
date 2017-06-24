using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExerciseClassicDotNet
{
    class Animal
    {
        //properties of this class:
        private int weight;

        /// <summary>
        /// The Accessor for the private weight property. Differentiated
        /// by the Capital W in the name of the variable. The GET accessor will return
        /// the private value for lowecase weight. The SET accessor will set the private
        /// propert to the value assigned thought the public variable. This is an example of
        /// ENCAPSULATION.
        /// </summary>
        public int Weight {
            get {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        private string name { get; set; }

        private string height;

        private int numberOfLimbs;


        public bool IsAlive()
        {
            throw new NotImplementedException();
        }
    }
}
