(* Project Euler Problem 1
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000

let rec sum acc = function
                  | 0 -> acc
                  | x -> if (x % 3 = 0) || (x % 5 = 0) then
                            sum (acc + x) (x - 1)
                         else
                            sum (acc) (x - 1)

let problem1 ubound = sum 0 (ubound - 1)
    
let main = printfn "The sum is %d." (problem1 ubound)

main
