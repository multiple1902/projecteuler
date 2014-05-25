(* Project Euler Problem 22
 * By Weisi Dai <weisi@x-research.com>
 *)

let NAMES_FILENAME = "./problem22.res"
let NAMES_URL = "http://projecteuler.net/project/names.txt"

if not <| System.IO.File.Exists NAMES_FILENAME then
    (new System.Net.WebClient()).DownloadFile(NAMES_URL, NAMES_FILENAME)

let names = 
    let fullLine = System.IO.File.ReadAllText NAMES_FILENAME
    fullLine.[1 .. fullLine.Length - 2]
            .Replace("\",\"", (string << char) 30)
            .Split(char 30)
            |> Array.append [| "" |] // first name to position 1 after sorting
            |> Array.sort

let score number name = 
    let worth name = 
        Seq.map (fun ch -> (int ch) - (int 'A') + 1)
                name
        |> Seq.sum

    number * (worth name)

let problem22 = Seq.mapi score names |> Seq.sum
    
let main = printfn "The answer is %d." (problem22)

main
