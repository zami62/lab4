using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

using lab4;

namespace lab4.Controllers
{
    [ApiController]
    [Route("/controller")]
    [ApiExplorerSettings(GroupName = "machines")]
    public class MachinesController : ControllerBase
    {

        MachinesBLL BLL = new MachinesBLL();

        [HttpPut]
        [Route("/add")]
        public void AddMachine(string model, Vector3 maxDimensions, float processingTimeOf1mm3, float priceOfProcessing1mm3)
        {
            BLL.AddMachine(model, maxDimensions, priceOfProcessing1mm3, priceOfProcessing1mm3);
        }

        [HttpGet]
        [Route("/get all")]
        public List<Machine> GetMachines()
        {
            return BLL.GetMachines();
        }

        [HttpGet]
        [Route("/get by id")]
        public Machine GetMachineByID(int machineID)
        {
            return BLL.GetMachineByID(machineID);
        }

        [HttpGet]
        [Route("/get by model")]
        public List<Machine> GetMachinesByModel(string model)
        {
            return BLL.GetMachinesByModel(model);
        }

        [HttpPatch]
        [Route("/patch processing price")]
        public void UpdateMachineProcessingPrice(int machineID, float newPriceOfProcessing)
        {
            BLL.UpdateMachineProcessingPrice(machineID, newPriceOfProcessing);
        }

        [HttpDelete]
        [Route("/delete by id")]
        public void RemoveMachine(int machineID)
        {
            BLL.RemoveMachine(machineID);
        }

    }
}
