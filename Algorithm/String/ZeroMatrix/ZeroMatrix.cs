namespace Algorithm.String.ZeroMatrix;

public static class ZeroMatrix
{
    
    public static int[][] RunWithInPlace(int[][] matrix)
    {
        if(matrix.Length == 0|| matrix[0].Length == 0)
            return matrix;
        
        bool firstRowHasZero = false;
        bool firstColumnHasZero = false;

        // İlk satırda ve sütunda sıfır olup olmadığını kontrol et
        for (int j = 0; j < matrix[0].Length; j++)
        {
            if (matrix[0][j] == 0)
            {
                firstRowHasZero = true;
                break;
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i][0] == 0)
            {
                firstColumnHasZero = true;
                break;
            }
        }

        // Diğer satır ve sütunları kontrol et
        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        // Sıfırlanacak satır ve sütunları sıfırla
        for (int i = 1; i < matrix.Length; i++)
        {
            if (matrix[i][0] == 0)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        for (int j = 1; j < matrix[0].Length; j++)
        {
            if (matrix[0][j] == 0)
            {
                for (int i = 1; i < matrix.Length; i++)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        // İlk satırı ve sütunu gerekiyorsa sıfırla
        if (firstRowHasZero)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                matrix[0][j] = 0;
            }
        }

        if (firstColumnHasZero)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }

        return matrix;
    }

    public static int[][] Run(int[][] matrix)
        {
            if(matrix.Length == 0|| matrix[0].Length == 0)
                return matrix;
            
            int rowLength = matrix.Length;
            int colLength = matrix[0].Length;

            List<int> zeroRows = new List<int>();
            List<int> zeroCols = new List<int>();

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        zeroRows.Add(i);
                        zeroCols.Add(j);
                    }
                }
            }

            foreach (int rowIndex in zeroRows)
            {
                for (int j = 0; j < colLength; j++)
                {
                    matrix[rowIndex][j] = 0;
                }
            }

            foreach (int colIndex in zeroCols)
            {
                for (int i = 0; i < rowLength; i++)
                {
                    matrix[i][colIndex] = 0;
                }
            }

            return matrix;
        }
        
    public static int[][] FirstRun(int[][] matrix)
    {

        if(matrix.Length == 0|| matrix[0].Length == 0)
            return matrix;

        int rowLength = matrix.Length;
        int colLength = matrix[0].Length;
        List<int> indexes = new List<int>();

        for(int i = 0;i<rowLength;i++){
            for(int j = 0; j<colLength;j++){
                if(matrix[i][j] == 0){
                    indexes.Add(i);
                    indexes.Add(j);
                }
            }
        }

        int count = 0;
        foreach(int index in indexes){
            count++;
                if(count%2 != 0)
            {
            for(int i = 0;i<colLength;i++){
                    matrix[index][i] = 0;
                }
            }
            else{
            for(int i = 0;i<rowLength;i++){
                matrix[i][index] = 0;
            }
  

            }
        }

        return matrix;
    }
}