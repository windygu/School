﻿using System;
using System.Data;

namespace Sparkle.Admission.Component.TestDefination
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
            base.CreateStoredProcedure = "Admission.TestDefinitionInsert";
            base.ReadStoredProcedure = "Admission.TestDefinitionRead";
            base.ReadAllStoredProcedure = "Admission.TestDefinitionReadAll";
            base.UpdateStoredProcedure = "Admission.TestDefinitionUpdate";
            base.NumberOfRowsAffectedInUpdate = 1;
            base.DeleteStoredProcedure = "Admission.TestDefinitionDelete";
            base.NumberOfRowsAffectedInDelete = 1;
        }

        protected override BinAff.Core.Data CreateDataObject(DataRow dr, BinAff.Core.Data data)
        {
            Data dt = data as Data;
            dt.Id = Convert.IsDBNull(dr["Id"]) ? 0 : Convert.ToInt64(dr["Id"]);
            dt.Name = Convert.IsDBNull(dr["Name"]) ? String.Empty : Convert.ToString(dr["Name"]);
            dt.IsActive = Convert.IsDBNull(dr["IsActive"]) ? false : Convert.ToBoolean(dr["IsActive"]);

            return dt;
        }

        protected override void AssignParameter(String procedureName)
        {
            base.AddInParameter("@Name", DbType.Int32, (this.Data as Data).Name);
        }

        #endregion

        internal Boolean ReadDuplicate()
        {
            Data data = this.Data as Data;
            this.CreateConnection();
            this.CreateCommand("Admission.TestDefinitionReadDuplicate");
            this.AssignParameter("Admission.TestDefinitionReadDuplicate");

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
            this.CreateCommand("Admission.TestDefinitionUpdateStatus");
            base.AddInParameter("@Id", DbType.String, (this.Data as Data).Id);
            base.AddInParameter("@IsActive", DbType.Boolean, ActiveStatus);
            return this.ExecuteNonQuery() == 1 ? true : false;
        }
    }
}