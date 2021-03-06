﻿using System;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections;

namespace MTApiService
{
    [DataContract]
    public class MtCommand
    {
        public MtCommand(int commandType, ArrayList parameters)
        {
            CommandType = commandType;
            Parameters = parameters;
        }

        [DataMember]
        public int CommandType { get; private set; }

        [DataMember]
        public ArrayList Parameters { get; private set; }

    }
}
