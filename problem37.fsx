(* Project Euler Problem 37
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000000

let primesUpTo n = 
    let rec sieve sub (current: int[]) =
        if current.[sub] > (n |> float |> sqrt |> int)
           || sub > (current.GetUpperBound 0) then current else
        current
        |> Array.filter (fun x -> (x %  current.[sub] <> 0)
                               || (x <= current.[sub]))
        |> sieve (sub + 1) 
    sieve 0 [| 2 .. n |] 

let primesArr = primesUpTo ubound
let primes = primesArr |> Set.ofArray

let isPrime x = Set.contains x primes

let truncable x = 
    let rec leftTruncable x = 
        let str = x.ToString()
        if not <| isPrime x then false else
        if str.Length = 1 then true else
        leftTruncable (int str.[1 .. ])
    let rec rightTruncable x =
        if not <| isPrime x then false else
        if x < 10 then true else
        rightTruncable (x / 10)
    (x >= 10) && (leftTruncable x) && (rightTruncable x)

let problem37 = primesArr
                |> Array.filter truncable
                |> Array.sum
    
let main = printfn "The answer is %d." (problem37)

main
