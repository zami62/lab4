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
    [ApiExplorerSettings(GroupName = "metalblanks")]
    public class MetalBlanksController : ControllerBase
    {

        MetalBlanksBLL BLL = new MetalBlanksBLL();

        [HttpPut]
        [Route("/add by price per kg")]
        public void AddMetalBlankByPricePerKG(string material, Vector3 dimensions, float density, float priceOf1kg)
        {
            BLL.AddMetalBlankByPricePerKG(material, dimensions, density, priceOf1kg);
        }

        [HttpPut]
        [Route("/add by price")]
        public void AddMetalBlankByPrice(string material, Vector3 dimensions, float density, float price)
        {
            BLL.AddMetalBlankByPrice(material, dimensions, density, price);
        }

        [HttpGet]
        [Route("/get all")]
        public List<MetalBlank> GetMetalBlanks()
        {
            return BLL.GetMetalBlanks();
        }

        [HttpGet]
        [Route("/get by id")]
        public MetalBlank GetMetalBlankByID(int metalBlankID)
        {
            return BLL.GetMetalBlankByID(metalBlankID);
        }

        [HttpGet]
        [Route("/get by material")]
        public List<MetalBlank> GetMetalBlanksByMaterial(string name)
        {
            return BLL.GetMetalBlanksByMaterial(name);
        }

        [HttpPatch]
        [Route("/patch price per kg")]
        public void UpdateMetalBlankPricePerKG(int metalBlankID, float newPriceOf1kg)
        {
            BLL.UpdateMetalBlankPricePerKG(metalBlankID, newPriceOf1kg);
        }

        [HttpPatch]
        [Route("/patch price")]
        public void UpdateMetalBlankPrice(int metalBlankID, float newPrice)
        {
            BLL.UpdateMetalBlankPrice(metalBlankID, newPrice);
        }

        [HttpDelete]
        [Route("/delete by id")]
        public void RemoveMetalBlank(int metalBlankID)
        {
            BLL.RemoveMetalBlank(metalBlankID);
        }

    }
}
