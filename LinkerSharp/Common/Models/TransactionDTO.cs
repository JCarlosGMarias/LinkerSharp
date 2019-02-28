﻿using System.Collections.Generic;

namespace LinkerSharp.Common.Models
{
    public enum TransportTypeEnum { IN_OUT, JUST_IN }

    public sealed class TransactionDTO
    {
        public int TransactionID { get; set; }
        public TransportTypeEnum Transport { get; set; }
        public Dictionary<string, string> Properties { get; set; }

        public TransmissionMessageDTO RequestMessage { get; set; }
        public TransmissionMessageDTO ResponseMessage { get; set; }

        public TransactionDTO()
        {
            this.Properties = new Dictionary<string, string>();
            this.Transport = TransportTypeEnum.IN_OUT;
        }
    }
}