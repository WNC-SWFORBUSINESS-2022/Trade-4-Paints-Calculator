Input_List = [] #Holds the visual stuff
Input_Type = [] #Holds the more complex information: numbers = 0, method = 1, Unit = 2

Input_Units = [] #Holds more specific information for Units (0 - 3)
Input_Methods = [] #Holds more specific information for Methods(0 - 3)


Section = "0" #Numbers and Methods fight for this variable

#ram
Current_Section_Type = 0 # Numbers = 0, Methods = 1
Current_Section_Unit = 0 # (0 - 3)

#Library
Unit_Values = ["mm","cm","m","km"]
Exchange_Rate = ["*1000""*100""/1""/1000"]
L_Methods = ["+","-","*","/"]

#------#
Repeat = 0
#inputs: Numbers = 0-9, (+ - x /) = 10-13, Units = 14-17, End = 18 

def Number(x):
  if(Current_Section_Type == 1): #Doesn't like Numbers
    Input_List.append(L_Methods[Section]) #Adds Method to the visual list
    Input_Type.append(1) #Adds Method to type list be fore replacing it with Number type
    Input_Methods = Section
  else:
    Section = Section + str(x) #inputs number

def Method(x):
  if(Current_Section_Type == 0): #Doesn't like Methods
    Input_List.append(Section) #add numbers to the visual list
    Input_Type.append(0) #add numbers to type list be fore replacing it with method type

    Input_List.append(Unit_Values[Current_Section_Unit]) #Adds the visual unit onto the visual list
    Input_Type.append(2) #Adds the type to the list
    Input_Units.append(Current_Section_Unit) #adds the specific unit to the list
    
    Current_Section_Type = 1 #Finally does the Method
    Section = (x - 10)
  else:
    Section = (x - 10)
    
def Unit(x):
  Current_Section_Unit = (x - 14)

while (Repeat == 0):
  User_Input = input()
  User_Input = int(User_Input)
  if (0 <= User_Input < 10):
    Number(User_Input)
  elif (10 <= User_Input < 14):
    Method(User_Input)
  elif (14 <= User_Input < 17):
    Unit(User_Input)
  elif (User_Input == 18):
    Repeat = 1
  else:
    print("Enter Correct Info")
  print(Input_List)
  
