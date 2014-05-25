(* Project Euler Problem 25
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000

let rec firstTerm current a b = 
    if b.ToString().Length >= ubound then current else
    firstTerm (current + 1) b (a + b)

let problem25 = firstTerm 1 (bigint 0) (bigint 1)
    
let main = printfn "The answer is %d." (problem25)

main
