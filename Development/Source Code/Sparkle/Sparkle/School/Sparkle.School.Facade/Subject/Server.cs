﻿using Comp = Sparkle.School.Component.Subject;

using FacLib = Sparkle.Core.Facade;

namespace Sparkle.School.Facade.Subject
{

    public class Server : Sparkle.Core.Facade.Server
    {

        public Server(FormDto formDto)
            : base(formDto)
        {

        }

        #region Framework

        protected override FacLib.FormDto InstantiateFormDto()
        {
            return new FormDto
            {
                Dto = new Dto(),
            };
        }

        protected override FacLib.Server InstantiateFacade()
        {
            return new Server(base.FormDto as FormDto);
        }

        protected override void Instantiate()
        {
            base.ComponentData = new Comp.Data();
            base.ComponentServer = new Comp.Server(base.ComponentData as Comp.Data);
        }

        public override void AssignDto()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            dto.Name = data.Name;
            dto.TotalMarks = data.TotalMarks;
            dto.PassMarks = data.PassMarks;
        }

        public override void AssignData()
        {
            Dto dto = (base.FormDto as FormDto).Dto as Dto;
            Comp.Data data = base.ComponentData as Comp.Data;
            data.Name = dto.Name;
            data.TotalMarks = dto.TotalMarks;
            data.PassMarks = dto.PassMarks;

        }

        public override BinAff.Facade.Library.Dto Convert(BinAff.Core.Data data)
        {
            Comp.Data dt = data as Comp.Data;
            return new Dto
            {
                Id = dt.Id,
                Name = dt.Name,
                TotalMarks = dt.TotalMarks,
                PassMarks = dt.PassMarks,
                IsActive = dt.IsActive,
            };
        }

        public override BinAff.Core.Data Convert(BinAff.Facade.Library.Dto dto)
        {
            Dto dt = dto as Dto;
            return new Comp.Data
            {
                Id = dt.Id,
                Name = dt.Name,
                TotalMarks = dt.TotalMarks,
                PassMarks = dt.PassMarks,
                IsActive = dt.IsActive,
            };
        }

        #endregion

    }

}