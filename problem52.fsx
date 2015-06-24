(* Project Euler Problem 52
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 6

let lbound = 2

let digestOf number =
    System.String ((string number).ToCharArray() |> Array.sort)

let rec search x =
    let rec verify number factor digest =
        if factor > ubound then number else
        if digest = digestOf (number * factor) then
            verify number (factor + 1) digest
        else
            search (number + 1)
    let rec computeDigest number factor =
        verify number (factor + 1) ((number * factor) |> digestOf)

    computeDigest x lbound

let problem52 = search 1
    
let main() = printfn "The answer is %d." (problem52)

main()
