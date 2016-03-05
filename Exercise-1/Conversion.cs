using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_1
{
    /// <summary>
    /// Хувирсан мэдээллийг хадгалах ангилал
    /// </summary>
    public class Conversion
    {
        double input, output;
        string description;
        /// <summary>
        /// Параметертэй байгуулагч
        /// </summary>
        /// <param name="i">Оролтын утга</param>
        /// <param name="o">Гаралтын утга</param>
        /// <param name="d">Хувиргалтын нэр</param>
        public Conversion(double i, double o, string d)
        {
            this.input = i;
            this.output = o;
            this.description = d;
        }
        /// <summary>
        /// Оролтын утгыг авах
        /// </summary>
        public double Input
        {
            get
            {
                return this.input;
            }
        }
        /// <summary>
        /// Гаралтын утгыг авах
        /// </summary>
        public double Output
        {
            get
            {
                return this.output;
            }
        }
        /// <summary>
        /// Ямар хувиргалт хийснийг авах
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }
        }
    }
}