namespace Algorithm.String.RotateMatrix;

public static class RotateMatrix
{
    public static int[][] RunWithExtraSpace(int[][] matrix)
    {
        int N = matrix.Length;
        int[][] rotatedMatrix = new int[N][];

        for (int i = 0; i < N; i++)
        {
            rotatedMatrix[i] = new int[N];
        }

        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < N; y++)
            {
                rotatedMatrix[y][N - 1 - x] = matrix[x][y];
            }
        }

        return rotatedMatrix;
    }

    public static int[][] RunWithInPlace(int[][] matrix)
    {
        int n = matrix.Length;

        for (int layer = 0; layer < n / 2; layer++)
        {
            int first = layer;
            int last = n - 1 - layer;

            for (int i = first; i < last; i++)
            {
                int offset = i - first;

                // Üst kısım kaydediliyor
                int top = matrix[first][i];

                // Sol -> Üst
                matrix[first][i] = matrix[last - offset][first];

                // Alt -> Sol
                matrix[last - offset][first] = matrix[last][last - offset];

                // Sağ -> Alt
                matrix[last][last - offset] = matrix[i][last];

                // Üst (kaydedilen) -> Sağ
                matrix[i][last] = top;
            }
        }

        return matrix;
    }
}