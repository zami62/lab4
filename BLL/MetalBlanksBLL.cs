using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace lab4
{
    [System.ComponentModel.DataObject]
    public class MetalBlanksBLL
    {
        private MetalBlanksTableAdapter Adapter = new MetalBlanksTableAdapter();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddMetalBlankByPricePerKG(string material, Vector3 dimensions, float density, float priceOf1kg)
        {
            float volume = dimensions.X * dimensions.Y * dimensions.Z;
            float weight = volume * density;

            Adapter.AddMetalBlank(new MetalBlank
            {
                ID = Adapter.GetLastID() + 1,
                Material = material,
                Width = dimensions.X,
                Height = dimensions.Y,
                Length = dimensions.Z,
                Density = density,
                Weight = weight,
                PriceOf1kg = priceOf1kg,
                Price = priceOf1kg * weight
            });
        }

        public void AddMetalBlankByPrice(string material, Vector3 dimensions, float density, float price)
        {
            float volume = dimensions.X * dimensions.Y * dimensions.Z;
            float weight = volume * density;

            Adapter.AddMetalBlank(new MetalBlank
            {
                ID = Adapter.GetLastID() + 1,
                Material = material,
                Width = dimensions.X,
                Height = dimensions.Y,
                Length = dimensions.Z,
                Density = density,
                Weight = weight,
                Price = price
            });
        }

        public List<MetalBlank> GetMetalBlanks()
        {
            return Adapter.GetMetalBlanks();
        }

        public MetalBlank GetMetalBlankByID(int metalBlankID)
        {
            return Adapter.GetMetalBlankByID(metalBlankID);
        }

        public List<MetalBlank> GetMetalBlanksByMaterial(string name)
        {
            return Adapter.GetMetalBlanksByMaterial(name);
        }

        public void UpdateMetalBlankPricePerKG(int metalBlankID, float newPriceOf1kg)
        {
            Adapter.UpdateMetalBlankPricePerKG(metalBlankID, newPriceOf1kg);

            float weight = Adapter.GetMetalBlankByID(metalBlankID).Weight;

            Adapter.UpdateMetalBlankPrice(metalBlankID, weight * newPriceOf1kg);
        }

        public void UpdateMetalBlankPrice(int metalBlankID, float newPrice)
        {
            Adapter.UpdateMetalBlankPrice(metalBlankID, newPrice);

            float weight = Adapter.GetMetalBlankByID(metalBlankID).Weight;

            Adapter.UpdateMetalBlankPricePerKG(metalBlankID, newPrice / weight);
        }

        public void RemoveMetalBlank(int metalBlankID)
        {
            Adapter.RemoveMetalBlank(metalBlankID);
        }
    }
}

