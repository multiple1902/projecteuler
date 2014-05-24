(* Project Euler Problem 16
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000

let problem16 = Seq.fold (fun cur ch -> cur + ((int << string) ch)) 
                         0 
                         ((Seq.fold (fun cur _ -> cur * bigint(2)) 
                                    (bigint(1)) 
                                    [1 .. ubound]).ToString());;
    
let main = printfn "The answer is %d." (problem16)

main
