using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExerciseClassicDotNet
{
    /// <summary>
    /// An Interface is a blueprint for an object. when an object inherits from this interface, it must use the methods it holds!
    /// </summary>
    interface LivingThing
    {
        /// <summary>
        /// this method must be implemented by any class that implements this interface!
        /// </summary>
        /// <returns></returns>
        bool IsAlive();

    }
}
