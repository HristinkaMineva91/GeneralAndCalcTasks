using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralUnitTests.models
{
    public interface IOperationSuccessCalculator
    {
        bool IsAttackSuccesful(int x, int y);
        bool IsDefenceSuccesful(int x, int y);
    }
}
