(* Project Euler Problem 51
 * By Weisi Dai <weisi@x-research.com>
 *)

open Weisi.Dai.Algorithms

let threshold = 8

let lbound = 2  // start search from 2 digits

let BASE = 10

let PATTERNBASE = BASE + 1

let numberOfPatterns len = pown PATTERNBASE len

type PatternDigit =
    | KnownDigit of int
    | UnknownDigit

let getPatternDigit = function
    | x when x = BASE -> UnknownDigit
    | x               -> KnownDigit(x)

let fillinPatternDigit fillin = function
    | KnownDigit x -> x
    | UnknownDigit -> fillin

type Pattern = PatternDigit list

let rec isValidPattern = function
    | hd::tl when hd = UnknownDigit -> true
    | hd::tl                        -> isValidPattern tl
    | []                            -> false

let constructIntFromPattern pattern fillin =
    let rec makeInt current = function
        | hd::tl -> makeInt (current * 10 + (fillinPatternDigit fillin hd)) tl
        | []     -> current
    makeInt 0 pattern

let checkPattern pattern =
    let newMinimal current newval =
        match current with
        | None   -> Some newval
        | Some x -> Some x

    let rec _checkPattern fillin count minimal =
        if fillin = BASE && count = threshold then minimal else
        if fillin = BASE then None else
        if BASE - fillin < threshold - count then None else  // avoid useless search
        let number = constructIntFromPattern pattern fillin
        if IsPrime number then
            _checkPattern (fillin + 1) (count + 1) (newMinimal minimal number)
        else
            _checkPattern (fillin + 1) count minimal

    let searchStart =
        match pattern |> List.head with
        | KnownDigit x -> 0
        | UnknownDigit -> 1

    if isValidPattern pattern |> not then None else
    _checkPattern searchStart 0 None

let buildPattern ord =
    let rec _buildPattern current = function
    | 0 -> current
    | x -> _buildPattern ((getPatternDigit (x % PATTERNBASE))::current) (x / PATTERNBASE)
    _buildPattern [] ord

let rec search len =
    let rec _search current =
        if len |> numberOfPatterns = current then None else
        match current |> buildPattern |> checkPattern with
        | Some(x) -> Some(x)
        | _       -> _search (current + 1)

    match _search (numberOfPatterns (len - 1)) with
    | Some x -> x
    | None   -> search (len + 1)

let problem51 = search lbound
    
let main() = printfn "The answer is %d." (problem51)

main()
