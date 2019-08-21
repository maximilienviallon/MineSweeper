using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class MineFieldElement
    {
        private int id;
        private int noOfNeighborMines;
        private bool hasAMine = false;

        public MineFieldElement(int pId)
        {
            this.id = pId;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public bool HasAMine
        {
            get
            {
                return hasAMine;
            }

            set
            {
                hasAMine = value;
            }
        }

        public int NoOfNeighborMines
        {
            get
            {
                return noOfNeighborMines;
            }

            set
            {
                noOfNeighborMines = value;
            }
        }
    }
}