using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPOS_Utility
{
    class OPOS_ErrorConstant
    {
        //Value of constant is access like static field
        public const int OPOSERR = 100;
        public const int OPOSERREXT = 200;
        public const int OPOS_SUCCESS = 0;
        public const int OPOS_E_CLOSED = 101;
        public const int OPOS_E_CLAIMED = 102;
        public const int OPOS_E_NOTCLAIMED = 103;
        public const int OPOS_E_NOSERVICE = 104;
        public const int OPOS_E_DISABLED = 105;
        public const int OPOS_E_ILLEGAL = 106;
        public const int OPOS_E_NOHARDWARE = 107;
        public const int OPOS_E_OFFLINE = 108;
        public const int OPOS_E_NOEXIST = 109;
        public const int OPOS_E_EXISTS = 110;
        public const int OPOS_E_FAILURE = 111;
        public const int OPOS_E_TIMEOUT = 112;
        public const int OPOS_E_BUSY = 113;
        public const int OPOS_E_EXTENDED = 114;

        public OPOS_ErrorConstant()
        {

        }

        public static string return_ErrorMessage(int returnCode)
        {
            string errMsg = "";
            switch (returnCode)
            {
                case OPOSERR: errMsg = "OPOSERR (" + OPOSERR + ")"; break;
                case OPOS_SUCCESS: errMsg = "OPOS_SUCCESS (" + OPOS_SUCCESS + ")"; break;
                case OPOS_E_CLOSED: errMsg = "OPOS_E_CLOSED (" + OPOS_E_CLOSED + ")"; break;
                case OPOS_E_CLAIMED: errMsg = "OPOS_E_CLAIMED (" + OPOS_E_CLAIMED + ")"; break;
                case OPOS_E_NOTCLAIMED: errMsg = "OPOS_E_NOTCLAIMED (" + OPOS_E_NOTCLAIMED + ")"; break;
                case OPOS_E_NOSERVICE: errMsg = "OPOS_E_NOSERVICE (" + OPOS_E_NOSERVICE + ")"; break;
                case OPOS_E_DISABLED: errMsg = "OPOS_E_DISABLED (" + OPOS_E_DISABLED + ")"; break;
                case OPOS_E_NOHARDWARE: errMsg = "OPOS_E_NOHARDWARE (" + OPOS_E_NOHARDWARE + ")"; break;
                case OPOS_E_OFFLINE: errMsg = "OPOS_E_OFFLINE (" + OPOS_E_OFFLINE + ")"; break;
                case OPOS_E_ILLEGAL: errMsg = "OPOS_E_ILLEGAL (" + OPOS_E_ILLEGAL + ")"; break;
                case OPOS_E_NOEXIST: errMsg = "OPOS_E_NOEXIST (" + OPOS_E_NOEXIST + ")"; break;
                case OPOS_E_EXISTS: errMsg = "OPOS_E_EXISTS (" + OPOS_E_EXISTS + ")"; break;
                case OPOS_E_FAILURE: errMsg = "OPOS_E_FAILURE (" + OPOS_E_FAILURE + ")"; break;
                case OPOS_E_TIMEOUT: errMsg = "OPOS_E_TIMEOUT (" + OPOS_E_TIMEOUT + ")"; break;
                case OPOS_E_BUSY: errMsg = "OPOS_E_BUSY (" + OPOS_E_BUSY + ")"; break;
                case OPOS_E_EXTENDED: errMsg = "OPOS_E_EXTENDED (" + OPOS_E_EXTENDED + ")"; break;
                default: errMsg = "ERROR"; break;
            }
            return errMsg;
        }
        

        
    }

    
    
}
