﻿namespace Sparkle.Billing.Component.Fine.Type
{

    public class Server : BinAff.Core.Crud
    {

        public Server(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.Name = "Fine Type";
            base.Validator = new Validator(this.Data as Data);
            base.DataAccess = new Dao(this.Data as Data);
            base.IsLov = true;
        }

        public override BinAff.Core.Data CreateDataObject()
        {
            return new Data();
        }

        public override BinAff.Core.Crud CreateInstance(BinAff.Core.Data data)
        {
            return new Server(data as Data);
        }

    }

}