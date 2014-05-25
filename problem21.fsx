(* Project Euler Problem 21
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 10000

let sumOfDivisors x = 
    Seq.sum (seq {
        for i in 1 .. x - 1 do
            if x % i = 0 then
                yield i
    })

let d x = sumOfDivisors x
    
let amicables = seq {
    for i in 1 .. ubound - 1 do
        if d i <> i && (d << d) i = i then
            yield i
}

let problem21 = Seq.sum amicables
    
let main = printfn "The answer is %d." (problem21)

main
