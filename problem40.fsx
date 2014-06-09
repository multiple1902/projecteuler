(* Project Euler Problem 40
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 7

let BASE = 10

let minNDigit n = pown BASE (n - 1)

let champDigit n = 
    let rec findDigit digits remaining = 
        let segLength = digits * (minNDigit (digits + 1)
                                - minNDigit  digits    )
        if remaining > segLength then
            findDigit (digits + 1) (remaining - segLength)
        else
            let delta = remaining / digits
            let pos   = remaining % digits
            (string <| (minNDigit digits) + delta)
                .ToCharArray().[pos] |> string |> int 

    findDigit 1 (n - 1)

let digits = seq {
    for i in 1 .. ubound do
        let pos = minNDigit i
        yield champDigit pos
}

let problem40 = Seq.fold ( * ) 1 digits
    
let main() = printfn "The answer is %d." (problem40)

main()
