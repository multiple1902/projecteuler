(* Project Euler Problem 15
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 20

let result = Array2D.zeroCreate<int64 option> (ubound + 1)
                                              (ubound + 1)

let rec lattice (x, y) = 
        match result.[x, y] with
        | None   -> let ret = computeLattice (x, y)
                    result.[x, y] <- Some ret
                    ret
        | Some n -> n

and computeLattice = function
    | 0, 0 | 0, _ | _, 0 -> 1L
    | x, y -> lattice (x    , y - 1)
            + lattice (x - 1, y    )

let problem15 = lattice (ubound, ubound)
    
let main = printfn "The answer is %d." (problem15)

main
