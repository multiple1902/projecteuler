(* Project Euler Problem 44
 * By Weisi Dai <weisi@x-research.com>
 *)

let pentagon n = n * (3 * n - 1) / 2

let pentagonals = Seq.initInfinite pentagon |> Seq.cache

let isPentagonal x = 
    Seq.find ((<=) x) pentagonals
    |> (=) x

let rec find n =
    let maxD = (pentagon (n + 1)) - (pentagon n)
    let maxn = (maxD - 1) / 3 + 1   // ceiling
    let D = pentagon n
    let rec check j = 
        let Pj = pentagon j
        let Pk = Pj + D             // guessed
        if (isPentagonal Pk) && (isPentagonal (Pj + Pk)) then Some(D) else
        if j > maxn then None else
        check (j + 1)
    match check 1 with
    | Some(x) -> x
    | None    -> find (n + 1)

let problem44 = find 1

let main() = printfn "The answer is %d." (problem44)

main()
