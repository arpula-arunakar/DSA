class SymmetricMatrix:
    # SymmetricMatrix: A symmetric matrix is a square matrix that is equal to its transpose.
    # approach of code is changed compared to lower,diagonal,upper triangular matrix...
    def read_matrix(self, n):
        matrix = []
        print("Enter the matrix elements row by row:")
        for i in range(n):
            row = []
            for j in range(n):
                val = int(input(f"Element [{i},{j}]: "))
                row.append(val)
            matrix.append(row)
        return matrix

    def print_matrix(self, matrix):
        print("\nMatrix:")
        for row in matrix:
            for val in row:
                print(val, end="\t")
            print()

    def is_symmetric(self, matrix):
        n = len(matrix)
        for i in range(n):
            for j in range(n):
                if matrix[i][j] != matrix[j][i]:
                    return False
        return True

    def main(self):
        n = int(input("Enter the size of the square matrix (n x n): "))
        matrix = self.read_matrix(n)
        self.print_matrix(matrix)

        if self.is_symmetric(matrix):
            print("\n The matrix is symmetric.")
        else:
            print("\n The matrix is NOT symmetric.")
