(* Project Euler Problem 4
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = (1000 * 1000)

let isPalindrome n = 
    let str = n.ToString().ToCharArray()
    str = Array.rev str

let avail = Array.create ubound false
    // arrays are mutable

for i in 100 .. 998 do
    for j in i .. 999 do
        avail.[i * j] <- true

let rec maxPalindrome p = 
    if avail.[p] && (isPalindrome p) then
        p
    else
        maxPalindrome (p - 1)

let problem4 = maxPalindrome (ubound - 1)
    
let main = printfn "The largest palindrome from products is %d." (problem4)

main
