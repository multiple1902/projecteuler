(* Project Euler Problem 35
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

let allRotations x =
    let rotate (str: string) n =
        let left  = str.[ .. str.Length - n - 1]
        let right = str.[str.Length - n     .. ]
        right + left
    let str = x.ToString()
    [| 0 .. str.Length - 1 |]
    |> Array.map (rotate str)
    |> Array.map int

let isCircle x = 
    allRotations x
    |> Array.fold (fun status element -> 
                       (status && (Set.contains element primes)))
                  true 

let problem35 = primesArr
                |> Array.filter isCircle
                |> Array.length
  
let main = printfn "The answer is %d." (problem35)

main
