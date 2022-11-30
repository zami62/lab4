using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable

namespace lab4
{
    public class MetalBlanksTableAdapter
    {
        ApplicationContext db = new ApplicationContext();

        public void AddMetalBlank(MetalBlank part)
        {
            db.MetalBlanks.Add(part);
        }

        public int GetLastID()
        {
            int? id = db.Parts.Max(mb => mb.ID);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<MetalBlank>? GetMetalBlanks()
        {
            List<MetalBlank>? parts = db.MetalBlanks.ToList();
            return parts;
        }

        public MetalBlank? GetMetalBlankByID(int metalBlankID)
        {
            MetalBlank? part = (from p in db.MetalBlanks where p.ID == metalBlankID select p).First();
            return part;
        }

        public List<MetalBlank>? GetMetalBlanksByMaterial(string name)
        {
            List<MetalBlank>? parts = (from p in db.MetalBlanks where p.Material.Contains(name) select p).ToList();
            return parts;
        }

        public void UpdateMetalBlankPricePerKG(int metalBlankID, float newPriceOf1kg)
        {
            MetalBlank? metalBlank = (from mb in db.MetalBlanks where mb.ID == metalBlankID select mb).First();
            if (metalBlank != null)
            {
                metalBlank.PriceOf1kg = newPriceOf1kg;
                db.SaveChanges();
            }
        }

        public void UpdateMetalBlankPrice(int metalBlankID, float newPrice)
        {
            MetalBlank? metalBlank = (from mb in db.MetalBlanks where mb.ID == metalBlankID select mb).First();
            if (metalBlank != null)
            {
                metalBlank.Price = newPrice;
                db.SaveChanges();
            }
        }

        public void RemoveMetalBlank(int metalBlankID)
        {
            MetalBlank? part = (from p in db.MetalBlanks where p.ID == metalBlankID select p).First();
            if (part != null)
            {
                db.MetalBlanks.Remove(part);
            }
        }
    }
}
