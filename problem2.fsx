(* Project Euler Problem 2
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 4000000

let rec fib current a b =
    let c = a + b
    if (c < ubound) then
        fib (c :: current) b c
        // re-written to use tail recursion
        // reversed list -- sum is the same
    else
        current

let Fib = fib [1; 1] 1 1

let evenFib = seq {
    for i in Fib do
        if i % 2 = 0 then
            yield i
}

let result = Seq.sum evenFib

let problem2 = result
    
let main = printfn "The sum is %d." (problem2)

main
