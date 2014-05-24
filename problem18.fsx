(* Project Euler Problem 18
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 42

let numbers = System.IO.File.ReadLines "problem18.data" 
              |> Seq.map (fun str -> str.Split(' '))
              |> Seq.map (Seq.map (int))
              |> Seq.map List.ofSeq
              |> List.ofSeq

let update (currentTotal: list<int>) (newLine: list<int>) = 
    List.init newLine.Length 
              (fun n -> if n = 0 then newLine.[0] 
                                    + currentTotal.[0] else
                        if n = newLine.Length - 1 then newLine.[n]
                                                     + currentTotal.[n - 1] else
                        newLine.[n] + max currentTotal.[n - 1]
                                          currentTotal.[n])
    
let total = List.fold update 
                      [ for i in 1 .. numbers.Length -> 0 ]
                      numbers

let problem18 = Seq.max total
    
let main = printfn "The answer is %d." (problem18)

main

