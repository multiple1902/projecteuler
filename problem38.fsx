(* Project Euler Problem 38
 * By Weisi Dai <weisi@x-research.com>
 *)

open Weisi.Dai.Algorithms

let ubound = 9

let makeConcat x n = 
    [| 1 .. n |]
    |> Array.map (fun i -> (i * x).ToString())
    |> String.concat ""

let univStr = 
    String.concat "" 
    <| seq { for i in 1 .. ubound do yield i.ToString() }

let isPanDigital (str: string) = 
    str.ToCharArray()
    |> Array.sort
    |> Array.map (fun ch -> ch.ToString())
    |> String.concat ""
    |> univStr.Equals

let atLeast n x = 
    (makeConcat x n).Length >= 9

let moreThan n x = 
    (makeConcat x n).Length > 9

let pandigits = seq {
    for n in 2 .. 9 do
        let range = FindRange 1 (atLeast n) (moreThan n)
        for x in fst range .. snd range do
            let concat = makeConcat x n
            if isPanDigital concat then yield concat
}

let problem38 = Seq.max pandigits
    
let main = printfn "The answer is %s." (problem38)

main
