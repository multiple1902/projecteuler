(* Project Euler Problem 34
 * By Weisi Dai <weisi@x-research.com>
 *)

let BASE = 10

let ubound = pown BASE 7

let lbound = pown BASE 1

let rec computeFib n = 
    if n = 0 then 1 else
    n * (computeFib (n - 1))

let fib = Array.init 10 computeFib

let sumOfFib n = 
    n.ToString().ToCharArray()
    |> Array.map (fun ch -> (int ch) - (int '0'))
    |> Array.map (fun digit -> fib.[digit])
    |> Array.sum

let isCurious n = sumOfFib n = n

let curious = seq { lbound .. ubound } 
              |> Seq.filter isCurious

let problem34 = Seq.sum curious
    
let main = printfn "The answer is %d." (problem34)

main
