(* Project Euler Problem 23
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 28123

let isAbundant x = 
    let sumOfDivisors x = 
        seq {
            for i in 1 .. x - 1 do
                if x % i = 0 then
                    yield i
        } |> Seq.sum
    sumOfDivisors x > x

let abundants = Array.filter isAbundant 
                             [| 1 .. ubound |]

let abundantSums = 
    abundants 
    |> Array.collect (fun x -> abundants |> Array.map (fun y -> x + y))
    |> Seq.distinct
    |> Seq.sort
    |> Seq.toArray

let problem23 = Seq.filter (fun x -> not <| Array.exists ((=) x) abundantSums)
                           (seq { 1 .. ubound })
                |> Seq.sum
    
let main = printfn "The answer is %d." (problem23)

main
