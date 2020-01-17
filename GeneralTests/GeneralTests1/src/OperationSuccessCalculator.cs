using GeneralUnitTests.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralUnitTests.classes
{
    public class OperationSuccessCalculator : IOperationSuccessCalculator
    {
        public bool IsAttackSuccesful(int x, int y)
        {
            if (ValidCoordinates(x, y) && (x + y - 5) % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsDefenceSuccesful(int x, int y)
        {
            if (ValidCoordinates(x, y) && (x * y - 5) % 2 == 0)
            {
                return true;
            }
            return false;
        }

        private bool ValidCoordinates(int x, int y)
        {
            if ((x > 0 && x <= 200) && (y > 0 && y <= 300))
            { 
                return true;
            }
            return false;
        }
    }
}
