(* Algorithms
 * By Weisi Dai <weisi@x-research.com>
 *)

module Weisi.Dai.Algorithms

let AnswerToEverything = 42

// Numeric

let IsOdd x = x % 2 = 1

let Square x = x * x

let IsSquare x =
    (x |> float |> sqrt |> int)
    |> Square
    |> (=) x

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
    if (high <= low + 1) && (test low <> CompareResult.COMPARE_HIT) then
        None else
    let mid = (high + low) / 2
    match test mid with
    | CompareResult.COMPARE_TOO_LARGE -> 
                BinarySearch low mid  test
    | CompareResult.COMPARE_TOO_SMALL -> 
                BinarySearch mid high test
    | CompareResult.COMPARE_HIT | _   -> Some mid

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
            (BinarySearch offset (offset + step) compareEnter).Value
        else 
            GateSearch (offset + step) (step * 2)

    GateSearch low 1
        
let FindRange low testEnter testLeave = 
    let lbound = FindGate low          testEnter
    let ubound = FindGate (lbound - 1) testLeave
    (lbound, ubound - 1)

let Compare expected actual =
    if actual < expected then CompareResult.COMPARE_TOO_SMALL else
    if actual > expected then CompareResult.COMPARE_TOO_LARGE else
    CompareResult.COMPARE_HIT


// Combinatorics

let NextPermutation (current: 'a []) =
    let rec findRev pos = 
        if pos = 0 then None else
        if current.[pos - 1] < current.[pos] then Some pos else
        findRev (pos - 1)
    let last = current.GetUpperBound 0
    match findRev last with
    | None     -> None
    | Some pos -> let lowest = current.[pos .. last]
                               |> Array.filter ((<) current.[pos - 1])
                               |> Seq.ofArray |> Seq.min
                  current.[pos - 1 .. last]
                      |> Array.filter ((<>) lowest)
                      |> Array.sort
                  |> Array.append [| lowest |]
                  |> Array.append current.[0 .. pos - 2]
                  |> Some
