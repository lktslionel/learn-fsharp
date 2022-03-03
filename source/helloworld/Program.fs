open System

[<EntryPoint>]
let main argv = 
    let mutable value = argv.[0]
    value <- "mutate"
    printfn "argv: %s" value
    0
