import random

num = int

def generate(allowNegatives): #The generate() method takes in a boolean to determine whether it can generate negative numbers
    l = random.randint(0,5000)
    d = 0

    i = 0
    for j in range(0,l):
        d += i * i^16
        i += 1

    #Final Product
    x = d^16

    if(x < 1 & allowNegatives == False):
        #If the number is negative, regenerate the number
        generate(False)
    
    num = x
    print(num)

    wait() #Comment this out if you don't plan on interacting with a console



def wait(): #Comment this out if you don't plan on interacting with a console
    input()
    generate(True)

#Runs the generation on start; Comment this out or delete it if you're calling the method from another script.
generate(True)