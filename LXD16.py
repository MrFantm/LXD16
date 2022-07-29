import random

num = int 
def generate():
    ran = random.Random()
    l = ran.Next(0,5000)
    d = 0

    for i in range(0,l):
        d += i * i^16
    
    #Final Product
    x = d^16
    if(x < 1):
        #If the number is negative, regenerate the number
        generate()
    num = x
