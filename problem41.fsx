(* Project Euler Problem 41
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 9

let isPrimeL x = 
    seq { 2L .. (x |> float |> sqrt |> int64) }
    |> Seq.exists (fun divisor -> x % divisor = 0L) |> not

let rec factorial = function
    | 0 -> 1
    | n -> n * factorial (n - 1)

let fullArrangements n = 
    let rec getNumber sequence (current: int list) (dict: int[]) =
        let remaining = n - current.Length
        if remaining = 0 then 
            current |> List.rev |> List.map (string) 
                    |> String.concat "" |> int64 else
        let digit = sequence / (factorial (remaining - 1))
        getNumber  (sequence % (factorial (remaining - 1)))
                   (dict.[digit] :: current)
                   (Array.append dict.[          .. digit - 1]
                                 dict.[digit + 1 ..          ])
        
    seq {
        for i in factorial n - 1 .. -1 .. 0 do
            yield getNumber i [] [| 1 .. n |]
    }
    
let allPandigits = seq {
    for i in ubound .. -1 .. 1 do
        let pandigits = fullArrangements i
        for pandigit in pandigits do
            yield pandigit
}

let firstPrime = allPandigits
                 |> Seq.filter isPrimeL
                 |> Seq.head

let problem41 = firstPrime
    
let main() = printfn "The answer is %d." (problem41)

main()
