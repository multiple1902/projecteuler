(* Project Euler Problem 5
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 20

let rec multiple current delta n = 
    if n > ubound then
        current
    else
        if (current % n <> 0) then
            multiple (current + delta) delta n
        else
            multiple current current (n + 1)

let problem5 = multiple 1 1 2
    
let main = printfn "The answer is %d." (problem5)

main
