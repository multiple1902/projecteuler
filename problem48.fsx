(* Project Euler Problem 48
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000L

let cutLen = 10

let cut x =
    x % (pown 10L cutLen)

let rec add i current =
    if i > ubound then current else
    let rec compute rnd i current =
        if rnd > i then current else
        compute (rnd + 1L) i (current * i |> cut)
    add (i + 1L) (current + (compute 1L i 1L) |> cut)

let problem48 = add 1L 0L

let main() = printfn "The answer is %010d." (problem48)

main()
