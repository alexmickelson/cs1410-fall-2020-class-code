﻿using System.Text.Json;
using System.Text.Json.Serialization;

var deck = CardGenerator.GenerateDeck(2);

var cardsByName = new Dictionary<string, Card>();

cardsByName["myFavorite"] = deck[0];
cardsByName["othercard"] = deck[0];
cardsByName["myFavorite"] = deck[1];

// System.Console.WriteLine(deck.HorizontalString());


// System.Console.WriteLine(JsonSerializer.Serialize(cardsByName));

// foreach(var card in deck)
// {
//   System.Console.WriteLine(card);
// }

// Would you ever want to eat an exception?