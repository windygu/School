﻿namespace Sparkle.School.WinForm.Class
{

    public partial class Form : Sparkle.Core.Presentation.Form
    {

        public Form()
        {
            InitializeComponent();
            base.ListDisplayName = "Name";
            base.FormName = "Class";
        }

        #region Framework

        protected override void InstantiateFormControl()
        {
            base.FormControl = new FormControl();
        }

        #endregion

    }

}