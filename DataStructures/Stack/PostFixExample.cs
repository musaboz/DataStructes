using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class PostFixExample
    {
        private string expression;
        private LinkedListStack<string> S = new LinkedListStack<string>();

        private string Expression()
        {
            int val1, val2, ans;
            for (int i = 0; i < expression.Length; i++)
            {
                String c = expression.Substring(i, 1);
                switch (c)
                {
                    case "*":
                        val1 = int.Parse(S.Pop());
                        val2 = int.Parse(S.Pop());
                        ans = val2 * val1;
                        S.Push(ans.ToString());
                        break;
                    case "/":
                        val1 = int.Parse(S.Pop());
                        val2 = int.Parse(S.Pop());
                        ans = val2 / val1;
                        S.Push(ans.ToString());
                        break;
                    case "+":
                        val1 = int.Parse(S.Pop());
                        val2 = int.Parse(S.Pop());
                        ans = val2 + val1;
                        S.Push(ans.ToString());
                        break;
                    case "-":
                        val1 = int.Parse(S.Pop());
                        val2 = int.Parse(S.Pop());
                        ans = val2 - val1;
                        S.Push(ans.ToString());
                        break;
                    default:
                        S.Push(c);
                        break;
                }
            }
            return S.Pop();
        }

        public static string Run(string expression)
        {
            PostFixExample e = new PostFixExample();
            e.expression = expression;
            return e.Expression();
        }
    }
}
