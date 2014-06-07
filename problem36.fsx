(* Project Euler Problem 36
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000000

let isPalindrome (str: string) = 
    let arr = str.ToCharArray()
    arr = Array.rev arr

let dec2bin x = 
    let rec div x current = 
        if x = 0 then current else
        div (x / 2) ((x % 2) :: current)
    div x []
    |> List.map (fun digit -> digit.ToString())
    |> String.concat ""

let testNumber x = 
    let decStr = x.ToString()
    let binStr = dec2bin x
    (isPalindrome decStr) && (isPalindrome binStr)

let palindromes = seq { 1 .. ubound }
                  |> Seq.filter testNumber
                                    
let problem36 = Seq.sum palindromes
    
let main = printfn "The answer is %d." (problem36)

main
