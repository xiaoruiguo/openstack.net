﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.openstack.Core
{
    public interface ICloudNetworksValidator
    {
        void ValidateCidr(string cidr);    
    }
}
