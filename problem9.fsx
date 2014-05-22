(* Project Euler Problem 9
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000

let abcList = seq {
    for a in 1 .. ubound / 2 do
        for b in (a + 1) .. (ubound - a) do
            yield [a; b; ubound - a - b]
}

let checkSum abc = 
    match abc with
    | [a; b; c] -> 
        a * a + b * b - c * c = 0
    |_ -> false

let goodList = Seq.filter checkSum abcList

let prodSeq seq1 = Seq.fold (fun product elem -> product * elem) 1 seq1

let problem9 = goodList |> Seq.head |> prodSeq
                           //  ^^ description said there's one
    
let main = printfn "The answer is %d." (problem9)

main
