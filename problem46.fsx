(* Project Euler Problem 46
 * By Weisi Dai <weisi@x-research.com>
 *)

open Weisi.Dai.Algorithms

let rec find n =
    if IsPrime n || n % 2 = 0 then find (n + 1) else
    let oddPrimes = PrimesUpTo n |> Array.filter IsOdd
    let canWriteWithPrime x =
        let potentialSquare = (n - x) / 2
        if 2 * potentialSquare + x <> n then false else
        IsSquare potentialSquare
    if oddPrimes 
       |> Seq.ofArray 
       |> Seq.filter canWriteWithPrime
       |> Seq.isEmpty then n else find (n + 1)

let problem46 = find 2

let main() = printfn "The answer is %d." (problem46)

main()
