﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Localization;



namespace Demo
{
    public class showMessageBox : Localizer
    {
        public string Abort { set; get; }  
        public string Cancel { set; get; }  
	    public string Ignore { set; get; }  
	    public string No { set; get; }  
        public string Ok { set; get; }  
        public string Retry { set; get; }  
	    public string Yes { set; get; }

        public showMessageBox (string abort, string cancel, string ignore, string no, string ok, string retry, string yes)
        {
            this.Abort = abort;
            this.Cancel = cancel;
            this.Ignore = ignore;
            this.No = no;
            this.Ok = ok;
            this.Retry = retry;
            this.Yes = yes;
        }

        public override string GetLocalizedString(StringId id)
        {
            if (id == StringId.XtraMessageBoxAbortButtonText)
            {
                return this.Abort;
            }
            if (id == StringId.XtraMessageBoxCancelButtonText)
            {
                return this.Cancel;
            }
            if (id == StringId.XtraMessageBoxIgnoreButtonText)
            {
                return this.Ignore;
            }
            if (id == StringId.XtraMessageBoxNoButtonText)
            {
                return this.No;
            }
            if (id == StringId.XtraMessageBoxOkButtonText)
            {
                return this.Ok;
            }
            if (id == StringId.XtraMessageBoxRetryButtonText)
            {
                return this.Retry;
            }
            if (id == StringId.XtraMessageBoxYesButtonText)
            {
                return this.Yes;
            }
            return base.GetLocalizedString(id);
        }
    }
}
