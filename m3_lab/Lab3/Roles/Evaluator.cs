using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Roles
{
    internal interface Evaluator
    {
        public void PublicEvaluate(Evaluatee evaluatee, int score);
    }
}
