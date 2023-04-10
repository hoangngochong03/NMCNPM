def print_numbers(a):
    for i in range(a):
        print(i)

def main():
    a, b, c = map(int, input("Enter three integers: ").split())
    s = a + b + c
    print("The sum is:", s)
    print("Hello, World! kkk")
    print_numbers(10)
    
if __name__ == "__main__":
    main()
