using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    public class BoolPlayground
    {
        private bool Right = true;
        private bool Left = false;

        public BoolPlayground(bool r, bool l) 
        {
            this.Right = r;
            this.Left = l;
        }

        public bool GetRight()
        {
            return this.Right;
        }

        public bool GetLeft()
        {
            return this.Left;
        }

        public void SetRigthToTrue()
        {
            this.Right = true;
        }

        public void SetRigthToFalse()
        {
            this.Right = false;
        }

        public void SetLeftToTrue()
        {
            this.Left = true;
        }

        public void SetLeftToFalse()
        {
            this.Left = false;
        }
    }
}
