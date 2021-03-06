﻿#I @"packages/FSharp.Data.Toolbox.Twitter/lib/net40"
#I @"packages/FSharp.Data/lib/net40"
#r "packages/Suave/lib/net40/Suave.dll"
#r "FSharp.Data.Toolbox.Twitter.dll"
#r "FSharp.Data.dll"

#load "async.fs"
#load "config.fsx"

open System
open System.Web
open System.Text
open System.Collections.Generic
open FSharp.Data
open FSharp.Data.Toolbox.Twitter
open AsyncHelpers

open Suave
open Suave.Web
open Suave.Http
open Suave.Filters
open Suave.Operators
open Suave.Sockets
open Suave.Sockets.Control
open Suave.Sockets.AsyncSocket
open Suave.WebSocket
open Suave.Utils

// --------------------------------------------------------------------------------------
// STEP #1: Connecting to Twitter & streaming
// --------------------------------------------------------------------------------------

// DEMO #1: Connect to twitter
// TODO: Get trending phrases
// TODO: Print tweets, GEO codes and Locations

// DEMO #2: Define the type for tweets
// DEMO #3: Create 'liveTweets' observable & start it
// TODO: let cleanup() = search.Stop()

// --------------------------------------------------------------------------------------
// STEP #2: Creating Suave web site
// --------------------------------------------------------------------------------------

// DEMO #4: Browse 'web' directory and the 'index.html' file (Files module)
// DEMO #5: Define JSON types for the results using JSON TP
// TODO: feedTweets skips RTs, limits rate (850ms) 
// DEMO #6: ... and returns JSON type & Observable.start (!)
// DEMO #7: Socket of observable helper
// TODO: Use 'handShake' to expose sockets at '/feedtweets'

// --------------------------------------------------------------------------------------
// STEP #3: Geolocting and adding map
// --------------------------------------------------------------------------------------

// TODO/DEMO #8: MapQuest geo location (locate : string -> Async<option<decimal * decimal>>)
// ("http://www.mapquestapi.com/geocoding/v1/address?location=Prague&key=" + Config.MapQuestKey)
// TODO: let replay = SchedulerAgent<Tweet>()
// DEMO #9: Use tweet location (delay by 5 seconds set InferredLocation)
// DEMO #A: Geo locate tweets (filter IsLetter, limitRate, set InferredLocation & delay & replay)
// DEMO #B: Wrap located tweets in JSON type for web
// TODO: Use 'handShake' to expose sockets at '/maptweets'

















//
