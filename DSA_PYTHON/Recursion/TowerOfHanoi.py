class TowerOfHanoi:
    def TOH(self,n,A,B,C):
        if n > 0:
            self.TOH(n-1,A,C,B);
            print(f"({A},{C})")
            self.TOH(n - 1, B, A, C);

    def main(self):
        self.TOH(3,1,2,3);
        return "";