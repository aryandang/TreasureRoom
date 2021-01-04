using TreasureRoom.Interfaces;
using TreasureRoom.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace TreasureRoom.Composing
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register(typeof(IDataTypeValueService),
                typeof(DataTypeValueService), Lifetime.Request);
        }
    }
}