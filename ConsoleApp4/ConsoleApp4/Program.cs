using System.Diagnostics;

Syain syain;



// 異なるアルゴリズムに従う3つのコンテキスト。
syain = new Syain(new Hira());
syain.standup();

syain.switchSyain(new Kacho());
syain.standup();

syain.switchSyain(new Bucho());
syain.standup();