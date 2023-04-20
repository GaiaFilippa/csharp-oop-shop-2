// DEFINISCO IL MIO SHOP

using C__Shop_2;

Shop negozio = new Shop("Esselunga", "Asti", "Corso Casale", 319, "Alimentare");

// DEFINISCO I PRODOTTI CHE IL MIO SHOP TRATTA
itemShop bottigliaAcqua = new itemShop("Acqua 1,5L");
itemShop fruttaAPezzi = new itemShop("Sacchetto di frutta a pezzi");

// DEFINISCO LE CATEGOIRE PER I MIEI PRODOTTO
Category Bevande = new Category("Acqua", "Bottiglia d'acqua");
Category Frutta = new Category("Frutta", "Sacchetto con 5 pezzi di frutta");

// ASSOCIO I PRODOTTI CON LE LORO CATEGORIE
bottigliaAcqua.addCaetogy(Bevande);
fruttaAPezzi.addCaetogy(Frutta);

negozio.addItem(bottigliaAcqua);
negozio.addItem(fruttaAPezzi);


Console.WriteLine(negozio.InfoShop());
