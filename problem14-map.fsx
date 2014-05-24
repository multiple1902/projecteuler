(* Project Euler Problem 14
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000000

let collatz = function
    | x when x % 2L = 0L  -> x / 2L
    | x                   -> 3L * x + 1L

(*
 * This is the implementation using Maps.
 * It is slower than the brute force approach in ``problem14.fsx''.
 *)

type DistMap = Map<int64,int>

let initMap = Map.empty.Add(1L, 1)

let computeDistance distanceMap x =
    let rec dist x updateQueue (distanceMap: DistMap) = 
        if distanceMap.ContainsKey(x) then
            Seq.fold (fun (map: DistMap) x -> map.Add(x, map.[collatz x] + 1))
                     distanceMap updateQueue
        else
            dist (collatz x) (x::updateQueue) distanceMap

    dist x [] distanceMap

let finalMap = Seq.fold computeDistance initMap (
                seq { for i in 1 .. ubound do yield (int64 i) } )

let rec mostDistance currentKey currentValue = function
        | 1L -> currentKey
        | x  -> if currentValue > finalMap.[x] then
                    mostDistance currentKey currentValue (x - 1L)
                else
                    mostDistance x          finalMap.[x] (x - 1L)

let problem14 = mostDistance 0L 0 (int64 ubound)
    
let main = printfn "The answer is %d." (problem14)

main
