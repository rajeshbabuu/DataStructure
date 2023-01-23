using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure1
{
    internal class BalanceParenthesis
    {
        public static bool checkBalanced(String check)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < check.Length; i++)
            {
                char character = check[i];
                if (character == '[' || character == '{' || character == '(')
                    stack.Push(character);
                else if (character == ']' || character == '}' || character == ')')
                {
                    if (stack.Any())
                        return false;
                    switch (character)
                    {
                        case ']':
                            if (stack.Pop() != '[')
                                return false;
                            break;
                        case '}':
                            if (stack.Pop() != '{')
                                return false;
                            break;
                        case ')':
                            if (stack.Pop() != '(')
                                return false;
                            break;
                        default:
                            break;
                    }
                }
            }
            if (stack.Any())
                return true;
            return false;
        }
    }
}
