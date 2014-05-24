(* Project Euler Problem 20
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 100

let fac n = 
    let rec _fac n current = 
        if n = 1 then current else
        _fac (n - 1)
             (current * (bigint n))
    _fac n (bigint 1)

let problem20 = Seq.fold (fun cur ch -> cur + ((int << string) ch)) 
                         0 
                         ((fac ubound).ToString())
    
let main = printfn "The answer is %d." (problem20)

main
