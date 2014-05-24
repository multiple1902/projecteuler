(* Project Euler Problem 17
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000

let basicWords = [| ""; "one";      "two";      "three";    "four"; 
                        "five";     "six";      "seven";    "eight";
                        "nine";     "ten";      "eleven";   "twelve";
                        "thirteen"; "fourteen"; "fifteen";  "sixteen";
                        "seventeen";"eighteen"; "nineteen"; |]

let tensWords  = [| ""; ""; "twenty";   "thirty";   "forty";    "fifty";
                            "sixty";    "seventy";  "eighty";   "ninety"; |]

let HUNDRED = "hundred "
let AND = "and "
let ONE_THOUSAND = "one thousand"

let rec write = function
        | x when x <=  19    -> basicWords.[x]
        | x when x <=  99    -> tensWords.[x / 10] + " "
                              + write (x % 10)
        | x when x <= 999 &&
                 x % 100 = 0 -> basicWords.[x / 100] + " " + HUNDRED
        | x when x <= 999    -> basicWords.[x / 100] + " " + HUNDRED + AND
                              + write (x % 100)
        | _                  -> ONE_THOUSAND

let allLength = seq {
    for i in 1 .. ubound do
        let ans = write i
        yield String.length (ans.Replace(" ",""))
}

let problem17 = Seq.sum allLength
    
let main = printfn "The answer is %d." (problem17)

main
