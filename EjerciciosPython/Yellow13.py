a="s"
while a=="s":
    r=int(input("1"))
    if r >=0 and r <= 100:
        print("2")
    else:
        print("3")
    a=input("4 (S/N): ").lower()
    if a!= "s":
        print("5")