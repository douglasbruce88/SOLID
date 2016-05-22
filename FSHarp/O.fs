namespace FSharp

module O = 

  let canRollAgain (firstRoll : int) (secondRoll : int) ruleSet : bool = 
      ruleSet firstRoll secondRoll

  let caller = canRollAgain 1 2
