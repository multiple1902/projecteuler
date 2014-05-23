(* Project Euler Problem 12
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 500

let triangular = Seq.initInfinite ( 
                     fun index ->
                         (index + 2) * (index + 1) / 2
                 )

let isPrime x = 
    seq { 2 .. (x |> float |> sqrt |> int) }
    |> Seq.exists (fun divisor -> x % divisor = 0) |> not

let numberOfDivisors n = 

    let rec primePower n m from = 
        if n % m = 0 then primePower (n / m) m (from + 1)
        else from

    let rec numberOfDivisorsGreaterThan n m current = 
        if m > n then current else
        let power = if isPrime m then primePower n m 0 else 0
        numberOfDivisorsGreaterThan (n / (pown m power)) (m + 1) (current * (power + 1))

    numberOfDivisorsGreaterThan n 2 1

let highlyDivisible = seq {
    for i in triangular do
        if numberOfDivisors i > ubound then
            yield i
}

let problem12 = Seq.head highlyDivisible
    
let main = printfn "The answer is %d." (problem12)

main
