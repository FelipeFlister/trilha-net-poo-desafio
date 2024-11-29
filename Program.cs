using DesafioPOO.Models;

Iphone testeApple = new Iphone("5531123456789", "A77", "n", 64);
Nokia testeNokia = new Nokia("5531123456789", "A7", "s", 64);
testeApple.InstalarAplicativo("Whatsap");
testeNokia.InstalarAplicativo("PlayStore");
testeApple.ReceberLigacao();
testeNokia.ReceberLigacao();
testeApple.Ligar();
testeNokia.Ligar();
