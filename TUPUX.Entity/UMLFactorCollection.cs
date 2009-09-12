using System;
using System.Collections.Generic;
using System.Text;
using TUPUX.ActiveRecord;
using TUPUX.Entity.Constants;

namespace TUPUX.Entity
{
    [Serializable]
    public class UMLFactorCollection : ActiveList<UMLFactor, UMLFactorCollection>
    {        
        /// <summary>
        /// Gets factors list using a file
        /// </summary>
        /// <param name="fileName">File Name</param>
        /// <returns></returns>
        public static UMLFactorCollection GetFactors(bool defaultFactor)
        {
            string fileName = "";
            if (defaultFactor)
            {
                fileName = pahtFactorsDefault;
            }
            else
            {
                fileName = pahtFactors;
            }

            UMLFactorCollection factors = HelperEstimation.XMLDeserialize<UMLFactorCollection>(fileName);
            foreach (UMLFactor factor in factors)
            {
                factor.MarkLoaded();
            }
            return factors;
        }

        public static string pahtFactors = AppPath.Path + HelperEstimation.PATH_FACTORS;
        public static string pahtFactorsDefault = AppPath.Path + HelperEstimation.PATH_FACTORS_DEFAULT;
    }
}
