(* Project Euler Problem 6
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 100

let probSeq = [ 1 .. ubound ]

let sqList = seq { 
    for i in probSeq do
        yield (i * i)
}

let sqSum = Seq.sum sqList

let linSum = Seq.sum probSeq

let linSumSq = linSum * linSum

let problem6 = linSumSq - sqSum
    
let main = printfn "The answer to life the universe and everything is %d." (problem6)

main
