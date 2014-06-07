(* Project Euler Problem 32
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 9

let BASE = 10

let minNDigit n = pown (int64 BASE) (n - 1)

let maxNDigit n = (minNDigit (n + 1)) - 1L

let univStr = 
    String.concat "" 
    <| seq { for i in 1 .. ubound do yield i.ToString() }

let isPanDigital a b c = 
    [| a; b; c |]
    |> Array.collect (fun x -> x.ToString().ToCharArray())
    |> Array.sort
    |> Array.map     (fun ch -> ch.ToString())
    |> String.concat ""
    |> univStr.Equals

let products = seq {
    for a in 1L .. (maxNDigit ((ubound - 1) / 3 + 1)) do
        let aLen = (a.ToString()).Length
        let bLbound = max a 
                          (minNDigit ((ubound - 2 * aLen) / 2))
        let bUbound = maxNDigit ((ubound + 1 - 2 * aLen) / 2)
        for b in bLbound .. bUbound do
            let product = a * b
            if isPanDigital a b product then
                yield product
}

let problem32 = products |> Seq.distinct |> Seq.sum
    
let main = printfn "The answer is %d." (problem32)

main
