using NetCoreBase.BCUnitOfWork;
using NetCoreBase.Features.Inventory.Entities;
using NetCoreBase.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreBase.Features.Inventory
{
    public class InventoryAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryAppService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response> GetAllItems()
        {
            IEnumerable<Item> items = await _unitOfWork.repository.GetAllAsync();

            if (items.Any())
            {
                return new Response { Data = items };
            }
            return new Response { FailMessage = "No items were found" };
        }

        public async Task<Response> SaveNewItem(string code, decimal quantity)
        {
            Item itemToBeSaved = new Item();
            itemToBeSaved.Code = code;
            itemToBeSaved.Quantity = quantity;

            await _unitOfWork.repository.AddAsync(itemToBeSaved);
            await _unitOfWork.CommitAsync();

            return new Response { SuccessMessage = $"{itemToBeSaved.Quantity} of {itemToBeSaved.Code} were saved." };
        }
    }
}
