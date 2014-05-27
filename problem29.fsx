(* Project Euler Problem 29
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 100

let range = seq { 2 .. ubound }

let powers = seq {
    for a in range do
        for b in range do
            yield pown (bigint a) b
}

let problem29 = Seq.distinct powers |> Seq.length
    
let main = printfn "The answer is %d." (problem29)

main
