let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20

//However, if we try to swap immutable values:
let x = 10
let y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y //This will give a compile time error because x and y are immutable