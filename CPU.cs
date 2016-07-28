using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerGame
{
    class CPU
    {
        private byte _dataBus;
        private ushort _addressBus;

        public byte DataBus { get { return _dataBus; } }
        public ushort AdressBus { get { return _addressBus; } }

        public CPU()
        {

        }

        public void Update()
        {

        }
    }
}
