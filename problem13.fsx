(* Project Euler Problem 13
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 10

let numbers = System.IO.File.ReadLines "problem13.data" 
              |> Seq.map (fun str -> str.Substring(0, ubound + 1))
              |> Seq.map int64
              |> Array.ofSeq

(*
 * I wanted to use parallel aggregation so it would be 
 * quicker than summing linearly.
 *
let add x y = x + y

let rec sum = function
              | [| x |]    -> x
              | [| x; y |] -> add x y
              | longArr    -> let len = longArr.Length
                              let mid = len / 2
                              add (longArr.[0 .. mid] |> sum)
                                  (longArr.[mid + 1 .. len - 1] |> sum)
*)

let problem13 = (Seq.sum numbers).ToString().Substring(0, ubound)
    
let main = printfn "The answer is %s." (problem13)

main
