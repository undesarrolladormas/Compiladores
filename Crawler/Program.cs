﻿using Cocona;
using Crawler.Commands;

var app = CoconaApp.Create();

app.AddCommands<Search>();

app.AddCommands<ListDB>();

app.Run();
