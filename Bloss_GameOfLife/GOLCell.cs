using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bloss_GameOfLife
{
    class GOLCell
    {
        public int age;
        public int alive;
        public Rectangle cell;
        public int futureState;

        public GOLCell(Rectangle pCell, int pAge, int pAlive)
        {
            cell = pCell;
            age = pAge;
            alive = pAlive;
        }

        public int Age { get => age; set => age = value; }
        public int Alive { get => alive; set => alive = value; }
        public Rectangle Cell { get => cell; set => cell = value; }
        public int FutureState { get => futureState; set => futureState = value; }


    }
}
