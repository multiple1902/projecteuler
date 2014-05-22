(* Project Euler Problem 3
 * By Weisi Dai <weisi@x-research.com>
 *)

let number = 600851475143L

let rec lastFactor (n: int64) (factor: int64) = 
    if (n % (factor) = 0L) then
        if n = factor then
            n
        else
            lastFactor (n / factor) factor
    else
        lastFactor n (factor + 1L)

let problem3 = lastFactor number 2L
    
let main = printfn "The largest prime factor is %d." (problem3)

main
