(* Project Euler Problem 14
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000000

let collatz = function
    | x when x % 2L = 0L  -> x / 2L
    | x                   -> 3L * x + 1L

(*
 * I wanted to use hash maps to store all past results to 
 * accelerate future computation. Not really needed.
 *
 * See ``problem14-map.fsx''.
 *)

let distance x = 
    let rec dist current = function
            | 1L -> current + 1
            | x  -> dist (current + 1) (collatz x)

    dist 0 x

let seqDistancePair = seq { for i in 1 .. ubound do yield (i, distance (int64 i)) }

let findMax (curMaxKey, curMaxValue) (key, value) = 
    if value > curMaxValue then
        (key, value)
    else
        (curMaxKey, curMaxValue)

let (problem14, _) = Seq.fold findMax (1, 1) seqDistancePair
    
let main = printfn "The answer is %d." (problem14)

main
