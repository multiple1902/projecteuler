(* Project Euler Problem 47
 * By Weisi Dai <weisi@x-research.com>
 *)

open Weisi.Dai.Algorithms

let magic = 4

let lbound = 2

let factors n =
    let primes = PrimesUpTo n
    let power p n =
        let rec power p n current =
            if n % p <> 0 then current else
            power p (n / p) (current + 1)
        power p n 0
    let makePair prime =
        match power prime n with
        | 0   -> [|              |]
        | pow -> [| (prime, pow) |]
    primes
    |> Array.collect makePair

let distinctFactors n =
    factors n
    |> Array.length 

let rec find i depth =
    if depth = magic then (i - magic) else
    if distinctFactors i = magic then find (i + 1) (depth + 1) else
    find (i + 1) 0

let problem47 = find lbound 0
    
let main() = printfn "The answer is %d." (problem47)

main()
