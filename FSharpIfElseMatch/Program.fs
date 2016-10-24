open System

let isPair chiffre : string =
    if (chiffre % 2) = 0 then
        "pair"
    else
        "impair"

let isPairMatch chiffre : string =
    match (chiffre % 2) with
    | 0 -> "pair"
    | _ -> "impair"

let jeux chiffre : string = 
    match chiffre with 
    | x when x % 5 = 0 && x % 3 = 0 -> "FizzBuzz"
    | x when x % 3 = 0 -> "Fizz"
    | x when x % 5 = 0 -> "Buzz"
    | _ -> (sprintf "%d" chiffre)


[<EntryPoint>]
let main argv = 
    let chiffre = 5
    let chiffre2 = 4
    
    (* Test avec les if else *)
    printfn "********* avec if/else *********"
    printfn "%d est %s" chiffre (isPair chiffre)
    printfn "%d est %s" chiffre2 (isPair chiffre2)
    
    (* Test avec match *)
    printfn "********* avec match *********"
    printfn "%d est %s" chiffre (isPairMatch chiffre)
    printfn "%d est %s" chiffre2 (isPairMatch chiffre2)
    
    (* Jeux *)
    (* Règles :
        Si multiple de 3 --> Fizz
        Si multiple de 3 --> Buzz
        Si multiple de 3 et de 5 --> FizzBuzz
        Sinon on dit le chiffre
    *)
    printfn "********* le jeux *********"
    printfn "%d --> %s" 2 (jeux 2)
    printfn "%d --> %s" 3 (jeux 3)
    printfn "%d --> %s" 5 (jeux 5)
    printfn "%d --> %s" 15 (jeux 15)

    let stop = Console.ReadLine()

    1
