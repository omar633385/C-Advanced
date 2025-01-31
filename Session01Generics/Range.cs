using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01Generics
{
    internal class Range<T> where T:IComparable<T>
    {

        #region Properties

        public T Minimum { get; set; }
        public T Maximum { get; set; }
        #endregion
        #region Constructor
        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum must be less than or equal to Maximum.");
            }
            Minimum = minimum;
            Maximum = maximum;
        }
        #endregion

        #region Methods
        public bool IsInRange(T value)
        {
            if (value is not null)
                return value.CompareTo(Minimum) > 0 && value.CompareTo(Maximum) < 0;
            return false;
        }
        public T Length()
        {
            dynamic min = Minimum;
            dynamic max = Maximum;
            return max - min;
        } 
        #endregion

    }

        
}


 