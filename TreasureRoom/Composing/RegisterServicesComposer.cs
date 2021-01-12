using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace TreasureRoom.Composing
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]//Only do this when the application is running
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            //Create an instance of Search Service in the interface and do it per request
            composition.Register<ISearchService, SearchService>(Lifetime.Request);
        }
    }
}