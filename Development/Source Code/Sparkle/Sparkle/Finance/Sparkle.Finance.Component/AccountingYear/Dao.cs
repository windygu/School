﻿using System;
using System.Data;

namespace Sparkle.Finance.Component.AccountingYear
{

    public class Dao : BinAff.Core.Dao
    {

        public Dao(Data data)
            : base(data)
        {

        }

        #region Framework

        protected override void Compose()
        {
            base.CreateStoredProcedure = "Finance.AccountingYearInsert";
            base.ReadStoredProcedure = "Finance.AccountingYearRead";
            base.ReadAllStoredProcedure = "Finance.AccountingYearReadAll";
            base.UpdateStoredProcedure = "Finance.AccountingYearUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Finance.AccountingYearDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Name = Convert.IsDBNull(dr["Name"]) ? String.Empty : Convert.ToString(dr["Name"]);
            dt.CurrentFlag = Convert.IsDBNull(dr["CurrentFlag"]) ? false : Convert.ToBoolean(dr["CurrentFlag"]);

            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Name", DbType.String, (this.Data as Data).Name);
            base.AddInParameter("@CurrentFlag", DbType.Boolean, (this.Data as Data).CurrentFlag);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Finance.AccountingYearReadDuplicate");
            this.AssignParameter("Finance.AccountingYearReadDuplicate");

            DataSet ds = this.ExecuteDataSet();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (!Convert.IsDBNull(dr["Id"]) && Convert.ToInt64(dr["Id"]) != this.Data.Id) return true;
                }
            }

            return false;
        }

        internal Boolean Activate()
        {
            return UpdateStatus(true);
        }

        internal Boolean Deactivate()
        {
            return UpdateStatus(false);
        }

        internal Boolean UpdateStatus(Boolean ActiveStatus)
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Finance.AccountingYearUpdateStatus");
            base.AddInParameter("@Id", DbType.String, (this.Data as Data).Id);
            base.AddInParameter("@IsActive", DbType.Boolean, ActiveStatus);
            return this.ExecuteNonQuery() == 1 ? true : false;
        }


    }

}