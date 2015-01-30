using System;
using System.Collections.Generic;

namespace Enigmanation2
{
    class Enigmanation2
    {
        static int getPrecedence(char op)
        {
            switch (op)
            {
                case '*':
                    return 5;
                case '%':
                    return 5;
                case '-':
                    return 4;
                case '+':
                    return 4;
            }
            return 0;
        }
        static bool isOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '%')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            string inputStr = Console.ReadLine();

            Queue<char> outputQueue = new Queue<char>();
            Stack<char> operatorsStack = new Stack<char>();

            int i = 0;
            while (inputStr[i] != '=')
            {
                if (Char.IsDigit(inputStr[i]))
                {
                    outputQueue.Enqueue(inputStr[i]);
                }
                else
                {
                    if (inputStr[i] == '(')
                    {
                        operatorsStack.Push(inputStr[i]);
                    }
                    else if (inputStr[i] == ')')
                    {
                        do
                        {
                            outputQueue.Enqueue(operatorsStack.Pop());
                        } while (operatorsStack.Peek() != '(');
                        operatorsStack.Pop();
                    }
                    else
                    {
                        while (operatorsStack.Count != 0 && getPrecedence(inputStr[i]) <= getPrecedence(operatorsStack.Peek()))
                        {
                            outputQueue.Enqueue(operatorsStack.Pop());
                        }
                        operatorsStack.Push(inputStr[i]);
                    }
                }
                i++;
            }
            while (operatorsStack.Count > 0)
            {
                outputQueue.Enqueue(operatorsStack.Pop());
            }
            char[] sOutputQueue = new char[outputQueue.Count];
            outputQueue.CopyTo(sOutputQueue, 0);
            double result = CalculateRPN(sOutputQueue);
            Console.WriteLine("{0:F3}", result);
        }
        static double CalculateRPN(char[] rpn)
        {
            Stack<double> stack = new Stack<double>();
            double number = 0D;

            foreach (char token in rpn)
            {
                if (double.TryParse(token.ToString(), out number))
                {
                    stack.Push(number);
                }
                else
                {
                    switch (token)
                    {

                        case '*':
                            {
                                stack.Push(stack.Pop() * stack.Pop());
                                break;
                            }
                        case '%':
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() % number);
                                break;
                            }
                        case '+':
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                                break;
                            }
                        case '-':
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() - number);
                                break;
                            }
                    }
                }
            }

            return stack.Pop();
        }
    }
}