using System.Collections.Generic;
using System.Web.Mvc;

namespace TreasureRoom.Interfaces
{
    public interface IDataTypeValueService
    {
        IEnumerable<SelectListItem> GetItemsFromValueListDataType(string dataTypeName, string[] selectedValues);
    }
}