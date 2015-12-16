namespace SoftUniWarz.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ValidateData
    {
        // Validating info from the proeperties.
        public static void ValidateNumber(int bottomBoundary, int upperBoundary, int numberToValidate, string paramName)
        {
            if (numberToValidate < bottomBoundary || numberToValidate > upperBoundary)
            {
                throw new ArgumentOutOfRangeException(string.Format($"{paramName} must be in range[{bottomBoundary},{upperBoundary}]"));
            }
        }

        public static void CheckIsNull (object objectToValidate, string name)
        {
            if (objectToValidate == null)
            {
                throw new ArgumentNullException(string.Format($"{name} cannot be null!"));
            }
        }
    }
}
