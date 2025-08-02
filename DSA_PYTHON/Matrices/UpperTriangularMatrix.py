class UpperTriangularMatrix:
    # UpperTriangularMatrix: An upper triangular matrix is a square matrix where all the elements below the main diagonal are zero
    def read_matrix(self, matrix):
        n = len(matrix)
        print("Enter matrix elements:")
        print("Note: Enter only the upper triangle (i <= j)")
        for i in range(n):
            for j in range(i, n):
                matrix[i][j] = int(input(f"Element [{i},{j}]: "))

    def print_matrix(self, matrix):
        n = len(matrix)
        print("\nUpper Triangular Matrix Output:")
        for i in range(n):
            for j in range(n):
                if i <= j:
                    print(matrix[i][j], end=" ")
                else:
                    print(0, end=" ")
            print()

    def main(self):
        n = int(input("Enter the size of the square matrix (n x n): "))
        matrix = [[0 for _ in range(n)] for _ in range(n)]
        self.read_matrix(matrix)
        self.print_matrix(matrix)
