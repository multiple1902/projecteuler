(* Project Euler Problem 31
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 200

let coins = [0; 1; 2; 5; 10; 20; 50; 100; 200]

let results = Array2D.zeroCreate<int> (ubound + 1)
                                      (coins.Length + 1)

for coinId in 0 .. coins.Length - 1 do
    results.[0, coinId] <- 1

let addCoin coinId = 
    for money in 1 .. ubound do
        results.[money, coinId] <- Seq.sum <| seq {
            for origMoney in money .. -coins.[coinId] .. 0 do
                yield results.[origMoney, coinId - 1]
        }

for coinId in 1 .. coins.Length - 1 do
    addCoin coinId

let problem31 = results.[ubound, coins.Length - 1]
    
let main = printfn "The answer is %d." (problem31)

main
