# Introduction to program
print("Hej, välkommen till gissa talet spelet!")

# Create random hidden number between 1 - 100 
import random
randomNumber = random.randrange(1, 101)

# Ask users name and introduce to game and rules
print("Vem är du?")
name = input()
print("Okej " + name + " nu tänker jag att vi ska spela ett spel, jag tänker på ett tal mellan 1 till 100, kan du gissa rätt?")

# Boolean, must be true or false, store info in tries
guessed = False
tries = 0 

while guessed == False:

    userInput = int(input("Välj ett tal eller siffra: ")) # Make string to input
    
    if userInput == randomNumber: # User guesses the same "hidden" number
        guessed = True
        tries += 1 # Adds tries count stored in tries
        tries = str(tries) 
        print("Gratulerar ! Du gissade rätt efter " + str(tries) + " försök ! ") # Converts tries to match string
    
    elif userInput > 100 or userInput < 1: # If user guesses outside of 1 to 100
        tries += 1
        print("Du kan enbart gissa talet/siffran mellan 1 till 100, försök igen")
    
    elif userInput > randomNumber: # > higher than the hidden random number
        tries += 1
        print("Du gissade för högt, prova igen")

    elif userInput < randomNumber: # lower than the hidden random number
        tries += 1
        print("Du gissade för lågt, prova igen")

    
# Wait for user
input()