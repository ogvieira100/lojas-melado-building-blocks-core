﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingBlocksCore.Mediator.Messages.Integration
{
    public class UserInsertedIntegrationEvent : IntegrationEvent
    {

        public string CPF { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }
        public long UserInserted { get; set; }

        public UserInsertedIntegrationEvent():base()
        {
                
        }

    }
}
