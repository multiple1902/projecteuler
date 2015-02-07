(* Project Euler Problem 49
 * By Weisi Dai <weisi@x-research.com>
 *)

open Weisi.Dai.Algorithms

let ubound = 10000

let lbound = 1000

let blacklisted = 1487

let primes = 
    PrimesUpTo ubound
    |> Array.filter ((<=) lbound)

let normalize x =
    let rec split current x =
        if x = 0 then current else
        split ((x % 10)::current) (x / 10)
    let rec assemble current lst =
        match lst with
        | []     -> current
        | hd::tl -> assemble (current * 10 + hd) tl
    x |> split [] |> List.sort |> assemble 0

let verify first second third =
    if IsPrime third |> not || third > ubound then None else
    let n1 = normalize first
    let n2 = normalize second
    let n3 = normalize third
    if n1 = normalize blacklisted then None else
    if n1 <> n2 || n1 <> n3 then None else
    [| first; second; third |]
    |> Array.map string
    |> String.concat ""
    |> Some

let rec find1 current first =
    let primesOverFirst = primes |> Array.filter ((<) first)
    let rec find2 current second =
        let third = second * 2 - first
        match verify first second third with
        | None    -> current
        | Some(s) -> s::current
    Array.fold find2 current primesOverFirst

let answers = Array.fold find1 [] primes

let problem49 = answers.[0]
    
let main() = printfn "The answer is %s." (problem49)

main()
