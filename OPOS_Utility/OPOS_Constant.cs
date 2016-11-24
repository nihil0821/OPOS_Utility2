using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPOS_Utility
{
    class OPOS_Constant
    {
        //OPOS Constant
        public const int PTR_S_RECEIPT = 2;
        public const int PTR_CP_FULLCUT = 100;
        public const Int32 DISP_DT_NORMAL = 0;

        //** "Width" Parameter
        //     Either bitmap width or:

        public const int PTR_BM_ASIS = -11;  // One pixel per printer dot

        //** "Alignment" Parameter
        //     Either the distance from the left-most print column to the start
        //     of the bitmap, or one of the following:

        public const int PTR_BM_LEFT = -1;
        public const int PTR_BM_CENTER = -2;
        public const int PTR_BM_RIGHT = -3;

        //** "Printer letter attribute"
        public const string ESC = "\x1B";
        public const string FEEDCUT = "\x1B" + "|100fP"; //ESC + Feed Cut 100
        public const string PRTBITMAP = "\x1B" + "|1B";
    }
}
