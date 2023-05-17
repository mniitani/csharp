using System;
Syain syain;

// 異なるアルゴリズムに従う3つのコンテキスト。
syain = new Syain(new Hira().standup);
syain.standup();

syain = new Syain(new Kacho().standup);
syain.standup();

syain = new Syain(new Bucho().standup);
syain.standup();