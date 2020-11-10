using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognex.VisionPro;

namespace VTFD
{
    class VisionResult
    {
        public ICogImage InputImage;

        public ICogImage OutputImage;

        public ICogRecord cogRecord;

        public bool RunStatus = false;

        public bool ExamineStatus = false;

        public string RunStatusText = "NG";

        public double width1;

        public double width2;

        public double CoordX;

        public DateTime StartTime;

        public string ImagePath;
    }
}
