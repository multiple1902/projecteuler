(* Project Euler Problem 28
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1001

let rec diagonals interior current = 
    if interior = ubound then current else
    let n = pown interior 2
    let delta = interior + 1
    diagonals (interior + 2) ((n + delta * 4)::
                              (n + delta * 3)::
                              (n + delta * 2)::
                              (n + delta    )::
                              current)

let problem28 = diagonals 1 [1] |> List.sum
    
let main = printfn "The answer is %d." (problem28)

main
