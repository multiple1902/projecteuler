(* Project Euler Problem 26
 * By Weisi Dai <weisi@x-research.com>
 *)

let BASE = 10
let ubound = 1000

let lenOfRecurringCycle denominator = 

    let rec solve numerator denominator current =
        let remainder = (numerator * BASE) % denominator
        try 
            1 + List.findIndex ((=) remainder) current
        with
        | :? System.Collections.Generic
             .KeyNotFoundException -> solve remainder 
                                            denominator 
                                            (remainder::current)

    solve 1 denominator [] 

let lens = seq {
    for i in 1 .. ubound - 1 do
        yield i, lenOfRecurringCycle i
}

let problem26 = lens |> Seq.maxBy snd |> fst
    
let main = printfn "The answer is %d." (problem26)

main
