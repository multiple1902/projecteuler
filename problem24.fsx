(* Project Euler Problem 24
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000000
let digits = [| '0' ..  '9' |]

let fac n = Seq.fold (fun s x -> s * x) 1 (seq { 1 .. n })

let digitsIndex = Seq.toList <| seq {
    for i in 1 .. digits.Length do
        let pos = digits.Length - i + 1
        yield ((ubound - 1) % fac pos) / fac (pos - 1)
}

let rec build index digits current = 
    match index with
    | []     -> current
    | hd::tl -> build tl 
                      (Array.append digits.[0 .. hd - 1]
                                    digits.[hd + 1 .. digits.Length - 1])
                      (Array.append current [| digits.[hd] |])
        
let problem24 = build digitsIndex digits [| |]

let main = printfn "The answer is %s." (new System.String (problem24))

main
