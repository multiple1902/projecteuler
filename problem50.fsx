(* Project Euler Problem 50
 * By Weisi Dai <weisi@x-research.com>
 *)

open Weisi.Dai.Algorithms

let ubound = 1000000 // one million

let primes = PrimesUpTo ubound

let isPrime x = 
    None <> BinarySearch 0 
                         (1 + primes.GetUpperBound 0) 
                         (fun sub -> Compare x primes.[sub])

let findFrom (sum, count) left =
    let primesIncludingLeft = Array.filter ((<=) left) primes
    let rec findTo (sum, count) index current =
        if index > primesIncludingLeft.GetUpperBound 0 then (sum, count) else
        let newSum = current + primesIncludingLeft.[index]
        if newSum > ubound then (sum, count) else
        let newCount = index + 1
        if newCount > count && isPrime newSum then 
            findTo (newSum, newCount) (index + 1) (newSum)
        else
            findTo (sum, count) (index + 1) (newSum)
    findTo (sum, count) 0 0

let problem50 = Array.fold findFrom (0, 0) primes |> fst
    
let main() = printfn "The answer is %d." (problem50)

main()
