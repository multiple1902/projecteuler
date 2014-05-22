(* Project Euler Problem 7
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000001

let isPrime n =
    let rec check (i: int) =
        if i > (float >> sqrt >> int) n then
            true
        else
            if (n % i = 0) then
                false
            else
                check (i + 1)
    check 2

let rec findPrime n m = 
    if isPrime m then
        if n = ubound then
            m
        else
            findPrime (n + 1) (m + 1)
    else
        findPrime n (m + 1)

let problem7 = findPrime 1 2
    
let main = printfn "The answer is %d." (problem7)

main
