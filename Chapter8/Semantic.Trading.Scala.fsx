﻿#I @"../packages/FParsec.0.9.2.0/lib/net40"
#r "FParsecCS"
#r "FParsec"

#load "Semantic.Trading.Scala.fs"

open FSharpx.Books.DSLsInAction.Chapter8.Scala.Trading.Semantic
open Parsing

// Listing 8.4 Running the DSL Processor

let example = """(100 IBM shares to buy at max 45, 40 Sun shares 
      to sell at min 24, 25 CISCO shares to buy at max 56) 
      for account "A1234"
      """

let result = parseTradings example
