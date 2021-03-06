﻿namespace Sparkle.School.Component.Class
{

    public class Server : BinAff.Core.Crud
    {

        public Server(Data data)
            : base(data)
        {

        }

        protected override void Compose()
        {
            base.Name = "Class";
            base.Validator = new Validator(this.Data as Data);
            base.DataAccess = new Dao(this.Data as Data);
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
            base.AddChild(new Standard.Server((this.Data as Data).Standard)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
            base.AddChild(new Section.Server((this.Data as Data).Section)
            {
                Type = ChildType.Independent,
                IsReadOnly = true,
            });
        }

    }

}