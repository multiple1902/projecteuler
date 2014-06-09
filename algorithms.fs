(* Algorithms
 * By Weisi Dai <weisi@x-research.com>
 *)

module Weisi.Dai.Algorithms

let AnswerToEverything = 42

// Numeric

let IsPrime x = 
    seq { 2 .. (x |> float |> sqrt |> int) }
    |> Seq.exists (fun divisor -> x % divisor = 0) |> not

let PrimesUpTo n = 
    let rec sieve sub (current: int[]) =
        if current.[sub] > (n |> float |> sqrt |> int)
           || sub > (current.GetUpperBound 0) then current else
        current
        |> Array.filter (fun x -> (x %  current.[sub] <> 0)
                               || (x <= current.[sub]))
        |> sieve (sub + 1) 
    sieve 0 [| 2 .. n |] 

// Search

type CompareResult = 
     | COMPARE_HIT = 0
     | COMPARE_TOO_SMALL = -1
     | COMPARE_TOO_LARGE = 1

let rec BinarySearch low high test = 
                     //  ^^ high is unreachable
    let mid = (high + low) / 2
    match test mid with
    | CompareResult.COMPARE_TOO_LARGE -> 
                BinarySearch low mid  test
    | CompareResult.COMPARE_TOO_SMALL -> 
                BinarySearch mid high test
    | CompareResult.COMPARE_HIT | _   -> mid

let FindGate low test = 

    let safeTest x = 
        if (x < low) then false else
        test x

    let compareEnter x = 
        let prev = safeTest (x - 1)
        let cur  = safeTest x
        if not cur then CompareResult.COMPARE_TOO_SMALL else
        if prev    then CompareResult.COMPARE_TOO_LARGE else
        CompareResult.COMPARE_HIT

    let rec GateSearch offset step = 
        if test <| offset + step - 1 then
            BinarySearch offset (offset + step) compareEnter
        else 
            GateSearch (offset + step) (step * 2)

    GateSearch low 1
        
let FindRange low testEnter testLeave = 
    let lbound = FindGate low          testEnter
    let ubound = FindGate (lbound - 1) testLeave
    (lbound, ubound - 1)

