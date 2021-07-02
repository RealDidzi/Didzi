# Introduction to program
print("Välkommen till denna enkla pensionssimulator")

# Ask user for name
print("Vad heter du i förnamn?")
name = input()

# Ask users age
print("hur gammal är du?")
age = input()

# Calculate
year = 65 - int(age)

# Print out information
print("Hej " + name + " " + age + " år. " "Du går i pension om " + str(year) + " år ")

# Wait for user
input()
