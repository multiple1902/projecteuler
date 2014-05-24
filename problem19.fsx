(* Project Euler Problem 19
 * By Weisi Dai <weisi@x-research.com>
 *)

type DayInWeek = 
     | Monday       = 0
     | Tuesday      = 1
     | Wednesday    = 2
     | Thursday     = 3
     | Friday       = 4
     | Saturday     = 5
     | Sunday       = 6

let ubound = (2000, 12, 31)
let lbound = 1901

let init = (1900, 1, 1)
let initState = DayInWeek.Monday
let daysOfMonthList = [ 0; 31; 0;  31; 30; 31; 30;
                           31; 31; 30; 31; 30; 31 ]

let isLeapYear year = year % 100 <> 0 && year % 4 = 0
                   || year % 100 = 0  && year % 400 = 0

let dayOfMonth year month = 
    if month <> 2 then daysOfMonthList.[month] else
    if isLeapYear year then 29 else 28

let rec calcDate (year, month, day) state current = 

    let bumpDate (year, month, day) = 
        if day < dayOfMonth year month then (year, month, day + 1) else
        if month < 12                  then (year, month + 1,   1) else
                                            (year + 1,     1,   1)

    let bumpState state = enum<DayInWeek> (((int state) + 1) % 7)

    let count (year, month, day) state = 
        if year < lbound then 0 else
        if day = 1 && state = DayInWeek.Sunday then 1 else 0
    
    if (year, month, day) = ubound then
        current + count (year, month, day) state
    else
        calcDate (bumpDate  (year, month, day))
                 (bumpState state)
                 (current + count (year, month, day) state)

let problem19 = calcDate init initState 0
    
let main = printfn "The answer is %d." (problem19)

main
