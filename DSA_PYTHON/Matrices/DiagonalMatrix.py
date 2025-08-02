
class DiagonalMatrix:
    # Diagonal Matrix: A matrix where only the diagonal elements are non-zero, and all other elements are zero.
    def read_matrix(self,matrix):
        n = len(matrix)
        print("Enter matrix elements:")
        print("Note: You need to enter only diagonal elements.....")
        for i in range(n):
            for j in range(n):
                if i == j:
                    matrix[i][j] = int(input(f"Element [{i},{j}]: "))

    def print_matrix(self,matrix):
        n = len(matrix)
        print("\nDiagonal Matrix Output (main diagonal only):")
        for i in range(n):
            for j in range(n):
                if i == j:
                    print(matrix[i][j], end=" ")
                else:
                    print(0, end=" ")
            print()

    def main(self):
        n = int(input("Enter the size of the square matrix (n x n): "))
        matrix = [[0 for _ in range(n)] for _ in range(n)]
        self.read_matrix(matrix)
        self.print_matrix(matrix)

