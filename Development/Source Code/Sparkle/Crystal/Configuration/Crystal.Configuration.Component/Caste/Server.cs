﻿namespace Crystal.Configuration.Component.Caste
{
    public class Server : BinAff.Core.Observer.SubjectCrud
    {
        public Server(Data data)
            : base(data)
        {

        }
        protected override void Compose()
        {
            this.Name = "Caste";
            this.DataAccess = new Dao(this.Data as Data);
            this.Validator = new Validator(this.Data as Data);
        }

        public override BinAff.Core.Data CreateDataObject()
        {
            return new Data();
        }

        public override BinAff.Core.Crud CreateInstance(BinAff.Core.Data data)
        {
            return new Server(data as Data);
        }

        protected override void CreateChildren()
        {
            base.AddChild(new Religion.Server((this.Data as Data).Religion)
            {
                IsReadOnly = true,
                Type = ChildType.Independent
            });
        }
    }
}
