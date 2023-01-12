//open system

// Alex Schmaus 1/12/2023
// Playing around with F#

let msg = "Hello World! How are you today?"

if 1 = 1 then
    printfn "%s" msg
else
    printfn "The heck??"



let greetFunction message = 
    printfn $"Message is: {message}"

greetFunction "twenty three skidoo"




let names = ["Bob"; "Sally"; "Susan"; "Bill"]

for n in names do
    printfn "Hello %s" n