﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IdGen
    {
        private long uniqueId;
            
        public IdGen()
        {
            this.uniqueId = 0;
        }

        public long generate()
        {
            this.uniqueId++;
            return uniqueId;
        }
    }
}
