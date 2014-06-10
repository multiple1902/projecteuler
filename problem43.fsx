(* Project Euler Problem 43
 * By Weisi Dai <weisi@x-research.com>
 *)

open Weisi.Dai.Algorithms

let ubound = 9

let primes = PrimesUpTo 17

let rec factorial = function
    | 0 -> 1
    | n -> n * factorial (n - 1)

let fullArrangements n = 
    let rec getNumber sequence (current: int list) (dict: int[]) =
        let remaining = n - current.Length
        if remaining = 0 then 
            current |> List.rev |> List.map (string) 
                    |> String.concat "" |> int64 else
        let digit = sequence / (factorial (remaining - 1))
        getNumber  (sequence % (factorial (remaining - 1)))
                   (dict.[digit] :: current)
                   (Array.append dict.[          .. digit - 1]
                                 dict.[digit + 1 ..          ])
        
    seq {
        for i in factorial (n - 1) .. factorial n - 1 do
            yield getNumber i [] [| 0 .. n - 1 |]
    }

let isSpecial i = 
    let str = i.ToString()
    let testPairs = seq {
        for left = 1 to str.Length - 3 do
            yield (left - 1, str.[left .. left + 2] |> int)
    }
    Seq.forall (fun (primeIndex, x) -> x % primes.[primeIndex] = 0)
               testPairs

let specialNumbers = seq {
    for i in fullArrangements (ubound + 1) do
        if isSpecial i then
            yield i
}
    
let problem43 = Seq.sum specialNumbers
    
let main() = printfn "The answer is %d." (problem43)

main()
