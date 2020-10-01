using System;

namespace GameLogic
{
     class GameLogic
    {
        private GridDict
        public Winner
        public Player
        public Turn
        // Number of turns. 
        public GridSide
        // Length of one side of grid, as specified by the user. 
        
        
        public List InitGrid(int gridSide)
        {
            // Initialize the grid array in 2D:
            int[,] gridDict = new int[gridSide, gridSide]
            foreach (int i in gridDict)
            {
                gridDict[i] = i+1;
                // Iterate as flattened array:
                // [[1,2,3],
                //  [6,7,8],
                //  [9,10,11]]
            }
            return gridDict
        }
        
        public bool CheckWinner()
        {
        // Check win conditions: 
        
        
        }
        
        public 
        
        
        