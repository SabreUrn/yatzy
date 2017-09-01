using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy.Evaluators {
    class TwoPairEvaluator : IDiceEvaluator {
        public int Evaluate(Dictionary<int, int> diceCountByValue) {
            int score = 0;
            List<int> keys = new List<int>();

            foreach(var dieCount in diceCountByValue) {
                //first condition: more than 4 dice
                //second condition: use highest pairs
                //third condition: pairs must be different
                if((dieCount.Value >= 4) && ()) {
                    
                }
            }

            return score;
        }

    }//end class
}//end namespace
