public class Solution {
    public bool IsValidSudoku(char[][] board) {
		var rowSeen = new Dictionary<int, HashSet<char>>();
		var colSeen = new Dictionary<int, HashSet<char>>();
		var squareSeen = new Dictionary<int, HashSet<char>>();

		for (int row = 0; row < board.Length; row++){
			if(!rowSeen.ContainsKey(row)){
				rowSeen.Add(row, new HashSet<char>());
			}
			
			for (int col = 0; col < board[row].Length; col++){
				var element = board[row][col];
				var squareIndex = 3 * (row/3) + col/3;
				
				if(!colSeen.ContainsKey(col)){
					colSeen.Add(col, new HashSet<char>());
				}
				
				if(!squareSeen.ContainsKey(squareIndex)){
					squareSeen.Add(squareIndex, new HashSet<char>());
				}

                if(element == '.') {
					continue;
				}
				   
				if (
					rowSeen[row].Contains(element) || 
					colSeen[col].Contains(element) || 
					squareSeen[squareIndex].Contains(element)) 
				{
					return false;
				}
				
				rowSeen[row].Add(element);
				colSeen[col].Add(element);
				squareSeen[squareIndex].Add(element);
			}
		}
		
        return true;
    }
}