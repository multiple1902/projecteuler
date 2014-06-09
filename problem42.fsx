(* Project Euler Problem 42
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 50

let WORDS_FILENAME = "./problem42.res"
let WORDS_URL = "http://projecteuler.net/project/words.txt"

if not <| System.IO.File.Exists WORDS_FILENAME then
    (new System.Net.WebClient()).DownloadFile(WORDS_URL, WORDS_FILENAME)

let isTriangleLookup = 
    let rec buildTriangleTable n current = 
        if n > ubound then current else
        let delta = Array.ofSeq <| seq {
            for i in 1 .. (n - 1) do
                yield false
            yield true
        }
        buildTriangleTable (n + 1) (Array.append current delta)
    buildTriangleTable 1 [| false |] // placeholder for pos zero

let words = 
    let fullLine = System.IO.File.ReadAllText WORDS_FILENAME
    fullLine.[1 .. fullLine.Length - 2]
            .Replace("\",\"", (string << char) 30)
            .Split(char 30)

let isTriangleWord (word: string) = 
    let charToValue ch = (int ch) - (int 'A') + 1
    let isTriangleNumber n = isTriangleLookup.[n]

    let values = word.ToCharArray() |> Array.map charToValue
    Array.sum values |> isTriangleNumber

let problem42 =words |> Array.filter isTriangleWord |> Array.length
    
let main() = printfn "The answer is %d." (problem42)

main()
