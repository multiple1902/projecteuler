(* Project Euler Problem 27
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000

let range = seq { -ubound .. ubound }

let isPrime x = 
    if x < 2 then false else
    seq { 2 .. (x |> float |> sqrt |> int) }
    |> Seq.exists (fun divisor -> x % divisor = 0) |> not

let leftHand a b n = n * n + a * n + b

let rec primeCount a b n = 
    if leftHand a b n |> isPrime then primeCount a b (n + 1) else (n - 1)

let primes = seq {
    for a in range do
        for b in range do
            yield (a, b), primeCount a b 0
}

let a, b = primes |> Seq.maxBy snd |> fst

let problem27 = a * b
    
let main = printfn "The answer is %d." (problem27)

main
