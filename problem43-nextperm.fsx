(* Project Euler Problem 43
 * By Weisi Dai <weisi@x-research.com>
 *)

open Weisi.Dai.Algorithms

let ubound = 9

let primes = PrimesUpTo 17

let getPermutations n = 
    Seq.unfold (fun perm -> let next = NextPermutation perm
                            if next.IsNone then None else
                            Some(next.Value |> Array.map (string) 
                                 |> String.concat "" |> int64,
                                 next.Value))
               (Array.append [|1; 0|] [|2 .. n|])

let isSpecial i = 
    let str = i.ToString()
    let testPairs = seq {
        for left = 1 to str.Length - 3 do
            yield (left - 1, str.[left .. left + 2] |> int)
    }
    Seq.forall (fun (primeIndex, x) -> x % primes.[primeIndex] = 0)
               testPairs

let specialNumbers = seq {
    for i in getPermutations ubound do
        if isSpecial i then
            yield i
}
    
let problem43 = Seq.sum specialNumbers
    
let main() = printfn "The answer is %d." (problem43)

main()
