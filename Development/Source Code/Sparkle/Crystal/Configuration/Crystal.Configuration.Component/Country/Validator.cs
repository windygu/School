﻿using System.Collections.Generic;

using BinAff.Core;
using BinAff.Utility;

namespace Crystal.Configuration.Component.Country
{

    public class Validator : BinAff.Core.Validator
    {

        public Validator(Data data)
            : base(data)
        {

        }

        protected override List<Message> Validate()
        {
            List<Message> retMsg = new List<Message>();
            Data data = base.Data as Data;

            if (ValidationRule.IsNullOrEmpty(data.Name))
            {
                retMsg.Add(new Message("Country name cannot be empty.", Message.Type.Error));
            }
            else if (data.Name.Length > 50)
            {
                retMsg.Add(new Message("Country name cannot be more than 50 characters.", Message.Type.Error));
            }
            if ((this.Server.DataAccess as Dao).ReadDuplicate())
            {
                retMsg.Add(new Message("Same Country already exists.", Message.Type.Error));
            }

            return retMsg;
        }

    }

}