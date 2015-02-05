(* Project Euler Problem 45
 * By Weisi Dai <weisi@x-research.com>
 *)

let lbound = 286L

let T n = n * (n + 1L) / 2L

let P n = n * (3L * n - 1L) / 2L

let H n = n * (2L * n - 1L)

let rec isPentagonalSince n x = 
    match P n with
    | Pn when Pn > x -> (n, false)
    | Pn when Pn = x -> (n,  true)
    | _ -> isPentagonalSince (n + 1L) x

let rec isHexagonalSince n x =
    match H n with
    | Hn when Hn > x -> (n, false)
    | Hn when Hn = x -> (n,  true)
    | _ -> isHexagonalSince (n + 1L) x

let rec find n pIndex hIndex = 
    let Tn = T n
    let pIndexNew, isPentagonal = isPentagonalSince pIndex Tn
    let hIndexNew, isHexagonal  = isHexagonalSince  hIndex Tn
    if isPentagonal && isHexagonal then Tn else
    find (n + 1L) pIndexNew hIndexNew

let problem45 = find lbound 1L 1L
    
let main() = printfn "The answer is %d." (problem45)

main()
