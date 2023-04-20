

// DEFINISCO IL MIO SHOP

using C__Shop_2;

Shop negozio = new Shop("Di tutto e di più", "Palermo", "Via Roma", 89, "Alimentare");

// DEFINISCO I PRODOTTI CHE IL MIO SHOP TRATTA
itemShop insalata = new itemShop("Insalata");
itemShop pollo = new itemShop("Pollo");

// DEFINISCO LE CATEGOIRE PER I MIEI PRODOTTO
Category verdura = new Category("Verdura", "Insalata verde");
Category carne = new Category("Carne", "Pollo allevato a terra");

// ASSOCIO I PRODOTTI CON LE LORO CATEGORIE
insalata.addCaetogy(verdura);
pollo.addCaetogy(carne);

negozio.addItem(insalata);
negozio.addItem(pollo);


Console.WriteLine(negozio.InfoShop());
