// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"


module Say =
    let hello name =
        printfn "Hello %s" name


Say.hello("Luke")