class SparseMatrix:
    # A Sparse Matrix is a matrix that contains mostly zero values.
    # If the number of zero elements is significantly more than the number of non-zero elements, the matrix is considered sparse.
    def read_matrix(self, rows, cols):
        print(f"Enter {rows}x{cols} matrix elements:")
        matrix = []
        for i in range(rows):
            row = []
            for j in range(cols):
                val = int(input(f"Element [{i}][{j}]: "))
                row.append(val)
            matrix.append(row)
        return matrix

    def convert_to_sparse(self, matrix):
        sparse = []
        for i in range(len(matrix)):
            for j in range(len(matrix[0])):
                if matrix[i][j] != 0:
                    sparse.append((i, j, matrix[i][j]))
        return sparse

    def print_sparse(self, sparse):
        print("\nSparse Matrix Representation (COO Format):")
        print("Row\tCol\tValue")
        for i, j, val in sparse:
            print(f"{i}\t{j}\t{val}")

    def main(self):
        rows = int(input("Enter number of rows: "))
        cols = int(input("Enter number of columns: "))
        matrix = self.read_matrix(rows, cols)
        sparse = self.convert_to_sparse(matrix)
        self.print_sparse(sparse)
