//open system

let msg = "Hello World! How are you today?"

if 1 = 1 then
    printfn "%s" msg
else
    printfn "The heck??"

let greetFunction message = 
    printfn $"Message is: {message}"

greetFunction "twenty three skidoo"