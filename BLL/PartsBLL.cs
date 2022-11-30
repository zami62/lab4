using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4
{
    [System.ComponentModel.DataObject]
    public class PartsBLL
    {
        private PartsTableAdapter Adapter = new PartsTableAdapter();
        private MetalBlanksTableAdapter MetalBlankAdapter = new MetalBlanksTableAdapter();
        private MachinesTableAdapter MachineAdapter = new MachinesTableAdapter();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddPart(string name, float partVolume, int metalBlankID, int machineID)
        {
            MetalBlank usedMetalBlank = MetalBlankAdapter.GetMetalBlankByID(metalBlankID);
            Machine usedMachine = MachineAdapter.GetMachineByID(machineID);

            float processedVolume = usedMetalBlank.Width * usedMetalBlank.Height * usedMetalBlank.Length - partVolume;

            float totalPrice = usedMetalBlank.Price * usedMachine.PriceOfProcessing1mm3;

            Adapter.AddPart(new Part {
                ID = Adapter.GetLastID() + 1, 
                Name = name, 
                Volume = partVolume, 
                TotalPrice = totalPrice,
                MachineID = machineID,
                MetalBlankID = metalBlankID });
        }

        public List<Part> GetParts()
        {
            return Adapter.GetParts();
        }

        public Part GetPartByID(int partID)
        {
            return Adapter.GetPartByID(partID);
        }

        public List<Part> GetPartsByName(string name)
        {
            return Adapter.GetPartsByName(name);
        }

        public void UpdatePartName(int partID, string newName)
        {
            Adapter.UpdatePartName(partID, newName);
        }

        public void RemovePart(int partID)
        {
            Adapter.RemovePart(partID);
        }
    }
}
