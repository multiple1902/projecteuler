(* Project Euler Problem 10
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 2000000L

let canvas = [ 2L .. ubound ]

let notMultiple x y =
    if x = y then // x is prime and should be kept
        true
    elif y % x <> (int64 0) then
        true
    else
        false

let rec sieve canvas n = 
    let nth = List.nth canvas n
    if nth > int64 (sqrt (float ubound)) then
        canvas
    else
        sieve (List.filter (notMultiple nth) canvas) (n + 1)

let problem10 = Seq.sum (sieve canvas 0)
    
let main = printfn "The answer is %d." (problem10)

main
