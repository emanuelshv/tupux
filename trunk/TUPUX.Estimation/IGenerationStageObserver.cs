using System;
using System.Collections.Generic;
using System.Text;

namespace TUPUX.Estimation
{
    public interface IGenerationStageObserver
    {
        void setStage(int stageNum);
    }
}
