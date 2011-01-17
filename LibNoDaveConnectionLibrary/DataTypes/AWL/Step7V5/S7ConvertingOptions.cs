﻿using DotNetSiemensPLCToolBoxLibrary.DataTypes.Projectfolders;

namespace DotNetSiemensPLCToolBoxLibrary.DataTypes.AWL.Step7V5
{
    public class S7ConvertingOptions
    {
        public S7ConvertingOptions()
        {
            this.Memnoic = 0;
            this.CombineDBOpenAndDBAccess = true;
            this.ReplaceDBAccessesWithSymbolNames = true;
            this.ReplaceDIAccessesWithSymbolNames = true;
            this.ReplaceLokalDataAddressesWithSymbolNames = true;
            this.GenerateCallsfromUCs = true;
            this.UseInFCStoredFCsForCalls = true; //todo implement the reading of them in the step7 project
            this.UseComments = true;
        }

        public bool UseComments { get; set; }
        public int Memnoic { get; set; }
        public bool CombineDBOpenAndDBAccess { get; set; }
        public bool ReplaceDBAccessesWithSymbolNames { get; set; }

        public bool ReplaceLokalDataAddressesWithSymbolNames { get; set; }
        public bool ReplaceDIAccessesWithSymbolNames { get; set; } 
       

        public bool GenerateCallsfromUCs { get; set;}
        public bool UseInFCStoredFCsForCalls { get; set; }

        
    }
}