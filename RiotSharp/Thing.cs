﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RiotSharp
{
    public class Thing
    {
        public static Thing Parse(RiotApi api, JToken json, IRequester requester
            , Region region, Type typeToParse)
        {
            if(typeToParse.Equals(typeof(SummonerBase)))
            {
                return new SummonerBase(api, json, requester, region);
            }
            else if(typeToParse.Equals(typeof(RunePage)))
            {
                return new RunePage(json);
            }
            else if (typeToParse.Equals(typeof(MasteryPage)))
            {
                return new MasteryPage(json);
            }
            else
            {
                return null;
            }
        }
    }
}
