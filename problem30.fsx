(* Project Euler Problem 30
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 5

let range = seq { 2 .. pown 10 6 }

let sumOfNPower x = 
    x.ToString()
    |> Seq.map (fun ch -> pown (int(ch) - int('0')) ubound)
    |> Seq.sum

let goodNumbers = seq {
    for i in range do
        if sumOfNPower i = i then
            yield i
}

let problem30 = Seq.sum goodNumbers
    
let main = printfn "The answer is %d." (problem30)

main
