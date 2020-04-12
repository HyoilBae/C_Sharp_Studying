//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.Data.Services;
using System.Data.Services.Common;

namespace WCFService
{
    [System.ServiceModel.ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class AutomobileService : DataService<MCSDEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("Automobiles", EntitySetRights.AllRead);            
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }
    }
}
