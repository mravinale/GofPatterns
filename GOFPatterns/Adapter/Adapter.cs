﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter {

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class Adapter : Target {
        private Adaptee _adaptee = new Adaptee();

        public override void Request() {
            // Possibly do some other work
            //  and then call SpecificRequest
            _adaptee.SpecificRequest();
        }
    }
}
