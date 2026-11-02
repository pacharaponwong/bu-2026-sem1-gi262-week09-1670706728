using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            
            int count = stack.Count;
            int popped = stack.Pop();
            int peek = stack.Peek();
            int countAfterPeek = stack.Count;

            
            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            
            int count = queue.Count;
            int dequeued = queue.Dequeue();
            int peek = queue.Peek();
            int countAfterPeek = queue.Count;

            
            return (count, dequeued, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

           
            Stack<Action> stack = new Stack<Action>();
            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            
            List<string> result = new List<string>();
            while (stack.Count > 0)
            {
                result.Add(stack.Pop().Name);
            }

            return result.ToArray();
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            
            Queue<Action> queue = new Queue<Action>();
            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            
            List<string> result = new List<string>();
            while (queue.Count > 0)
            {
                result.Add(queue.Dequeue().Name);
            }

            return result.ToArray();
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            string reversed = "";

            
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            return reversed;
        }

        public bool ASN02_StackPalindrome(string str)
        {
            Stack<char> stack = new Stack<char>(); 
            foreach (char c in str)
            {
                stack.Push(c);
            }

            string reversed = "";
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            return str == reversed;
        }

        #endregion
        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            Stack<char> stack = new Stack<char>();

            // วนลูปแต่ละ character ใน str[cite: 2]
            foreach (char c in str)
            {
                // ถ้าเป็น opening bracket ให้ Push เข้า Stack[cite: 2]
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                // ถ้าเป็น closing bracket[cite: 2]
                else if (c == ')' || c == ']' || c == '}')
                {
                    // ถ้า Stack ว่าง ให้คืน false ทันที[cite: 2]
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    // Pop และตรวจคู่ ถ้าคู่ไม่ตรงกันให้คืน false[cite: 2]
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        #endregion
    }
}
