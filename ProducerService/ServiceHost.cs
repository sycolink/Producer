﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;

namespace ProducerService
{
    class ServiceHost
    {
        private readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public ServiceHost()
        {
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}
