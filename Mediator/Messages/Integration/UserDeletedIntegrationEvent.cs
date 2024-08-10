using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingBlocksCore.Mediator.Messages.Integration
{
    public class UserDeletedIntegrationEvent : IntegrationEvent
    {
        public long Id { get; set; }
        public long  UserDeleteId { get; set; }
    }
}
