namespace FSharp

module DoesOneThing = 

  let toCharList (s:string) =
        [for c in s -> c]

  let numberOfCommas (s : string) = 
    let rec countCommas chars count = 
        match chars with
        | [] -> count
        | h :: t -> 
                   let updatedCount = if h = '/' then count+1 else count 
                   in countCommas t updatedCount
    in countCommas (toCharList s) 0

  let numberOfCommas2 (s : string) = 
     let mutable count = 0
     for c in s do if c = '/' then count <- count + 1
     count


  let log logger (message : string) = 
      logger (sprintf "The string you gave me has %i commas" (numberOfCommas message))
      |> ignore
           